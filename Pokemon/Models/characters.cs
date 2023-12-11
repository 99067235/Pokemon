namespace Pokemon.Models
{
    public abstract class Pokemon
    {
        public String? defaultName;
        public string? givenName;
        protected readonly String? strength;
        protected readonly String? weakness;
        public bool useable;
        public PokemonTypes type;
        public readonly BattleHandler batteHandler;
        public Pokemon(bool wantsToName = true)
        {
            if (wantsToName)
            {
                this.giveName();
            }

            else
            {
                this.giveName(false, defaultName);
            }
            this.type = PokemonTypes.Fire;
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

        public bool? Versus(PokemonTypes enemyType, PokemonTypes type)
        {
<<<<<<< HEAD
            if (enemyType != null && this.type != null)
            {
                var result = BattleHandler.Versus(type, enemyType);
=======
            var enemy_type = pokemon.type;
            if (enemy_type != null && this.type != null)
            {
                bool? result = this.batteHandler.Versus(enemy_type);
>>>>>>> d172fd425a27832e725536cba367780879d8f6d0
                return result;
            }
            Console.WriteLine("Oh no, an error has occurred.");
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
            Console.WriteLine("\n*Charmander battlecry sounds*");
        }
        public Charmander(bool wantsToName = true, string ? defaultName = "Charmander"): base(wantsToName)
        {
            this.type = PokemonTypes.Fire;
            this.defaultName = defaultName;
        }
    }

    public class Squirtle : Pokemon
    {
        public override void BattleCry()
        {
            Console.WriteLine("\n*Squirtle battlecry sounds*");
        }
        public Squirtle(bool wantsToName = true, string ? defaultName = "Squirtle"): base(wantsToName)
        {
            this.defaultName = defaultName;
            this.type = PokemonTypes.Water;
        }
    }

    public class Bulbasaur : Pokemon
    {
        public override void BattleCry()
        {
            Console.WriteLine("\n*Bulbasaur battlecry sounds*");
        }
        public Bulbasaur(bool wantsToName = true, string defaultName = "Bulbasaur"): base(wantsToName)
        {
            this.defaultName = defaultName;
            this.type = PokemonTypes.Grass;
        }
    }
}
