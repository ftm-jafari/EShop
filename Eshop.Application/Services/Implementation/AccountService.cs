using Eshop.Application.Services.Interfaces;
using Eshop.Domain.Enums.User;
using Eshop.Domain.Interfaces;
using Eshop.Domain.Models.User;
using Eshop.Domain.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Application.Services.Implementation
{
    public class AccountService(IUserRepository userRepository)
        : IAccountService
    {


        public async Task<RegisterResult> RegisterAsync(RegisterViewModel model)
        {
            if (await userRepository.ExitsMobileAsync(model.Mobile))
                return RegisterResult.MobileDuplicated;


            string hashPassword = model.Password;

            User user = new()
            {
                Mobile = model.Mobile,
                Password = hashPassword,
                CreateDate = DateTime.Now,
                Email = null,
                FirstName = null,
                LastName = null,
                Status = UserStatus.Active,
            };

            await userRepository.InsertAsync(user);
            await userRepository.SaveAsync();

            return RegisterResult.Succsess;
        }
    }
}
