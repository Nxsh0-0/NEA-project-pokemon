using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace NEA_project_pokemon
{
    
    public partial class Form2 : Form
    {
        static Image eevee = NEA_project_pokemon.Properties.Resources.eevee;
        static Image treecko = NEA_project_pokemon.Properties.Resources.treecko;
        static Image bulbasaur = NEA_project_pokemon.Properties.Resources.bulbasaur;
        static Random rnd = new Random();
        List<Pokemon> pokemons = new List<Pokemon>();

        public Form2()
        {
            InitializeComponent();
            Pokemon Eevee = new Pokemon(eevee, "Eevee", 30, 30, 10, 5);
            Pokemon Treecko = new Pokemon(treecko, "Treecko", 35, 35, 12, 5);
            Pokemon Bulbasaur = new Pokemon(bulbasaur, "Bulbasaur", 40, 40, 8, 7);
           
            pokemons.Add(Eevee);
            pokemons.Add(Treecko);
            pokemons.Add(Bulbasaur);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void run_button_Click(object sender, EventArgs e)
        {
           this.Hide();
            Owner.Show();
        }

        private void Foepokemon_Paint(object sender, PaintEventArgs e)
        {
            Pokemon encounter = pokemons[rnd.Next(0, pokemons.Count)];
            e.Graphics.DrawImage(encounter.getsprite(),90,0,160,160);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
