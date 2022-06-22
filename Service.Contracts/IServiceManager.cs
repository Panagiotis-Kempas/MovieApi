using Service.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        public IMovieService MovieService { get;  }
        public IDirectorService DirectorService { get;  }
        public IActorService ActorService { get;  }
        public IGenreService GenreService { get;  }
        public IPhotoService PhotoService { get;  }
    }
}
