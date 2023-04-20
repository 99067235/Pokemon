using Pokemon.Models;

Character henk = new Character("henk", "henk", "fire", "water");

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