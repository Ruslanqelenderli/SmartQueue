using AutoMapper;
using SmartQueue.Business.Abstract.Services;
using SmartQueue.Business.Concrete.Dtos.ManageDto;
using SmartQueue.Business.Concrete.Dtos.UserDtos;
using SmartQueue.Business.Helpers.Identity.Password;
using SmartQueue.Business.Helpers.ReturnResult;
using SmartQueue.DataAccess.Abstract.IRepositories;
using SmartQueue.DataAccess.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;



        public UserManager(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<BusinessReturnResult<UserGetDto>> GetForLoginAsync(LoginDto dto)
        {
            try
            {
                var data = await userRepository.GetAsync(x => x.Email == dto.Email && x.HashedPassword == PasswordHasher.HashPassword(dto.Password));
                var returnresult = mapper.Map<BusinessReturnResult<UserGetDto>>(data);
                return returnresult;
            }
            catch (Exception ex)
            {
                var returnresult = new BusinessReturnResult<UserGetDto>();
                returnresult.MainMethod(ex.Message, false);
                return returnresult;
            }
        }
    }
}
