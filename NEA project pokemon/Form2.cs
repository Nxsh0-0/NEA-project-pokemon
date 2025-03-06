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
            if ((Globals.battling.gethp() - (Globals.encounter.getatk() - Globals.battling.getdef()) - 1) > 0)
            {
                int dmg = Globals.encounter.getatk() - Globals.battling.getdef(); //calculates the damage dealt
                if (dmg < 0) //if dmg is negative then the pokmeon would be healed when attacked so set to 0
                { dmg = 0; }
                Globals.battling.sethp(Globals.battling.gethp() - dmg - 1);
                BattlingHealth.Value = Globals.battling.gethp();
                

                pictureBox2.Refresh();
                pictureBox2.Update();
            }
            else
            {
                Globals.battling.sethp(0);
                BattlingHealth.Value = Globals.battling.gethp();
                label1.Text = Globals.battling.getname() + " has fainted!";
                label1.Visible = true;

                pictureBox2.Refresh();
                pictureBox2.Update();
            }
            if ((Globals.encounter.gethp() - (Globals.battling.getatk() - Globals.encounter.getdef()) - 1) > 0)
            {
                int dmg = Globals.battling.getatk() - Globals.encounter.getdef(); //calculates the damage dealt
                if (dmg < 0) //if dmg is negative then the pokmeon would be healed when attacked so set to 0
                { dmg = 0; }
                Globals.encounter.sethp(Globals.encounter.gethp() - dmg - 1);
                Foehealth.Value = Globals.encounter.gethp();
            }
            else
            {
                Globals.encounter.sethp(0);
                label1.Text =  Globals.encounter.getname() + " has fainted!";
                label1.Visible = true;
                Foehealth.Value = 0;
                
            }
        }

        private void catch_button_Click(object sender, EventArgs e)
        {
            int catch_chance = 100;
            if (rnd.Next(1,100) <= catch_chance)
            {
                if (Globals.Party.Count < 6)
                {
                    Globals.Party.Add(Globals.encounter);
                    label1.Text = "Successfully caught and added to your party!";
                    label1.Visible = true;
                }
                else
                {
                    label1.Text = "Party already full! Failed to catch." + Globals.encounter.getname() + " has run away!";
                    label1.Visible = true;
                }
                
            }
            else
            {
                label1.Text = "Failed to catch." + Globals.encounter.getname() + " has run away!";
                label1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            this.Hide();
            Owner.Show();
        }
    }
}
