using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Claim = MyProject.Repositories.Entities.Claim;

namespace MyProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        List<Claim> GetAll();

        Claim GetById(int id);

        Claim Add(int id, Role role,Permission permission,ePolicy policy);

        Claim Update(Claim claim,int id);

        void Delete(int id);
    }
}
