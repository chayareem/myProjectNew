using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class ClaimRepository: IClaimRepository
    {
        private readonly IContext _context;
        public ClaimRepository(IContext con)
        {
            _context = con;
        }
        public Claim Add(int id, Role role, Permission permission, ePolicy policy)
        {
            var newClaim = new Claim { Id = id, Role=role,Permission=permission,Policy=policy};
            _context.Claims.Add(newClaim);
            return newClaim;
        }

        public void Delete(int id)
        {
            Claim claim = new Claim { };
            for (int i = 0; i < _context.Claims.Count; i++)
            {
                if (_context.Claims[i].Id == id)
                {
                    claim = _context.Claims[i];
                }
                _context.Claims.Remove(claim);
            }
        }

        public List<Claim> GetAll()
        {
            return _context.Claims;
        }

        public Claim GetById(int id)
        {
            Claim claim = new Claim { };
            for (int i = 0; i < _context.Claims.Count; i++)
            {
                if (_context.Claims[i].Id == id)
                    claim = _context.Claims[i];
            }
            return claim;
        }

        public Claim Update(Claim claim, int id)
        {
            Claim newClaim = new Claim { };
            for (int i = 0; i < _context.Claims.Count; i++)
            {
                if (_context.Claims[i] == claim)
                {
                    _context.Claims[i].Id = id;
                    newClaim = _context.Claims[i];
                }
            }
            return newClaim;
        }
    }
}
