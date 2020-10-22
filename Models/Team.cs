using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_week4_mvc.Models
{
    public class Team
    {
        [Key]
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public List<Player> Players { get; set; }

        public static List<Team> GetTeams()
        {
            List<Team> teams = new List<Team> {
            new Team () {
            TeamName = "Canucks",
            City = "Vancouver",
            Country = "Canada",
            },
            new Team () {
            TeamName = "Oilers",
            City = "Edmonton",
            Country = "Canada",
            },
            new Team () {
            TeamName = "Flames",
            City = "Calgary",
            Country = "Canada",
            },
            new Team () {
            TeamName = "Leafs",
            City = "Toronto",
            Country = "Canada",
            }
        };

            return teams;
        }
    }
}
