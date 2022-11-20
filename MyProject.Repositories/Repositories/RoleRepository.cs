using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;
        public RoleRepository(IContext con)
        {
            _context = con;
        }
        public Role Add(int id, string name, string description)
        {
            var newRole = new Role { Description = description, Id = id, Name = name };
            _context.Roles.Add(newRole); 
            return newRole;
        }
        public void Delete(int id)
        {
            Role role=new Role { };
            for (int i = 0; i < _context.Roles.Count; i++)
            {
                if (_context.Roles[i].Id == id)
                {
                   role = _context.Roles[i];
                }
                _context.Roles.Remove(role);
            }
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int id)
        {
            Role role = new Role { };
            for (int i = 0; i < _context.Roles.Count; i++)
            {
                if (_context.Roles[i].Id == id)
                   role= _context.Roles[i];
            }
            return role;
        }

        public Role Update(Role role,int id)
        {
            Role newRole = new Role { };
            for (int i = 0; i < _context.Roles.Count; i++)
            {
                if(_context.Roles[i]==role)
                {
                    _context.Roles[i].Id = id;
                    newRole = _context.Roles[i];
                }
            }
            return newRole;
        }
    }
}
