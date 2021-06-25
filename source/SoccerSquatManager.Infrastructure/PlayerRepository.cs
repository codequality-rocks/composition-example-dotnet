using System.Collections.Generic;

using SoccerSquatManager.Core.Entities;
using SoccerSquatManager.SharedKernel;

namespace SoccerSquatManager.Infrastructure
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