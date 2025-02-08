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
        static int manw = 30;
        static int manh = 50;
        static obstacle[] obstacles = new obstacle[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        struct obstacle
        {
            public Image imagename;
            public int xloc;
            public int yloc;
            public int width;
            public int height;
            public Rectangle bounds;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawImage(man, x, y, manw, manh);
            
            for (int i = 0; i < obstacles.Length; i++)
            {
                obstacles[i] = new obstacle
                {
                    imagename = tree,
                    xloc = 60 * i,
                    yloc = 250,
                    width = 60,
                    height = 100,
                    bounds = new Rectangle(60 * i, 250, 60, 100)
                };
                e.Graphics.DrawImage(obstacles[i].imagename, obstacles[i].xloc, obstacles[i].yloc, obstacles[i].width, obstacles[i].height);
            }


        }
        private Boolean checkCollision()
        {
            Boolean collision = false;
            for (int i = 0; i < obstacles.Length; i++)
            {
                if (x+manw >= obstacles[i].xloc &&
                    x <= obstacles[i].xloc + obstacles[i].width &&
                    y+manh >= obstacles[i].yloc &&
                    y <= obstacles[i].yloc + obstacles[i].height)
                { collision = true; }
            }
            return collision;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                if (man == B1)
                { man = B2;}
                else man = B1;
                if (checkCollision())
                { y = y + 10; }
                else y = y - 10;
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if (man == L1)
                { man = L2; }
                else man = L1;
                if (checkCollision())
                { x = x + 10; }
                else x = x - 10;
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                if (man == F1)
                { man = F2; }
                else man = F1;
                if (checkCollision())
                { y = y - 10; }
                else y = y + 10;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (man == R1)
                { man = R2; }
                else man = R1;
                if (checkCollision())
                { x = x - 10; }
                else x = x + 10;
            }

            pictureBox1.Refresh();
            pictureBox1.Update();
        }
    }
}
