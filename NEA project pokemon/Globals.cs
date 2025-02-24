using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace NEA_project_pokemon
{
    internal class Globals      
        //list of all globals variable that will be accessible from any form.

    {
        static Image eevee = NEA_project_pokemon.Properties.Resources.eevee;
        static Image eevee_back = NEA_project_pokemon.Properties.Resources.eevee_back;
        static Image treecko = NEA_project_pokemon.Properties.Resources.treecko;
        static Image treecko_back = NEA_project_pokemon.Properties.Resources.treecko_back;
        static Image bulbasaur = NEA_project_pokemon.Properties.Resources.bulbasaur;
        static Image bulbasaur_back = NEA_project_pokemon.Properties.Resources.bulbasaur_back;
        static Image torchic = NEA_project_pokemon.Properties.Resources.torchic_1;
        static Image torchic_back = NEA_project_pokemon.Properties.Resources.torchic_back;
        public static List<Pokemon> Party = new List<Pokemon>();
        public static List<Pokemon> pokemons = new List<Pokemon>();
        public static Pokemon Torchic = new Pokemon(torchic, torchic_back, "Torchic", 45, 45, 65, 45);
        public static Pokemon Bulbasaur = new Pokemon(bulbasaur, bulbasaur_back, "Bulbasaur", 45, 45, 57, 47);
        public static Pokemon Treecko = new Pokemon(treecko, treecko_back, "Treecko", 40, 40, 55, 45);
        public static Pokemon Eevee = new Pokemon(eevee, eevee_back, "Eevee", 55, 55, 50, 57);

    }
}
