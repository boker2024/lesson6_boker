using Lesson6.Core.Repositories;
using Lesson6.Core.Services;
using Lesson6.Data;
using Lesson6.Data.Repositories;
using Lesson6.services;
using Microsoft.Extensions.DependencyInjection;

namespace Lesson6.Api.Extensions
{
    public static class ServicesInjectionExtension
    {
        public static void SetProviding(this IServiceCollection services) { 
        
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();


            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IProjectService, ProjectService>();
            //services.AddScoped<IUserService, UserSer>();

            services.AddDbContext<TaskitDB>();



        }
    }
}
