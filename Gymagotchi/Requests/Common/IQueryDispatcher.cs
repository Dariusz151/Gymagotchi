using System.Threading.Tasks;

namespace Gymagotchi.Requests.Common
{
    public interface IQueryDispatcher
    {
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}
