using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmetology.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Processing;

namespace Cosmetology.Controllers
{
        [Authorize]
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

            var files=Request.Form.Files;
            var fileName=files.First().FileName;
            var filePath=_hostingEnvironment.WebRootPath+"/articlepics/"+fileName;
            using(FileStream fileStream=new FileStream(filePath,FileMode.OpenOrCreate,FileAccess.ReadWrite)){
                files.First().CopyTo(fileStream);
                fileStream.Flush();
            }
            string url=Request.Host.Value;
            string requestPath="https://"+url+":8088/contents/"+fileName;
            if(article.Areas.Equals("1")||article.Areas.Equals("2")||article.Areas.Equals("3")){
                articles.Areas="首页"+article.Areas;
                if(article.Areas.Equals("2")){
                    string selfpath=_hostingEnvironment.WebRootPath+"/contents/"+fileName;   
                    var image=Image.Load(filePath);
                    image.Mutate(c=>c.Resize(640,426));
                    using( var selfstream=new FileStream(selfpath,FileMode.OpenOrCreate,FileAccess.ReadWrite))
                    {
                        image.SaveAsPng(selfstream);
                    }
                }else{
                    requestPath="https://"+url+":8088/articlepics/"+fileName;
                }
            }
            else{
                articles.Areas="关于我们"+article.Areas;
                if(article.Areas.Equals("5")){
                    string selfpath=_hostingEnvironment.WebRootPath+"/contents/"+fileName;   
                    var image=Image.Load(filePath);
                    image.Mutate(c=>c.Resize(640,426));
                    using( var selfstream=new FileStream(selfpath,FileMode.OpenOrCreate,FileAccess.ReadWrite))
                    {
                        image.SaveAsPng(selfstream);
                    }
                }
                if(article.Areas.Equals("6")){
                    string selfpath=_hostingEnvironment.WebRootPath+"/contents/"+fileName;   
                    var image=Image.Load(filePath);
                    image.Mutate(c=>c.Resize(200,150));
                    using( var selfstream=new FileStream(selfpath,FileMode.OpenOrCreate,FileAccess.ReadWrite))
                    {
                        image.SaveAsPng(selfstream);
                    }
                }else{
                    requestPath="https://"+url+":8088/articlepics/"+fileName;
                }

            }
            articles.ArticleImgUrl=requestPath;
            articles.ArticleContext=article.ArticleContext;
            articles.ArticleCreateDate=Convert.ToString(DateTime.Now);
            articles.ArticleUpdateDate=Convert.ToString(DateTime.Now);
            articles.UserName=User.Identity.Name;

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
                var file=Request.Form.Files;
                var fileName=file.First().FileName;
                 //上传原始图片
                string filepath=_hostingEnvironment.WebRootPath+"/contents/"+fileName;
                using(FileStream fileStream=new FileStream(filepath,FileMode.OpenOrCreate,FileAccess.ReadWrite)){
                    file.First().CopyTo(fileStream);
                    fileStream.Flush();
                }
                 //请求缩小图片
                string url=Request.Host.Value;
                string requestPath="https://"+url+":8088/contents/"+fileName;
                ScrollPics scroll=new ScrollPics();
                scroll.UserName=User.Identity.Name;
                scroll.PicName=scrollpic.PicName;
                scroll.ImgUrl=requestPath;
                scroll.ImgCreateDate=Convert.ToString(DateTime.Now);
                Updates updates=new Updates();
                updates.UpdateContent=requestPath;
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
        //返回网站修改信息列表
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
        //在网站修改信息列表中删除数据
        [HttpPost]
        public async Task<IActionResult> Delete(int id){
             Updates up=new Updates();
             up=_context.Updates.Find(id);
             if(up.UpdateType.Equals("轮播图")){
                 ScrollPics scroll=new ScrollPics();
                 scroll=_context.ScrollPic.FirstOrDefault(p=>p.ImgUrl.Equals(up.UpdateContent));
                 _context.Remove(scroll);
             }
             else{
                Articles article=new Articles();
                article=_context.Article.FirstOrDefault(p=>p.Areas.Equals(up.UpdateType) && p.ArticleName.Equals(up.UpdateContent));
                _context.Remove(article);
             }
             _context.Remove(up);
             await _context.SaveChangesAsync();
             return View("Update");
        }
        //删除网站预约信息
        [HttpPost]
        public async Task<IActionResult> DeleteMessage(int id){
            Messages me=new Messages();
            me=_context.Message.Find(id);
            _context.Remove(me);
            await _context.SaveChangesAsync();
            return View("MessageManage");
        }


        [HttpPost]
        public JsonResult GetInfos(){
            int currentpageIndex=int.Parse(Request.Form["page"]);
            int currentpageSize=int.Parse(Request.Form["rows"]);
            string searchtext=Request.Form["search"];
            List<User> users=new List<User>();
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


    }
}