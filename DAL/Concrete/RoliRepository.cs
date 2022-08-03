using DAL.Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    internal class RoliRepository : BaseRepository<Roli, Guid>, IRoliRepository
    {

        public RoliRepository(HRDB123Context dbContext) : base(dbContext)
        {
        }

        


    }


}
