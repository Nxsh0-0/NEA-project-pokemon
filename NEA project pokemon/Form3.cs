using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_project_pokemon
{
    public partial class Form3 : Form
    {
        static Image eevee = NEA_project_pokemon.Properties.Resources.eevee;
        static Image treecko = NEA_project_pokemon.Properties.Resources.treecko;
        static Image bulbasaur = NEA_project_pokemon.Properties.Resources.bulbasaur;
        static Pokemon Switcher;
        static int partyslot;


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
     
            
            

        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'P' || e.KeyChar == 'p')
            {
                this.Hide();
                Owner.Show();
            }
            
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.P )
            {
                this.Hide();
                Owner.Show();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Globals.Party.Count >= 1)
            {
                e.Graphics.DrawImage(Globals.Party[0].getsprite(), 40, 25, 100, 100);
            }
            if (Globals.Party.Count >= 1)
            {
                progressBar1.Maximum = Globals.Party[0].getmaxhp();
                progressBar1.Value = Globals.Party[0].gethp();
                progressBar1.Refresh();
                progressBar1.Update();
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (Globals.Party.Count >= 2)
            {
                e.Graphics.DrawImage(Globals.Party[1].getsprite(), 40, 25, 100, 100);
            }
            if (Globals.Party.Count >= 2)
            {
                progressBar2.Maximum = Globals.Party[1].getmaxhp();
                progressBar2.Value = Globals.Party[1].gethp();
                progressBar2.Refresh();
                progressBar2.Update();
            }
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            if (Globals.Party.Count >= 3)
            {
                e.Graphics.DrawImage(Globals.Party[2].getsprite(), 40, 25, 100, 100);
            }
            if (Globals.Party.Count >= 3)
            {
                progressBar3.Maximum = Globals.Party[2].getmaxhp();
                progressBar3.Value = Globals.Party[2].gethp();
                progressBar3.Refresh();
                progressBar3.Update();
            }
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            if (Globals.Party.Count >= 4)
            {
                e.Graphics.DrawImage(Globals.Party[3].getsprite(), 40, 25, 100, 100);
            }
            if (Globals.Party.Count >= 4)
            {
                progressBar4.Maximum = Globals.Party[3].getmaxhp();
                progressBar4.Value = Globals.Party[3].gethp();
                progressBar4.Refresh();
                progressBar4.Update();
            }
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            if (Globals.Party.Count >= 5)
            {
                e.Graphics.DrawImage(Globals.Party[4].getsprite(), 40, 25, 100, 100);
            }
            if (Globals.Party.Count >= 5)
            {
                progressBar5.Maximum = Globals.Party[4].getmaxhp();
                progressBar5.Value = Globals.Party[4].gethp();
                progressBar5.Refresh();
                progressBar5.Update();
            }
        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            if (Globals.Party.Count >= 6)
            {
                e.Graphics.DrawImage(Globals.Party[5].getsprite(), 40, 25, 100, 100);
            }
            if (Globals.Party.Count >= 6)
            {
                progressBar6.Maximum = Globals.Party[5].getmaxhp();
                progressBar6.Value = Globals.Party[5].gethp();
                progressBar6.Refresh();
                progressBar6.Update();
            }
        }

        

        private void switchno_Click(object sender, EventArgs e)
        {
            switchyes.Visible = false;
            switchno.Visible = false;
            switchconfirm.Visible = false;
        }

        private void switchyes_Click(object sender, EventArgs e)
        {
            Pokemon temp = Globals.Party[0];
           
            
            switch (partyslot)
            {
                case 2:
                    Globals.Party[0] = Globals.Party[1];
                    Globals.Party[1] = temp;
                    pictureBox2.Refresh();
                    pictureBox2.Update();
                    pictureBox1.Refresh();
                    pictureBox1.Update();
                    switchyes.Visible = false;
                    switchno.Visible = false;
                    switchconfirm.Visible = false;
                    break;
                case 3:
                    Globals.Party[0] = Globals.Party[2];
                    Globals.Party[2] = temp;
                    pictureBox3.Refresh();
                    pictureBox3.Update();
                    pictureBox1.Refresh();
                    pictureBox1.Update();
                    switchyes.Visible = false;
                    switchno.Visible = false;
                    switchconfirm.Visible = false;
                    break;
                case 4:
                    Globals.Party[0] = Globals.Party[3];
                    Globals.Party[3] = temp;
                    pictureBox4.Refresh();
                    pictureBox4.Update();
                    pictureBox1.Refresh();
                    pictureBox1.Update();
                    switchyes.Visible = false;
                    switchno.Visible = false;
                    switchconfirm.Visible = false;
                    break;
                case 5:
                    Globals.Party[0] = Globals.Party[4];
                    Globals.Party[4] = temp;
                    pictureBox5.Refresh();
                    pictureBox5.Update();
                    pictureBox1.Refresh();
                    pictureBox1.Update();
                    switchyes.Visible = false;
                    switchno.Visible = false;
                    switchconfirm.Visible = false;
                    break;
                case 6:
                    Globals.Party[0] = Globals.Party[5];
                    Globals.Party[5] = temp;
                    pictureBox6.Refresh();
                    pictureBox6.Update();
                    pictureBox1.Refresh();
                    pictureBox1.Update();
                    switchyes.Visible = false;
                    switchno.Visible = false;
                    switchconfirm.Visible = false;
                    break;
                



            }
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switchconfirm.Text = "Switch " + Globals.Party[1].getname() + " to the front?";
            switchyes.Visible = true;
            switchno.Visible = true;
            switchconfirm.Visible = true;
            partyslot = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switchconfirm.Text = "Switch " + Globals.Party[2].getname() + " to the front?";
            switchyes.Visible = true;
            switchno.Visible = true;
            switchconfirm.Visible = true;
            partyslot = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switchconfirm.Text = "Switch " + Globals.Party[3].getname() + " to the front?";
            switchyes.Visible = true;
            switchno.Visible = true;
            switchconfirm.Visible = true;
            partyslot = 4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            switchconfirm.Text = "Switch " + Globals.Party[4].getname() + " to the front?";
            switchyes.Visible = true;
            switchno.Visible = true;
            switchconfirm.Visible = true;
            partyslot = 5;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            switchconfirm.Text = "Switch " + Globals.Party[5].getname() + " to the front?";
            switchyes.Visible = true;
            switchno.Visible = true;
            switchconfirm.Visible = true;
            partyslot = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
