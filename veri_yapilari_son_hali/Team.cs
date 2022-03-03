using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapilari_son_hali
{
    class Team
    {
        public string TeamName { get; set; }
        public Record<Player> playersOfTeam { get; set; }
        public Team() { }
        public Team(string teamName)
        {
            TeamName = teamName;
            playersOfTeam = new Record<Player>();
        }
        public override string ToString()
        {
            return TeamName;
        }
    }
}
