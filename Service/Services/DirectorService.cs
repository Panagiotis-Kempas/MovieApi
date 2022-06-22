using Contracts;
using Service.Contracts.Interfaces;

namespace Service.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public DirectorService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
