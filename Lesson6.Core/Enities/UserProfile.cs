using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Enities
{
    public class UserProfile
    {
   
     
        public DateTime Created { get; set; }=DateTime.Now;
        public int? Role { get; set; }
        [Key]
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
