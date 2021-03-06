using SoccerSquatManager.Core.Entities;

namespace SoccerSquatManager.Application.CompositionExample.Trainings
{
    public class RunningTraining : Training
    {
        public override Player Train(Player player, Intensity intensity)
        {
            switch (intensity)
            {
                case Intensity.Low:
                    player.Dribbling += 1;
                    break;
                case Intensity.Medium:
                    player.Dribbling += 2;
                    break;
                case Intensity.High:
                    player.Dribbling += 3;
                    break;
                default:
                    throw new System.ArgumentException($"The given intensity is not valid:{intensity}");
            }

            return player;
        }
    }
}