﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movety.Persistence.DbContexts;

namespace Movety.Persistence.Migrations
{
    [DbContext(typeof(TrainingsDbContext))]
    [Migration("20181226102708_SeedDataTrainingProposals")]
    partial class SeedDataTrainingProposals
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Movety.Persistence.DAO.Athlethe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthdate");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("LastName");

                    b.Property<DateTime?>("Modified");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Athlethes");
                });

            modelBuilder.Entity("Movety.Persistence.DAO.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<DateTime>("Created");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<DateTime?>("Modified");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f155a8b0-6a05-4587-a9f0-bbbd7f67ab36"),
                            Created = new DateTime(2018, 12, 26, 11, 27, 8, 310, DateTimeKind.Local).AddTicks(414),
                            Latitude = 51.107883000000001,
                            Longitude = 13.038538000000001
                        },
                        new
                        {
                            Id = new Guid("e0a7a518-d626-4948-9ef3-efb7070b52c9"),
                            Created = new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(5839),
                            Latitude = 57.107883000000001,
                            Longitude = 20.038537999999999
                        },
                        new
                        {
                            Id = new Guid("08747727-f75f-4656-a4dc-f7640a8b53e0"),
                            Created = new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(5930),
                            Latitude = 88.107883000000001,
                            Longitude = 40.038538000000003
                        });
                });

            modelBuilder.Entity("Movety.Persistence.DAO.SportField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("SportFields");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(7439),
                            Name = "cycling"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(8547),
                            Name = "swimming"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(8580),
                            Name = "climbing"
                        });
                });

            modelBuilder.Entity("Movety.Persistence.DAO.TrainingProposals", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DatetimeFrom");

                    b.Property<DateTime>("DatetimeTo");

                    b.Property<string>("Description");

                    b.Property<Guid>("LocationId");

                    b.Property<int>("MaxParticipants");

                    b.Property<DateTime?>("Modified");

                    b.Property<int>("SportFieldId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("SportFieldId");

                    b.ToTable("TrainingProposals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20519637-f600-461a-b8da-1766481e0538"),
                            Created = new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(9080),
                            DatetimeFrom = new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            DatetimeTo = new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum lorem ipsum",
                            LocationId = new Guid("f155a8b0-6a05-4587-a9f0-bbbd7f67ab36"),
                            MaxParticipants = 4,
                            SportFieldId = 1
                        },
                        new
                        {
                            Id = new Guid("dc0e3dd4-abda-4591-a29b-3bca6e9a6a9f"),
                            Created = new DateTime(2018, 12, 26, 11, 27, 8, 312, DateTimeKind.Local).AddTicks(1530),
                            DatetimeFrom = new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified),
                            DatetimeTo = new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum lorem ipsum2",
                            LocationId = new Guid("e0a7a518-d626-4948-9ef3-efb7070b52c9"),
                            MaxParticipants = 5,
                            SportFieldId = 2
                        });
                });

            modelBuilder.Entity("Movety.Persistence.DAO.TrainingProposalsAcceptance", b =>
                {
                    b.Property<Guid>("TrainingProposalsId");

                    b.Property<Guid>("UserId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime?>("Modified");

                    b.HasKey("TrainingProposalsId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("TrainingProposalsAcceptances");
                });

            modelBuilder.Entity("Movety.Persistence.DAO.TrainingProposalsLikes", b =>
                {
                    b.Property<Guid>("TrainingProposalsId");

                    b.Property<Guid>("UserId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime?>("Modified");

                    b.HasKey("TrainingProposalsId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("TrainingProposalsLikes");
                });

            modelBuilder.Entity("Movety.Persistence.DAO.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Movety.Persistence.DAO.Athlethe", b =>
                {
                    b.HasOne("Movety.Persistence.DAO.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Movety.Persistence.DAO.TrainingProposals", b =>
                {
                    b.HasOne("Movety.Persistence.DAO.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Movety.Persistence.DAO.SportField", "SportField")
                        .WithMany()
                        .HasForeignKey("SportFieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Movety.Persistence.DAO.TrainingProposalsAcceptance", b =>
                {
                    b.HasOne("Movety.Persistence.DAO.TrainingProposals", "TrainingProposals")
                        .WithMany("TrainingProposalsAcceptances")
                        .HasForeignKey("TrainingProposalsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Movety.Persistence.DAO.User", "User")
                        .WithMany("TrainingProposalsAcceptances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Movety.Persistence.DAO.TrainingProposalsLikes", b =>
                {
                    b.HasOne("Movety.Persistence.DAO.TrainingProposals", "TrainingProposals")
                        .WithMany("TrainingProposalsLikes")
                        .HasForeignKey("TrainingProposalsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Movety.Persistence.DAO.User", "User")
                        .WithMany("TrainingProposalsLikes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
