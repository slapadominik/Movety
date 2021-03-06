﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movety.Persistence.DbContexts;

namespace Movety.Persistence.Migrations
{
    [DbContext(typeof(TrainingsDbContext))]
    partial class TrainingsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("1231b8b0-f42b-4440-912b-f108fc1d7e5e"),
                            Birthdate = new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(9361),
                            Description = "Moje zainteresowania to....",
                            FirstName = "Jan",
                            Gender = "m",
                            LastName = "Kowalski",
                            UserId = new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c")
                        },
                        new
                        {
                            Id = new Guid("92a068dc-8842-4bf4-9dcd-5dbcfc42f719"),
                            Birthdate = new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(1589),
                            Description = "Narty, siatkowka, koszykowka - sport.",
                            FirstName = "Ania",
                            Gender = "m",
                            LastName = "Boruc",
                            UserId = new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375")
                        },
                        new
                        {
                            Id = new Guid("72ab8ea9-f8c8-4767-806f-99d728d37714"),
                            Birthdate = new DateTime(1989, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(1638),
                            Description = "Narty, siatkowka, koszykowka - sport.",
                            FirstName = "Wojciech",
                            Gender = "m",
                            LastName = "Nowak",
                            UserId = new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b")
                        },
                        new
                        {
                            Id = new Guid("a0ffa806-c3fa-4f45-8147-7f9c6331c2f9"),
                            Birthdate = new DateTime(1993, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(1671),
                            Description = "Narty, siatkowka, koszykowka - sport.",
                            FirstName = "Damian",
                            Gender = "m",
                            LastName = "Nowak",
                            UserId = new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10")
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
                            Id = new Guid("37d767e0-4c4b-44b0-809d-8ae89235f5fb"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 520, DateTimeKind.Local).AddTicks(3949),
                            Latitude = 50.102074999999999,
                            Longitude = 18.509135000000001
                        },
                        new
                        {
                            Id = new Guid("26bd2c52-f77d-419a-81a6-ed6e65992536"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1176),
                            Latitude = 50.094844999999999,
                            Longitude = 18.519753000000001
                        },
                        new
                        {
                            Id = new Guid("f7bf4ad4-530f-43b0-bfb4-fcc99bc97ebf"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1275),
                            Latitude = 88.107883000000001,
                            Longitude = 40.038538000000003
                        },
                        new
                        {
                            Id = new Guid("80b4ed41-79ef-433b-97cc-ded5bec5f174"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1345),
                            Latitude = 51.114697,
                            Longitude = 17.046592
                        },
                        new
                        {
                            Id = new Guid("0c2c96f5-1a13-4526-a505-201387307d7a"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1365),
                            Latitude = 51.087727000000001,
                            Longitude = 17.032025999999998
                        },
                        new
                        {
                            Id = new Guid("9e9bf630-d669-4cf0-b242-a1d5ea2a2441"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1386),
                            Latitude = 51.091599000000002,
                            Longitude = 17.019652000000001
                        },
                        new
                        {
                            Id = new Guid("d7a4da39-aae0-4979-a89d-4623936d9349"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1402),
                            Latitude = 51.113126000000001,
                            Longitude = 17.069683000000001
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
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(3064),
                            Name = "cycling"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(5254),
                            Name = "swimming"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(5295),
                            Name = "climbing"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(5312),
                            Name = "iceskating"
                        });
                });

            modelBuilder.Entity("Movety.Persistence.DAO.TrainingProposals", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AuthorId");

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

                    b.HasIndex("AuthorId");

                    b.HasIndex("LocationId");

                    b.HasIndex("SportFieldId");

                    b.ToTable("TrainingProposals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"),
                            AuthorId = new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(5773),
                            DatetimeFrom = new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            DatetimeTo = new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum lorem ipsum",
                            LocationId = new Guid("d7a4da39-aae0-4979-a89d-4623936d9349"),
                            MaxParticipants = 4,
                            SportFieldId = 1,
                            Title = "Rower we Wro!"
                        },
                        new
                        {
                            Id = new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"),
                            AuthorId = new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(8481),
                            DatetimeFrom = new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified),
                            DatetimeTo = new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum lorem ipsum2",
                            LocationId = new Guid("9e9bf630-d669-4cf0-b242-a1d5ea2a2441"),
                            MaxParticipants = 5,
                            SportFieldId = 2,
                            Title = "Wspinaczka na Tarnogaju"
                        },
                        new
                        {
                            Id = new Guid("1595b442-49b7-4548-98da-8ef656d733fb"),
                            AuthorId = new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(8543),
                            DatetimeFrom = new DateTime(2019, 4, 12, 15, 20, 0, 0, DateTimeKind.Unspecified),
                            DatetimeTo = new DateTime(2019, 4, 12, 17, 20, 0, 0, DateTimeKind.Unspecified),
                            Description = "Zapraszam wszystkich na łyżwy na godzinę 19:30. ",
                            LocationId = new Guid("80b4ed41-79ef-433b-97cc-ded5bec5f174"),
                            MaxParticipants = 10,
                            SportFieldId = 4,
                            Title = "Łyżwy w Pszowie"
                        },
                        new
                        {
                            Id = new Guid("4fd3bbd8-7644-4984-9226-e185bb52839c"),
                            AuthorId = new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(8567),
                            DatetimeFrom = new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            DatetimeTo = new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum lorem ipsum",
                            LocationId = new Guid("0c2c96f5-1a13-4526-a505-201387307d7a"),
                            MaxParticipants = 6,
                            SportFieldId = 1,
                            Title = "Rolki na rampie"
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
                            TrainingProposalsId = new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"),
                            UserId = new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TrainingProposalsId = new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"),
                            UserId = new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TrainingProposalsId = new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"),
                            UserId = new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TrainingProposalsId = new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"),
                            UserId = new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TrainingProposalsId = new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"),
                            UserId = new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TrainingProposalsId = new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"),
                            UserId = new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b"),
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
                            Id = new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(6137),
                            Email = "jankowalski@gmail.com",
                            PasswordHash = "asdasdasd123213",
                            SecurityStamp = "asd123",
                            Username = "kowalskijan3"
                        },
                        new
                        {
                            Id = new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(8122),
                            Email = "kamilszybki@gmail.com",
                            PasswordHash = "asdasdasd123213",
                            SecurityStamp = "asd123",
                            Username = "kamil91"
                        },
                        new
                        {
                            Id = new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(8163),
                            Email = "jankowalski2@gmail.com",
                            PasswordHash = "asdasdasd123213",
                            SecurityStamp = "asd123",
                            Username = "kowalskijan3"
                        },
                        new
                        {
                            Id = new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10"),
                            Created = new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(8184),
                            Email = "jankowalski2@gmail.com",
                            PasswordHash = "asdasdasd123213",
                            SecurityStamp = "asd123",
                            Username = "kowalskijan2"
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
                    b.HasOne("Movety.Persistence.DAO.User", "User")
                        .WithMany()
                        .HasForeignKey("AuthorId");

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
