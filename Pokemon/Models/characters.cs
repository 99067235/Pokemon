namespace Pokemon.Models
{
    public abstract class Pokemon
    {
        public String? defaultName;
        public String? strength;
        public String? weakness;

        public void changeName(bool RequiresInput = true, string? newName = null)
        {
            if (RequiresInput)
            {
                Console.Write("Enter Name Here:");
                newName = Console.ReadLine();
            }
            if (newName != null)
            {
                this.defaultName = newName;
            } else
            {
                Console.WriteLine("Name has not been changed");
            }
        }

        public override string ToString()
        {
            return $"DefaultName: {defaultName}, Strength: {strength}, Weakness: {weakness}";
        }
    }

    public class Charmander : Pokemon
    {
        public Charmander(string defaultName, string strength, string weakness)
        {
            this.defaultName = defaultName;
            this.strength = strength;
            this.weakness = weakness;
        }
    }

    public class Squirtle : Pokemon
    {
        public Squirtle(string defaultName, string strength, string weakness)
        {
            this.defaultName = "Squirtle";
            this.strength = strength;
            this.weakness = weakness;
        }
    }

    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string defaultName, string strength, string weakness)
        {
            this.defaultName = "Bulbasaur";
            this.strength = strength;
            this.weakness = weakness;
        }
    }
}
