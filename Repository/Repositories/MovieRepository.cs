using Contracts.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
    {
        public MovieRepository(RepositoryContext context):base(context)
        {

        }

        public async Task<IEnumerable<Movie>> GetAllMovies(bool trackChanges)
        {
            return await  FindAll(trackChanges).OrderBy(m => m.Title).ToListAsync();
        }

        public async Task<Movie> GetMovie(int movieId, bool trackChanges)
        {
            return await FindByCondition(x => x.MovieId.Equals(movieId), trackChanges).SingleOrDefaultAsync();
        }
    }
}
