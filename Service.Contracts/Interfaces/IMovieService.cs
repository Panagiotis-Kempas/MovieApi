using Entities.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieDto>> GetAllMovies(bool trackChanges);
        Task<MovieDto> GetMovie(int movieId,bool trackChanges);
    }
}
