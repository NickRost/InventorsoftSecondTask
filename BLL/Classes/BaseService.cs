using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BLL.Interfaces;
using Domain;

namespace BLL.Classes
{
    public class BaseService<T>:IBaseService<T> where T: class
    {
        protected readonly EmployerContext context;
        public BaseService(EmployerContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? context.Set<T>() : context.Set<T>().Where(filter);
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? context.Set<T>().FirstOrDefault() : context.Set<T>().FirstOrDefault(filter);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
