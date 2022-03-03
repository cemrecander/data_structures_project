using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapilari_son_hali
{
    class Country
    {
        public string CountryName { get; set; }
        public Record<Team> teamsOfCountry { get; set; }
        public Country(string countryName)
        {
            CountryName = countryName;
            teamsOfCountry = new Record<Team>();
        }
        public override string ToString()
        {
            return CountryName;
        }
    }
}
