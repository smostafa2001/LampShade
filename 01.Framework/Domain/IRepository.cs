using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _01.Framework.Domain
{
    public interface IRepository<TKey, T> where T : class
    {
        T Get(TKey id);
        List<T> GetAll();
        void Create(T entity);
        bool DoesExist(Expression<Func<T, bool>> expression);
        void Save();
    }
}
