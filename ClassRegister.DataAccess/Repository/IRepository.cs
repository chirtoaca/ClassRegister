﻿using System.Linq;

namespace ClassRegister.DataAccess.Repository
{
    public interface IRepository
    {
        IQueryable<T> GetAll<T>() where T : class;
        T Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        //void Delete<T>(Expression<Func<T, bool>> where) where T : class;
        //IEnumerable<T> GetMany<T>(Expression<Func<T, bool>> where) where T : class;
        //T Get<T>(Expression<Func<T, bool>> where) where T : class;

    }
}
