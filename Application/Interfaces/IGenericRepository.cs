﻿using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<T> AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task UpdateAsync(T entity);

        Task SaveAsync();

        Task<T?> FindAsync(Expression<Func<T, bool>> includeProperties);
    }
}