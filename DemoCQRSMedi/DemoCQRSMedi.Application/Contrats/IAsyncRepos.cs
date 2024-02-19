using System.Linq.Expressions;

namespace DemoCQRSMedi.Application.Contrats
{

    public interface IAsyncRepos<T> where T : class
    {
        Task<T> AddAsync(T Entity);
        Task<T> GetByIdAsync(Guid Id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task UpDateAsync(T Entity);

        Task DeleteAsync(T Entity);

    }

}
