//using MyProject.Common.Commons;
using MyProject.Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Interfaces
{
    public interface IClaimService
    {
        List<ClaimDTO> GetAll();

        ClaimDTO GetById(int id);

        ClaimDTO Add(int id, RoleDTO role, PermissionDTO permission, ePolicy policy);

        ClaimDTO Update(ClaimDTO claim, int id);

        void Delete(int id);
    }
}
