using SoccerSquatManager.Core.Entities;

namespace SoccerSquatManager.Application.InheritanceExample.Trainings
{
    public abstract class Training
    {
        public abstract Player Train(Player player, Intensity intensity);
    }
}