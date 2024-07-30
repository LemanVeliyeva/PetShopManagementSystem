﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShopManagementSystem.Context;

#nullable disable

namespace PetShopManagementSystem.Migrations
{
    [DbContext(typeof(PetShopContext))]
    [Migration("20240729083642_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetShopManagementSystem.Entities.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OwnerId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("PetShopManagementSystem.Entities.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PetId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("PetId");

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetShopManagementSystem.Entities.PetSpecialization", b =>
                {
                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int");

                    b.HasKey("PetId", "SpecializationId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("PetSpecializations");
                });

            modelBuilder.Entity("PetShopManagementSystem.Entities.Specialization", b =>
                {
                    b.Property<int>("SpecializationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecializationId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecializationId");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("PetShopManagementSystem.Entities.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitId"));

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VisitId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("PetShopManagementSystem.Entities.Pet", b =>
                {
                    b.HasOne("PetShopManagementSystem.Entities.Owner", "Owner")
                        .WithOne("Pet")
                        .HasForeignKey("PetShopManagementSystem.Entities.Pet", "OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("PetShopManagementSystem.Entities.PetSpecialization", b =>
                {
                    b.HasOne("PetShopManagementSystem.Entities.Pet", "Pet")
                        .WithMany("PetsSpecialization")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShopManagementSystem.Entities.Specialization", "Specialization")
                        .WithMany("PetSpecializations")
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("PetShopManagementSystem.Entities.Visit", b =>
                {
                    b.HasOne("PetShopManagementSystem.Entities.Owner", "Owner")
                        .WithMany("Visits")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("PetShopManagementSystem.Entities.Owner", b =>
                {
                    b.Navigation("Pet")
                        .IsRequired();

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("PetShopManagementSystem.Entities.Pet", b =>
                {
                    b.Navigation("PetsSpecialization");
                });

            modelBuilder.Entity("PetShopManagementSystem.Entities.Specialization", b =>
                {
                    b.Navigation("PetSpecializations");
                });
#pragma warning restore 612, 618
        }
    }
}
