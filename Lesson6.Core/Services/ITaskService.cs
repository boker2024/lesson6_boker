using Lesson6.Core.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Services
{
    public interface ITaskService
    {
        List<MyTask> GetAll();
        MyTask GetById(int id);
        MyTask DeleteById(int id);

        MyTask Update(int id, MyTask p);
        MyTask Add(MyTask p);
    }
}
