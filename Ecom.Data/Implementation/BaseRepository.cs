using Ecom.Data.Interface;
using Ecom.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecom.Data.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ECOMContext _context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository(ECOMContext context)
        {
            this._context = context;
            entities = context.Set<T>();
        }

        public void Delete(Guid id)
        {
          
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            entities.Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.SaveChanges();
        }
      
    }
}
