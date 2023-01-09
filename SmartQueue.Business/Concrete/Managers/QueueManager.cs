using AutoMapper;
using SmartQueue.Business.Abstract.Services;
using SmartQueue.Business.Concrete.Dtos.QueueDtos;
using SmartQueue.Business.Helpers.Mailing;
using SmartQueue.Business.Helpers.ReturnResult;
using SmartQueue.DataAccess.Abstract.IRepositories;
using SmartQueue.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Concrete.Managers
{
    public class QueueManager : IQueueService
    {
        private readonly IQueueRepository queueRepository;
        private readonly IMapper mapper;
        private readonly IMailService mailService;

        public QueueManager(IQueueRepository queueRepository, IMapper mapper, IMailService mailService)
        {
            this.queueRepository = queueRepository;
            this.mapper = mapper;
            this.mailService = mailService;
        }
        public async Task<BusinessReturnResult<QueueGetDto>> AddAsync(QueueAddDto dto)
        {
            try
            {
                var data = mapper.Map<Queue>(dto);
                data.CreatedDate = DateTime.Now;
                data.IsDeleted = false;
                var returnresult = await queueRepository.AddAsync(data);
                var result = mapper.Map<BusinessReturnResult<QueueGetDto>>(returnresult);
                return result;
            }
            catch (Exception ex)
            {
                var result = new BusinessReturnResult<QueueGetDto>();
                result.MainMethod(ex.Message, false);
                return result;
            }
        }

        public async Task<BusinessReturnResult<QueueGetDto>> NextAsync(MailSettings mailSettings)
        {
            try
            {
                var list = await GetAllForStateAsync();
                var id=list.List.FirstOrDefault().Id;
                var returnresult = await queueRepository.DeleteAsync(id);
                var result = mapper.Map<BusinessReturnResult<QueueGetDto>>(returnresult);
                var nthresult = await GetNtgAsync(3);
                if (nthresult.List.Count > 0)
                {
                    Mail mail = new Mail("Smart Queue", "Sizdən əvvəl növbədə 2 nəfər var.", "", "",
                    nthresult.List.First().Email);
                    mailService.SendMail(mail, mailSettings);
                }
                
                return result;
            }
            catch (Exception ex)
            {
                var result = new BusinessReturnResult<QueueGetDto>();
                result.MainMethod(ex.Message, false);
                return result;
            }
        }

        public async Task<BusinessReturnResult<QueueGetDto>> GetAllForStateAsync(bool enableTracking = true, params string[] include)
        {
            try
            {
                var result = await queueRepository.GetAllAsync(x => x.State == true && x.IsDeleted == false,
                                                      enableTracking,
                                                      include);
                var returnresult = mapper.Map<BusinessReturnResult<QueueGetDto>>(result);
                return returnresult;

            }
            catch (Exception ex)
            {
                var returnresult = new BusinessReturnResult<QueueGetDto>();
                returnresult.MainMethod(ex.Message, false);
                return returnresult;
                ;
            }
        }

        public async Task<BusinessReturnResult<QueueGetDto>> GetNtgAsync(int n, bool enableTracking = true, params string[] include)
        {
            try
            {
                var result = await queueRepository.GetAllAsync(x => x.State == true && x.IsDeleted == false,
                                                      enableTracking,
                                                      include);
                 result.List=result.List.Skip(n-1).Take(1).ToList();
                var returnresult = mapper.Map<BusinessReturnResult<QueueGetDto>>(result);
                return returnresult;

            }
            catch (Exception ex)
            {
                var returnresult = new BusinessReturnResult<QueueGetDto>();
                returnresult.MainMethod(ex.Message, false);
                return returnresult;
                ;
            }
        }
    }
}
