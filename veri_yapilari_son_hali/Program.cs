using System;

namespace veri_yapilari_son_hali
{
    class Program
    {
        static void Main(string[] args)
        {
            Json json = new Json();
            Manager manager = new Manager();
            Country turkiye = new Country("Türkiye");
            Country england = new Country("İngiltere");
            Team fenerbahce = new Team("Fenerbahçe");
            Team galatasaray = new Team("Galatasaray");
            Team liverpool = new Team("Liverpool");
            Player cemre = new Player("Cemre", 20);
            Player merve = new Player("Merve", 30);
            Player ahmet = new Player("Ahmet", 25);
            manager.AddTeam2Country(turkiye, fenerbahce);
            manager.AddTeam2Country(turkiye, galatasaray);
            manager.AddPlayer2Team(fenerbahce, cemre);
            manager.AddPlayer2Team(fenerbahce, merve);
            manager.PrintPlayers(fenerbahce);
            json.Write(turkiye.teamsOfCountry, turkiye);
            manager.RemovePlayerFromTeam(fenerbahce, merve);
            manager.AddTeam2Country(england, liverpool);
            manager.AddPlayer2Team(liverpool, ahmet);
            json.Write(england.teamsOfCountry, england);
            json.Write(liverpool.playersOfTeam, liverpool);
            manager.PrintTeams(turkiye);
            json.Write(fenerbahce.playersOfTeam, fenerbahce);
        }
    }
}
