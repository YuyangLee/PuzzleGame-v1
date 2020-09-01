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
    [Migration("20200803185610_RenameUTCTimeMigration")]
    partial class RenameUTCTimeMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.7.20365.15");

            modelBuilder.Entity("GZTimeServer.Models.LevelProcess", b =>
                {
                    b.Property<int>("Id")
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

                    b.HasKey("Id");

                    b.ToTable("LevelProcesses");
                });
#pragma warning restore 612, 618
        }
    }
}
