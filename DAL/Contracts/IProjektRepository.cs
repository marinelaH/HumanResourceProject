using System;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    internal interface IProjektRepository:IRepository<Projekt, Guid>
    {
    }
}
