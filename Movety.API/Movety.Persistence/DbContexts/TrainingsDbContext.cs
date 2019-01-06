using System;
using Microsoft.EntityFrameworkCore;
using Movety.Persistence.DAO;

namespace Movety.Persistence.DbContexts
{
    public class TrainingsDbContext : DbContext
    {
        public DbSet<TrainingProposals> TrainingProposals { get; set; }
        public DbSet<SportField> SportFields { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<TrainingProposalsLikes> TrainingProposalsLikes { get; set; }
        public DbSet<TrainingProposalsAcceptance> TrainingProposalsAcceptances { get; set; }
        public DbSet<Athlethe> Athlethes { get; set; }

        protected TrainingsDbContext()
        {
        }

        public TrainingsDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrainingProposalsLikes>()
                .HasKey(t => new { t.TrainingProposalsId, t.UserId });

            modelBuilder.Entity<TrainingProposalsLikes>()
                .HasOne(pt => pt.TrainingProposals)
                .WithMany(p => p.TrainingProposalsLikes)
                .HasForeignKey(pt => pt.TrainingProposalsId);

            modelBuilder.Entity<TrainingProposalsLikes>()
                .HasOne(pt => pt.User)
                .WithMany(t => t.TrainingProposalsLikes)
                .HasForeignKey(pt => pt.UserId);

            modelBuilder.Entity<TrainingProposalsAcceptance>()
                .HasKey(t => new { t.TrainingProposalsId, t.UserId });

            modelBuilder.Entity<TrainingProposalsAcceptance>()
                .HasOne(pt => pt.TrainingProposals)
                .WithMany(p => p.TrainingProposalsAcceptances)
                .HasForeignKey(pt => pt.TrainingProposalsId);

            modelBuilder.Entity<TrainingProposalsAcceptance>()
                .HasOne(pt => pt.User)
                .WithMany(t => t.TrainingProposalsAcceptances)
                .HasForeignKey(pt => pt.UserId);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var location1 = Guid.NewGuid();
            var location2 = Guid.NewGuid();
            var location3 = Guid.NewGuid();
            var location4 = Guid.NewGuid();
            var location5 = Guid.NewGuid();
            var location6 = Guid.NewGuid();
            var location7 = Guid.NewGuid();

            modelBuilder.Entity<Location>().HasData(new Location { Id = location1, Created = DateTime.Now, Latitude = 50.102075, Longitude = 18.509135 });
            modelBuilder.Entity<Location>().HasData(new Location { Id = location2, Created = DateTime.Now, Latitude = 50.094845, Longitude = 18.519753 });
            modelBuilder.Entity<Location>().HasData(new Location { Id = Guid.NewGuid(), Created = DateTime.Now, Latitude = 88.107883, Longitude = 40.038538 });
            modelBuilder.Entity<Location>().HasData(new Location { Id = location3, Created = DateTime.Now, Latitude = 51.114697, Longitude = 17.046592 });
            modelBuilder.Entity<Location>().HasData(new Location { Id = location4, Created = DateTime.Now, Latitude = 51.087727, Longitude = 17.032026 });
            modelBuilder.Entity<Location>().HasData(new Location { Id = location5, Created = DateTime.Now, Latitude = 51.091599, Longitude = 17.019652 });
            modelBuilder.Entity<Location>().HasData(new Location { Id = location6, Created = DateTime.Now, Latitude = 51.113126, Longitude = 17.069683 });

            modelBuilder.Entity<SportField>().HasData(new SportField { Id = 1, Created = DateTime.Now, Name = "cycling" });
            modelBuilder.Entity<SportField>().HasData(new SportField { Id = 2, Created = DateTime.Now, Name = "swimming" });
            modelBuilder.Entity<SportField>().HasData(new SportField { Id = 3, Created = DateTime.Now, Name = "climbing" });
            modelBuilder.Entity<SportField>().HasData(new SportField { Id = 4, Created = DateTime.Now, Name = "iceskating" });

            var userId1 = Guid.NewGuid();
            var userId2 = Guid.NewGuid();
            var userId3 = Guid.NewGuid();
            var userId4 = Guid.Parse("38e88f51-a4bd-4163-be6e-cdaad099ba10");

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = userId1,
                Created = DateTime.Now,
                Email = "jankowalski@gmail.com",
                PasswordHash = "asdasdasd123213",
                SecurityStamp = "asd123",
                Username = "kowalskijan3"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = userId2,
                Created = DateTime.Now,
                Email = "kamilszybki@gmail.com",
                PasswordHash = "asdasdasd123213",
                SecurityStamp = "asd123",
                Username = "kamil91"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = userId3,
                Created = DateTime.Now,
                Email = "jankowalski2@gmail.com",
                PasswordHash = "asdasdasd123213",
                SecurityStamp = "asd123",
                Username = "kowalskijan3"
            });


            modelBuilder.Entity<User>().HasData(new User
            {
                Id = userId4,
                Created = DateTime.Now,
                Email = "jankowalski2@gmail.com",
                PasswordHash = "asdasdasd123213",
                SecurityStamp = "asd123",
                Username = "kowalskijan2"
            });

