using Pokemon.Models;

Pokemon.Models.Pokemon pokemon = new Pokemon.Models.Pokemon();
while (true)
{
    Console.Write("Name the first trainer: ");
    string trainerName1 = Console.ReadLine();
    Trainer trainer1 = new();
    trainer1.name = trainerName1;
    Console.Write("Name the second trainer: ");
    string trainerName2 = Console.ReadLine();
    Trainer trainer2 = new();
    trainer2.name = trainerName2;
    Console.Write("Name: ");
    string chosenName = Console.ReadLine();
    if (chosenName == "exit")
    {
        break;
    } else
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(chosenName + '!');
        }
    }
}