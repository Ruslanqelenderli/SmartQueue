using SmartQueue.DataAccess.Abstract.IGenericRepository;
using SmartQueue.DataAccess.Concrete.ReturnResult;
using SmartQueue.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.DataAccess.Abstract.IRepositories
{
    public interface IUserRoleRepository : IAsyncRepository<UserRole, DataAccessReturnResult<UserRole>>, IRepository<UserRole, DataAccessReturnResult<UserRole>>

    {
    }
}
