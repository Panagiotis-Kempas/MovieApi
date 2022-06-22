using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        public IActorRepository Actor { get; }
        public IMovieRepository Movie { get; }
        public IDirectorRepository Director { get; }
        public IPhotoRepository Photo { get;  }
        public IGenreRepository Genre { get; }

        void Save();
    }
}
