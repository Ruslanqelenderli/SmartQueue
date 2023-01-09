using SmartQueue.Business.Concrete.Dtos.ManageDto;
using SmartQueue.Business.Concrete.Dtos.UserDtos;
using SmartQueue.Business.Helpers.ReturnResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Abstract.Services
{
    public interface IUserService
    {
         Task<BusinessReturnResult<UserGetDto>> GetForLoginAsync(LoginDto dto);
    }
}
