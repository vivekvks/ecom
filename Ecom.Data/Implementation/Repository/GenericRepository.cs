using Dapper;
using Ecom.Data.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Data.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly string _tableName;
        public GenericRepository(string tableName)
        {
            _tableName = tableName;
        }
        /// <summary>
        /// Generate new connection based on connection string
        /// </summary>
        /// <returns></returns>
        private SqlConnection SqlConnection()
        {
            return new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;Initial Catalog = ECOM; Integrated Security = True;");
        }
        /// <summary>
        /// Open new connection and return it for use
        /// </summary>
        /// <returns></returns>
        private IDbConnection CreateConnection()
        {
            var conn = SqlConnection();
            conn.Open();
            return conn;
        }
        private IEnumerable<PropertyInfo> GetProperties => typeof(T).GetProperties();

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var connection = CreateConnection())
            {
                return await connection.QueryAsync<T>($"SELECT * FROM {_tableName}");
            }
        }
        public async Task DeleteRowAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                await connection.ExecuteAsync($"DELETE FROM {_tableName} WHERE Id=@Id", new { Id = id });
            }
        }
        public async Task<T> GetAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var result = await connection.QuerySingleOrDefaultAsync<T>($"SELECT * FROM {_tableName} WHERE Id=@Id", new { Id = id });
                if (result == null)
                    throw new KeyNotFoundException($"{_tableName} with id [{id}] could not be found.");
                return result;
            }
        }
        public async Task<int> SaveRangeAsync(IEnumerable<T> list)
        {
            var inserted = 0;
            var query = GenerateInsertQuery();
            using (var connection = CreateConnection())
            {
                inserted += await connection.ExecuteAsync(query, list);
            }
            return inserted;
        }

        private static List<string> GenerateListOfProperties(IEnumerable<PropertyInfo> listOfProperties)
        {
            return (from prop in listOfProperties
                    let attributes = prop.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    where attributes.Length <= 0 || (attributes[0] as DescriptionAttribute)?.Description != "ignore"
                    select prop.Name).ToList();
        }

        public async Task<int> InsertAsync(T t)
        {
            var insertQuery = GenerateInsertQuery();

            insertQuery = $"{insertQuery}; SELECT CAST(SCOPE_IDENTITY() as int)";
            using (var connection = CreateConnection())
            {
                return await connection.ExecuteScalarAsync<int>(insertQuery, t);
            }
        }

        private string GenerateInsertQuery()
        {
            var insertQuery = new StringBuilder($"INSERT INTO {_tableName} ");

            insertQuery.Append("(");
            var properties = GenerateListOfProperties(GetProperties);
            properties = properties.Where(x => x != "Id").ToList();
            properties.ForEach(prop => { insertQuery.Append($"[{prop}],"); });
            insertQuery
                .Remove(insertQuery.Length - 1, 1)
                .Append(") VALUES (");
            properties.ForEach(prop => { insertQuery.Append($"@{prop},"); });
            insertQuery
                .Remove(insertQuery.Length - 1, 1)
                .Append(")");
            return insertQuery.ToString();
        }   

        public async Task UpdateAsync(T t)
        {
            var updateQuery = GenerateUpdateQuery();
            using (var connection = CreateConnection())
            {
                await connection.ExecuteAsync(updateQuery, t);
            }
        }
        private string GenerateUpdateQuery()
        {
            var updateQuery = new StringBuilder($"UPDATE {_tableName} SET ");
            var properties = GenerateListOfProperties(GetProperties);
            properties = properties.Where(x => x != "Id").ToList();
            properties.ForEach(property =>
            {
                if (!property.Equals("Id"))
                {
                    updateQuery.Append($"{property}=@{property},");
                }
            });
            updateQuery.Remove(updateQuery.Length - 1, 1); //remove last comma
            updateQuery.Append(" WHERE Id=@Id");
            return updateQuery.ToString();
        }


        /// <summary>
        /// Execute the Given SP with the Parameter and return a List.
        /// </summary>
        /// <typeparam name="RequestModel"></typeparam>
        /// <param name="spName"></param>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        public List<T> ExecResult<RequestModel>(string spName, RequestModel requestModel)
        {
            using (var connection = CreateConnection())
            {
                List<T> list = new List<T>();
                DynamicParameters spParameters = GetParameters(requestModel);

                connection.Open();
                try
                {
                    var registro = SqlMapper.Query<T>(connection, spName, spParameters, commandType: CommandType.StoredProcedure);
                    if (registro.Count() > 1)
                        list = registro.ToList();
                    else
                        list.Add(registro.First());
                }
                catch (Exception e)
                {
                    //ILog log_ = log4net.LogManager.GetLogger("log4Net");
                    //log_.Error(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType + "-" + System.Reflection.MethodBase.GetCurrentMethod().ToString() + "-" + e.Message + "-SOURCE: " + e.Source);

                }
                finally
                {
                    connection.Close();
                }
                return list;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="funcName"></param>
        /// <param name="requestModel"></param>
        /// <typeparam name="RequestModel"></typeparam>

        public void Exec<RequestModel>(string funcName, RequestModel requestModel)
        {
            using (var connection = CreateConnection())
            {
                DynamicParameters parameters = GetParameters(requestModel);
                connection.Open();
                try
                {
                    var registro = connection.Execute(funcName, parameters, commandType: CommandType.StoredProcedure);
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        #region Private

        /// <summary>
        /// Gets the DynamicParameter in return for the Model Passed.
        /// </summary>
        /// <typeparam name="RequestModel">Generic Type, in Almost Cased will be a Interface Ref.</typeparam>
        /// <param name="requestModel">SP Request Model to be Converted</param>
        /// <returns></returns>
        private DynamicParameters GetParameters<RequestModel>(RequestModel requestModel)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            Type type = requestModel.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                dynamicParameters.Add(properties[i].Name, properties[i].GetValue(requestModel));
            }
            return dynamicParameters;
        }

        #endregion

    }
}
