﻿// <auto-generated />
using BookCatelog.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookApp.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20220818161900_FifthMigration")]
    partial class FifthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("BookApp.Model.BookModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("bookAuthor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("bookTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("categoryname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("subcategoryname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("BookModel");
                });
#pragma warning restore 612, 618
        }
    }
}
