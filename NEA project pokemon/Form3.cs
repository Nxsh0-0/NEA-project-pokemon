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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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
            var box = sender as PictureBox;
            switch (box.Tag)
            {
                case 2:
                    Globals.Party[0] = Globals.Party[1];
                    Globals.Party[1] = temp;
                    break;
                case 3:
                    Globals.Party[0] = Globals.Party[2];
                    Globals.Party[2] = temp;
                    break;
                case 4:
                    Globals.Party[0] = Globals.Party[3];
                    Globals.Party[3] = temp;
                    break;
                case 5:
                    Globals.Party[0] = Globals.Party[4];
                    Globals.Party[4] = temp;
                    break;
                case 6:
                    Globals.Party[0] = Globals.Party[5];
                    Globals.Party[5] = temp;
                    break;
                



            }
        }

        private void CommonPicbox(object sender, EventArgs e)
        {
            var box = sender as PictureBox;
            switch (box.Tag)
            {
                case 2:
                    switchconfirm.Text = "Switch " + Globals.Party[1] + " to the front?";
                    switchyes.Visible = true;
                    switchno.Visible = true;
                    switchconfirm.Visible = true;
                    break;
                case 3:
                    switchconfirm.Text = "Switch " + Globals.Party[2] + " to the front?";
                    switchyes.Visible = true;
                    switchno.Visible = true;
                    switchconfirm.Visible = true;
                    break;
                case 4:
                    switchconfirm.Text = "Switch " + Globals.Party[3] + " to the front?";
                    switchyes.Visible = true;
                    switchno.Visible = true;
                    switchconfirm.Visible = true;
                    break;
                case 5:
                    switchconfirm.Text = "Switch " + Globals.Party[4] + " to the front?";
                    switchyes.Visible = true;
                    switchno.Visible = true;
                    switchconfirm.Visible = true;
                    break;
                case 6:
                    switchconfirm.Text = "Switch " + Globals.Party[5] + " to the front?";
                    switchyes.Visible = true;
                    switchno.Visible = true;
                    switchconfirm.Visible = true;
                    break;
               
            }
            

        }
    }
}
