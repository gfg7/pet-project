using Map.Domain.Contracts.Database;

namespace Map.Domain.Database.Repository
{
    public abstract class BaseRepository
    {
        protected readonly IExecuteService _executeService;
        public BaseRepository(IExecuteService executeService)
        {
            _executeService = executeService;
        }
    }
}