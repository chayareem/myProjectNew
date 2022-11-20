using AutoMapper;
//using MyProject.Common.Commons;
using MyProject.Common.DTO;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public RoleService(IRoleRepository role,IMapper mapper)
        {
            _roleRepository = role;
            _mapper = mapper;
        }
        public RoleDTO Add(int id, string name, string description)
        {
            Role role= _roleRepository.Add(id, name, description);
            return _mapper.Map<RoleDTO>(role);
        }
        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }

        public List<RoleDTO> GetAll()
        {
            return _mapper.Map<List<RoleDTO>>(_roleRepository.GetAll());
        }

        public RoleDTO GetById(int id)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.GetById(id));
        }

        public RoleDTO Update(RoleDTO roleDto, int id)
        {
            Role role = _mapper.Map<Role>(roleDto);
            return _mapper.Map<RoleDTO>(_roleRepository.Update(role, id));
        }
    }
}
