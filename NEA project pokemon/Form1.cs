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
        static Image bush = NEA_project_pokemon.Properties.Resources.tall_grass;
        
        Image man = F1;
        static int x = 25;
        static int y = 500;
        static int manw = 30;
        static int manh = 50;
        static obstacle[] obstacles = new obstacle[38];
        static obstacle[] tall_grass = new obstacle[49];
        static int encounter_chance = 10;
        static Random rnd = new Random();
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
            Pokemon starter = Globals.Eevee;
            Globals.Party.Add(starter);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        struct obstacle //defining a structure for all 'obstacles' the player can bump into
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
            
            for (int i = 0; i < 18; i++)    //rendering the trees going horizontal
            {
                obstacles[i] = new obstacle
                {
                    imagename = tree,
                    xloc = 10 + 30* i,
                    yloc = 250,
                    width = 60,
                    height = 100,
                    bounds = new Rectangle(10+ 20 * i, 250, 60, 100)
                };
                e.Graphics.DrawImage(obstacles[i].imagename, obstacles[i].xloc, obstacles[i].yloc, obstacles[i].width, obstacles[i].height);
            }
            for (int i = 18; i < 27; i++)   //rendering the tress going vertical
            {
                obstacles[i] = new obstacle
                {
                    imagename = tree,
                    xloc = 510,
                    yloc = 250 + 20* (i-18),
                    width = 60,
                    height = 100,
                    bounds = new Rectangle(obstacles[i].xloc, obstacles[i].yloc, obstacles[i].width, obstacles[i].height)
                };
                e.Graphics.DrawImage(obstacles[i].imagename, obstacles[i].xloc, obstacles[i].yloc, obstacles[i].width, obstacles[i].height);
            }
            for (int i =0; i <7; i++)  // each loop is one row of tall grass
            {
                tall_grass[i] = new obstacle
                {
                    imagename = bush,
                    xloc = 10 + 20 * i,
                    yloc = 370,
                    width = 40,
                    height = 40,
                    bounds = new Rectangle(tall_grass[i].xloc, tall_grass[i].yloc, tall_grass[i].width, tall_grass[i].height)
                };
                e.Graphics.DrawImage(tall_grass[i].imagename, tall_grass[i].xloc, tall_grass[i].yloc, tall_grass[i].width, tall_grass[i].height) ;
            }
            for (int i = 7; i < 14; i++)
            {
                tall_grass[i] = new obstacle
                {
                    imagename = bush,
                    xloc = 10 + 20 * (i-7),
                    yloc = 410,
                    width = 40,
                    height = 40,
                    bounds = new Rectangle(tall_grass[i].xloc, tall_grass[i].yloc, tall_grass[i].width, tall_grass[i].height)
                };
                e.Graphics.DrawImage(tall_grass[i].imagename, tall_grass[i].xloc, tall_grass[i].yloc, tall_grass[i].width, tall_grass[i].height);
            }
            for (int i = 14; i < 21; i++)
            {
                tall_grass[i] = new obstacle
                {
                    imagename = bush,
                    xloc = 10 + 20 * (i - 14),
                    yloc = 450,
                    width = 40,
                    height = 40,
                    bounds = new Rectangle(tall_grass[i].xloc, tall_grass[i].yloc, tall_grass[i].width, tall_grass[i].height)
                };
                e.Graphics.DrawImage(tall_grass[i].imagename, tall_grass[i].xloc, tall_grass[i].yloc, tall_grass[i].width, tall_grass[i].height);
            }
            for (int i = 21; i < 28; i++)
            {
                tall_grass[i] = new obstacle
                {
                    imagename = bush,
                    xloc = 10 + 20 * (i - 21),
                    yloc = 490,
                    width = 40,
                    height = 40,
                    bounds = new Rectangle(tall_grass[i].xloc, tall_grass[i].yloc, tall_grass[i].width, tall_grass[i].height)
                };
                e.Graphics.DrawImage(tall_grass[i].imagename, tall_grass[i].xloc, tall_grass[i].yloc, tall_grass[i].width, tall_grass[i].height);
            }
           




        }
        private Boolean checkCollision() //collision function to see if player has collided with trees
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
        private Boolean encounter() //collision function to see if player has collided with tall grass
        {
            Boolean collision = false;
            for (int i = 0; i < obstacles.Length; i++)
            {
                if (x + manw >= tall_grass[i].xloc &&
                    x <= tall_grass[i].xloc + tall_grass[i].width &&
                    y + manh >= tall_grass[i].yloc &&
                    y <= tall_grass[i].yloc + tall_grass[i].height)
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
                { y = y + 30; }
                if (encounter())
                {
                    if (rnd.Next(1, 100) <= encounter_chance)
                    {
                        this.Hide();
                        form2.Show(this);
                        Globals.encounter = Globals.pokemons[rnd.Next(0, Globals.pokemons.Count)];
                        Globals.encounter.sethp(Globals.encounter.getmaxhp());

                    }
                    else y = y - 10;
                }
                else y = y - 10;
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if (man == L1)
                { man = L2; }
                else man = L1;
                if (checkCollision())
                { x = x + 30; }
                if (encounter())
                {
                    if (rnd.Next(1, 100) <= encounter_chance)
                    {
                        this.Hide();
                        form2.Show(this);
                        Globals.encounter = Globals.pokemons[rnd.Next(0, Globals.pokemons.Count)];
                        Globals.encounter.sethp(Globals.encounter.getmaxhp());
                    }
                    else x = x - 10;
                }
                else x = x - 10;
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                if (man == F1)
                { man = F2; }
                else man = F1;
                if (checkCollision())
                { y = y - 30; }
                if (encounter())
                {
                    if (rnd.Next(1, 100) <= encounter_chance)
                    {
                        this.Hide();
                        form2.Show(this);
                        Globals.encounter = Globals.pokemons[rnd.Next(0, Globals.pokemons.Count)];
                        Globals.encounter.sethp(Globals.encounter.getmaxhp());
                    }
                    else y = y + 10;
                }
                else y = y + 10;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (man == R1)
                { man = R2; }
                else man = R1;
                if (checkCollision())
                { x = x - 30; }
                if (encounter())
                {
                    if (rnd.Next(1, 100) <= encounter_chance)
                    {
                        this.Hide();
                        form2.Show(this);
                        Globals.encounter = Globals.pokemons[rnd.Next(0, Globals.pokemons.Count )];
                        Globals.encounter.sethp(Globals.encounter.getmaxhp());
                    }
                    else x = x + 10;
                }
                else x = x + 10;
            }

            pictureBox1.Refresh();
            pictureBox1.Update();
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'P' || e.KeyChar == 'p')   //press p to view your party screen
            {

                this.Hide();
                form3.Show(this);
            }
            if (e.KeyChar == 'H' || e.KeyChar == 'h')   //heals your team when pressing h
            {
                for (int i = 0; i < Globals.Party.Count; i++)
                {
                    Globals.Party[i].sethp(Globals.Party[i].getmaxhp());
                }
            }

        }
    }
}
