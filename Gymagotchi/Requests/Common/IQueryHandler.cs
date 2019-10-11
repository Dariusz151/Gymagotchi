using System.Threading.Tasks;

namespace Gymagotchi.Requests.Common
{
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
    }

    public interface IQueryHandler
    {

    }
}
