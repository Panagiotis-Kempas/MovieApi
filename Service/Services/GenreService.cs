using Contracts;
using Service.Contracts.Interfaces;

namespace Service.Services
{
    public class GenreService : IGenreService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public GenreService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
