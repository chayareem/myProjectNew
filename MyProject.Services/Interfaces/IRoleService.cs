//using MyProject.Common.Commons;
using MyProject.Common.DTO;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Interfaces
{
    public interface IRoleService
    {
        List<RoleDTO> GetAll();

        RoleDTO GetById(int id);

        RoleDTO Add(int id, string name, string description);

        RoleDTO Update(RoleDTO role, int id);

        void Delete(int id);
    }
}
