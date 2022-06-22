using Contracts;
using Service.Contracts.Interfaces;

namespace Service.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public PhotoService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
