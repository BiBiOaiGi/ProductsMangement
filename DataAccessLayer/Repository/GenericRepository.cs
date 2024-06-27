using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    internal class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public readonly ApplicationDbContext _dbcontext;
        public GenericRepository(ApplicationDbContext dbContext) {
            _dbcontext = dbContext;
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                TEntity entity = await _dbcontext.Set<TEntity>().FirstOrDefaultAsync(filter);
                return entity;
            }
            catch
            {
                throw;
            }
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            try
            {

                _dbcontext.Set<TEntity>().Add(entity);
                await _dbcontext.SaveChangesAsync();
                return entity;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Edit(TEntity entity)
        {
            try
            {
                _dbcontext.Update(entity);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Delete(TEntity entity)
        {
            try
            {
                _dbcontext.Remove(entity);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public async Task<IQueryable<TEntity>> Query(Expression<Func<TEntity, bool>> filter)
        {
            IQueryable<TEntity> queryentity = filter == null ? _dbcontext.Set<TEntity>() : _dbcontext.Set<TEntity>().Where(filter);
            return queryentity;
        }

    }
}
