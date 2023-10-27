﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using game_film.DB.Context;

#nullable disable

namespace game_film.DB.Migrations
{
    [DbContext(typeof(GameAndFilmContext))]
    [Migration("20231019162349_UpdateCategoriesTableProp")]
    partial class UpdateCategoriesTableProp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("game_film.DB.Models.Game", b =>
                {
                    b.Property<int>("gameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("gameId"));

                    b.Property<string>("gameCategoryId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gameName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("isActive")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("state")
                        .HasColumnType("tinyint");

                    b.HasKey("gameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("game_film.DB.Models.GameCategory", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoryId"));

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("categoryId");

                    b.ToTable("GameCategories");
                });

            modelBuilder.Entity("game_film.DB.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("isLogin")
                        .HasColumnType("bit");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
