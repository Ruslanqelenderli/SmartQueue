using SmartQueue.DataAccess.Abstract.IGenericRepository;
using SmartQueue.DataAccess.Concrete.ReturnResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.DataAccess.Abstract.IRepositories
{
    public interface IQueueRepository : IAsyncRepository<SmartQueue.Entity.Entities.Queue, DataAccessReturnResult<SmartQueue.Entity.Entities.Queue>>, IRepository<SmartQueue.Entity.Entities.Queue, DataAccessReturnResult<SmartQueue.Entity.Entities.Queue>>
    {
    }
}
