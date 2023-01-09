using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartQueue.Business.Abstract.Services;
using SmartQueue.Business.Concrete.Dtos.QueueDtos;
using SmartQueue.Business.Helpers.Mailing;

namespace SmartQueue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class QueueController : ControllerBase
    {
        private readonly ILogger<QueueController> logger;
        private readonly IQueueService queueService;
        private IConfiguration configuration;
        public QueueController(IQueueService queueService, ILogger<QueueController> logger, IConfiguration configuration)
        {
            this.queueService = queueService;
            this.logger = logger;
            this.configuration = configuration;
        }
        [HttpGet("/queues")]
        public async Task<IActionResult> Get()
        {
            logger.LogInformation("Start Get method in QueueController.");
            var result = await queueService.GetAllForStateAsync(true);

            if (result.Status)
            {
                logger.LogInformation(result.Message + " in QueueController Get method");
                return Ok(result.List);
            }
            else
            {
                logger.LogError(result.Message + " in QueueController Get method");
                return NotFound(result.Message);
            }
        }
        [HttpDelete("/queue/next")]
        //[Authorize(Roles ="Admin")]
        public async Task<IActionResult> Next()
        {
            logger.LogInformation("Start next method in QueueController.");
            MailSettings mailsettings = configuration.GetSection("MailSettings").Get<MailSettings>();
            var result = await queueService.NextAsync(mailsettings);

            if (result.Status)
            {
                logger.LogInformation(result.Message + " in QueueController next method");
                return Ok();
            }
            else
            {
                logger.LogError(result.Message + " in QueueController next method");
                return NotFound(result.Message);
            }
        }


        [HttpPost("/queue/add")]
        public async Task<IActionResult> Add(QueueAddDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            logger.LogInformation("Start Add method in QueueController.");
            var result = await queueService.AddAsync(dto);
            if (result.Status)
            {
                logger.LogInformation(result.Message + " in QueueController Add method");
                return Ok();
            }
            else
            {
                logger.LogError(result.Message + " in QueueController Add method");
                return NotFound(result.Message);
            }
        }
    }
}

