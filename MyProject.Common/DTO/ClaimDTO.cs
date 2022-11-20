using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Common.DTO
{
    public enum ePolicy
    {
        allow, deny
    }
    public class ClaimDTO
    {
        public int Id { get; set; }
        public RoleDTO RoleDto { get; set; }
        public PermissionDTO PermissionDto { get; set; }
        public ePolicy Policy { get; set; }
    }
}
