using MontyHallAPI.Model;

namespace MontyHallAPI.Services
{
    public class SimulationService
    {
        public SimulationResult RunSimulation(int numberOfSimulations, bool changeDoor)
        {
            int wins = 0;
            Random random = new Random();

            for (int i = 0; i < numberOfSimulations; i++)
            {
                int carDoor = random.Next(0, 3);
                int chosenDoor = random.Next(0, 3);
                int shownDoor = 0;

                // Find a door to open
                for (int j = 0; j < 3; j++)
                {
                    if (j != carDoor && j != chosenDoor)
                    {
                        shownDoor = j;
                        break;
                    }
                }

                if (changeDoor)
                {
                    // Switch to the remaining door
                    chosenDoor = 3 - chosenDoor - shownDoor;
                }

                if (chosenDoor == carDoor)
                {
                    wins++;
                }
            }

            return new SimulationResult
            {
                Wins = wins,
                Losses = numberOfSimulations - wins
            };
        }
    }

}
