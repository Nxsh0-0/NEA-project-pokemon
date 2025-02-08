using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_project_pokemon
{
    public partial class Form1 : Form
    {
        static Image F1 =   NEA_project_pokemon.Properties.Resources.walkF1;
        static Image F2 = NEA_project_pokemon.Properties.Resources.walkF2;
        static Image B1 = NEA_project_pokemon.Properties.Resources.walkB1;
        static Image B2 = NEA_project_pokemon.Properties.Resources.walkB2;
        static Image L1 = NEA_project_pokemon.Properties.Resources.walkL1;
        static Image L2 = NEA_project_pokemon.Properties.Resources.walkL2;
        static Image R1 = NEA_project_pokemon.Properties.Resources.walkR1;
        static Image R2 = NEA_project_pokemon.Properties.Resources.walkR2;
        static Image tree = NEA_project_pokemon.Properties.Resources.tree_sprite;
        Image man = F1;
        static int x = 25;
        static int y = 25;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(man, x, y, 30, 50);
          
            
        }
    }
}
