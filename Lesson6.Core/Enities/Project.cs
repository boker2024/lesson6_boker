using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Enities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<MyTask>? Tasks { get; set; } = new();
    }
}
