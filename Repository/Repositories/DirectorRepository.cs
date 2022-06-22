using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class DirectorRepository : RepositoryBase<Director>, IDirectorRepository
    {
        public DirectorRepository(RepositoryContext context):base(context)
        {

        }
    }
}
