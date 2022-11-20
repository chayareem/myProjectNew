using AutoMapper;
using MyProject.Common.DTO;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ePolicyDTO = MyProject.Common.DTO.ePolicy;
using ePolicy = MyProject.Repositories.Entities.ePolicy;

namespace MyProject.Services.Services
{
    public class ClaimService : IClaimService
    {
        private readonly IClaimRepository _claimRepository;
        private readonly IMapper _mapper;
        public ClaimService(IClaimRepository claim,IMapper mapper)
        {
            _claimRepository = claim;
            _mapper = mapper;
        }
        public ClaimDTO Add(int id, RoleDTO roleDto, PermissionDTO permissionDto, ePolicyDTO policy)
        {
            Role role = _mapper.Map<Role>(roleDto);
            Permission permission = _mapper.Map<Permission>(permissionDto);
            ePolicy newPolicy = _mapper.Map<ePolicy>(policy);
            Claim claim= _claimRepository.Add(id, role, permission, newPolicy);
            return _mapper.Map<ClaimDTO>(claim);
        }
        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }

        public List<ClaimDTO> GetAll()
        {
            List<Claim> list=_claimRepository.GetAll();
            return _mapper.Map<List<ClaimDTO>>(list);
        }

        public ClaimDTO GetById(int id)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.GetById(id));
        }

        public ClaimDTO Update(ClaimDTO claimDto, int id)
        {
            Claim claim = _mapper.Map<Claim>(claimDto);
            return _mapper.Map<ClaimDTO>(_claimRepository.Update(claim, id));
        }
    }
}
