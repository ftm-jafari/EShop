using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Domain.Interfaces;
using Eshop.Domain.Models.User;
using Eshop.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infra.Data.Repositories
{
    public class UserRepository(EshopContext context)
        : IUserRepository
    {
        public async Task<bool> ExitsMobileAsync(string mobile)
        {
            return await context.Users.AnyAsync(x => x.Mobile == mobile);
        }

        public async Task InsertAsync(User user)
        {
           await context.Users.AddAsync(user);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
