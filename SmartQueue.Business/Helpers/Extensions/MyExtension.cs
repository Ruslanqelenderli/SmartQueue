using Microsoft.Extensions.DependencyInjection;
using SmartQueue.Business.Abstract.Services;
using SmartQueue.Business.Concrete.Managers;
using SmartQueue.Business.Helpers.Mailing;
using SmartQueue.Business.Helpers.Mailing.MailKitİmplementations;
using SmartQueue.DataAccess.Abstract.IRepositories;
using SmartQueue.DataAccess.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Helpers.Extensions
{
    public static class MyExtension
    {
        public static void ServiceCollectionMethod(this IServiceCollection service)
        {
            service.AddScoped<IQueueRepository, QueueRepository>();
            service.AddScoped<IQueueService, QueueManager>();
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IUserService, UserManager>();
            service.AddScoped<IRoleRepository, RoleRepository>();
            service.AddScoped<IRoleService, RoleManager>();
            service.AddScoped<IUserRoleRepository, UserRoleRepository>();
            service.AddScoped<IUserRoleService, UserRoleManager>();
            service.AddScoped<IMailService, MailManager>();

        }
    }
}
