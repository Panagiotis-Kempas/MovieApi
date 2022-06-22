using Contracts;
using Contracts.Interfaces;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IActorRepository> _actorRepository;
        private readonly Lazy<IMovieRepository> _movieRepository;
        private readonly Lazy<IDirectorRepository> _directorRepository;
        private readonly Lazy<IPhotoRepository> _photoRepository;
        private readonly Lazy<IGenreRepository> _genreRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _actorRepository = new Lazy<IActorRepository>(() => new ActorRepository(repositoryContext));
            _movieRepository = new Lazy<IMovieRepository>(() => new MovieRepository(repositoryContext));
            _directorRepository = new Lazy<IDirectorRepository>(() => new DirectorRepository(repositoryContext));
            _genreRepository = new Lazy<IGenreRepository>(() => new GenreRepository(repositoryContext));
            _photoRepository = new Lazy<IPhotoRepository>(() => new PhotoRepository(repositoryContext));


        }


        public IActorRepository Actor => _actorRepository.Value;
        public IMovieRepository Movie => _movieRepository.Value;
        public IDirectorRepository Director => _directorRepository.Value;
        public IPhotoRepository Photo => _photoRepository.Value;
        public IGenreRepository Genre => _genreRepository.Value;

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
