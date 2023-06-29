namespace Pokemon.Models
{
    public class pokeball
    {
        public Pokemon pokemon;
        private bool pokemonInside;
        public pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            this.pokemonInside = true;
        }

        public bool Use()
        {
            if (this.pokemonInside)
            {
                this.pokemonInside = false;
                this.pokemon.BattleCry();
            } else
            {
                Console.WriteLine(this.pokemon.defaultName + " went back to his pokeball");
                this.pokemonInside = true;
            }
            return true;
        }
    }
}
