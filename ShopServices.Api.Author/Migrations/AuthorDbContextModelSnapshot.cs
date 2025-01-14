﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ShopServices.Api.Author.Persistence;

namespace ShopServices.Api.Author.Migrations
{
    [DbContext(typeof(AuthorDbContext))]
    partial class AuthorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ShopServices.Api.Author.Model.AcademicDegree", b =>
                {
                    b.Property<int>("AcademicDegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AcademicCenter")
                        .HasColumnType("text");

                    b.Property<string>("AcademicDegreeGuid")
                        .HasColumnType("text");

                    b.Property<int>("AuthorBookId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DegreeDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("AcademicDegreeId");

                    b.HasIndex("AuthorBookId");

                    b.ToTable("AcademicDegree");
                });

            modelBuilder.Entity("ShopServices.Api.Author.Model.AuthorBook", b =>
                {
                    b.Property<int>("AuthorBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AuthorBookGuid")
                        .HasColumnType("text");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("AuthorBookId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("ShopServices.Api.Author.Model.AcademicDegree", b =>
                {
                    b.HasOne("ShopServices.Api.Author.Model.AuthorBook", "AuthorBook")
                        .WithMany("AcademicDegreeList")
                        .HasForeignKey("AuthorBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
