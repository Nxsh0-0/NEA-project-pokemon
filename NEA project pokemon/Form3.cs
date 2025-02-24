using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }
    }
}
