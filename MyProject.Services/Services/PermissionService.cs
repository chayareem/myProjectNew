using AutoMapper;
using MyProject.Common.DTO;
//using MyProject.Common.Commons;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;
        public PermissionService(IPermissionRepository permission,IMapper mapper)
        {
            _permissionRepository = permission;
            _mapper = mapper;
        }
        public PermissionDTO Add(int id, string name, string description)
        {
            Permission permission = _permissionRepository.Add(id, name, description);
            return _mapper.Map<PermissionDTO>(permission);
        }

        public void Delete(int id)
        {
            _permissionRepository.Delete(id);
        }
        public List<PermissionDTO> GetAll()
        {
            List<Permission> list = _permissionRepository.GetAll();
            return _mapper.Map<List<PermissionDTO>>(list);
        }

        public PermissionDTO GetById(int id)
        {
            Permission permission=_permissionRepository.GetById(id);
            return _mapper.Map<PermissionDTO>(permission);
        }

        public PermissionDTO Update(PermissionDTO permissionDto, int id)
        {
            Permission per = _mapper.Map<Permission>(permissionDto);
            Permission permission=_permissionRepository.Update(per, id);
            return _mapper.Map<PermissionDTO>(permission);
        }
    }
}
