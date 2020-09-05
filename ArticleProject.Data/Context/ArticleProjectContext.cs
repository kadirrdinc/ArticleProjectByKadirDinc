using ArticleProject.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Data.Context
{
    public class ArticleProjectContext : DbContext
    {
        public ArticleProjectContext(DbContextOptions<ArticleProjectContext> options) : base(options) { }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(new Post
            {
                ID = 1,
                Title = "Yazılıma Başlangıç",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                CategoryID = 1
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                ID = 2,
                Title = "Asp.Net Core Başlangıç",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                CategoryID = 1
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                ID = 3,
                Title = "Dört Büyüklerde Transfer Hız Kesmiyor !",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                CategoryID = 2
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                ID = 4,
                Title = "Basketbol Takımımız Avrupa Yolcusu",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                CategoryID = 2
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                ID = 1,
                Title = "Yazılım",
                Description = "Yazılıma Dair Her Şey"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                ID = 2,
                Title = "Spor",
                Description = "Spora Dair Her Şey"
            });

            modelBuilder.Entity<Comment>().HasData(new Comment
            {
                ID = 1,
                FullName = "Kadir DİNÇ",
                Email = "kadirdinc34@gmail.com",
                PostID = 1
            });

            modelBuilder.Entity<Comment>().HasData(new Comment
            {
                ID = 2,
                FullName = "Kadir DİNÇ",
                Email = "kadirdinc34@gmail.com",
                PostID = 3
            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                ID = 1,
                ImageUrl = "../yazilim.jpg",
                Description = "Yazılım Hayattır",
                PostID = 1

            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                ID = 2,
                ImageUrl = "../dortBuyukler.jpg",
                Description = "DÖRT BÜYÜKLER LOGO",
                PostID = 3
            });
        }
    }
}
