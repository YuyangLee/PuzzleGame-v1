﻿// <auto-generated />
using System;
using GZTimeServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GZTimeServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200825224839_AddRankRepo")]
    partial class AddRankRepo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.7.20365.15");

            modelBuilder.Entity("GZTimeServer.Models.AnimeProcess", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("_0")
                        .HasColumnType("bit");

                    b.Property<bool>("_1")
                        .HasColumnType("bit");

                    b.Property<bool>("_2")
                        .HasColumnType("bit");

                    b.Property<bool>("_3")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("AnimeProcesses");
                });

            modelBuilder.Entity("GZTimeServer.Models.CodeKey", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CodeKeys");
                });

            modelBuilder.Entity("GZTimeServer.Models.LevelProcess", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LevelID")
                        .HasColumnType("int");

                    b.Property<string>("LevelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateTimeUTC")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("LevelProcesses");
                });

            modelBuilder.Entity("GZTimeServer.Models.LiveLike", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("Count")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateTimeUTC")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("LiveLikes");
                });

            modelBuilder.Entity("GZTimeServer.Models.MazeProcess", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("x")
                        .HasColumnType("int");

                    b.Property<int>("y")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("MazeProcesses");
                });

            modelBuilder.Entity("GZTimeServer.Models.Rank", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ranking")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateTimeUTC")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Ranks");
                });
#pragma warning restore 612, 618
        }
    }
}
