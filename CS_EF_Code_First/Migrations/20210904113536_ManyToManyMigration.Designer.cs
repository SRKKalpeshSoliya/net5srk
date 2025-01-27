﻿// <auto-generated />
using CS_EF_Code_First.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CS_EF_Code_First.Migrations
{
    [DbContext(typeof(SRKLabDbContext))]
    [Migration("20210904113536_ManyToManyMigration")]
    partial class ManyToManyMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CS_EF_Code_First.Models.Category", b =>
                {
                    b.Property<int>("CategoryRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasePrice")
                        .HasColumnType("int");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("CategoryRowId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CS_EF_Code_First.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("CS_EF_Code_First.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("CS_EF_Code_First.Models.Products", b =>
                {
                    b.Property<int>("ProductRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryRowId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ProductRowId");

                    b.HasIndex("CategoryRowId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DoctorPatient", b =>
                {
                    b.Property<int>("DoctorsDoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientsPatientId")
                        .HasColumnType("int");

                    b.HasKey("DoctorsDoctorId", "PatientsPatientId");

                    b.HasIndex("PatientsPatientId");

                    b.ToTable("DoctorsPatients");
                });

            modelBuilder.Entity("CS_EF_Code_First.Models.Products", b =>
                {
                    b.HasOne("CS_EF_Code_First.Models.Category", "Categtory")
                        .WithMany("Products")
                        .HasForeignKey("CategoryRowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categtory");
                });

            modelBuilder.Entity("DoctorPatient", b =>
                {
                    b.HasOne("CS_EF_Code_First.Models.Doctor", null)
                        .WithMany()
                        .HasForeignKey("DoctorsDoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CS_EF_Code_First.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsPatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CS_EF_Code_First.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
