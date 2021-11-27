﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using db2WebApplication.Models;

namespace db2WebApplication.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20211025024507_meritnewdb")]
    partial class meritnewdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("db2WebApplication.Models.Author", b =>
                {
                    b.Property<int>("authorid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bookid")
                        .HasColumnType("int");

                    b.Property<string>("authorname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pubyear")
                        .HasColumnType("int");

                    b.HasKey("authorid");

                    b.HasIndex("Bookid");

                    b.ToTable("authors");

                    b.HasData(
                        new
                        {
                            authorid = 11,
                            Bookid = 1,
                            authorname = "aaaa",
                            pubyear = 2018
                        },
                        new
                        {
                            authorid = 12,
                            Bookid = 2,
                            authorname = "bbb",
                            pubyear = 2020
                        },
                        new
                        {
                            authorid = 13,
                            Bookid = 3,
                            authorname = "cccc",
                            pubyear = 2021
                        },
                        new
                        {
                            authorid = 14,
                            Bookid = 2,
                            authorname = "dfdfd",
                            pubyear = 2018
                        });
                });

            modelBuilder.Entity("db2WebApplication.Models.Book", b =>
                {
                    b.Property<int>("bookid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("bookid1")
                        .HasColumnType("int");

                    b.Property<string>("bookname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("bookid");

                    b.HasIndex("bookid1");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            bookid = 1,
                            bookname = "asdsfsd"
                        },
                        new
                        {
                            bookid = 2,
                            bookname = "hjkhjh"
                        },
                        new
                        {
                            bookid = 3,
                            bookname = "jhuyuu"
                        });
                });

            modelBuilder.Entity("db2WebApplication.Models.Author", b =>
                {
                    b.HasOne("db2WebApplication.Models.Book", "books")
                        .WithMany()
                        .HasForeignKey("Bookid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("books");
                });

            modelBuilder.Entity("db2WebApplication.Models.Book", b =>
                {
                    b.HasOne("db2WebApplication.Models.Book", null)
                        .WithMany("books")
                        .HasForeignKey("bookid1");
                });

            modelBuilder.Entity("db2WebApplication.Models.Book", b =>
                {
                    b.Navigation("books");
                });
#pragma warning restore 612, 618
        }
    }
}