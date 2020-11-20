using HotellbookingEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotellbookingEF.Data
{
    public interface IDataRepository
    {
        int SaveChanges();
        IQueryable<TEntity> Get<TEntity>() where TEntity : class;
        IQueryable<TEntity> GetWithInclude<TEntity>(string[] tables) where TEntity : class;
        TEntity Add<TEntity>(TEntity entity) where TEntity : class;
        void Update<TEntity>(TEntity entity) where TEntity : class;
        TEntity Delete<TEntity>(TEntity entity) where TEntity : class;
        IEnumerable<Booking> Search(DateTime start, DateTime end, int numberOfPers);

    }
}
