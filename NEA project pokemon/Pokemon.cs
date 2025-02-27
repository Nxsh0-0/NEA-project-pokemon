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
         Image backsprite;
         string name;
         int maxhp;
         int hp;
         int attack;    
         int defence;
       
        public Pokemon(Image mysprite,Image mybacksprite, string myname, int mymaxhp, int myhp, int myatk, int mydef)
        {
            sprite = mysprite; 
            backsprite = mybacksprite;
            name = myname;
            maxhp = mymaxhp;
            hp = myhp;
            attack = myatk;
            defence = mydef;
        }
        public Image getbacksprite()
        { return backsprite; }
        public Image getsprite()
        { return sprite; }
        public void sethp(int newhp)
        { hp = newhp; }
        public int gethp()
        { return hp; }
        public string getname()
        { return name; }
        public int getmaxhp() 
        { return maxhp;}
        public int getatk()
        { return attack;}
        public int getdef()
        { return defence;}
    }
  
    
}
