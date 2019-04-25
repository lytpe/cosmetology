using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmetology.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cosmetology.Controllers{

    public class AccountController:Controller{
        private SignInManager<User> _signManager;
        private UserManager<User> _userManager;
        private ModelsDBContext _context;
        public AccountController(UserManager<User> userManager,
        SignInManager<User> signInManager,ModelsDBContext context){
            _signManager=signInManager;
            _userManager=userManager;
            _context=context;
        }

        public ViewResult Register(){
            return View();
        }

//因为密码规则必须是 6 个字符以上且包含一个大写字母和小写字母，且必须包含一个非数组字母字符
//tpe   Tpe#123
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model){
            if(ModelState.IsValid){
                var user=new User{UserName=model.UserName};
                var result=await _userManager.CreateAsync(user,model.Password);
                if(result.Succeeded){
                    await _signManager.SignInAsync(user,false);
                    return RedirectToAction("Index","ManageContent");
                }
                else{
                    foreach(var error in result.Errors){
                        ModelState.AddModelError("UserName",error.Description);
                    }
                    return View(model);
                }
            }
            else{
                ModelState.AddModelError("ConfirmPassword","密码不相符！");
                return View(model);
            }

        }

        public IActionResult Show(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id){
            User users=new User();
            users=_context.Users.Find(id);
            _context.Remove(users);
            await _context.SaveChangesAsync();
            return View("Show","ManageContent");
        }

        [HttpPost]
        public async Task<IActionResult> Logout(){
            await _signManager.SignOutAsync();
            return RedirectToAction("Login","Account");
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string returnUrl=""){
            var model =new LoginViewModel{ReturnUrl=returnUrl};
            return View(model);
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid){
                var result=await _signManager.PasswordSignInAsync(model.UserName,model.Password,model.RememberMe,false);
                if(result.Succeeded){
                    if(!string.IsNullOrEmpty(model.ReturnUrl)&&Url.IsLocalUrl(model.ReturnUrl)){
                        return Redirect(model.ReturnUrl);
                    }else{
                        return RedirectToAction("Index","ManageContent");
                    }
                }
            }
            if(string.IsNullOrEmpty(model.ReturnUrl)){
                model.ReturnUrl="";
            }
            ModelState.AddModelError("Password","用户名或密码错误");
            return View(model);
        }
    }
      public class RegisterViewModel{
        [Required,MaxLength(64)]
        public string UserName{get;set;}
        [Required,DataType(DataType.Password)]
        public string Password{get;set;}
        [DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword{get;set;}
    }
    public class LoginViewModel{
        public string UserName{get;set;}
        [DataType(DataType.Password)]
        public string Password{get;set;}

        [Display(Name="Remember Me")]
        public bool RememberMe{get;set;}
        public string ReturnUrl{get;set;}
    }
}