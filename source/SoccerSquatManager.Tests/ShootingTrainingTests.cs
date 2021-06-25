using Microsoft.VisualStudio.TestTools.UnitTesting;

using SoccerSquatManager.Application.InheritanceExample.Trainings;
using SoccerSquatManager.Core.Entities;

namespace SoccerSquatManager.Tests
{
    [TestClass]
    public class ShootingTrainingTests
    {
        [TestMethod]
        public void TrainShouldReturnTrainedPlayer()
        {
            var shootingTraining = new ShootingTraining();
            var player = new Player();
            var trainedPlayer = shootingTraining.Train(player, Intensity.High);
            Assert.IsTrue(player.Shooting < trainedPlayer.Shooting);
        }
    }
}