using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _roleRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Role Get(int id)
        {
            return _roleRepository.GetById(id);
        }

        [HttpPost]
        public void Post(int id,string name,string description)
        {
            _roleRepository.Add(id, name, description);
        }
        [HttpPut("{id}")]
        public void Put(int id, Role role)
        {
            _roleRepository.Update(role, id);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }
    }
}
