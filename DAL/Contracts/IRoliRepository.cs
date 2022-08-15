using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IRoliRepository : IRepository<Roli, Guid> {
        Guid getRoleID(string roleName);

    }
}
