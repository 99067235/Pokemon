using Pokemon.Models;

Pokemon.Models.Pokemon henk = new Pokemon.Models.Pokemon("henk", "henk", "fire", "water");

while (true)
{
    Console.Write("Name: ");
    string chosenName = Console.ReadLine();
    if (chosenName == "exit")
    {
        break;
    } else
    {
        henk.chosenName = chosenName;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(chosenName + '!');
        }
    }
}