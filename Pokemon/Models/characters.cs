﻿namespace Pokemon.Models
{
    public abstract class Pokemon
    {
        public String? defaultName;
        public string? givenName;
        protected String? strength;
        protected String? weakness;
        public bool useable;
        public string type;
        public BattleHandler batteHandler;
        public Pokemon(bool wantsToName = true, string? DefaultName = "NoGivenName")
        {
            if (wantsToName)
            {
                this.giveName();
            }
            else
            {
                this.giveName(false, defaultName);
            }
            this.type = "Fire";
        }
        public void giveName(bool wantsToName = true, string? givenName = null)
        {
            if (wantsToName)
            {
                Console.Write("Enter your desired name: ");
                givenName = Console.ReadLine();
                if (givenName != null)
                {
                    this.givenName = givenName;
                }
                else
                {
                    this.givenName = "IGotNoName";
                }
            } else
            {
                if (givenName != null)
                {
                    this.givenName = givenName;
                } else
                {
                    this.givenName = "IGotNoName";
                }
            }
        }

        public bool? Versus(Pokemon pokemon)
        {
            var enemyType = pokemon.type;
            if (enemyType != null && this.type != null)
            {
                bool? result = this.batteHandler.Versus(enemyType);
                return result;
            }
            Console.WriteLine("An error has occurred.");
            return null;
        }

        public string getStrength()
        {
            if (this.strength != null)
            {
                return this.strength;
            } else
            {
                return null;
            }
        }

        public abstract void BattleCry();
    }

    public class Charmander : Pokemon
    {
        public override void BattleCry()
        {
            Console.WriteLine("\n*Charmander sounds*");
        }
        public Charmander(bool wantsToName = true, string ? defaultName = "Charmander"): base(wantsToName)
        {
            this.type = "Fire";
            this.defaultName = defaultName;
        }
    }

    public class Squirtle : Pokemon
    {
        public override void BattleCry()
        {
            Console.WriteLine("\n*Squirtle sounds*");
        }
        public Squirtle(bool wantsToName = true, string ? defaultName = "Squirtle"): base(wantsToName)
        {
            this.defaultName = defaultName;
            this.type = "Water";
        }
    }

    public class Bulbasaur : Pokemon
    {
        public override void BattleCry()
        {
            Console.WriteLine("\n*Bulbasaur sounds*");
        }
        public Bulbasaur(bool wantsToName = true, string defaultName = "Bulbasaur"): base(wantsToName)
        {
            this.defaultName = defaultName;
            this.type = "Grass";
        }
    }
}
