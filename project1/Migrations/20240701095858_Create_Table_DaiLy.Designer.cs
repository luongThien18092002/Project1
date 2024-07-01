﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace project1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240701095858_Create_Table_DaiLy")]
    partial class Create_Table_DaiLy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("project1.Models.HeThongPhanPhoi", b =>
                {
                    b.Property<string>("MaHTPP")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenHTPP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaHTPP");

                    b.ToTable("HeThongPhanPhoi");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("project1.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("Person");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("project1.Models.DaiLy", b =>
                {
                    b.HasBaseType("project1.Models.HeThongPhanPhoi");

                    b.Property<string>("DiaChia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaDaiLy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NguoiDaiDien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenDaiLy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("DaiLy");
                });

            modelBuilder.Entity("project1.Models.Employee", b =>
                {
                    b.HasBaseType("project1.Models.Person");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeeID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("project1.Models.DaiLy", b =>
                {
                    b.HasOne("project1.Models.HeThongPhanPhoi", null)
                        .WithOne()
                        .HasForeignKey("project1.Models.DaiLy", "MaHTPP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("project1.Models.Employee", b =>
                {
                    b.HasOne("project1.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("project1.Models.Employee", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
