using AutoMapper;
using SmartQueue.Business.Concrete.Dtos.QueueDtos;
using SmartQueue.Business.Concrete.Dtos.RoleDtos;
using SmartQueue.Business.Concrete.Dtos.UserDtos;
using SmartQueue.Business.Concrete.Dtos.UserRoleDtos;
using SmartQueue.Business.Helpers.ReturnResult;
using SmartQueue.DataAccess.Concrete.ReturnResult;
using SmartQueue.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Helpers.AutoMapper
{
    public class ProgramProfile:Profile
    {
        public ProgramProfile()
        {
            CreateMap<Queue, QueueGetDto>().ReverseMap();
            CreateMap<Queue, QueueAddDto>().ReverseMap();
            CreateMap<BusinessReturnResult<QueueGetDto>, DataAccessReturnResult<Queue>>().ReverseMap();

            CreateMap<User, UserGetDto>().ReverseMap();
            //CreateMap<Queue, QueueAddDto>().ReverseMap();
            CreateMap<BusinessReturnResult<UserGetDto>, DataAccessReturnResult<User>>().ReverseMap();

            CreateMap<Role, RoleGetDto>().ReverseMap();
            //CreateMap<Queue, QueueAddDto>().ReverseMap();
            CreateMap<BusinessReturnResult<RoleGetDto>, DataAccessReturnResult<Role>>().ReverseMap();

            CreateMap<UserRole, UserRoleGetDto>().ReverseMap();
            //CreateMap<Queue, QueueAddDto>().ReverseMap();
            CreateMap<BusinessReturnResult<UserRoleGetDto>, DataAccessReturnResult<UserRole>>().ReverseMap();
        }
    }
}
