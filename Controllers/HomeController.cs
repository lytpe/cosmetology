using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmetology.Models;

namespace Cosmetology.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Single(){
            return View();
        }
        public IActionResult Support(){
            return View();
        }
        #region 用户邮箱信息
        public IActionResult Mail(){
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Mail(Messages message){
            using(ModelsDBContext modelsDB=new ModelsDBContext()){
                Messages messages=new Messages();
                messages.Name=message.Name;
                messages.Phone=message.Phone;
                messages.Email=message.Email;
                messages.Infos=message.Infos;
                messages.CreateDate=Convert.ToString(DateTime.Now);
                try{
                modelsDB.Add(messages);
                await modelsDB.SaveChangesAsync();
                return View("Mail");
                }catch{}
            }
            return View("Index");
        }
        #endregion
         [HttpPost]
         public async Task<IActionResult> Message(Messages message){
             using(ModelsDBContext dBContext=new ModelsDBContext()){
                      Messages me=new Messages();
                      me.CreateDate=Convert.ToString(DateTime.Now);
                      me.Infos=message.Infos;
                      me.Name=message.Name;
                      me.Phone=message.Phone;
                      me.Email=message.Email;
                      await dBContext.Message.AddAsync(me);
                      return View();
             }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
