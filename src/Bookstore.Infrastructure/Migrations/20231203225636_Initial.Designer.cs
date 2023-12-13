﻿// <auto-generated />
using System;
using Bookstore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookstore.Infrastructure.Data.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    [Migration("20231203225636_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bookstore.Domain.Entities.v1.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Bookstore.Domain.Entities.v1.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
