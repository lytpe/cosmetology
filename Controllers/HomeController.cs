using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmetology.Models;
using Microsoft.AspNetCore.Hosting;

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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Single(int id){
            Articles article=new Articles();
            article=_context.Article.Find(id);
            return View(article);
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

        [HttpPost]
        public JsonResult showIndexModelOne(){
            List<Articles> articles=new List<Articles>();
            articles=_context.Article.Where(p=>p.Areas.Equals("首页1")).ToList();
            return Json(new {articles=articles});
        }


        [HttpPost]
        public JsonResult showIndexModelThree(){
            List<Articles> articles=new List<Articles>();
            articles=_context.Article.Where(p=>p.Areas.Equals("首页3")).ToList();
            return Json(new {articles=articles});
        }
        [HttpPost]
        public JsonResult showIndexModelTwo(){
            List<Articles> articles=new List<Articles>();
            articles=_context.Article.Where(p=>p.Areas.Equals("首页2")).ToList();
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
            articles=_context.Article.Where(p=>p.Areas.Equals("关于我们4")).ToList();
            return Json(new {articles=articles});
        }
       
        [HttpPost]
        public JsonResult showAboutModelTwo(){
            List<Articles> articles=new List<Articles>();
            articles=_context.Article.Where(p=>p.Areas.Equals("关于我们5")).ToList();
            return Json(new {articles=articles});
        }
       
        [HttpPost]
        public JsonResult  showAboutModelThree(){
            List<Articles> articles=new List<Articles>();
            articles=_context.Article.Where(p=>p.Areas.Equals("关于我们6")).ToList();
            return Json(new {articles=articles});
        }
    }
}
