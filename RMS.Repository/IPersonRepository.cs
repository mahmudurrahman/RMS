using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Model;

namespace RMS.Repository
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        Person GetById(long id);
    }
}
