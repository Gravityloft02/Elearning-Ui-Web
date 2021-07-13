
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPSchoolManagementWeb.Models;

namespace ERPSchoolManagementWeb.Interfaces
{
  public interface ILocation
    {
        Task<bool> AddState(StateModel staterequest);
        Task<IEnumerable<StateModel>> GetStates();

        Task<bool> AddCity(CityModel cityrequest);
        Task<IEnumerable<CityModel>> GetCities(int stateId);
        Task<bool> AddLocality(LocalityModel cityrequest);
        Task<IEnumerable<LocalityModel>> GetLocalities(int cityId);
    }
}
