using Eshop.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> ExitsMobileAsync(string mobile);
        Task InsertAsync(User user);
        Task SaveAsync();
    }
}
