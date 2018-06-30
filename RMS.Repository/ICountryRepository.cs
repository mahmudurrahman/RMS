using System;
using RMS.Model;
namespace RMS.Repository
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Country GetById(int id);
    }
}
