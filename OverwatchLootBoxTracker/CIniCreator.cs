using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class CIniCreator
    {
        IniStream inisHeroes = null;
        //IniStream inisPI = null;
        string Path = null;

        public CIniCreator(string Folder)
        {
            Path = Folder;
        }

        public void Heroe(string name, int Skin, int Emote)
        {
            inisHeroes = new IniStream(Path + "\\" + name + ".ini");

            for (int i = 1; i <= Skin; i++)
            {
                if (i < 10)
                {
                    inisHeroes.Write("SK0" + i, "false");
                }
                else
                {
                    inisHeroes.Write("SK" + i, "false");
                }
            }
            for (int i = 1; i <= Emote; i++)
            {
                if (i < 10)
                {
                    inisHeroes.Write("EM0" + i, "false");
                }
                else
                {
                    inisHeroes.Write("EM" + i, "false");
                }
            }
        }

        public void VP(string name, int Victory_Pose)
        {
            inisHeroes = new IniStream(Path + "\\" + name + ".ini");

            for (int i = 1; i <= Victory_Pose; i++)
            {
                if (i < 10)
                {
                    inisHeroes.Write("VP0" + i, "false");
                }
                else
                {
                    inisHeroes.Write("VP" + i, "false");
                }
            }
        }

        public void VL(string name, int Voice_Line)
        {
            inisHeroes = new IniStream(Path + "\\" + name + ".ini");

            for (int i = 1; i <= Voice_Line; i++)
            {
                if (i < 10)
                {
                    inisHeroes.Write("VL0" + i, "false");
                }
                else
                {
                    inisHeroes.Write("VL" + i, "false");
                }
            }
        }
    }
}
