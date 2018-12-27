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
        private readonly IHostingEnvironment _hostingEnvironment;
        public ManageContentController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
     
        public IActionResult Index(){
            return View();
        }

        #region 添加通用文章
        public IActionResult AddArticles(){
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> AddArticles(Articles articles){
            using(ModelsDBContext modelsDB=new ModelsDBContext()){
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
                modelsDB.Add(Articles);
                modelsDB.Add(updates);
                await modelsDB.SaveChangesAsync();
                return View("Index");
                }catch{}
            }
            return View("Error");
        }
        #endregion
        #region 添加企业特征信息
        public IActionResult AddFeatures(){
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> AddFeatures(Features feature){
            using(ModelsDBContext modelsDB=new ModelsDBContext()){
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
                modelsDB.Add(feature);
                modelsDB.Add(updates);
                await modelsDB.SaveChangesAsync();
                return View("Index");
                }catch{}
            }
            return  View("Error");
        }
        #endregion
        #region 添加视频信息

        public IActionResult AddMovies(){
            return View();
        }
        [HttpPost]
    
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
                    using(ModelsDBContext modelsDB=new ModelsDBContext()){
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
                        modelsDB.Add(movies);
                        modelsDB.Add(updates);
                        await modelsDB.SaveChangesAsync();
                        }catch{}   
                    }  
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
                                using(ModelsDBContext modelsDB=new ModelsDBContext()){
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
                                        modelsDB.Add(scroll);
                                        modelsDB.Add(updates);
                                        await modelsDB.SaveChangesAsync();
                                        }catch{}
                                        return View("Index");
                                    }  
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
            using(var model=new ModelsDBContext()){
                if(searchtext.Equals("")){
                count=model.Message.Count();
                messages=model.Message.Skip((currentpageIndex-1)*10).Take(currentpageSize).ToList();
                }
                else{
                    messages=model.Message.Where(p=>p.Name.Equals(searchtext)).ToList();
                    count=model.Message.Where(p=>p.Name.Equals(searchtext)).Count();
                }
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
            using(ModelsDBContext models=new ModelsDBContext()){
                
                if(searchtext.Equals("")){
                updates=models.Updates.Skip((currentpageIndex-1)*currentpageSize).Take(currentpageSize).ToList();
                count=models.Updates.Count();
                }else{
                    updates=models.Updates.Where(p=>p.UpdateType.Equals(searchtext)).ToList();
                    count=models.Updates.Where(p=>p.UpdateType.Equals(searchtext)).Count();
                }
            }
            return Json(new {total=count,rows=updates});
        }
        #endregion 
        public IActionResult Delete(string type,string name){
           return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteMessage(int id){
            using(ModelsDBContext md=new ModelsDBContext()){
                 Messages me=new Messages();
                 me=md.Message.Find(id);
                 md.Remove(me);
                 await md.SaveChangesAsync();
            }
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
            using(ModelsDBContext models=new ModelsDBContext()){
                
                if(searchtext.Equals("")){
                users=models.Users.Skip((currentpageIndex-1)*currentpageSize).Take(currentpageSize).ToList();
                count=models.Users.Count();
                }else{
                    users=models.Users.Where(p=>p.UserName.Equals(searchtext)).ToList();
                    count=models.Users.Where(p=>p.UserName.Equals(searchtext)).Count();
                }
            }
            return Json(new {total=count,rows=users});
        }

    }
}