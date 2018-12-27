using Movety.Persistence.DAO;

namespace Movety.Persistence.Repositories.Interfaces
{
    public interface ISportFieldRepository
    {
        SportField Get(int id);
    }
}