using System.Collections.Generic;
using SoccerSquatManager.Console.Entities;

namespace SoccerSquatManager.Console.SharedKernel
{
    public interface IRepository
    {
        IList<Player> GetPlayers();
    }
}