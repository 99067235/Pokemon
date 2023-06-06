namespace Pokemon.Models
{
    public class pokeball
    {
        private Pokemon pokemon;
        public pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
        }

        public bool Use()
        {
            this.pokemon.BattleCry();
            return true;
        }
    }
}
