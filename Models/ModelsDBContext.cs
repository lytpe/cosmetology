using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace Cosmetology.Models
{
    public class ModelsDBContext:IdentityDbContext<User>{
        public ModelsDBContext(){}
        public ModelsDBContext(DbContextOptions<ModelsDBContext> options) : base(options)
        {
        }
        public DbSet<Messages> Message{get;set;}
        public DbSet<Articles> Article{get;set;}
        public DbSet<ScrollPics> ScrollPic{get;set;}
        public DbSet<Updates> Updates{get;set;}
    }
}