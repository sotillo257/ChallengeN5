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
    public class PermissionTypeRepository : IPermissionType
    {
        protected readonly DbContext _context;
        protected readonly DbSet<PermissionType> _dbSet;
        public PermissionTypeRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<PermissionType>();
        }

        public async Task<PermissionType> AddPermissionTypeAsync(PermissionType PermissionType)
        {
            return (await _dbSet.AddAsync(PermissionType)).Entity;
        }
        public async Task<List<PermissionType>> GetAllPermissionTypesAsync()
        {
            return await _dbSet.ToListAsync(); 
        }
        public async Task<PermissionType> GetPermissionTypesAsync(int Id)
        {
            var result = await _dbSet.FindAsync(Id);            
            return result;
        }
        public void UpdatePermissionType(PermissionType PermissionType)
        {
            _dbSet.Update(PermissionType);
        }
    }
}
