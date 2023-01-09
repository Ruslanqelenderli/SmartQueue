using SmartQueue.Business.Concrete.Dtos.QueueDtos;
using SmartQueue.Business.Concrete.Dtos.RoleDtos;
using SmartQueue.Business.Helpers.ReturnResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Abstract.Services
{
    public interface IRoleService
    {
        Task<BusinessReturnResult<RoleGetDto>> GetAllForStateAsync(bool enableTracking = true, params string[] include);
        Task<BusinessReturnResult<RoleGetDto>> GetAllByUserIdAsync(int userId,bool enableTracking = true, params string[] include);
    }
}
