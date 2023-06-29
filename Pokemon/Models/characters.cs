namespace Pokemon.Models
{
    public abstract class Pokemon
    {
        public String? defaultName;
        protected String? strength;
        protected String? weakness;

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
        public Charmander(string defaultName, string strength, string weakness)
        {
            this.defaultName = defaultName;
            this.strength = strength;
            this.weakness = weakness;
        }
    }

    public class Squirtle : Pokemon
    {
        public override void BattleCry()
        {
            Console.WriteLine("\n*Squirtle sounds*");
        }
        public Squirtle(string defaultName, string strength, string weakness)
        {
            this.defaultName = "Squirtle";
            this.strength = strength;
            this.weakness = weakness;
        }
    }

    public class Bulbasaur : Pokemon
    {
        public override void BattleCry()
        {
            Console.WriteLine("\n*Bulbasaur sounds*");
        }
        public Bulbasaur(string defaultName, string strength, string weakness)
        {
            this.defaultName = "Bulbasaur";
            this.strength = strength;
            this.weakness = weakness;
        }
    }
}
