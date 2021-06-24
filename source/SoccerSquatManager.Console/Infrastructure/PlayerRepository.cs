using System.Collections.Generic;
using SoccerSquatManager.Console.Entities;
using SoccerSquatManager.Console.SharedKernel;

namespace SoccerSquatManager.Console.Infrastructure
{
    public class PlayerRepository : IRepository
    {
        private readonly PlayerDb playerDb;

        public PlayerRepository(PlayerDb playerDb)
        {
            this.playerDb = playerDb ?? throw new System.ArgumentNullException(nameof(playerDb));
        }
        public IList<Player> GetPlayers()
        {
            return playerDb.Players;
        }
    }
}