            modelBuilder.Entity<Athlethe>().HasData(
                new Athlethe
                {
                    Id = Guid.NewGuid(),
                    UserId = userId1,
                    Created = DateTime.Now,
                    Birthdate = new DateTime(2002, 4, 12),
                    Description = "Moje zainteresowania to....",
                    Gender = 'm',
                    FirstName = "Jan",
                    LastName = "Kowalski"
                });

            modelBuilder.Entity<Athlethe>().HasData(
                new Athlethe
                {
                    Id = Guid.NewGuid(),
                    UserId = userId2,
                    Created = DateTime.Now,
                    Birthdate = new DateTime(1985, 11, 21),
                    Description = "Narty, siatkowka, koszykowka - sport.",
                    Gender = 'm',
                    FirstName = "Ania",
                    LastName = "Boruc"
                });

            modelBuilder.Entity<Athlethe>().HasData(
                new Athlethe
                {
                    Id = Guid.NewGuid(),
                    UserId = userId3,
                    Created = DateTime.Now,
                    Birthdate = new DateTime(1989, 11, 11),
                    Description = "Narty, siatkowka, koszykowka - sport.",
                    Gender = 'm',
                    FirstName = "Wojciech",
                    LastName = "Nowak"
                });

            modelBuilder.Entity<Athlethe>().HasData(
                new Athlethe
                {
                    Id = Guid.NewGuid(),
                    UserId = userId4,
                    Created = DateTime.Now,
                    Birthdate = new DateTime(1993, 11, 11),
                    Description = "Narty, siatkowka, koszykowka - sport.",
                    Gender = 'm',
                    FirstName = "Damian",
                    LastName = "Nowak"
                });


            var trainingProposalId1 = Guid.NewGuid();
            var trainingProposalId2 = Guid.NewGuid();

            modelBuilder.Entity<TrainingProposals>().HasData(new TrainingProposals
            {
                Id = trainingProposalId1,
                Title = "Rower we Wro!",
                AuthorId = userId4,
                Created = DateTime.Now,
                DatetimeFrom = new DateTime(2019, 5, 3, 8, 20, 0),
                DatetimeTo = new DateTime(2019, 5, 3, 8, 20, 0),
                Description = "Lorem ipsum lorem ipsum",
                SportFieldId = 1,
                MaxParticipants = 4,
                LocationId = location6
            });

            modelBuilder.Entity<TrainingProposals>().HasData(new TrainingProposals
            {
                Id = trainingProposalId2,
                Title = "Wspinaczka na Tarnogaju",
                AuthorId = userId4,
                Created = DateTime.Now,
                DatetimeFrom = new DateTime(2020, 3, 5, 15, 20, 0),
                DatetimeTo = new DateTime(2020, 3, 5, 17, 20, 0),
                Description = "Lorem ipsum lorem ipsum2",
                SportFieldId = 2,
                MaxParticipants = 5,
                LocationId = location5
            });

            modelBuilder.Entity<TrainingProposals>().HasData(new TrainingProposals
            {
                Id = Guid.NewGuid(),
                Title = "Łyżwy w Pszowie",
                AuthorId = userId1,
                Created = DateTime.Now,
                DatetimeFrom = new DateTime(2019, 4, 12, 15, 20, 0),
                DatetimeTo = new DateTime(2019, 4, 12, 17, 20, 0),
                Description = "Zapraszam wszystkich na łyżwy na godzinę 19:30. ",
                SportFieldId = 4,
                MaxParticipants = 10,
                LocationId = location3
            });

            modelBuilder.Entity<TrainingProposals>().HasData(new TrainingProposals
            {
                Id = Guid.NewGuid(),
                Title = "Rolki na rampie",
                AuthorId = userId2,
                Created = DateTime.Now,
                DatetimeFrom = new DateTime(2019, 5, 3, 8, 20, 0),
                DatetimeTo = new DateTime(2019, 5, 3, 8, 20, 0),
                Description = "Lorem ipsum lorem ipsum",
                SportFieldId = 1,
                MaxParticipants = 6,
                LocationId = location4
            });

            modelBuilder.Entity<TrainingProposalsLikes>().HasData(
                new TrainingProposalsLikes { TrainingProposalsId = trainingProposalId1, UserId = userId1 });
            modelBuilder.Entity<TrainingProposalsLikes>().HasData(
                new TrainingProposalsLikes { TrainingProposalsId = trainingProposalId1, UserId = userId2 });
            modelBuilder.Entity<TrainingProposalsLikes>().HasData(
                new TrainingProposalsLikes { TrainingProposalsId = trainingProposalId1, UserId = userId3 });

            modelBuilder.Entity<TrainingProposalsLikes>().HasData(
                new TrainingProposalsLikes { TrainingProposalsId = trainingProposalId2, UserId = userId1 });
            modelBuilder.Entity<TrainingProposalsLikes>().HasData(
                new TrainingProposalsLikes { TrainingProposalsId = trainingProposalId2, UserId = userId2 });
            modelBuilder.Entity<TrainingProposalsLikes>().HasData(
                new TrainingProposalsLikes { TrainingProposalsId = trainingProposalId2, UserId = userId3 });
        }
    }
}