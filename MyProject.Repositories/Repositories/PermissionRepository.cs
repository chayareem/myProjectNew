using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class PermissionRepository: IPermissionRepository
    {
        private readonly IContext _context;
        public PermissionRepository(IContext con)
        {
            _context = con;
        }
        public Permission Add(int id, string name, string description)
        {
            var newPermission = new Permission { Description = description, Id = id, Name = name };
            _context.Permissions.Add(newPermission);
            return newPermission;
        }

        public void Delete(int id)
        {
            Permission permission = new Permission { };
            for (int i = 0; i < _context.Permissions.Count; i++)
            {
                if (_context.Permissions[i].Id == id)
                {
                    permission = _context.Permissions[i];
                }
                _context.Permissions.Remove(permission);
            }
        }

        //public void Delete(Permission permission)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }

        public Permission GetById(int id)
        {
            Permission permission = new Permission { };
            for (int i = 0; i < _context.Permissions.Count; i++)
            {
                if (_context.Permissions[i].Id == id)
                    permission = _context.Permissions[i];
            }
            return permission;
        }

        public Permission Update(Permission permission, int id)
        {
            Permission newPermission = new Permission { };
            for (int i = 0; i < _context.Permissions.Count; i++)
            {
                if (_context.Permissions[i] == permission)
                {
                    _context.Permissions[i].Id = id;
                    newPermission = _context.Permissions[i];
                }
            }
            return newPermission;
        }
    }
}
