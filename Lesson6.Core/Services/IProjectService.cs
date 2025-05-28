using Lesson6.Core.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Services
{
    public interface IProjectService
    {
        List<Project> GetAll();
        Project GetById(int id);
        Project DeleteById(int id);
        Project Update(int id,Project p);
        Project Add(Project p);
    }
}
