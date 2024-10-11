using Eshop.Application.Services.Interfaces;
using Eshop.Domain.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Web.Controllers
{
    public class AccountController(IAccountService accountService)
        : SiteBaseController
    {
        #region Fields
        #endregion

        #region Constructor
        #endregion

        #region Actions

        #region Register

        [HttpGet("/register")]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost("/register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            #region Validations

            if (!ModelState.IsValid)
                return View(model);

            #endregion

            //RegisterResult result = await accountService.RegisterAsync(model);

            //switch (result)
            //{
            //    case RegisterResult.Succsess:
            //        break;

            //    case RegisterResult.Error:
            //        break;

            //    case RegisterResult.MobileDuplicated:
            //        break;
            //}

            return View();
        }

        #endregion


        #endregion

    }
}
