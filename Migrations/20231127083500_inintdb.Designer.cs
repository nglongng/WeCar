﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeCar.Controller;

#nullable disable

namespace WeCar.Migrations
{
    [DbContext(typeof(WeCarDbContext))]
    [Migration("20231127083500_inintdb")]
    partial class inintdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BillService", b =>
                {
                    b.Property<string>("BillsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ServicesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BillsId", "ServicesId");

                    b.HasIndex("ServicesId");

                    b.ToTable("BillService");
                });

            modelBuilder.Entity("WeCar.Controller.Bill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CarId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<string>("ScheduleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeStart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("WeCar.Controller.Car", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FuelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarTypeId");

                    b.HasIndex("FuelId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("WeCar.Controller.CarTypes", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CarTypes");
                });

            modelBuilder.Entity("WeCar.Controller.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WeCar.Controller.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WeCar.Controller.Fuels", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fuels");
                });

            modelBuilder.Entity("WeCar.Controller.Schedule", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("WeCar.Controller.Service", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("BillService", b =>
                {
                    b.HasOne("WeCar.Controller.Bill", null)
                        .WithMany()
                        .HasForeignKey("BillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeCar.Controller.Service", null)
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeCar.Controller.Bill", b =>
                {
                    b.HasOne("WeCar.Controller.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");

                    b.HasOne("WeCar.Controller.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("WeCar.Controller.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("WeCar.Controller.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId");

                    b.Navigation("Car");

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("WeCar.Controller.Car", b =>
                {
                    b.HasOne("WeCar.Controller.CarTypes", "CarType")
                        .WithMany()
                        .HasForeignKey("CarTypeId");

                    b.HasOne("WeCar.Controller.Fuels", "Fuel")
                        .WithMany()
                        .HasForeignKey("FuelId");

                    b.Navigation("CarType");

                    b.Navigation("Fuel");
                });
#pragma warning restore 612, 618
        }
    }
}
