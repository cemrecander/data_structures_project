using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapilari_son_hali
{
    class Manager
    {
        public void AddPlayer2Team(Team team, Player player)
        {
            if (team.playersOfTeam.Find(player) == -1)
            {
                team.playersOfTeam.Add(player);
                Console.WriteLine("{0} added to {1} team.\n", player, team);
            }
            else
                Console.WriteLine("This player is already in this team.\n");
        }
        public void AddTeam2Country(Country country, Team team)
        {
            if (country.teamsOfCountry.Find(team) == -1)
            {
                country.teamsOfCountry.Add(team);
                Console.WriteLine("{0} added to {1}\n", team, country);
            }
            else
                Console.WriteLine("This team is already in this country.\n");
        }
        public void RemovePlayerFromTeam(Team team, Player player)
        {
            team.playersOfTeam.Remove(player);
            Console.WriteLine("{0} removed from {1}\n", player, team);
        }
        public void RemoveTeamFromCountry(Country country, Team team)
        {
            country.teamsOfCountry.Remove(team);
            team.playersOfTeam.Clear();
            Console.WriteLine("{0} removed from {1}\n", team, country);
        }
        public void PrintTeams(Country country)
        {
            if (country.teamsOfCountry.Count != 0)
            {
                Console.WriteLine("List of teams of {0}", country);
                foreach (var item in country.teamsOfCountry.GetEnumerator())
                    Console.WriteLine(item);
                Console.WriteLine();
            }
            else
                Console.WriteLine("There are no teams in {0}\n", country);
        }
        public void PrintPlayers(Team team)
        {
            if (team.playersOfTeam.Count != 0)
            {
                Console.WriteLine("List of players of {0}", team);
                foreach (var item in team.playersOfTeam.GetEnumerator())
                    Console.WriteLine(item);
                Console.WriteLine();
            }
            else
                Console.WriteLine("There are no players in {0}\n", team);
        }
    }
}