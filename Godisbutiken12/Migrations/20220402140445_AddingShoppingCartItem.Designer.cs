﻿// <auto-generated />
using System;
using Godisbutiken12.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Godisbutiken12.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220402140445_AddingShoppingCartItem")]
    partial class AddingShoppingCartItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Godisbutiken12.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Soft Candy"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Hard Candy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Fruit Candy"
                        });
                });

            modelBuilder.Entity("Godisbutiken12.Models.Godis", b =>
                {
                    b.Property<int>("GodisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("GodisID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Godisar");

                    b.HasData(
                        new
                        {
                            GodisID = 1,
                            CategoryId = 1,
                            Description = "Bästa godis!",
                            ImageThumbnailUrl = "\\images\\thumbnails\\Thumbnailsoftcandy.jpg",
                            ImageUrl = "\\images\\Softcandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Soft Candy",
                            Price = 5
                        },
                        new
                        {
                            GodisID = 2,
                            CategoryId = 2,
                            Description = "Bästa godis!",
                            ImageThumbnailUrl = "\\images\\thumbnails\\Hardcandythumbnail.jpg",
                            ImageUrl = "\\images\\Hardcandybild.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Hard Candy",
                            Price = 3
                        },
                        new
                        {
                            GodisID = 3,
                            CategoryId = 3,
                            Description = "Bästa godis!",
                            ImageThumbnailUrl = "\\images\\thumbnails\\fruitcandythumbnail.jpg",
                            ImageUrl = "\\images\\fruitcandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Fruit Candy",
                            Price = 4
                        });
                });

            modelBuilder.Entity("Godisbutiken12.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("GodisID")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("GodisID");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Godisbutiken12.Models.Godis", b =>
                {
                    b.HasOne("Godisbutiken12.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Godisbutiken12.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Godisbutiken12.Models.Godis", "Godis")
                        .WithMany()
                        .HasForeignKey("GodisID");
                });
#pragma warning restore 612, 618
        }
    }
}
