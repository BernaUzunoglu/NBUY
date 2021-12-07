﻿// <auto-generated />
using System;
using KuzeyCodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KuzeyCodeFirst.Migrations
{
    [DbContext(typeof(KuzeyContext))]
    partial class KuzeyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KuzeyCodeFirst.Models.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("KuzeyCodeFirst.Models.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SiparisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UlasmaTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("KuzeyCodeFirst.Models.SiparisDetay", b =>
                {
                    b.Property<int>("SiparisId")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("SiparisId", "UrunId");

                    b.HasIndex("UrunId");

                    b.ToTable("SiparisDetaylari");
                });

            modelBuilder.Entity("KuzeyCodeFirst.Models.Tedarikci", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirmaAdi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Telefon")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tedarikçiler");
                });

            modelBuilder.Entity("KuzeyCodeFirst.Models.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DevamEtmiyor")
                        .HasColumnType("bit");

                    b.Property<decimal>("Fiyat")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KategorId")
                        .HasColumnType("int");

                    b.Property<int>("StokMiktari")
                        .HasColumnType("int");

                    b.Property<Guid?>("TedarikciId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KategorId");

                    b.HasIndex("TedarikciId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("KuzeyCodeFirst.Models.SiparisDetay", b =>
                {
                    b.HasOne("KuzeyCodeFirst.Models.Siparis", "Siparis")
                        .WithMany("SiparisDetaylari")
                        .HasForeignKey("SiparisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KuzeyCodeFirst.Models.Urun", "Urun")
                        .WithMany("SiparisDetaylari")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Siparis");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("KuzeyCodeFirst.Models.Urun", b =>
                {
                    b.HasOne("KuzeyCodeFirst.Models.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KuzeyCodeFirst.Models.Tedarikci", "Tedarikci")
                        .WithMany("Urunler")
                        .HasForeignKey("TedarikciId");

                    b.Navigation("Kategori");

                    b.Navigation("Tedarikci");
                });

            modelBuilder.Entity("KuzeyCodeFirst.Models.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("KuzeyCodeFirst.Models.Siparis", b =>
                {
                    b.Navigation("SiparisDetaylari");
                });

            modelBuilder.Entity("KuzeyCodeFirst.Models.Tedarikci", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("KuzeyCodeFirst.Models.Urun", b =>
                {
                    b.Navigation("SiparisDetaylari");
                });
#pragma warning restore 612, 618
        }
    }
}
