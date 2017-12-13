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

        public void create3()
        {
            inisHeroes = new IniStream(Path + "\\Ana.ini");
            inisHeroes.Write("SK14", "false");

            inisHeroes = new IniStream(Path + "\\Bastion.ini");
            inisHeroes.Write("SK17", "false");

            inisHeroes = new IniStream(Path + "\\Genji.ini");
            inisHeroes.Write("VP06", "false");

            inisHeroes = new IniStream(Path + "\\Hanzo.ini");
            inisHeroes.Write("SK13", "false");

            inisHeroes = new IniStream(Path + "\\Junkrat.ini");
            inisHeroes.Write("SK14", "false");

            inisHeroes = new IniStream(Path + "\\Mercy.ini");
            inisHeroes.Write("VP07", "false");

            inisHeroes = new IniStream(Path + "\\Orisa.ini");
            inisHeroes.Write("EM07", "false");

            inisHeroes = new IniStream(Path + "\\Roadhog.ini");
            inisHeroes.Write("SK14", "false");
            inisHeroes.Write("VP07", "false");

            inisHeroes = new IniStream(Path + "\\Soldier_76.ini");
            inisHeroes.Write("SK15", "false");

            inisHeroes = new IniStream(Path + "\\Sombra.ini");
            inisHeroes.Write("SK13", "false");

            inisHeroes = new IniStream(Path + "\\Widowmaker.ini");
            inisHeroes.Write("VP06", "false");

            inisHeroes = new IniStream(Path + "\\Zarya.ini");
            inisHeroes.Write("VP06", "false");

            inisHeroes = new IniStream(Path + "\\Zenyatta.ini");
            inisHeroes.Write("EM07", "false");
            inisHeroes.Write("VP06", "false");
        }
    }
}
