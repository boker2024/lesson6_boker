using Lesson6.Core.Enities;
using Lesson6.Core.Repositories;
using Lesson6.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson6.services
{
    public class TaskService(ITaskRepository repo) : ITaskService
    { private readonly ITaskRepository _repository=repo;
        public MyTask Add(MyTask p)
        {
        return  _repository.Add(p);
        }

        public MyTask DeleteById(int id)
        {
            return _repository.Delete(id);
        }

        public List<MyTask> GetAll()
        {
            return _repository.GetAll();
        }

        public MyTask GetById(int id)
        {
            return _repository.Get(id);
        }

        public MyTask Update(int id, MyTask p)
        {
          return _repository.Update(id, p);  
        }
    }
}
