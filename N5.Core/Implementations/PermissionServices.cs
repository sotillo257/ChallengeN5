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
    public class PermissionServices : IPermissionServices
    {
        protected readonly IUnitOfWork unitOfWork;
        protected readonly IPermission repository;
        public PermissionServices(IUnitOfWork unitOfWork) {
            this.unitOfWork = unitOfWork;
            repository = GetRepositoryFrom(unitOfWork);
        }
       
        public async Task<PermissionDto> AddPermissionAsync(PermissionAddDto permissionDto)
        {
            try
            {
                var entity = await repository.AddPermissionAsync(new Permission()
                {
                    ApellidoEmpleado = permissionDto.ApellidoEmpleado,
                    NombreEmpleado = permissionDto.NombreEmpleado,
                    PermissionTypeID = permissionDto.PermissionTypeID,
                    FechaPermiso = DateTime.Now
                });

                var Permission = new PermissionDto()
                {
                    ApellidoEmpleado = entity.ApellidoEmpleado,
                    NombreEmpleado = entity.NombreEmpleado,
                    PermissionID = entity.Id,
                    FechaPermiso = entity.FechaPermiso,
                    PermissionTypeID = entity.PermissionTypeID
                };

                await unitOfWork.CommitAsync();
                return Permission;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
                

        public async Task<bool> UpdatePermission(PermissionUpdateDto permissionDto)
        {
            try
            {
                var permissionUpdate = await repository.GetPermissionsAsync(permissionDto.PermissionID);

                if (permissionUpdate != null)
                {
                    permissionUpdate.ApellidoEmpleado = permissionDto.ApellidoEmpleado;
                    permissionUpdate.NombreEmpleado = permissionDto.NombreEmpleado;
                    permissionUpdate.PermissionTypeID = permissionDto.PermissionTypeID;
                    permissionUpdate.FechaPermiso = DateTime.Now;

                    repository.UpdatePermission(permissionUpdate);
                    await unitOfWork.CommitAsync();
                    return true;
                }

            }
            catch (Exception ex)
            { 
            }
            
            
            return false;
        }

        public async Task<PermissionResultDto> GetAllPermissionsAsync(PermissionResultDto permissionResult)
        {
           var result = await repository.GetAllPermissionsAsync<PermissionDto>(permissionResult.Page, permissionResult.ItemsPerPage, String.Empty, String.Empty,
               s => new PermissionDto()
               {
                   ApellidoEmpleado = s.ApellidoEmpleado,
                   NombreEmpleado = s.NombreEmpleado,
                   PermissionID = s.Id,
                   FechaPermiso = s.FechaPermiso,
                   PermissionTypeID = s.PermissionTypeID,
                   PermissionType = new PermissionTypeDto()
                   {
                       Id = s.PermissionType.Id,
                       Description = s.PermissionType.Description
                   }

               });
            permissionResult.Permissions = result;
            return permissionResult;
        }

        protected IPermission GetRepositoryFrom(IUnitOfWork unitOfWork)
        {
            return unitOfWork.permission;
        }
    }
}
