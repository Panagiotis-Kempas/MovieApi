using Contracts;
using Service.Contracts;
using Service.Contracts.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IMovieService> _movieService;
        private readonly Lazy<IDirectorService> _directorService;
        private readonly Lazy<IActorService> _actorService;
        private readonly Lazy<IGenreService> _genreService;
        private readonly Lazy<IPhotoService> _photoService;

        public ServiceManager(IRepositoryManager repositoryManager,ILoggerManager loggerManager)
        {
            _movieService = new Lazy<IMovieService>(() => new MovieService(repositoryManager, loggerManager));
            _actorService = new Lazy<IActorService>(() => new ActorService(repositoryManager, loggerManager));
            _directorService = new Lazy<IDirectorService>(() => new DirectorService(repositoryManager, loggerManager));
            _genreService = new Lazy<IGenreService>(() => new GenreService(repositoryManager, loggerManager));
            _photoService = new Lazy<IPhotoService>(() => new PhotoService(repositoryManager, loggerManager)); 
        }


        public IMovieService MovieService => _movieService.Value;

        public IDirectorService DirectorService => _directorService.Value;

        public IActorService ActorService => _actorService.Value;

        public IGenreService GenreService => _genreService.Value;

        public IPhotoService PhotoService => _photoService.Value;
    }
}
