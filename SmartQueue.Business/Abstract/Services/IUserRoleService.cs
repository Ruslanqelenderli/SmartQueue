using SmartQueue.Business.Concrete.Dtos.RoleDtos;
using SmartQueue.Business.Concrete.Dtos.UserRoleDtos;
using SmartQueue.Business.Helpers.ReturnResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Abstract.Services
{
    public interface IUserRoleService
    {
        Task<BusinessReturnResult<UserRoleGetDto>> GetAllByUserIdAsync(int userId,bool enableTracking = true, params string[] include);
    }
}
