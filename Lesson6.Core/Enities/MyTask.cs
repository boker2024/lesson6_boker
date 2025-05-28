using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Enities
{
    public enum ePriority
    {
        Low = 0,
        High = 2,
        Mid = 1
    }
    public class MyTask
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public ePriority Priority { get; set; }

        public int ProjectId { get; set; }
        public Project? Project { get; set; }

        public List<User>? Users { get; set; } = new ();



    }
}
