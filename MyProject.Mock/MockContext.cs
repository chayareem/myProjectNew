﻿using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace MyProject.Mock
{
    public class MockContext : IContext
    {
        public List<Role> Roles { get; set; }
        public List<Permission> Permissions { get; set; }
        public List<Claim> Claims { get; set; }


        public MockContext()
        {
            this.Roles = new List<Role>();
            this.Permissions = new List<Permission>();
            this.Claims = new List<Claim>();

            this.Roles.Add(new Role { Id = 1, Name = "admin" });
            this.Roles.Add(new Role { Id = 2, Name = "user" });

            this.Permissions.Add(new Permission { Id = 1, Name = "VIEW_ALL_ROLES" });
            this.Permissions.Add(new Permission { Id = 2, Name = "ADD_ROLE" });

            this.Claims.Add(new Claim { });
            this.Claims.Add(new Claim { });
        }
    }
}
