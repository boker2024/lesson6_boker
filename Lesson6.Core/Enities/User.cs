using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Enities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public UserProfile? Profile { get; set; }
        public List<MyTask>? Tasks { get; set; } = new();
    }
}
