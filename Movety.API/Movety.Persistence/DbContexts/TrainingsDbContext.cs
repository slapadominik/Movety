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

            var location1 = Guid.NewGuid();
            var location2 = Guid.NewGuid();
            modelBuilder.Entity<Location>().HasData(new Location{Id = location1, Created = DateTime.Now, Latitude = 51.107883 , Longitude = 13.038538 });
            modelBuilder.Entity<Location>().HasData(new Location { Id = location2, Created = DateTime.Now, Latitude = 57.107883, Longitude = 20.038538 });
            modelBuilder.Entity<Location>().HasData(new Location { Id = Guid.NewGuid(), Created = DateTime.Now, Latitude = 88.107883, Longitude = 40.038538 });

            modelBuilder.Entity<SportField>().HasData(new SportField{Id = 1, Created = DateTime.Now, Name = "cycling"});
            modelBuilder.Entity<SportField>().HasData(new SportField { Id = 2, Created = DateTime.Now, Name = "swimming" });

            modelBuilder.Entity<SportField>().HasData(new SportField { Id = 3, Created = DateTime.Now, Name = "climbing" });

            modelBuilder.Entity<TrainingProposals>().HasData(new TrainingProposals
            {
                Id = Guid.NewGuid(),
                Title = "Rower we Wro!",
                Author = "Jan Kowalski",
                Created = DateTime.Now,
                DatetimeFrom = new DateTime(2019, 5, 3, 8, 20, 0),
                DatetimeTo = new DateTime(2019, 5, 3, 8, 20, 0),
                Description = "Lorem ipsum lorem ipsum",
                SportFieldId = 1,
                MaxParticipants = 4,
                LocationId = location1
            });

            modelBuilder.Entity<TrainingProposals>().HasData(new TrainingProposals
            {
                Id = Guid.NewGuid(),
                Title = "Wspinaczka na Tarnogaju",
                Author = "Kamil Jacewicz",
                Created = DateTime.Now,
                DatetimeFrom = new DateTime(2020, 3, 5, 15, 20, 0),
                DatetimeTo = new DateTime(2020, 3, 5, 17, 20, 0),
                Description = "Lorem ipsum lorem ipsum2",
                SportFieldId = 2,
                MaxParticipants = 5,
                LocationId = location2
            });
        }
    }
}