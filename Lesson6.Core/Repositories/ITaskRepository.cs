using Lesson6.Core.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Repositories
{
    public interface ITaskRepository:IRepository<MyTask>
    {
    }
}
