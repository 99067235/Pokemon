using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public abstract class BattleHandler
    {
        public abstract bool? Versus(string EnemyType);
    }
    public class Fire : BattleHandler
    {
        public override bool? Versus(string EnemyType)
        {
            if (EnemyType is "Water")
            {
                return false;
            }
            else if (EnemyType is "Grass")
            {
                return true;
            }
            else if (EnemyType is "Fire")
            {
                return null;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Enemy does not have a valid type, attack has been canceled.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
    }
    public class Grass : BattleHandler
    {
        public override bool? Versus(string EnemyType)
        {
            if (EnemyType is "Water")
            {
                return true;
            }
            else if (EnemyType is "Grass")
            {
                return null;
            }
            else if (EnemyType is "Fire")
            {
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Enemy does not have a valid type, attack has been canceled.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
    }
    public class Water : BattleHandler
    {
        public override bool? Versus(string EnemyType)
        {
            if (EnemyType is "Water")
            {
                return null;
            }
            else if (EnemyType is "Grass")
            {
                return false;
            }
            else if (EnemyType is "Fire")
            {
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Enemy does not have a valid type, attack has been canceled.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
    }
}
