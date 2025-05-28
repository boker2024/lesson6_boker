using Lesson6.Core.Enities;
using Lesson6.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace Lesson6.Data.Repositories
{
    public class ProjectRepository(TaskitDB context) : IProjectRepository
    {
        private readonly TaskitDB _context = context;


        public Project Add(Project entity)
        {
            _context.Projects.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Project Delete(int id)
        {
            var project = _context.Projects.Find(id);
            if (project == null)
                return null;

            _context.Projects.Remove(project);
            _context.SaveChanges();
            return project;
        }

        public Project? Get(int id)
        {
            return _context.Projects.Include(item=>item.Tasks).FirstOrDefault(item=>item.Id==id);
        }

        public List<Project> GetAll()
        {
            return _context.Projects.Include(item=>item.Tasks).ToList();
        }

        public Project Update(int id, Project entity)
        {
            var existing = _context.Projects.Find(id);
            if (existing == null)
                return null;

            // שדרוג שדות
            existing.Name = entity.Name;

            // existing.ManagerId = entity.ManagerId;

            _context.SaveChanges();
            return existing;
        }
    }
}