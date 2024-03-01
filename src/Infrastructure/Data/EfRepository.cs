﻿using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly WatchWorldContext _db;

        public EfRepository(WatchWorldContext db)
        {
            _db = db;
        }

        public async Task<T> AddAsync(T entity)
        {
            _db.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<int> CountAsync(ISpecification<T> specification)
        {
            return await _db.Set<T>().WithSpecification(specification).CountAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<T> FirstAsync(ISpecification<T> specification)
        {
            return await _db.Set<T>().WithSpecification(specification).FirstAsync();
        }

        public async Task<T?> FirstorDefaultAsync(ISpecification<T> specification)
        {
            return await _db.Set<T>().WithSpecification(specification).FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetAllAsync(ISpecification<T> specification)
        {
            return await _db.Set<T>().ToListAsync(specification);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _db.FindAsync<T>(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
