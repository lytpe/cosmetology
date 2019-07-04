using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmetology.Models;
using Microsoft.AspNetCore.Hosting;
using Cosmetology.Services;
namespace Cosmetology.Controllers
{
    public class HomeController : Controller
    {
        private ModelsDBContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment,ModelsDBContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context=context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Single(int id){
            Articles article=HomeServices.searchArticle(_context,id);
            return View(article);
        }
        #region 用户邮箱信息
        public IActionResult Mail(){
            return View();
        }
        [HttpPost]
        public  ActionResult Mail(string Name,string Phone,string Email,string Infos){
            Messages messages=new Messages();
            messages.Name=Name;
            messages.Phone=Phone;
            messages.Email=Email;
            messages.Infos=Infos;
            messages.CreateDate=Convert.ToString(DateTime.Now);
            _context.Add(messages);
            _context.SaveChanges();
            ViewData["Infos"]="success";
            return View();
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

        [HttpPost]
        public JsonResult showIndexModelOne(){
            List<Articles> articles=new List<Articles>();
            articles=HomeServices.showIndexModel(_context,"首页1");
            return Json(new {articles=articles});
        }
        [HttpPost]
        public JsonResult showIndexModelThree(){
            List<Articles> articles=new List<Articles>();
            articles=HomeServices.showIndexModel(_context,"首页3");
            return Json(new {articles=articles});
        }
        [HttpPost]
        public JsonResult showIndexModelTwo(){
            List<Articles> articles=new List<Articles>();
            articles=HomeServices.showIndexModel(_context,"首页2");
            return Json(new {articles=articles});
        }

        [HttpPost]
        public JsonResult showBigPic(){
            List<ScrollPics> scrolls=new List<ScrollPics>();
            scrolls=_context.ScrollPic.ToList();
            return Json(new {scrolls=scrolls});
        }
               
        [HttpPost]
        public JsonResult showAboutModelOne(){
            List<Articles> articles=new List<Articles>();
            articles=HomeServices.showIndexModel(_context,"关于我们4");
            return Json(new {articles=articles});
        }
       
        [HttpPost]
        public JsonResult showAboutModelTwo(){
            List<Articles> articles=new List<Articles>();
            articles=HomeServices.showIndexModel(_context,"关于我们5");
            return Json(new {articles=articles});
        }
       
        [HttpPost]
        public JsonResult  showAboutModelThree(){
            List<Articles> articles=new List<Articles>();
            articles=HomeServices.showIndexModel(_context,"关于我们6");
            return Json(new {articles=articles});
        }
    }
}
