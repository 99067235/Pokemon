namespace Pokemon.Models
{
    public class Trainer
    {
        public string name;
        public Belt belt;
        public bool pokemonInUse;
        public Pokemon? ReleasedPokemon;

        public Trainer(string name, Belt belt) {
            this.name = name;
            this.belt = belt;
        }
    }
}
