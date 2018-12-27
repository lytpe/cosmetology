using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace Cosmetology.Models
{
    public class ModelsDBContext:IdentityDbContext<Users>{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=Cosmetology.db");
        }
        public DbSet<Messages> Message{get;set;}
        public DbSet<Articles> Article{get;set;}
        public DbSet<Movies> Movie{get;set;}
        public DbSet<ScrollPics> ScrollPic{get;set;}
        public DbSet<Features> Feature{get;set;}
        public DbSet<Updates> Updates{get;set;}
    }
}