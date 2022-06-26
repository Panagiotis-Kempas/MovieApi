using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts.Interfaces;
using Shared.DataTransferObjects;
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
        private readonly IMapper _mapper;

        public MovieService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MovieDto>> GetAllMovies(bool trackChanges)
        {
                var movies = await _repository.Movie.GetAllMovies(trackChanges);
                var moviesDto = _mapper.Map<IEnumerable<MovieDto>>(movies);

                return moviesDto;                        
        }

        public async Task<MovieDto> GetMovie(int movieId, bool trackChanges)
        {
            var movie =await  _repository.Movie.GetMovie(movieId, trackChanges);
           var movieDto = _mapper.Map<MovieDto>(movie);
            return movieDto;
        }
    }
}
