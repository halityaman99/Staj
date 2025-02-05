﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using odevproject.Models;

#nullable disable

namespace odevproject.Migrations
{
    [DbContext(typeof(StajContext))]
    [Migration("20240905125818_deneme1")]
    partial class deneme1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("odevproject.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("Kullanici")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("odevproject.Models.Il", b =>
                {
                    b.Property<int>("IlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IlId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlId"));

                    b.Property<string>("IlAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("IlAd");

                    b.HasKey("IlId");

                    b.ToTable("iller", (string)null);
                });

            modelBuilder.Entity("odevproject.Models.Ilce", b =>
                {
                    b.Property<int>("IlceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IlceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlceId"));

                    b.Property<int>("IlId")
                        .HasColumnType("int")
                        .HasColumnName("IlId");

                    b.Property<string>("IlceAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("IlceAd");

                    b.HasKey("IlceId");

                    b.HasIndex("IlId");

                    b.ToTable("ilceler", (string)null);
                });

            modelBuilder.Entity("odevproject.Models.ÖdevTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IlId")
                        .HasColumnType("int");

                    b.Property<int?>("IlceId")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("kullaniciAdi");

                    b.Property<string>("KullaniciSoyadi")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("kullaniciSoyadi");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("TelefonNumarasi")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("telefonNumarasi");

                    b.Property<string>("Yas")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("Yetki")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("yetki");

                    b.HasKey("Id");

                    b.HasIndex("IlId");

                    b.HasIndex("IlceId");

                    b.ToTable("ödev_table", (string)null);
                });

            modelBuilder.Entity("odevproject.Models.Ilce", b =>
                {
                    b.HasOne("odevproject.Models.Il", "Il")
                        .WithMany("Ilceler")
                        .HasForeignKey("IlId")
                        .IsRequired();

                    b.Navigation("Il");
                });

            modelBuilder.Entity("odevproject.Models.ÖdevTable", b =>
                {
                    b.HasOne("odevproject.Models.Il", "Il")
                        .WithMany("ÖdevTables")
                        .HasForeignKey("IlId");

                    b.HasOne("odevproject.Models.Ilce", "Ilce")
                        .WithMany("ÖdevTables")
                        .HasForeignKey("IlceId");

                    b.Navigation("Il");

                    b.Navigation("Ilce");
                });

            modelBuilder.Entity("odevproject.Models.Il", b =>
                {
                    b.Navigation("Ilceler");

                    b.Navigation("ÖdevTables");
                });

            modelBuilder.Entity("odevproject.Models.Ilce", b =>
                {
                    b.Navigation("ÖdevTables");
                });
#pragma warning restore 612, 618
        }
    }
}
