using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;


namespace veri_yapilari_son_hali
{
    class Json
    {
        private int counter = 1;
        private int counter1 = 1;
        public void Write(Record<Player> playersOfTeam, Team team)
        {
            string fileName = @".\..\..\players of " + team.TeamName + " " + counter + ".json";
            if (File.Exists(fileName))
            {
                counter += 1;
                fileName = @".\..\..\players of " + team.TeamName + " " + counter + ".json";
            }
            File.WriteAllText((fileName), JsonConvert.SerializeObject(playersOfTeam));
            using (StreamWriter file = File.CreateText(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, playersOfTeam.GetEnumerator());
            }
        }
        public void Write(Record<Team> teamsOfCountry, Country country)
        {
            string fileName = @".\..\..\teams of " + country.CountryName + " " + counter1 + ".json";
            if (File.Exists(fileName))
            {
                counter1 += 1;
                fileName = @".\..\..\teams of " + country.CountryName + " " + counter1 + ".json";
            }
            File.WriteAllText(fileName, JsonConvert.SerializeObject(teamsOfCountry));
            using (StreamWriter file = File.CreateText(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, teamsOfCountry.GetEnumerator());
            }
        }
    }
}
