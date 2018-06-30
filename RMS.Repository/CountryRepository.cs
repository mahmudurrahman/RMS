using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Model;

namespace RMS.Repository
{
  public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
      public CountryRepository(DbContext context)
            : base(context)
        {
           
        }
        public Country GetById(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();            
        }
    }
}
