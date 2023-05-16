using Pokemon.Models;

Pokemon.Models.Pokemon pokemon = new Pokemon.Models.Pokemon();
while (true)
{
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