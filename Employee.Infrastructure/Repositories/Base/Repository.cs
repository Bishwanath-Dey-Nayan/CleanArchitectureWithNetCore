using Employee.Core.Repositories.Base;
using Employee.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EmployeeContext _employeeContext;

        public Repository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _employeeContext.Set<T>().AddAsync(entity);
            await _employeeContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _employeeContext.Set<T>().Remove(entity);
            await _employeeContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _employeeContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _employeeContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
