using HotellbookingEF.Data.Context;
using HotellbookingEF.Exceptions;
using HotellbookingEF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;

namespace HotellbookingEF.Data
{
    public class DataRepository : IDataRepository
    {
        private SqlServerContext _db { get; set; }
        public DataRepository()
        {
            _db = new SqlServerContext();
        }
        public int SaveChanges()
        {
            try
            {
                return _db.SaveChanges();
            }
            catch
            {
                throw new DatabaseException("Could not save changes to the database");
            }
        }
        public IQueryable<TEntity> Get<TEntity>() where TEntity : class
        {
            try
            {
                return _db.Set<TEntity>();
            }
            catch
            {
                throw new EntityException("Could not find the entity");
            }
        }
        public IQueryable<TEntity> GetWithInclude<TEntity>(string[] tables) where TEntity : class
        {
            try
            {
                foreach (var table in tables)
                    _db.Set<TEntity>().Include(table);

                return _db.Set<TEntity>();
            }
            catch
            {
                throw new EntityException("Could not find the entity");
            }
        }
        public TEntity Add<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                var addedEntity = _db.Set<TEntity>().Add(entity);

                if (_db.SaveChanges() < 1)
                    throw new EntityException<TEntity>("Could not add", entity);

                return addedEntity;
            }
            catch
            {
                throw;
            }
        }

        public TEntity Delete<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                var removedEntity = _db.Set<TEntity>().Remove(entity);

                if (_db.SaveChanges() < 1)
                    throw new EntityException<TEntity>("Could not delete", entity);


                return removedEntity;
            }
            catch
            {
                throw new EntityException<TEntity>("Could not delete the entity", entity);
            }
        }
        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                _db.Entry(entity).State = EntityState.Modified;

                if (_db.SaveChanges() < 1)
                    throw new EntityException<TEntity>("Could not update", entity);               
            }
            catch
            {
                throw new EntityException<TEntity>("Could not update the entity", entity);
            }
        }      
        public IEnumerable<Booking> Search(DateTime start, DateTime end, int numberOfPers)
        {
            try
            {
                var bookings = Get<Booking>().AsEnumerable().Where(b => 
                (b.BookingDateStart.Date <= end && b.BookingDateEnd.Date >= start) 
                && b.NumberOfPerson.Equals(numberOfPers));
                return bookings;
            }
            catch (Exception)
            {

                throw;
            }         
        }
    }
}

