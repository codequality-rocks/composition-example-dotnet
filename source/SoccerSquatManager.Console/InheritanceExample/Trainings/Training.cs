using SoccerSquatManager.Console.Entities;

namespace SoccerSquatManager.Console.InheritanceExample.Trainings
{
    public abstract class Training
    {
        public abstract Player Train(Player player, Intensity intensity);
    }
}