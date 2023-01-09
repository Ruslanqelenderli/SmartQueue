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
    public interface IUserRepository:IAsyncRepository<User, DataAccessReturnResult<User>>, IRepository<User, DataAccessReturnResult<User>>
    {
    }
}
