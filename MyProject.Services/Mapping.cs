using AutoMapper;
//using MyProject.Common.Commons;
using MyProject.Common.DTO;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ePolicyDTO=MyProject.Common.DTO.ePolicy;
using ePolicy = MyProject.Repositories.Entities.ePolicy;

namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Role, RoleDTO>().
                ForMember(dest=>dest.DescriptionDTO,opt=>opt.MapFrom(src=>src.Description)).
                ReverseMap();
            CreateMap<Permission, PermissionDTO>().
                ForMember(dest=>dest.DescriptionDTO,opt=>opt.MapFrom(src=>src.Description)).
                ReverseMap();
            CreateMap<Claim, ClaimDTO>().ReverseMap();
            CreateMap<ePolicyDTO, ePolicy>().ReverseMap();
        }
    }
}
