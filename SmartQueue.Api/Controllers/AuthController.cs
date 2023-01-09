using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartQueue.Business.Abstract.Services;
using SmartQueue.Business.Concrete.Dtos.ManageDto;
using SmartQueue.Business.Helpers.Identity.Token;

namespace SmartQueue.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IRoleService roleService;
        private readonly IConfiguration configurationService;

        public AuthController(IUserService userService, IConfiguration configurationService, IRoleService roleService)
        {
            this.userService = userService;
            this.configurationService = configurationService;
            this.roleService = roleService;
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await userService.GetForLoginAsync(dto);
            if (user.List.Count==0)
            {
                return Ok(new LoginResultDto
                {
                    Id = 0,
                    Token = "",
                    Status = 401,
                    Message = "Unauthorized"
                });
               
            }
            else
            {
                var roles = await roleService.GetAllByUserIdAsync(user.List.FirstOrDefault().Id);
                var token = TokenGenerator.GenerateJwtToken(user.List.FirstOrDefault().Id.ToString(),roles.List);
                return Ok(new LoginResultDto
                {
                    Id = user.List.FirstOrDefault().Id,
                    Token = token,
                    Status = 200,
                    Message = "Succeed"
                });
            }

        }
    }
}
