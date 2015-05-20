using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInformationApp.Model
{
    public class City
    {
        public int Id { set; get; }
        public string CityName { set; get; }
        public string Upazila { set; get; }
        public string Division { set; get; }
        public string Distric { set; get; }
        public int PostCode { set; get; }
        public string Country { set; get; }

    }
}
