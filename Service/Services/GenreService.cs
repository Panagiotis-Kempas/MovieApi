using AutoMapper;
using Contracts;
using Service.Contracts.Interfaces;

namespace Service.Services
{
    public class GenreService : IGenreService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;


        public GenreService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
    }
}
