using System.Collections.Generic;
using SoccerSquatManager.Console.Entities;

namespace SoccerSquatManager.Console.Infrastructure
{
    public class PlayerDb
    {
        public PlayerDb()
        {
            this.Players = new List<Player>
            {
                new Player{Name = "John", Age=28},
                new Player{Name = "Mike", Age=24},
                new Player{Name = "Tom", Age=25}
            };

        }
        public IList<Player> Players { get; set; }
    }
}