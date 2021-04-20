using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookTalk.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTalk.Pages.Account
{
    public class RegisterModel : PageModel
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly Context _context;


        public RegisterModel(UserManager<User> userManager, Context context, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _context = context;
            _signInManager = signInManager;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostRegisterAccount(string email, string password, string confirmPassword)
        {


            if (password.Equals(confirmPassword))
            {
                User user = await _userManager.FindByEmailAsync(email);

                if (user is not null)
                {
                    ViewData["message"] = "There is already a user with this email, try restoring your account instead";
                    return Page();
                }
                else
                {
                    User newUser = new User()
                    {
                        UserName = email,
                        Email = email
                    };

                    var result = await _userManager.CreateAsync(newUser, password);

                    if (result.Succeeded)
                    {

                        if(_context.Users.Count() == 1)
                        {

                            await _userManager.AddToRoleAsync(newUser, "Admin");
                        }
                        else
                        {
                            await _userManager.AddToRoleAsync(newUser, "Customer");
                        }


                        // Sign in user. 

                        var signinResult = await _signInManager.PasswordSignInAsync(newUser, password, false, false);

                        if(signinResult.Succeeded)
                        {

                            return LocalRedirect("/");
                        }
                        else
                        {


                            ViewData["message"] = "Account was created, but failed to sign in.";


                        }

                    }
                    else
                    {

                        ViewData["message"] = "Something happened, please try again";

                    }

                }
                
            }
            else
            {
                ViewData["message"] = "Your password does not match!";
            }

            return Page();

        }
    }
}
