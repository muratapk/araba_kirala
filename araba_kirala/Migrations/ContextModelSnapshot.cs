﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using araba_kirala.Data;

#nullable disable

namespace araba_kirala.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("araba_kirala.Models.Brands", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandID"), 1L, 1);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DailyPrice")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModelYear")
                        .HasColumnType("int");

                    b.HasKey("BrandID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("araba_kirala.Models.Cars", b =>
                {
                    b.Property<int>("CarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarID"), 1L, 1);

                    b.Property<int?>("BrandID")
                        .HasColumnType("int");

                    b.Property<int?>("BrandsBrandID")
                        .HasColumnType("int");

                    b.Property<int?>("ColorID")
                        .HasColumnType("int");

                    b.Property<int?>("ColorsColorID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CarID");

                    b.HasIndex("BrandsBrandID");

                    b.HasIndex("ColorsColorID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("araba_kirala.Models.Colors", b =>
                {
                    b.Property<int>("ColorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorID"), 1L, 1);

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("araba_kirala.Models.Rentals", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CarsID")
                        .HasColumnType("int");

                    b.Property<string>("RentDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReturnDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CarsID");

                    b.HasIndex("UsersUserID");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("araba_kirala.Models.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("araba_kirala.Models.Cars", b =>
                {
                    b.HasOne("araba_kirala.Models.Brands", "Brands")
                        .WithMany("Cars")
                        .HasForeignKey("BrandsBrandID");

                    b.HasOne("araba_kirala.Models.Colors", "Colors")
                        .WithMany("Cars")
                        .HasForeignKey("ColorsColorID");

                    b.Navigation("Brands");

                    b.Navigation("Colors");
                });

            modelBuilder.Entity("araba_kirala.Models.Rentals", b =>
                {
                    b.HasOne("araba_kirala.Models.Cars", "Cars")
                        .WithMany("Rentals")
                        .HasForeignKey("CarsID");

                    b.HasOne("araba_kirala.Models.Users", "Users")
                        .WithMany("Rentals")
                        .HasForeignKey("UsersUserID");

                    b.Navigation("Cars");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("araba_kirala.Models.Brands", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("araba_kirala.Models.Cars", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("araba_kirala.Models.Colors", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("araba_kirala.Models.Users", b =>
                {
                    b.Navigation("Rentals");
                });
#pragma warning restore 612, 618
        }
    }
}
