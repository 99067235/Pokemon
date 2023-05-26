using Pokemon.Models;
#pragma warning disable CS8601
#pragma warning disable CS8600

Pokemon.Models.Pokemon pokemon = new Pokemon.Models.Pokemon();
Trainer trainer1 = new();
Trainer trainer2 = new();
Console.Write("Name the first trainer: ");
string trainerName1 = Console.ReadLine();
trainer1.name = trainerName1;
Console.Write("Name the second trainer: ");
string trainerName2 = Console.ReadLine();
trainer2.name = trainerName2;
for (int i = 0; i < 6; i++)
{
    trainer1.belt[i].Use();
    trainer2.belt[i].Use();
}