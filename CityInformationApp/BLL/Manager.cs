using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityInformationApp.DAL;
using CityInformationApp.Model;

namespace CityInformationApp.BLL
{
    class Manager
    {
        private Getaway getaway = new Getaway();
        public string Save(City aCity)
        {
            if (aCity.CityName.Length>3)
            {
                if (IsCityNameExitst(aCity.CityName))
                {
                    return "City name already exitst!";
                }
                else
                {
                    if (getaway.Save(aCity) > 0)
                    {
                        return "Data Successfully Inserted!";
                    }
                    else
                    {
                        return "Insertion Failed!";
                    }
                }
                
            }
            else
            {
                return "City name at least 4 character!";
            }
            
        }

        public String Update(City aCity,int id)
        {
            if (getaway.Update(aCity, id)>0)
            {
                return "Update successfull!";

            }
            else
            {
                return "Update Failed!";
            }
        }
        public List<City> Show()
        {
            return getaway.GetAllData();
        }

        public bool IsCityNameExitst(string name)
        {
            List<City> cityLis = getaway.GetAllData();
            bool isCityNameExitst = false;
            foreach (var city in cityLis)
            {
                if (city.CityName==name)
                {
                    isCityNameExitst = true;
                }
            }

            return isCityNameExitst;
        }
        public List<City> Search(string search,string value)
        {
            return getaway.SearchData(search, value);
        }

        public City GetCityById(int id)
        {
            return  getaway.GetCityById(id);
        }
    }
}
