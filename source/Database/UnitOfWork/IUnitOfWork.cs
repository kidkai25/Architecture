using System.Threading.Tasks;

namespace Architecture.Database
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
