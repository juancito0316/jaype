using Application.Interfaces.Persistance;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance.Shared
{
    public class Repository<T> : IRepository<T> where T: class, IEntity {

        readonly IDatabaseContext _database;
        
        public Repository(IDatabaseContext database) {
            _database = database;
        }

        public System.Linq.IQueryable<T> GetAll() {
            return _database.Set<T>();
        }

        public T Get(int id) {
            return _database.Set<T>().Single(i => i.Id == id);
        }

        public void Add(T entity) {
            _database.Set<T>().Add(entity);
        }

        public void Remove(T entity) {
            _database.Set<T>().Remove(entity);
        }
    }
}
