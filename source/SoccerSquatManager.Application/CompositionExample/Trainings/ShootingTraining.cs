using SoccerSquatManager.Core.Entities;

namespace SoccerSquatManager.Application.CompositionExample.Trainings
{
    public class ShootingTraining : Training
    {
        public override Player Train(Player player, Intensity intensity)
        {
            switch (intensity)
            {
                case Intensity.Low:
                    player.Shooting += 1;
                    break;
                case Intensity.Medium:
                    player.Shooting += 2;
                    break;
                case Intensity.High:
                    player.Shooting += 3;
                    break;
                default:
                    throw new System.ArgumentException($"The given intensity is not valid:{intensity}");
            }

            return player;
        }
    }
}