using System;
namespace Cosmetology.Models{
    //产品内容
    public class Articles{
        public int ID{get;set;}
        public string ArticleName{get;set;}
        public string ArticleSideName{get;set;}
        public string ArticleContext{get;set;}
        public string ArticleCreateDate{get;set;}
        public string ArticleUpdateDate{get;set;}
        public string ArticleImgUrl{get;set;}
        public string UserName{get;set;}
        public string Areas{get;set;}
    }
}