using System.Collections.Generic;

using SoccerSquatManager.Application.CompositionExample.Trainings;
using SoccerSquatManager.Core.Entities;
using SoccerSquatManager.SharedKernel;

namespace SoccerSquatManager.Application.CompositionExample.Sessions
{
    public class TrainingSession
    {
        private readonly Training training;
        private readonly IList<Player> players = new List<Player>();

        public TrainingSession(Training training, IRepository repository)
        {
            this.training = training ?? throw new System.ArgumentNullException(nameof(training));
            this.players = repository.GetPlayers();
        }

        public void WarmUp()
        {
            foreach (var player in this.players)
            {
                training.Train(player, Intensity.Low);
            }
        }

        public void Shooting()
        {
            foreach (var player in this.players)
            {
                training.Train(player, Intensity.Medium);
            }
        }
    }
}