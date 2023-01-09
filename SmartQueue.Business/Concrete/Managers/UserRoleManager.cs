using AutoMapper;
using SmartQueue.Business.Abstract.Services;
using SmartQueue.Business.Concrete.Dtos.RoleDtos;
using SmartQueue.Business.Concrete.Dtos.UserRoleDtos;
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
    public class UserRoleManager : IUserRoleService
    {
        private readonly IUserRoleRepository userRoleRepository;
        private readonly IMapper mapper;



        public UserRoleManager(IUserRoleRepository userRoleRepository, IMapper mapper)
        {
            this.userRoleRepository = userRoleRepository;
            this.mapper = mapper;
        }
        public async Task<BusinessReturnResult<UserRoleGetDto>> GetAllByUserIdAsync(int userId,bool enableTracking = true, params string[] include)
        {
            try
            {
                var result = await userRoleRepository.GetAllAsync(x => x.State == true && x.IsDeleted == false && x.UserId==userId,
                enableTracking,include);
                var returnresult = mapper.Map<BusinessReturnResult<UserRoleGetDto>>(result);
                return returnresult;

            }
            catch (Exception ex)
            {
                var returnresult = new BusinessReturnResult<UserRoleGetDto>();
                returnresult.MainMethod(ex.Message, false);
                return returnresult;
                ;
            }
        }
    }
}
