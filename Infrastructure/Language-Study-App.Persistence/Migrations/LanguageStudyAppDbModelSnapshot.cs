﻿// <auto-generated />
using System;
using Language_Study_App.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Language_Study_App.Persistence.Migrations
{
    [DbContext(typeof(LanguageStudyAppDb))]
    partial class LanguageStudyAppDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Language_Study_App.Domain.Entities.AllEntitie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EnglishAllEntite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishMean")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sentece")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateType")
                        .HasColumnType("int");

                    b.Property<string>("TurkishMean")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AllEntities");
                });

            modelBuilder.Entity("Language_Study_App.Domain.Entities.PV", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EnglishMean")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishPV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sentece")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateType")
                        .HasColumnType("int");

                    b.Property<string>("TurkishMean")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PVs");
                });

            modelBuilder.Entity("Language_Study_App.Domain.Entities.Translate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EnglishMean")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishTranslate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sentece")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateType")
                        .HasColumnType("int");

                    b.Property<string>("TurkishMean")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Translates");
                });

            modelBuilder.Entity("Language_Study_App.Domain.Entities.Word", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EnglishMean")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sentece")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateType")
                        .HasColumnType("int");

                    b.Property<string>("TurkishMean")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Words");
                });
#pragma warning restore 612, 618
        }
    }
}