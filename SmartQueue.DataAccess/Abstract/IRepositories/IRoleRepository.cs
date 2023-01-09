using SmartQueue.DataAccess.Abstract.IGenericRepository;
using SmartQueue.DataAccess.Concrete.ReturnResult;
using SmartQueue.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.DataAccess.Abstract.IRepositories
{
    public interface IRoleRepository : IAsyncRepository<Role, DataAccessReturnResult<Role>>, IRepository<Role, DataAccessReturnResult<Role>>

    {
        Task<DataAccessReturnResult<Role>> GetAllByIdsAsync(ICollection<UserRole> userRoles,
                                        Expression<Func<Role, bool>>? expression = null,
                                        bool enableTracking = true,
                                        params string[] include);
    }
}
