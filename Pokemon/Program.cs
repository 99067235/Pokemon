using Pokemon.Models;

Character henk = new Character("henk", "henk", "fire", "water");
Console.WriteLine(henk.ToString());

Console.Write("Name: ");
string chosenName = Console.ReadLine();
henk.chosenName = chosenName;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(chosenName);
}
Console.WriteLine(henk);