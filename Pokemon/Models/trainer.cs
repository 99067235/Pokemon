namespace Pokemon.Models
{
    public class Trainer
    {
        public string name = "";
        public List<pokeball> belt = new List<pokeball>();

        public Trainer() {
            Charmander charmander1 = new("peter", "fire", "water");
            Bulbasaur charmander2 = new("karel", "fire", "water");
            Charmander charmander3 = new("henk", "fire", "water");
            Charmander charmander4 = new("pieter", "fire", "water");
            Charmander charmander5 = new("Donald Trump", "fire", "water");
            Charmander charmander6 = new("Obama", "fire", "water");
            belt.Add(new pokeball(charmander1) { });
            belt.Add(new pokeball(charmander2) { });
            belt.Add(new pokeball(charmander3) { });
            belt.Add(new pokeball(charmander4) { });
            belt.Add(new pokeball(charmander5) { });
            belt.Add(new pokeball(charmander6) { });
        }

        public pokeball? getItem(int id)
        {
            if (belt != null)
            {
                return belt[id];
            } else
            {
                return null;
            }
        }
    }
}
