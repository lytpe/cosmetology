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
        public async Task<IActionResult> AddArticles(Articles articles){        
            Articles Articles=new Articles();
            Articles.ArticleName=articles.ArticleName;
            //Articles.ArticleImgUrl=articles.ArticleImgUrl;
            // Articles.ArticleMoiveUrl=articles.ArticleMoiveUrl;
            Articles.ArticleContext=articles.ArticleContext;
            Articles.ArticleCreateDate=Convert.ToString(DateTime.Now);
            Articles.ArticleUpdateDate=Convert.ToString(DateTime.Now);
            Articles.UserName=User.Identity.Name;
            Updates updates=new Updates();
            updates.UpdateContent=articles.ArticleName;
            updates.UpdateDate=Convert.ToString(DateTime.Now);
            updates.UpdateType="产品内容";
            updates.UpdateUserName=User.Identity.Name;
            try{
            _context.Add(Articles);
            _context.Add(updates);
            await _context.SaveChangesAsync();
            return View("Index");
            }catch{}
            return View("Error");
        }
        #endregion
        #region 添加企业特征信息
        public IActionResult AddFeatures(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddFeatures(Features feature){
                Features f=new Features();
                f.ArticleContext=feature.ArticleContext;
                f.ArticleCreateDate=Convert.ToString(DateTime.Now);
                //f.ArticleImgUrl=feature.ArticleImgUrl;
               // f.ArticleMovieUrl=feature.ArticleMovieUrl;
                f.ArticleName=feature.ArticleName;
                f.ArticleUpdateDate=Convert.ToString(DateTime.Now);
                f.UserName=User.Identity.Name;
                Updates updates=new Updates();
                updates.UpdateContent=feature.ArticleName;
                updates.UpdateDate=Convert.ToString(DateTime.Now);
                updates.UpdateType="企业内容";
                updates.UpdateUserName=User.Identity.Name;
                try{
                _context.Add(feature);
                _context.Add(updates);
                await _context.SaveChangesAsync();
                return View("Index");
                }catch{}
            return  View("Error");
        }
        #endregion
        #region 添加视频信息
        public IActionResult AddMovies(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]   
        public async Task<IActionResult> AddMovies(Movies movie){
            var files=Request.Form.Files;
           // string WebRootPath=_hostingEnvironment.WebRootPath; //该路径为启动后wwwroot下的路径
            string webPath=_hostingEnvironment.WebRootPath;//该路径为程序内容路径
            foreach(var file in files){
                if(file.Length>0){
                    string fileName=Path.GetFileName(file.FileName);
                    var filePath=webPath+"/contents/movies/"+fileName;
                    using(var stream=new FileStream(filePath,FileMode.Create)){
                        await file.CopyToAsync(stream);
                    }
                        Movies movies=new Movies();
                        movies.MovieName=fileName;
                        movies.MovieUrl=filePath;
                        movies.UserName=User.Identity.Name;

                        Updates updates=new Updates();
                        updates.UpdateContent=fileName;
                        updates.UpdateDate=Convert.ToString(DateTime.Now);
                        updates.UpdateType="视频文件";
                        updates.UpdateUserName=User.Identity.Name;
                        try{
                        _context.Add(movies);
                        _context.Add(updates);
                        await _context.SaveChangesAsync();
                        }catch{}   
                    }  
                }
            return View("Index");
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
             if(up.UpdateType.Equals("产品内容")){
                 Articles m=_context.Article.SingleOrDefault(p=>p.ArticleName.Equals(up.UpdateContent));
                 _context.Remove(m);
                 await _context.SaveChangesAsync();
             }else if(up.UpdateType.Equals("企业内容")){
                 Features m=_context.Feature.SingleOrDefault(p=>p.ArticleName.Equals(up.UpdateContent));
                 _context.Remove(m);
                 await _context.SaveChangesAsync();
             }
             else if(up.UpdateType.Equals("视频文件")){
                 Movies m=_context.Movie.SingleOrDefault(p=>p.MovieName.Equals(up.UpdateContent));
                 _context.Remove(m);
                 await _context.SaveChangesAsync();
               
             }else if(up.UpdateType.Equals("轮播图")){
                 ScrollPics s=_context.ScrollPic.SingleOrDefault(p=>p.ImgUrl.Equals(up.UpdateContent));
                 _context.Remove(s);
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

    }
}