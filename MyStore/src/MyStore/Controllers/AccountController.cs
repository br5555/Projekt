using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MyStore.Models.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Http.Authentication;
using MyStore.Models;

namespace MyStore.Controllers
{

    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userMgr,
                SignInManager<IdentityUser> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
        }

        [AllowAnonymous]
        public ViewResult Login(string returnUrl)
        {
            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user =
                    await userManager.FindByNameAsync(loginModel.Name);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    if ((await signInManager.PasswordSignInAsync(user,
                            loginModel.Password, false, false)).Succeeded)
                    {
                        return Redirect(loginModel?.ReturnUrl ?? "/Admin/Index");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View(loginModel);
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult GoogleLogin(string returnUrl)
        {
            string redirectUrl = Url.Action("GoogleResponse", "Account",
                new { ReturnUrl = returnUrl });
            AuthenticationProperties properties = signInManager
                .ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> GoogleResponse(string returnUrl = "/")
        {
            ExternalLoginInfo info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }
            var result = await signInManager.ExternalLoginSignInAsync(
                info.LoginProvider, info.ProviderKey, false);
            if (result.Succeeded)
            {
                return Redirect(returnUrl);
            }
            else
            {
                AppUser user = new AppUser
                {
                    Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                    UserName =
                        info.Principal.FindFirst(ClaimTypes.Email).Value
                };
                IdentityResult identResult = await userManager.CreateAsync(user);
                if (identResult.Succeeded)
                {
                    identResult = await userManager.AddLoginAsync(user, info);
                    if (identResult.Succeeded)
                    {
                        await signInManager.SignInAsync(user, false);
                        return Redirect(returnUrl);
                    }
                }
                return AccessDenied();
            }
        }


        [AllowAnonymous]
        public IActionResult FacebookLogin(string returnUrl)
        {
            string redirectUrl = Url.Action("FacebookResponse", "Account",
                new { ReturnUrl = returnUrl });
            AuthenticationProperties properties = signInManager
                .ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            return new ChallengeResult("Facebook", properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> FacebookResponse(string returnUrl = "/")
        {
            ExternalLoginInfo info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }
            var result = await signInManager.ExternalLoginSignInAsync(
                info.LoginProvider, info.ProviderKey, false);
            if (result.Succeeded)
            {
                return Redirect(returnUrl);
            }
            else
            {
                AppUser user = new AppUser
                {
                    Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                    UserName =
                        info.Principal.FindFirst(ClaimTypes.Email).Value
                };
                IdentityResult identResult = await userManager.CreateAsync(user);
                if (identResult.Succeeded)
                {
                    identResult = await userManager.AddLoginAsync(user, info);
                    if (identResult.Succeeded)
                    {
                        await signInManager.SignInAsync(user, false);
                        return Redirect(returnUrl);
                    }
                }
                return AccessDenied();
            }
        }

        //[AllowAnonymous]
        //public IActionResult TwitterLogin(string returnUrl)
        //{
        //    string redirectUrl = Url.Action("TwitterResponse", "Account",
        //        new { ReturnUrl = returnUrl });
        //    AuthenticationProperties properties = signInManager
        //        .ConfigureExternalAuthenticationProperties("Twitter", redirectUrl);
        //    return new ChallengeResult("Twitter", properties);
        //}

        ////[AllowAnonymous]
        ////public async Task<IActionResult> TwitterResponse(string returnUrl = "/")
        ////{
        ////    ExternalLoginInfo info = await signInManager.GetExternalLoginInfoAsync();
        ////    if (info == null)
        ////    {
        ////        return RedirectToAction(nameof(Login));
        ////    }
        ////    var result = await signInManager.ExternalLoginSignInAsync(
        ////        info.LoginProvider, info.ProviderKey, false);
        ////    if (result.Succeeded)
        ////    {
        ////        return Redirect(returnUrl);
        ////    }
        ////    else
        ////    {
        ////        AppUser user = new AppUser
        ////        {
        ////            Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
        ////            UserName =
        ////                info.Principal.FindFirst(ClaimTypes.Email).Value
        ////        };
        ////        IdentityResult identResult = await userManager.CreateAsync(user);
        ////        if (identResult.Succeeded)
        ////        {
        ////            identResult = await userManager.AddLoginAsync(user, info);
        ////            if (identResult.Succeeded)
        ////            {
        ////                await signInManager.SignInAsync(user, false);
        ////                return Redirect(returnUrl);
        ////            }
        ////        }
        ////        return AccessDenied();
        ////    }
        ////}

        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }

    }
}