using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserProfile:BaseEntity
    {
        public string Address { get; set; }
        public string Education { get; set; }
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User  User { get; set; }
    }
}
