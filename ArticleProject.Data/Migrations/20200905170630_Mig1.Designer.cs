﻿// <auto-generated />
using ArticleProject.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArticleProject.Data.Migrations
{
    [DbContext(typeof(ArticleProjectContext))]
    [Migration("20200905170630_Mig1")]
    partial class Mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticleProject.Data.Entity.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "Admin",
                            CreatedDate = "09.05.2020 20:06:29",
                            Description = "Yazılıma Dair Her Şey",
                            Title = "Yazılım",
                            UpdatedBy = "Admin",
                            UpdatedDate = "09.05.2020 20:06:29"
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "Admin",
                            CreatedDate = "09.05.2020 20:06:29",
                            Description = "Spora Dair Her Şey",
                            Title = "Spor",
                            UpdatedBy = "Admin",
                            UpdatedDate = "09.05.2020 20:06:29"
                        });
                });

            modelBuilder.Entity("ArticleProject.Data.Entity.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PostID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "Admin",
                            CreatedDate = "09.05.2020 20:06:29",
                            Email = "kadirdinc34@gmail.com",
                            FullName = "Kadir DİNÇ",
                            PostID = 1,
                            UpdatedBy = "Admin",
                            UpdatedDate = "09.05.2020 20:06:29"
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "Admin",
                            CreatedDate = "09.05.2020 20:06:29",
                            Email = "kadirdinc34@gmail.com",
                            FullName = "Kadir DİNÇ",
                            PostID = 3,
                            UpdatedBy = "Admin",
                            UpdatedDate = "09.05.2020 20:06:29"
                        });
                });

            modelBuilder.Entity("ArticleProject.Data.Entity.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PostID");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "Admin",
                            CreatedDate = "09.05.2020 20:06:29",
                            Description = "Yazılım Hayattır",
                            ImageUrl = "../yazilim.jpg",
                            PostID = 1,
                            UpdatedBy = "Admin",
                            UpdatedDate = "09.05.2020 20:06:29"
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "Admin",
                            CreatedDate = "09.05.2020 20:06:29",
                            Description = "DÖRT BÜYÜKLER LOGO",
                            ImageUrl = "../dortBuyukler.jpg",
                            PostID = 3,
                            UpdatedBy = "Admin",
                            UpdatedDate = "09.05.2020 20:06:29"
                        });
                });

            modelBuilder.Entity("ArticleProject.Data.Entity.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            CreatedBy = "Admin",
                            CreatedDate = "09.05.2020 20:06:29",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            Title = "Yazılıma Başlangıç",
                            UpdatedBy = "Admin",
                            UpdatedDate = "09.05.2020 20:06:29"
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 1,
                            CreatedBy = "Admin",
                            CreatedDate = "09.05.2020 20:06:29",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            Title = "Asp.Net Core Başlangıç",
                            UpdatedBy = "Admin",
                            UpdatedDate = "09.05.2020 20:06:29"
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 2,
                            CreatedBy = "Admin",
                            CreatedDate = "09.05.2020 20:06:29",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            Title = "Dört Büyüklerde Transfer Hız Kesmiyor !",
                            UpdatedBy = "Admin",
                            UpdatedDate = "09.05.2020 20:06:29"
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 2,
                            CreatedBy = "Admin",
                            CreatedDate = "09.05.2020 20:06:29",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            Title = "Basketbol Takımımız Avrupa Yolcusu",
                            UpdatedBy = "Admin",
                            UpdatedDate = "09.05.2020 20:06:29"
                        });
                });

            modelBuilder.Entity("ArticleProject.Data.Entity.Comment", b =>
                {
                    b.HasOne("ArticleProject.Data.Entity.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleProject.Data.Entity.Image", b =>
                {
                    b.HasOne("ArticleProject.Data.Entity.Post", "Post")
                        .WithMany("Images")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleProject.Data.Entity.Post", b =>
                {
                    b.HasOne("ArticleProject.Data.Entity.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
