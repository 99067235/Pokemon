namespace Pokemon.Models
{
    public class Character
    {
        public string defaultName { get; set; }
        public string chosenName { get; set; }
        public string strength { get; set; }
        public string weakness { get; set; }

        public Character(string defaultName, string chosenName, string strength, string weakness)
        {
            this.defaultName = defaultName;
            this.chosenName = chosenName;
            this.strength = strength;
            this.weakness = weakness;
        }

        public override string ToString()
        {
            return $"DefaultName: {defaultName}, ChosenName: {chosenName}, Strength: {strength}, Weakness: {weakness}";
        }
    }
}
