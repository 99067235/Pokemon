using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public enum PokemonTypes {
        Fire,
        Grass,
        Water
    }
    public abstract class BattleHandler
    {
<<<<<<< HEAD
        public static bool? Versus(PokemonTypes type, PokemonTypes EnemyType)
        {
            if (type == PokemonTypes.Fire)
=======
        public abstract bool? Versus(string enemy_type);
    }
    public class Fire : BattleHandler
    {
        public override bool? Versus(string enemy_type)
        {
            if (enemy_type is "Water")
>>>>>>> d172fd425a27832e725536cba367780879d8f6d0
            {
                if (EnemyType == PokemonTypes.Grass)
                {
                    return true;
                }
                if (EnemyType == PokemonTypes.Fire)
                {
                    return null;
                }
                if (EnemyType == PokemonTypes.Water)
                {
                    return false;
                }
            }
<<<<<<< HEAD

            if (type == PokemonTypes.Water)
=======
            else if (enemy_type is "Grass")
>>>>>>> d172fd425a27832e725536cba367780879d8f6d0
            {
                if (EnemyType == PokemonTypes.Fire)
                {
                    return true;
                }
                if (EnemyType == PokemonTypes.Water)
                {
                    return null;
                }
                if (EnemyType == PokemonTypes.Grass)
                {
                    return false;
                }
            }
<<<<<<< HEAD

            if (type == PokemonTypes.Grass)
            {
                if (EnemyType == PokemonTypes.Water)
                {
                    return true;
                }
                if (EnemyType == PokemonTypes.Grass)
                {
                    return null;
                }
                if (EnemyType == PokemonTypes.Fire)
                {
                    return false;
                }
=======
            else if (enemy_type is "Fire")
            {
                return null;
            }
            else
            {
                Console.WriteLine("Attack failed: No valid type.");
                return false;
            }
        }
    }
    public class Grass : BattleHandler
    {
        public override bool? Versus(string enemy_type)
        {
            if (enemy_type is "Water")
            {
                return true;
            }
            else if (enemy_type is "Grass")
            {
                return null;
            }
            else if (enemy_type is "Fire")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Attack failed: No valid type.");
                return false;
            }
        }
    }
    public class Water : BattleHandler
    {
        public override bool? Versus(string enemy_type)
        {
            if (enemy_type is "Water")
            {
                return null;
            }
            else if (enemy_type is "Grass")
            {
                return false;
            }
            else if (enemy_type is "Fire")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Attack failed: No valid type.");
                return false;
>>>>>>> d172fd425a27832e725536cba367780879d8f6d0
            }
            return false;
        }
    }
}
