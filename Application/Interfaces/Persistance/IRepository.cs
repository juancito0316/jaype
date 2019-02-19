using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Interfaces.Persistance
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Remove(T entity);

    }
}
