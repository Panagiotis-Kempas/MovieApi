using Contracts;
using Service.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public MovieService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
