﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Wtb.Domain.Demand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("HoursPerWeek")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxRate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinRate")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Demands");
                });

            modelBuilder.Entity("Wtb.Domain.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DemandId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Diploma")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Duur")
                        .HasColumnType("TEXT");

                    b.Property<string>("Omschrijving")
                        .HasColumnType("TEXT");

                    b.Property<string>("Onderwijsinstelling")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titel")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DemandId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Wtb.Domain.Expertise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Expertises");
                });

            modelBuilder.Entity("Wtb.Domain.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dd3adb18-8137-4815-a877-8bd1373c793a"),
                            Address = "Testweg 1",
                            City = "Tuk",
                            OrganizationId = new Guid("516d7328-24bb-4de3-9162-b150aa6726b3"),
                            PostalCode = "8334 RK"
                        },
                        new
                        {
                            Id = new Guid("b1cbab0b-5db0-4fa4-b2a0-7fcdcfb6b8ff"),
                            Address = "Testweg 2",
                            City = "De Basse",
                            OrganizationId = new Guid("516d7328-24bb-4de3-9162-b150aa6726b3"),
                            PostalCode = "8334 RK"
                        });
                });

            modelBuilder.Entity("Wtb.Domain.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Branch")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyType")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfEstablishment")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Phonenumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("516d7328-24bb-4de3-9162-b150aa6726b3"),
                            Branch = "ICT",
                            DateOfEstablishment = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Test Bedrijf",
                            Phonenumber = 121212121
                        },
                        new
                        {
                            Id = new Guid("1c031c4d-c8c5-4a9b-a025-d75f8e9aae9e"),
                            Branch = "HRM",
                            DateOfEstablishment = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Test Bedrijf 2",
                            Phonenumber = 121212121
                        });
                });

            modelBuilder.Entity("Wtb.Domain.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Place")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Wtb.Domain.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DemandId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DemandId");

                    b.HasIndex("PersonId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Wtb.Domain.Demand", b =>
                {
                    b.HasOne("Wtb.Domain.Organization", "Organization")
                        .WithMany("DemandedRequests")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Wtb.Domain.Education", b =>
                {
                    b.HasOne("Wtb.Domain.Demand", "Demand")
                        .WithMany("DemandedEducations")
                        .HasForeignKey("DemandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Demand");
                });

            modelBuilder.Entity("Wtb.Domain.Expertise", b =>
                {
                    b.HasOne("Wtb.Domain.Organization", "Organization")
                        .WithMany("Expertises")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Wtb.Domain.Location", b =>
                {
                    b.HasOne("Wtb.Domain.Organization", "Organization")
                        .WithMany("Locations")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Wtb.Domain.Skill", b =>
                {
                    b.HasOne("Wtb.Domain.Demand", "Demand")
                        .WithMany("DemandedSkills")
                        .HasForeignKey("DemandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Wtb.Domain.Person", "Person")
                        .WithMany("Skills")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Demand");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Wtb.Domain.Demand", b =>
                {
                    b.Navigation("DemandedEducations");

                    b.Navigation("DemandedSkills");
                });

            modelBuilder.Entity("Wtb.Domain.Organization", b =>
                {
                    b.Navigation("DemandedRequests");

                    b.Navigation("Expertises");

                    b.Navigation("Locations");
                });

            modelBuilder.Entity("Wtb.Domain.Person", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
