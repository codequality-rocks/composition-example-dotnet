using SoccerSquatManager.Core.Entities;

namespace SoccerSquatManager.Application.CompositionExample.Trainings
{
    public abstract class Training
    {
        public abstract Player Train(Player player, Intensity intensity);

        public void CoolDown(Player player)
        {
            player.MentalStrength += 2;
        }
    }
}