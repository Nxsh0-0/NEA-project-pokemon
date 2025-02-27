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
            Globals.encounter = Globals.pokemons[rnd.Next(0, Globals.pokemons.Count)];
            e.Graphics.DrawImage(Globals.encounter.getsprite(), 90, 0, 160, 160);
            FoeName.Text = Globals.encounter.getname();
            Foehealth.Maximum = Globals.encounter.getmaxhp();
            Foehealth.Value = Globals.encounter.gethp();
        }
        

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Globals.battling = Globals.Party[0];
            e.Graphics.DrawImage(Globals.battling.getbacksprite(), 90, 0, 320, 320);
            BattlingName.Text = Globals.battling.getname();
            BattlingHealth.Maximum = Globals.battling.getmaxhp();
            BattlingHealth.Value = Globals.battling.gethp();

            
        }

        private void fight_button_Click(object sender, EventArgs e)
        {
            int newhp = Globals.battling.gethp() - (Globals.encounter.getatk() - Globals.battling.getdef()) - 1;
            Globals.battling.sethp(newhp);
            BattlingHealth.Value = Globals.battling.gethp();
           
            pictureBox2.Refresh();
            pictureBox2.Update();
        }
    }
}
