using Microsoft.EntityFrameworkCore;
using N5.Core.Contracts;
using N5.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace N5.Repository.Repositories
{
    public class PermissionRepository : IPermission
    {
        protected readonly DbContext _context;
        protected readonly DbSet<Permission> _dbSet;
        public PermissionRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Permission>();
        }


        public async Task<Permission> AddPermissionAsync(Permission permission)
        {
            return (await _dbSet.AddAsync(permission)).Entity;
        }

        public async Task<List<T>> GetAllPermissionsAsync<T>(int page, int pageSize, string sortExpression, string filterExpression, Expression<Func<Permission, T>> projection)
        {
            IQueryable<Permission> query = _dbSet.AsQueryable();

            if (!string.IsNullOrEmpty(filterExpression))
                query = query.Where(filterExpression);


            if (!string.IsNullOrEmpty(sortExpression))
                query = query.OrderBy(sortExpression);


            var skip = page * pageSize;
            query = query.Skip(skip).Take(pageSize);
            return await query.Select(projection).ToListAsync(); 
        }
        public async Task<Permission> GetPermissionsAsync(int Id)
        {
            var result = await _dbSet.FindAsync(Id);            
            return result;
        }


        public void UpdatePermission(Permission permission)
        {
            _dbSet.Update(permission);
        }
    }
}
