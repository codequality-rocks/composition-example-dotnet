using Microsoft.VisualStudio.TestTools.UnitTesting;

using SoccerSquatManager.Application.InheritanceExample.Trainings;
using SoccerSquatManager.Core.Entities;

namespace SoccerSquatManager.Tests.Application.Trainings
{
    [TestClass]
    public class ShootingTrainingTests
    {
        [TestMethod]
        public void TrainShouldReturnTrainedPlayer()
        {
            var shootingTraining = new ShootingTraining();
            var trainedPlayer = shootingTraining.Train(new Player(), Intensity.High);
            Assert.AreEqual(3, trainedPlayer.Shooting);
        }
    }
}