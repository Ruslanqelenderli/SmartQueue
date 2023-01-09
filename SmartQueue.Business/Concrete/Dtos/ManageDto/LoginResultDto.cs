using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Concrete.Dtos.ManageDto
{
    public class LoginResultDto
    {
        public int Id { get; set; }
        public int  Status { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
