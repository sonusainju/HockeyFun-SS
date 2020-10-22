using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_week4_mvc.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public string TeamName { get; set; }
    
        [ForeignKey("TeamName")]
        public Team Team { get; set; }

        public static List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>() {
              new Player {
              PlayerId = 1,
              FirstName = "Sven",
              LastName = "Baertschi",
              TeamName = "Canucks",
              Position = "Forward"
              },
              new Player {
              PlayerId = 2,
              FirstName = "Hendrik",
              LastName = "Sedin",
              TeamName = "Canucks",
              Position = "Left Wing"
              },
              new Player {
              PlayerId = 3,
              FirstName = "John",
              LastName = "Rooster",
              TeamName = "Flames",
              Position = "Right Wing"
              },
              new Player {
              PlayerId = 4,
              FirstName = "Bob",
              LastName = "Plumber",
              TeamName = "Oilers",
              Position = "Defense"
              }
          };

            return players;
        }

    }
}
