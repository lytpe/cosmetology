using System;
using Cosmetology.Models;
using System.Linq;
using System.Collections.Generic;
namespace Cosmetology.Services{
    public class HomeServices{
        public static Articles searchArticle(ModelsDBContext db,int id){
            Articles article=new Articles();
            article=db.Article.Find(id);
            return article;
        }
        public static List<Articles> showIndexModel(ModelsDBContext db,string context){
            List<Articles> articles=new List<Articles>();
            articles=db.Article.Where(p=>p.Areas.Equals(context)).ToList();
            return articles;
        }
    }
}