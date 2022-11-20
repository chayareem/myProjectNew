using System;
using System.Collections.Generic;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

namespace MyProject.Mock
{
    public class Mock : IContext
    {
        public List<Role> Roles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Permission> Permissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Claim> Claims { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
