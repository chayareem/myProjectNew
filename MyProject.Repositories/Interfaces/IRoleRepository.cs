using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        List<Role> GetAll();

        Role GetById(int id);

        Role Add(int id, string name, string description);

        Role Update(Role role,int id);

        void Delete(int id);
    }
}
