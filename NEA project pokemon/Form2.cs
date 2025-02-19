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
        
        static Random rnd = new Random();
       

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Globals.pokemons.Add(Globals.Eevee);
            Globals.pokemons.Add(Globals.Treecko);
            Globals.pokemons.Add(Globals.Bulbasaur);
            Globals.pokemons.Add(Globals.Torchic);
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void Foepokemon_Paint(object sender, PaintEventArgs e)
        {
            Pokemon encounter = Globals.pokemons[rnd.Next(0, Globals.pokemons.Count)];
            e.Graphics.DrawImage(encounter.getsprite(), 90, 0, 160, 160);
            Foename.Text = encounter.getname();
            Foehealth.Value = (encounter.gethp() / encounter.getmaxhp()) * 100;
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
