using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Helpers.Identity.Password
{
    public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);
            var result = Convert.ToBase64String(hashedPassword);
            return result;
        }
    }
}
