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
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionRepository _permissionRepository;
        public PermissionController(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }
        [HttpGet]
        public IEnumerable<Permission> Get()
        {
            return _permissionRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Permission Get(int id)
        {
            return _permissionRepository.GetById(id);
        }

        [HttpPost]
        public void Post(Permission permission)
        {
            _permissionRepository.GetAll().Add(permission);
        }
        [HttpPut("{id}")]
        public void Put(int id, Permission permission)
        {
            _permissionRepository.Update(permission, id);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _permissionRepository.Delete(id);
        }
    }
}
