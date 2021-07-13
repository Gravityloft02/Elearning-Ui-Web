using ERPSchoolManagementWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ERPSchoolManagementWeb.Interfaces;
using ERPSchoolManagementWeb.Models;

namespace ERPSchoolManagementWeb.Services
{
    public class LocationService : BaseService, ILocation
    {
        public async Task<bool> AddCity(CityModel cityrequest)
        {
            var res = await ServiceCallAsync<CityModel>("api/Location/City/Add", null, null);
            //return result;
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> AddLocality(LocalityModel localityrequest)
        {

            var res = await ServiceCallAsync<LocalityModel>("api/Location/Locality/Add", null, null);
            //return result;
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> AddState(StateModel staterequest)
        {
            var res = await ServiceCallAsync<StateModel>("api/Location/State/Add", null, null);
            //return result;
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<IEnumerable<CityModel>> GetCities(int stateId)
        {
            var cities = await ServiceCallAsync<List<CityModel>>("api/Location/Cities", stateId);
            return cities;
        }

        public async Task<IEnumerable<LocalityModel>> GetLocalities(int cityId)
        {
            var localities = await ServiceCallAsync<List<LocalityModel>>("api/Location/Localities", cityId);
            return localities;
        }

        public async Task<IEnumerable<StateModel>> GetStates()
        {
            var states = await ServiceCallAsync<List<StateModel>>("api/Location/States", "");
            return states;
        }
    }
}