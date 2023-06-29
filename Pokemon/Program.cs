using Pokemon.Models;
#pragma warning disable CS8601
#pragma warning disable CS8600

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
while (true)
{
    var trainer1wins = 0;
    var trainer2wins = 0;
    var pokemontrainer1 = trainer1.getItem(trainer1wins);
    var pokemontrainer2 = trainer2.getItem(trainer2wins);
    var winner = Battle.StartBattle(trainer1, trainer2, pokemontrainer1, pokemontrainer2);
    Console.WriteLine(winner.name + " is the winner!");
    break;
}