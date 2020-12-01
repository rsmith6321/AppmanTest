﻿// <auto-generated />
using FinalTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalTest.Migrations
{
    [DbContext(typeof(relationContext))]
    [Migration("20201201130158_CreateRelationalDB")]
    partial class CreateRelationalDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FinalTest.Models.EnrollOrder", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "UniversityId");

                    b.HasIndex("UniversityId");

                    b.ToTable("EnrollOrders");
                });

            modelBuilder.Entity("FinalTest.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FinalTest.Models.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("FinalTest.Models.EnrollOrder", b =>
                {
                    b.HasOne("FinalTest.Models.Student", "Student")
                        .WithMany("EnrollOrders")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalTest.Models.University", "University")
                        .WithMany("EnrollOrders")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("University");
                });

            modelBuilder.Entity("FinalTest.Models.Student", b =>
                {
                    b.Navigation("EnrollOrders");
                });

            modelBuilder.Entity("FinalTest.Models.University", b =>
                {
                    b.Navigation("EnrollOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
