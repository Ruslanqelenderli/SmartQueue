using Microsoft.IdentityModel.Tokens;
using SmartQueue.Business.Concrete.Dtos.RoleDtos;
using SmartQueue.Entity.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Helpers.Identity.Token
{
    public class TokenGenerator
    {
        public static string GenerateJwtToken(string name,ICollection<RoleGetDto> roles)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();

                var Key = Encoding.UTF8.GetBytes("My Security Key....");
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, name));
                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.Name));
                }
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                   
                    Subject = new ClaimsIdentity(claims),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Key), SecurityAlgorithms.HmacSha256Signature),

                    Expires = DateTime.UtcNow.AddMinutes(60)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }
    }
}
