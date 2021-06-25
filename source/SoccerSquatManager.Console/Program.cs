using SoccerSquatManager.Application.InheritanceExample.Sessions;
using SoccerSquatManager.Application.InheritanceExample.Trainings;
using SoccerSquatManager.Infrastructure;

namespace SoccerSquatManager.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Start Training Session");
            var training = new ShootingTraining();
            var trainingSession = new TrainingSession(training, new PlayerRepository(new PlayerDb()));
            trainingSession.WarmUp();
            trainingSession.Shooting();
        }
    }
}
