using Pokemon.Models;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Belt beltTrainer1 = new();
        Belt beltTrainer2 = new();
        Console.WriteLine("Name Trainer 1: ");
        var nameTrainer1 = Console.ReadLine();
        Trainer trainer1 = new Trainer(nameTrainer1, beltTrainer1);
        beltTrainer1.trainerName = nameTrainer1;
        Console.Write("Give the pokemon a name? y/n");
        var answer = Console.ReadLine();
        if (answer == "y")
        {
            for (var i = 0; i < 6; i++)
            {
                trainer1.belt.add(trainer1.belt.makePokeball(new Charmander()));
            }
        }
        else
        {
            for (var i = 0; i < 6; i++)
            {
                trainer1.belt.add(trainer1.belt.makePokeball(new Charmander(false)));
            }
        }
        Console.WriteLine("Name Trainer 2: ");
        var nameTrainer2 = Console.ReadLine();
        Trainer trainer2 = new Trainer(nameTrainer2, beltTrainer1);
        beltTrainer2.trainerName = nameTrainer2;
        Console.Write("Give the pokemon a name? y/n");
        answer = Console.ReadLine();
        if (answer == "y")
        {
            for (var i = 0; i < 6; i++)
            {
                trainer2.belt.add(trainer2.belt.makePokeball(new Charmander()));
            }
        }
        else
        {
            for (var i = 0; i < 6; i++)
            {
                trainer2.belt.add(trainer2.belt.makePokeball(new Charmander()));
            }
        }
        // Start the battle
        // Define the variables which keep track of the amount of wins
        int winsTrainer1 = 0;
        int winsTrainer2 = 0;
        // Define a variable to keep track of how many ties there are played
        int ties = 0;
        while (true)
        {
            try
            {
                var trainer1Pokemon = trainer1.belt.getItemFromBelt(winsTrainer1);
                var trainer2Pokemon = trainer2.belt.getItemFromBelt(winsTrainer2);
                Trainer winner = Battle.StartBattle(trainer1, trainer2, trainer1Pokemon, trainer2Pokemon);
                if (winner != null)
                {
                    if (winner == trainer1)
                    {
                        winsTrainer1++;
                    } else
                    {
                        winsTrainer2++;
                    }
                } else
                {
                    ties++;
                }
            } catch
            {
                break;
            }
        }
        Console.WriteLine("Results: ");
        if (winsTrainer1 > winsTrainer2)
        {
            Console.WriteLine($"{trainer1.name} has won from {trainer2.name} with a score of {winsTrainer1}");
        }
        else if (winsTrainer2 > winsTrainer1)
        {
            Console.WriteLine($"{trainer2.name} has won from {trainer1.name} with a score of {winsTrainer2}");
        }
        else
        {
            Console.WriteLine($"It's a tie, you both had {winsTrainer1} wins.");
        }
    }
}