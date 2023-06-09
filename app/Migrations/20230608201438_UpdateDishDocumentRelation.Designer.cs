﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app.Domain;

#nullable disable

namespace app.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230608201438_UpdateDishDocumentRelation")]
    partial class UpdateDishDocumentRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("app.Models.Domain.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("app.Models.Domain.DishDocumentRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountDish")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("DocumentDishId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.HasIndex("DocumentDishId");

                    b.ToTable("DishDocumentRelations");
                });

            modelBuilder.Entity("app.Models.Domain.DishOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("DishOrders");
                });

            modelBuilder.Entity("app.Models.Domain.DocumentDish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("app.Models.Domain.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KindId")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("KindId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("app.Models.Domain.IngredientKind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IngredientKinds");
                });

            modelBuilder.Entity("app.Models.Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("app.Models.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DishDishOrder", b =>
                {
                    b.Property<int>("DishOrdersId")
                        .HasColumnType("int");

                    b.Property<int>("DishesId")
                        .HasColumnType("int");

                    b.HasKey("DishOrdersId", "DishesId");

                    b.HasIndex("DishesId");

                    b.ToTable("DishDishOrder");
                });

            modelBuilder.Entity("DishIngredient", b =>
                {
                    b.Property<int>("DishesId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.HasKey("DishesId", "IngredientsId");

                    b.HasIndex("IngredientsId");

                    b.ToTable("DishIngredient");
                });

            modelBuilder.Entity("DishOrderOrder", b =>
                {
                    b.Property<int>("DishOrdersId")
                        .HasColumnType("int");

                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.HasKey("DishOrdersId", "OrdersId");

                    b.HasIndex("OrdersId");

                    b.ToTable("DishOrderOrder");
                });

            modelBuilder.Entity("app.Models.Domain.Dish", b =>
                {
                    b.HasOne("app.Models.Domain.User", "User")
                        .WithMany("Dishes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("app.Models.Domain.DishDocumentRelation", b =>
                {
                    b.HasOne("app.Models.Domain.Dish", "Dish")
                        .WithMany("DishDocumentRelations")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.Models.Domain.DocumentDish", "DocumentDish")
                        .WithMany("DishDocumentRelations")
                        .HasForeignKey("DocumentDishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("DocumentDish");
                });

            modelBuilder.Entity("app.Models.Domain.Ingredient", b =>
                {
                    b.HasOne("app.Models.Domain.IngredientKind", "Kind")
                        .WithMany("Ingredients")
                        .HasForeignKey("KindId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kind");
                });

            modelBuilder.Entity("app.Models.Domain.Order", b =>
                {
                    b.HasOne("app.Models.Domain.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DishDishOrder", b =>
                {
                    b.HasOne("app.Models.Domain.DishOrder", null)
                        .WithMany()
                        .HasForeignKey("DishOrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.Models.Domain.Dish", null)
                        .WithMany()
                        .HasForeignKey("DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DishIngredient", b =>
                {
                    b.HasOne("app.Models.Domain.Dish", null)
                        .WithMany()
                        .HasForeignKey("DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.Models.Domain.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DishOrderOrder", b =>
                {
                    b.HasOne("app.Models.Domain.DishOrder", null)
                        .WithMany()
                        .HasForeignKey("DishOrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.Models.Domain.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("app.Models.Domain.Dish", b =>
                {
                    b.Navigation("DishDocumentRelations");
                });

            modelBuilder.Entity("app.Models.Domain.DocumentDish", b =>
                {
                    b.Navigation("DishDocumentRelations");
                });

            modelBuilder.Entity("app.Models.Domain.IngredientKind", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("app.Models.Domain.User", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
