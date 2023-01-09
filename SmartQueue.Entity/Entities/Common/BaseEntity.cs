using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Entity.Entities.Common
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool State { get; set; }
        public bool IsDeleted { get; set; } = default;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
