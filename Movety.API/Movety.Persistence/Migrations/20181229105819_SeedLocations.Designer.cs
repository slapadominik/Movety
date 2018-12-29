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
    [Migration("20181229105819_SeedLocations")]
    partial class SeedLocations
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a34998d-6e11-4ea6-8853-e8fa484b94c1"),
                            Birthdate = new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 803, DateTimeKind.Local).AddTicks(879),
                            Description = "Moje zainteresowania to....",
                            FirstName = "Jan",
                            Gender = "m",
                            LastName = "Kowalski",
                            UserId = new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49")
                        },
                        new
                        {
                            Id = new Guid("ae5331bc-46d4-4b96-b7ff-a57c313539c5"),
                            Birthdate = new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 803, DateTimeKind.Local).AddTicks(3111),
                            Description = "Narty, siatkowka, koszykowka - sport.",
                            FirstName = "Ania",
                            Gender = "m",
                            LastName = "Boruc",
                            UserId = new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266")
                        },
                        new
                        {
                            Id = new Guid("6c87fced-e815-4c49-bb4b-8b250731a575"),
                            Birthdate = new DateTime(1989, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 803, DateTimeKind.Local).AddTicks(3156),
                            Description = "Narty, siatkowka, koszykowka - sport.",
                            FirstName = "Wojciech",
                            Gender = "m",
                            LastName = "Nowak",
                            UserId = new Guid("3a002149-7a55-4b81-943f-d497a606cc77")
                        });
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
                            Id = new Guid("98285577-8523-45fd-b90b-6c0f8fa786b6"),
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 800, DateTimeKind.Local).AddTicks(4680),
                            Latitude = 50.102074999999999,
                            Longitude = 18.509135000000001
                        },
                        new
                        {
                            Id = new Guid("d4512864-0a1b-4a34-92b1-e8d1447f9466"),
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(589),
                            Latitude = 50.094844999999999,
                            Longitude = 18.519753000000001
                        },
                        new
                        {
                            Id = new Guid("2709b89c-4cd0-4037-a1e9-481864e5b603"),
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(684),
                            Latitude = 88.107883000000001,
                            Longitude = 40.038538000000003
                        },
                        new
                        {
                            Id = new Guid("e77a53ba-5e77-4836-9f49-dd49b82a40b1"),
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(704),
                            Latitude = 51.114697,
                            Longitude = 17.046592
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
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(2350),
                            Name = "cycling"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(3626),
                            Name = "swimming"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(3659),
                            Name = "climbing"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(3675),
                            Name = "iceskating"
                        });
                });

            modelBuilder.Entity("Movety.Persistence.DAO.TrainingProposals", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DatetimeFrom");

                    b.Property<DateTime>("DatetimeTo");

                    b.Property<string>("Description");

                    b.Property<Guid>("LocationId");

                    b.Property<int>("MaxParticipants");

                    b.Property<DateTime?>("Modified");

                    b.Property<int>("SportFieldId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("SportFieldId");

                    b.ToTable("TrainingProposals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"),
                            Author = "Jan Kowalski",
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(5021),
                            DatetimeFrom = new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            DatetimeTo = new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum lorem ipsum",
                            LocationId = new Guid("98285577-8523-45fd-b90b-6c0f8fa786b6"),
                            MaxParticipants = 4,
                            SportFieldId = 1,
                            Title = "Rower we Wro!"
                        },
                        new
                        {
                            Id = new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"),
                            Author = "Kamil Jacewicz",
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(7601),
                            DatetimeFrom = new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified),
                            DatetimeTo = new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum lorem ipsum2",
                            LocationId = new Guid("d4512864-0a1b-4a34-92b1-e8d1447f9466"),
                            MaxParticipants = 5,
                            SportFieldId = 2,
                            Title = "Wspinaczka na Tarnogaju"
                        },
                        new
                        {
                            Id = new Guid("2b6bae7d-ab5e-4253-b8dd-3569031da4ae"),
                            Author = "Anna Kowalska",
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(7655),
                            DatetimeFrom = new DateTime(2019, 4, 12, 15, 20, 0, 0, DateTimeKind.Unspecified),
                            DatetimeTo = new DateTime(2019, 4, 12, 17, 20, 0, 0, DateTimeKind.Unspecified),
                            Description = "Zapraszam wszystkich na łyżwy na godzinę 19:30. ",
                            LocationId = new Guid("e77a53ba-5e77-4836-9f49-dd49b82a40b1"),
                            MaxParticipants = 10,
                            SportFieldId = 4,
                            Title = "Łyżwy w Pszowie"
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

                    b.HasData(
                        new
                        {
                            TrainingProposalsId = new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"),
                            UserId = new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TrainingProposalsId = new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"),
                            UserId = new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TrainingProposalsId = new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"),
                            UserId = new Guid("3a002149-7a55-4b81-943f-d497a606cc77"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TrainingProposalsId = new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"),
                            UserId = new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TrainingProposalsId = new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"),
                            UserId = new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TrainingProposalsId = new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"),
                            UserId = new Guid("3a002149-7a55-4b81-943f-d497a606cc77"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49"),
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(8204),
                            Email = "jankowalski@gmail.com",
                            PasswordHash = "asdasdasd123213",
                            SecurityStamp = "asd123",
                            Username = "kowalskijan3"
                        },
                        new
                        {
                            Id = new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266"),
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(9878),
                            Email = "kamilszybki@gmail.com",
                            PasswordHash = "asdasdasd123213",
                            SecurityStamp = "asd123",
                            Username = "kamil91"
                        },
                        new
                        {
                            Id = new Guid("3a002149-7a55-4b81-943f-d497a606cc77"),
                            Created = new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(9915),
                            Email = "jankowalski2@gmail.com",
                            PasswordHash = "asdasdasd123213",
                            SecurityStamp = "asd123",
                            Username = "kowalskijan3"
                        });
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