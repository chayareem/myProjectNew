using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
//using MyProject.Repositories.Entities;

namespace MyProject.WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimRepository _claimRepository;
        public ClaimController(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }
        [HttpGet]
        public IEnumerable<Claim> Get()
        {
            return (IEnumerable<Claim>)_claimRepository.GetAll();
        }

        [HttpGet("{id}")]
        //public Claim Get(int id)
        //{
        //    return _claimRepository.GetById(id);
        //}

        [HttpPost]
        public void Post(Claim claim)
        {
            //_claimRepository.GetAll().Add(claim);
        }
        [HttpPut("{id}")]
        public void Put(int id, Claim claim)
        {
            
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }
    }
}
