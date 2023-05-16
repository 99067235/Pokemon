using static System.Net.WebRequestMethods;

namespace Pokemon.Models
{
    public class Pokemon
    {
        public String? defaultName;
        public String? chosenName;
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
                this.chosenName = newName;
            } else
            {
                Console.WriteLine("Name has not been changed");
            }
        }

        public string GetName()
        {
            return this.chosenName;
        }

        public override string ToString()
        {
            return $"DefaultName: {defaultName}, ChosenName: {chosenName}, Strength: {strength}, Weakness: {weakness}";
        }
    }

    public class Charmander : Pokemon
    {
        public Charmander(string defaultName, string chosenName, string strength, string weakness)
        {
        }
    }
}
