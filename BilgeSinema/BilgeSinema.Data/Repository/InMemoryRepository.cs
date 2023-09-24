using BilgeSinema.Data.Context;
using BilgeSinema.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BilgeSinema.Data.Repository
{
    public class InMemoryRepository<T> : IRepository<T> where T : MovieEntity
    {
        private readonly MovieContext _db;
        private readonly DbSet<T> _dbSet;
        public InMemoryRepository(MovieContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _db.SaveChanges(); 
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            Delete(entity);
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            _dbSet.Update(entity);
            _db.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            return predicate is not null ? _dbSet.Where(predicate) : _dbSet;
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _db.SaveChanges();
        }
    }
}
