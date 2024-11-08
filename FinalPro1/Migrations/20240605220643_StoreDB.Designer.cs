﻿// <auto-generated />
using System;
using FinalPro1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalPro1.Migrations
{
    [DbContext(typeof(CmsContext))]
    [Migration("20240605220643_StoreDB")]
    partial class StoreDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalPro1.Models.City", b =>
                {
                    b.Property<string>("COU_CODE")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("COU_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("COU_CODE");

                    b.ToTable("TableCOUNTYANDCITYs1111757");
                });

            modelBuilder.Entity("FinalPro1.Models.Discount", b =>
                {
                    b.Property<string>("DIS_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DIS_END")
                        .HasColumnType("datetime2");

                    b.Property<string>("DIS_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DIS_START")
                        .HasColumnType("datetime2");

                    b.HasKey("DIS_ID");

                    b.ToTable("TableDISCOUNTs1111757");
                });

            modelBuilder.Entity("FinalPro1.Models.Member", b =>
                {
                    b.Property<string>("MEM_ACCOUNT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MEM_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEM_NICKNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEM_PASSWORD")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MEM_ACCOUNT");

                    b.ToTable("TableMEMBERSs1111757");
                });

            modelBuilder.Entity("FinalPro1.Models.Store", b =>
                {
                    b.Property<string>("STORE_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("COU_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STORE_ADDRESS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STORE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("STORE_ID");

                    b.ToTable("TableSTOREs1111757");
                });
#pragma warning restore 612, 618
        }
    }
}
