using Movety.Persistence.DbContexts;
using Movety.Persistence.Repositories.Interfaces;

namespace Movety.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ILocationRepository Locations { get; }
        public ISportFieldRepository SportFields { get; }
        public ITrainingProposalsRepository TrainingProposals { get; }
        public ITrainingProposalsLikesRepository TrainingProposalsLikes { get; }
        public IAthleteRepository Athletes { get; }
        public ITrainingProposalsAcceptanceRepository Acceptances { get; }

        private readonly TrainingsDbContext _context;

        public UnitOfWork(TrainingsDbContext context)
        {
            _context = context;
            Locations = new LocationRepository(context);
            SportFields = new SportFieldRepository(context);
            TrainingProposals = new TrainingProposalsRepository(context);
            TrainingProposalsLikes = new TrainingProposalsLikesRepository(context);
            Athletes = new AthleteRepository(context);
            Acceptances = new TrainingProposalsAcceptanceRepository(context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}