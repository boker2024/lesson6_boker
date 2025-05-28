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
    public class ProjectService(IProjectRepository repository) : IProjectService
    {
        private readonly IProjectRepository _projectRepository = repository;
        public Project Add(Project p)
        {
        return    _projectRepository.Add(p);
        }

        public Project DeleteById(int id)
        {
            return _projectRepository.Delete(id);
        }

        public List<Project> GetAll()
        {
            return _projectRepository.GetAll();
        }

        public Project GetById(int id)
        {
            return _projectRepository.Get(id);
        }

        public Project Update(int id, Project p)
        {
            return _projectRepository.Update(id, p);

        }
    }
}
