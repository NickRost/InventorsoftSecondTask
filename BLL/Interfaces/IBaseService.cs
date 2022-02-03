using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Interfaces
{
    public interface IBaseService<T> where T:class
    {
        void Add(T entity);

        void Remove(T entity);

        IEnumerable<T> GetMany(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter = null);

        int SaveChanges();
    }
}
