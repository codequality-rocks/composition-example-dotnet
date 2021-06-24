using SoccerSquatManager.Console.Entities;

namespace SoccerSquatManager.Console.CompositionExample.Trainings
{
    public abstract class Training
    {
        public abstract Player Train(Player player, Intensity intensity);
    }
}