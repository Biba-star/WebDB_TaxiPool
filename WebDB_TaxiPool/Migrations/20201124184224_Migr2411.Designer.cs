﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebDB_TaxiPool.Data;

namespace WebDB_TaxiPool.Migrations
{
    [DbContext(typeof(WebDB_TaxiPoolContext))]
    [Migration("20201124184224_Migr2411")]
    partial class Migr2411
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AutoStaff", b =>
                {
                    b.Property<long>("AutoID")
                        .HasColumnType("bigint");

                    b.Property<long>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("AutoID", "StaffID");

                    b.HasIndex("StaffID");

                    b.ToTable("AutoStaff");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Auto", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("BrandID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateLastTI")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DriverID")
                        .HasColumnType("bigint");

                    b.Property<string>("EngineNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("MechID")
                        .HasColumnType("bigint");

                    b.Property<long>("Mileage")
                        .HasColumnType("bigint");

                    b.Property<string>("NumberCarBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecMark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("YearOfIssue")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.ToTable("Auto");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Brand", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("Cost")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specificity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Call", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("AutoID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("From")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OperID")
                        .HasColumnType("bigint");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<long?>("RateID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ServiceID")
                        .HasColumnType("bigint");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AutoID");

                    b.HasIndex("OperID");

                    b.HasIndex("RateID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Call");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Position", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Duties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Rate", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("Cost")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Rate");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Service", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("Cost")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<long?>("PositionID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("PositionID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("AutoStaff", b =>
                {
                    b.HasOne("WebDB_TaxiPool.Models.Auto", null)
                        .WithMany()
                        .HasForeignKey("AutoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebDB_TaxiPool.Models.Staff", null)
                        .WithMany()
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Auto", b =>
                {
                    b.HasOne("WebDB_TaxiPool.Models.Brand", "Brand")
                        .WithMany("Auto")
                        .HasForeignKey("BrandID");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Call", b =>
                {
                    b.HasOne("WebDB_TaxiPool.Models.Auto", "Auto")
                        .WithMany("Call")
                        .HasForeignKey("AutoID");

                    b.HasOne("WebDB_TaxiPool.Models.Staff", "Oper")
                        .WithMany("Call")
                        .HasForeignKey("OperID");

                    b.HasOne("WebDB_TaxiPool.Models.Rate", "Rate")
                        .WithMany("Call")
                        .HasForeignKey("RateID");

                    b.HasOne("WebDB_TaxiPool.Models.Service", "Service")
                        .WithMany("Call")
                        .HasForeignKey("ServiceID");

                    b.Navigation("Auto");

                    b.Navigation("Oper");

                    b.Navigation("Rate");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Staff", b =>
                {
                    b.HasOne("WebDB_TaxiPool.Models.Position", "Position")
                        .WithMany("Staff")
                        .HasForeignKey("PositionID");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Auto", b =>
                {
                    b.Navigation("Call");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Brand", b =>
                {
                    b.Navigation("Auto");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Position", b =>
                {
                    b.Navigation("Staff");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Rate", b =>
                {
                    b.Navigation("Call");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Service", b =>
                {
                    b.Navigation("Call");
                });

            modelBuilder.Entity("WebDB_TaxiPool.Models.Staff", b =>
                {
                    b.Navigation("Call");
                });
#pragma warning restore 612, 618
        }
    }
}
