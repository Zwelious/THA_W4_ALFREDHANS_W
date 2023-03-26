using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W4_ALFRED_W
{
    internal class Team
    {
        public string teamName { get; set; }
        public string teamCountry { get; set; }
        public string teamCity { get; set; }
        public List<Player> Players = new List<Player>();
        public Team(string teamName, string teamCountry, string teamCity)
        {
            this.teamName = teamName;
            this.teamCountry = teamCountry;
            this.teamCity = teamCity;
        }
    }
}
