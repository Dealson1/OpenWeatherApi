﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopTARgv21.Data;

#nullable disable

namespace ShopTARgv21.Data.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20230130072324_RealEstate")]
    partial class RealEstate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopTARgv21.Core.Domain.Car", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BuildOfDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CarWeight")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fuel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfCarDoors")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPassangersWithDriver")
                        .HasColumnType("int");

                    b.Property<string>("NumberOfRegistration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VINCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("ShopTARgv21.Core.Domain.FileToDatabase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SpaceshipId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SpaceshipId");

                    b.ToTable("FileToDatabase");
                });

            modelBuilder.Entity("ShopTARgv21.Core.Domain.RealEstate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("RealEstate");
                });

            modelBuilder.Entity("ShopTARgv21.Core.Domain.Spaceship", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BuildOfDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Crew")
                        .HasColumnType("int");

                    b.Property<int>("EnginePower")
                        .HasColumnType("int");

                    b.Property<DateTime>("LaunchDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LiftUpToSpaceByTonn")
                        .HasColumnType("int");

                    b.Property<string>("ModelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passengers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBuild")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpaceshipBuilder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spaceship");
                });

            modelBuilder.Entity("ShopTARgv21.Core.Domain.FileToDatabase", b =>
                {
                    b.HasOne("ShopTARgv21.Core.Domain.Spaceship", null)
                        .WithMany("FileToDatabases")
                        .HasForeignKey("SpaceshipId");
                });

            modelBuilder.Entity("ShopTARgv21.Core.Domain.Spaceship", b =>
                {
                    b.Navigation("FileToDatabases");
                });
#pragma warning restore 612, 618
        }
    }
}
