﻿// <auto-generated />
using CarsManagementApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarsManagementApp.Migrations
{
    [DbContext(typeof(CarsManagementAppContext))]
    [Migration("20241031095834_InitialMig2")]
    partial class InitialMig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("CarsManagementApp.Model.Cars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Car_Model")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Car_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Car_Owner_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Car_Plate_Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
