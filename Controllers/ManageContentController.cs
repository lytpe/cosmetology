using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmetology.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Cosmetology.Controllers{


    public class ManageContentController:Controller{
        private ModelsDBContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ManageContentController(IHostingEnvironment hostingEnvironment,ModelsDBContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context=context;
        }
        public IActionResult Index(){
            return View();
        }
        #region 添加通用文章
        public IActionResult AddArticles(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddArticles(Articles article){        
            Articles articles=new Articles();
            articles.ArticleName=article.ArticleName;
            articles.ArticleSideName=article.ArticleSideName;
            articles.ArticleImgUrl=article.ArticleImgUrl;
            articles.ArticleContext=article.ArticleContext;
            articles.ArticleCreateDate=Convert.ToString(DateTime.Now);
            articles.ArticleUpdateDate=Convert.ToString(DateTime.Now);
            articles.UserName=User.Identity.Name;
            if(article.Areas.Equals("1")||article.Areas.Equals("2")||article.Equals("3")){
                articles.Areas="首页"+article.Areas;
            }
            else{
                articles.Areas="关于我们"+article.Areas;
            }
            Updates updates=new Updates();
            updates.UpdateContent=article.ArticleName;
            updates.UpdateDate=Convert.ToString(DateTime.Now);
            if(article.Areas.Equals("1")||article.Areas.Equals("2")||article.Areas.Equals("3")){
                 updates.UpdateType="首页"+article.Areas;
            }else{
                updates.UpdateType="关于我们"+article.Areas;
            }

            updates.UpdateUserName=User.Identity.Name;
            try{
            _context.Add(articles);
            _context.Add(updates);
            await _context.SaveChangesAsync();
            return View("Index");
            }catch{}
            return View("Error");
        }
        #endregion  
        #region  添加滚动图片
        public IActionResult AddScrollPics(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]      
        public async Task<IActionResult> AddScrollPics(ScrollPics scrollpic){
             var files=Request.Form.Files;
            // var allowType=new string[]{"image/jpg","image/png","jpg","png"};
             //if(files.Any(c=>allowType.Contains(c.ContentType))){
                 if(files.Sum(c=>c.Length)<=1024*1024*4){
                     foreach(var file in files){
                         string filename=Path.GetFileName(file.FileName);
                         string path=_hostingEnvironment.WebRootPath+"/contents/images/"+filename;
                         using(var stream=new FileStream(path,FileMode.OpenOrCreate,FileAccess.ReadWrite)){
                                await file.CopyToAsync(stream);
                                ScrollPics scroll=new ScrollPics();
                                scroll.UserName=User.Identity.Name;
                                scroll.PicName=scrollpic.PicName;
                                scroll.ImgUrl=path;
                                scroll.ImgCreateDate=Convert.ToString(DateTime.Now);
                                Updates updates=new Updates();
                                updates.UpdateContent=path;
                                updates.UpdateDate=Convert.ToString(DateTime.Now);
                                updates.UpdateType="轮播图";
                                updates.UpdateUserName=User.Identity.Name;
                                try{
                                _context.Add(scroll);
                                _context.Add(updates);
                                await _context.SaveChangesAsync();
                                }catch{}
                                return View("Index");
                        }
                     }
                 }
                 else{
                     return Json("图片过大");
                 }
            // }
           //  else{
            //     return Json("图片格式有误");
           //  }
             return View("Error");
        }
        #endregion 
        #region 客户信息显示
        public IActionResult MessageManage(){
            return View();
        }
        [HttpPost]
        public JsonResult Message(){
            int currentpageIndex=int.Parse(Request.Form["page"]);
            int currentpageSize=int.Parse(Request.Form["rows"]);
            string searchtext=Request.Form["search"];
            List<Messages> messages=new List<Messages>();
            int count=0;
            if(searchtext.Equals("")){
            count=_context.Message.Count();
            messages=_context.Message.Skip((currentpageIndex-1)*10).Take(currentpageSize).ToList();
            }
            else{
                messages=_context.Message.Where(p=>p.Name.Equals(searchtext)).ToList();
                count=_context.Message.Where(p=>p.Name.Equals(searchtext)).Count();
            }
            return Json(new {total=count,rows=messages});
        }
        #endregion
        #region 信息更新列表
        public IActionResult Update(){
            return View();
        }
        [HttpPost]
        public JsonResult Updates(){
            int currentpageIndex=int.Parse(Request.Form["page"]);
            int currentpageSize=int.Parse(Request.Form["rows"]);
            string searchtext=Request.Form["search"];
            List<Updates> updates=new List<Updates>();
            int count=0;
            if(searchtext.Equals("")){
            updates=_context.Updates.Skip((currentpageIndex-1)*currentpageSize).Take(currentpageSize).ToList();
            count=_context.Updates.Count();
            }else{
                updates=_context.Updates.Where(p=>p.UpdateType.Equals(searchtext)).ToList();
                count=_context.Updates.Where(p=>p.UpdateType.Equals(searchtext)).Count();
            }
            return Json(new {total=count,rows=updates});
        }
        #endregion 
        [HttpPost]
        public async Task<IActionResult> Delete(int id){
             Updates up=new Updates();
             up=_context.Updates.Find(id);
             if(up.UpdateType.Equals("轮播图")){
                 ScrollPics s=_context.ScrollPic.SingleOrDefault(p=>p.ImgUrl.Equals(up.UpdateContent));
                 _context.Remove(s);
                 await _context.SaveChangesAsync();
             }else{
                 Articles m=_context.Article.SingleOrDefault(p=>p.ArticleName.Equals(up.UpdateContent));
                 _context.Remove(m);
                 await _context.SaveChangesAsync();
             }
             _context.Remove(up);
             await _context.SaveChangesAsync();
           return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteMessage(int id){
            Messages me=new Messages();
            me=_context.Message.Find(id);
            _context.Remove(me);
            await _context.SaveChangesAsync();
            return View("MessageManage");
        }

         //显示用户列表
        public IActionResult Show(){
            return View();
        }
        [HttpPost]
        public JsonResult GetInfos(){
            int currentpageIndex=int.Parse(Request.Form["page"]);
            int currentpageSize=int.Parse(Request.Form["rows"]);
            string searchtext=Request.Form["search"];
            List<Users> users=new List<Users>();
            int count=0;
                if(searchtext.Equals("")){
                users=_context.Users.Skip((currentpageIndex-1)*currentpageSize).Take(currentpageSize).ToList();
                count=_context.Users.Count();
                }else{
                    users=_context.Users.Where(p=>p.UserName.Equals(searchtext)).ToList();
                    count=_context.Users.Where(p=>p.UserName.Equals(searchtext)).Count();
                }
            return Json(new {total=count,rows=users});
        }

        [HttpPost]
        public JsonResult showArticles(){
            List<Articles> articles=new List<Articles>();
            articles=_context.Article.Where(p=>p.Areas.Equals("首页1")).ToList();
            return Json(new {articles=articles});
        }

    }
}