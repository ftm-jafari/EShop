using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Application.Services.Implementation;
using Eshop.Application.Services.Interfaces;
using Eshop.Domain.Interfaces;
using Eshop.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Eshop.Infra.IoC.Container
{
    public static class IOCContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            #region Services

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUserService, UserService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();


            #endregion
        }
    }
}
