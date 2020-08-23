﻿using Dapper;
using Ecom.Data.Interface;
using Ecom.Models.Web.Request;
using Ecom.Utility;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Data.Implementation.Repository
{
    public class Repository : IRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public Repository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        /// <summary>
        /// Execute the Given SP with the Parameter and return a List.
        /// </summary>
        /// <typeparam name="RequestModel"></typeparam>
        /// <param name="spName"></param>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        public List<T> ExecResult<T>(string spName, DynamicParameters parameters)
        {
            using (var connection = _dbConnectionFactory.GetConnection)
            {
                try
                {
                    return SqlMapper.Query<T>(connection, spName, parameters, commandType: CommandType.StoredProcedure).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Execute the Given SP with the Parameter and return a List.
        /// </summary>
        /// <typeparam name="RequestModel"></typeparam>
        /// <param name="spName"></param>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        public async Task<List<T>> ExecResultAsync<T>(string spName, DynamicParameters parameters)
        {
            using (var connection = _dbConnectionFactory.GetConnection)
            {
                try
                {
                    return (await SqlMapper.QueryAsync<T>(connection, spName, parameters, commandType: CommandType.StoredProcedure)).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DynamicParameters GetBaseParameters<T>(T request)
        {
            DbParamModel dbParamModel = new DbParamModel()
            {
                JsonString = StringHelper.GetJsonString(request)
            };

            return GetParameters(dbParamModel);
        }

        #region Priavte method

        /// <summary>
        /// Gets the DynamicParameter in return for the Model Passed.
        /// </summary>
        /// <typeparam name="RequestModel">Generic Type, in Almost Cased will be a Interface Ref.</typeparam>
        /// <param name="requestModel">SP Request Model to be Converted</param>
        /// <returns></returns>
        private DynamicParameters GetParameters<T>(T parametersModel)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            Type type = parametersModel.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                dynamicParameters.Add(properties[i].Name, properties[i].GetValue(parametersModel));
            }
            return dynamicParameters;
        }

        #endregion
    }
}