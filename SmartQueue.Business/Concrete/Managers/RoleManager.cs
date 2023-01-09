using AutoMapper;
using SmartQueue.Business.Abstract.Services;
using SmartQueue.Business.Concrete.Dtos.QueueDtos;
using SmartQueue.Business.Concrete.Dtos.RoleDtos;
using SmartQueue.Business.Concrete.Dtos.UserDtos;
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
    public class RoleManager : IRoleService
    {
        private readonly IRoleRepository roleRepository;
        private readonly IUserRoleRepository userRoleRepository;
        private readonly IMapper mapper;



        public RoleManager(IRoleRepository roleRepository, IMapper mapper, IUserRoleRepository userRoleRepository)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
            this.userRoleRepository = userRoleRepository;
        }

        public async Task<BusinessReturnResult<RoleGetDto>> GetAllByUserIdAsync(int userId,bool enableTracking = true, params string[] include)
        {
            try
            {
                var userroles = await userRoleRepository.GetAllAsync(x => x.State == true && x.IsDeleted == false && x.UserId == userId,
                enableTracking, include);
                var roles = await roleRepository.GetAllByIdsAsync(userroles.List,enableTracking:enableTracking,include:include);
                var returnresult = mapper.Map<BusinessReturnResult<RoleGetDto>>(roles);
                return returnresult;

            }
            catch (Exception ex)
            {
                var returnresult = new BusinessReturnResult<RoleGetDto>();
                returnresult.MainMethod(ex.Message, false);
                return returnresult;
                ;
            }
        }

        public async Task<BusinessReturnResult<RoleGetDto>> GetAllForStateAsync(bool enableTracking = true, params string[] include)
        {
            try
            {
                var result = await roleRepository.GetAllAsync(x => x.State == true && x.IsDeleted == false,
                                                      enableTracking,
                                                      include);
                var returnresult = mapper.Map<BusinessReturnResult<RoleGetDto>>(result);
                return returnresult;

            }
            catch (Exception ex)
            {
                var returnresult = new BusinessReturnResult<RoleGetDto>();
                returnresult.MainMethod(ex.Message, false);
                return returnresult;
                ;
            }
        }
    }
}
