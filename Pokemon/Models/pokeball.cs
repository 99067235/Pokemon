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
            Console.WriteLine("\n*BattleCry sounds*");
            this.BattleCry();
            return true;
        }

        public void BattleCry()
        {
             Console.WriteLine(pokemon.defaultName + '!');
        }
    }
}
