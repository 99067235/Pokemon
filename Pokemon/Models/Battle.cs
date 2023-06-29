using System.Runtime.CompilerServices;

namespace Pokemon.Models
{
    internal class Battle
    {
        public static Trainer StartBattle(Trainer trainer1, Trainer trainer2, pokeball pokemontrainer1, pokeball pokemontrainer2)
        {
            var pokemon1strength = pokemontrainer1.pokemon.getStrength();
            var pokemon2strength = pokemontrainer2.pokemon.getStrength();
            if (pokemon1strength == "fire" && pokemon2strength == "grass")
            {
                Trainer winner = trainer1;
                return winner;
            }
            return null;
        }
    }
}
