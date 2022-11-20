//using MyProject.Common.Commons;
using MyProject.Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Interfaces
{
    public interface IPermissionService
    {
        List<PermissionDTO> GetAll();

        PermissionDTO GetById(int id);

        PermissionDTO Add(int id, string name, string description);

        PermissionDTO Update(PermissionDTO permission, int id);

        void Delete(int id);
    }
}
