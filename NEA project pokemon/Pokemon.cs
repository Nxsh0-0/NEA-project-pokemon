using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_project_pokemon
{
    internal class Pokemon
    {
         Image sprite;
         string name;
         int maxhp;
         int hp;
         int attack;
         int defence;
        public Pokemon(Image mysprite, string myname, int mymaxhp, int myhp, int myatk, int mydef)
        {
            sprite = mysprite; 
            name = myname;
            maxhp = mymaxhp;
            hp = myhp;
            attack = myatk;
            defence = mydef;
        }
        public void sethp(int newhp)
        {
            hp = newhp;
        }
        public Image getsprite()
            { return sprite; }
    }
    
}
