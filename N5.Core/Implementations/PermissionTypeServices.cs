using AutoMapper;
using N5.Core.Contracts;
using N5.Core.Models;
using N5.Core.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.Implementations
{
    public class PermissionTypeServices : IPermissionTypeServices
    {
        protected readonly IUnitOfWork unitOfWork;
        protected readonly IPermissionType repository;
        public PermissionTypeServices(IUnitOfWork unitOfWork) {
            this.unitOfWork = unitOfWork;
            repository = GetRepositoryFrom(unitOfWork);
        }       

        public async Task<List<PermissionTypeDto>> GetAllPermissionTypesAsync()
        {
           var result = await repository.GetAllPermissionTypesAsync();

            var PermissionTypes = result.Select(s=> new PermissionTypeDto() { 
            Description = s.Description,
            Id = s.Id
            }).ToList();

            return PermissionTypes;
        }
        protected IPermissionType GetRepositoryFrom(IUnitOfWork unitOfWork)
        {
            return unitOfWork.permissionType;
        }
    }
}
