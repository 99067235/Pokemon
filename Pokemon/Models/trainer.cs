namespace Pokemon.Models
{
    public class Trainer
    {
        public string name = "";
        public List<pokeball> belt = new List<pokeball>();

        public Trainer() {
            Charmander charmander1 = new("peter", "5", "1");
            Charmander charmander2 = new("karel", "1", "2");
            Charmander charmander3 = new("henk", "2", "2");
            Charmander charmander4 = new("pieter", "3", "2");
            Charmander charmander5 = new("Donald Trump", "4", "7");
            Charmander charmander6 = new("Obama", "7", "4");
            belt.Add(new pokeball(charmander1) { });
            belt.Add(new pokeball(charmander2) { });
            belt.Add(new pokeball(charmander3) { });
            belt.Add(new pokeball(charmander4) { });
            belt.Add(new pokeball(charmander5) { });
            belt.Add(new pokeball(charmander6) { });
        }
    }
}
