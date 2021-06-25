using System.Collections.Generic;

using SoccerSquatManager.Core.Entities;

namespace SoccerSquatManager.SharedKernel
{
    public interface IRepository
    {
        IList<Player> GetPlayers();
    }
}