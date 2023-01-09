using SmartQueue.Business.Concrete.Dtos.QueueDtos;
using SmartQueue.Business.Helpers.Mailing;
using SmartQueue.Business.Helpers.ReturnResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Abstract.Services
{
    public interface IQueueService
    {
        Task<BusinessReturnResult<QueueGetDto>> AddAsync(QueueAddDto dto);
        Task<BusinessReturnResult<QueueGetDto>> NextAsync(MailSettings mailSettings);
        Task<BusinessReturnResult<QueueGetDto>> GetAllForStateAsync(bool enableTracking = true, params string[] include);
        Task<BusinessReturnResult<QueueGetDto>> GetNtgAsync(int n,bool enableTracking = true, params string[] include);
    }
}
