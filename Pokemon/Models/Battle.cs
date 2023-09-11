using System.Runtime.CompilerServices;

namespace Pokemon.Models
{
    internal class Battle
    {
        public static Trainer StartBattle(Trainer trainer1, Trainer trainer2, pokeball pokeballTrainer1, pokeball pokeballTrainer2)
        {
            if (trainer1 == null || trainer2 == null)
            {
                return null;
            }
            Pokemon? pokemonTrainer1 = pokeballTrainer1.Use(trainer1);
            Pokemon? pokemonTrainer2 = pokeballTrainer2.Use(trainer2);
            if (pokeballTrainer1 == null || pokemonTrainer2 == null)
            {
                return null;
            }
            else
            {
                bool? trainer1HasWon = pokemonTrainer1.Versus(pokemonTrainer2);
                if (trainer1HasWon == true)
                {
                    return trainer1;
                } else if (trainer1HasWon == false)
                {
                    return trainer2;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
