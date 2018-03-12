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
                    inisHeroes.Write("VL0" + i, "false");
                else
                    inisHeroes.Write("VL" + i, "false");
            }
        }

        public void create3(string Hero)
        {
            inisHeroes = new IniStream(Path + "\\" + Hero + ".ini");

            if (Hero == "Ana")
                inisHeroes.Write("SK14", "false");

            if (Hero == "Bastion")
                inisHeroes.Write("SK17", "false");

            if (Hero == "Genji")
                inisHeroes.Write("VP06", "false");

            if (Hero == "Hanzo")
                inisHeroes.Write("SK13", "false");

            if (Hero == "Junkrat")
                inisHeroes.Write("SK14", "false");

            if (Hero == "Mercy")
                inisHeroes.Write("VP07", "false");

            if (Hero == "Orisa")
                inisHeroes.Write("EM07", "false");

            if (Hero == "Roadhog")
            {
                inisHeroes.Write("SK14", "false");
                inisHeroes.Write("VP07", "false");
            }

            if (Hero == "Soldier_76")
                inisHeroes.Write("SK15", "false");

            if (Hero == "Sombra")
            {
                inisHeroes.Write("SK13", "false");
                inisHeroes.Write("VP07", "false");
            }

            if (Hero == "Widowmaker")
                inisHeroes.Write("VP06", "false");

            if (Hero == "Zarya")
                inisHeroes.Write("VP06", "false");

            if (Hero == "Zenyatta")
            {
                inisHeroes.Write("EM07", "false");
                inisHeroes.Write("VP06", "false");
            }
        }
        public void create4(string Hero)
        {
            inisHeroes = new IniStream(Path + "\\" + Hero + ".ini");

            if (Hero == "Bastion")
                inisHeroes.Write("VP07", "false");
        }

        public void create5(string Hero)
        {
            inisHeroes = new IniStream(Path + "\\" + Hero + ".ini");
            inisHeroes.Write("GW01", "false");
        }

        public void create6(string Hero)
        {
            inisHeroes = new IniStream(Path + "\\" + Hero + ".ini");
            inisHeroes.Write("OWL01", "false");
            inisHeroes.Write("OWL02", "false");
            inisHeroes.Write("OWL03", "false");
            inisHeroes.Write("OWL04", "false");
            inisHeroes.Write("OWL05", "false");
            inisHeroes.Write("OWL06", "false");
            inisHeroes.Write("OWL07", "false");
            inisHeroes.Write("OWL08", "false");
            inisHeroes.Write("OWL09", "false");
            inisHeroes.Write("OWL10", "false");
            inisHeroes.Write("OWL11", "false");
            inisHeroes.Write("OWL12", "false");
        }

        public void create7(string Hero)
        {
            inisHeroes = new IniStream(Path + "\\" + Hero + ".ini");
            if (Hero == "Doomfist")
                inisHeroes.Write("SK11", "false");

            if (Hero == "Orisa")
                inisHeroes.Write("SK12", "false");

            if (Hero == "Roadhog" || Hero == "Widowmaker")
                inisHeroes.Write("SK15", "false");

            if (Hero == "Zarya" || Hero == "Torbjörn" || Hero == "Mei" || Hero == "Reinhardt")
                inisHeroes.Write("SK16", "false");
        }

        public void create8(string Hero)
        {//BlizzardWorld Update
            inisHeroes = new IniStream(Path + "\\" + Hero + ".ini");

            if (Hero == "Hanzo")
                inisHeroes.Write("SK14", "false");

            if (Hero == "D.Va" || Hero == "Junkrat" || Hero == "Lúcio" || Hero == "Pharah" || Hero == "Symmetra" || Hero == "Zenyatta")
                inisHeroes.Write("SK15", "false");

            if (Hero == "McCree" || Hero == "Reaper")
                inisHeroes.Write("SK16", "false");

            if (Hero == "Moira")
                inisHeroes.Write("EM06", "false");

            if (Hero == "Genji" || Hero == "Mercy" || Hero == "Sombra" || Hero == "Tracer")
                inisHeroes.Write("EM07", "false");
        }

        public void create9(string Hero)
        {//Lunar 18
            inisHeroes = new IniStream(Path + "\\" + Hero + ".ini");

            if (Hero == "Genji")
                inisHeroes.Write("SK15", "false");

            if (Hero == "Mercy" || Hero == "Pharah" || Hero == "Widowmaker")
                inisHeroes.Write("SK16", "false");

            if (Hero == "McCree" || Hero == "Zarya")
                inisHeroes.Write("SK17", "false");

            if (Hero == "Doomfist")
                inisHeroes.Write("EM06", "false");

            if (Hero == "Roadhog")
                inisHeroes.Write("EM07", "false");

            if (Hero == "McCree")
                inisHeroes.Write("VP06", "false");

            if (Hero == "Symmetra" || Hero == "Tracer" || Hero == "Widowmaker" || Hero == "Winston" || Hero == "Zarya")
                inisHeroes.Write("VP07", "false");
        }

        public void create10(string Hero)
        {//Only new Widow Skin -.-
            inisHeroes = new IniStream(Path + "\\" + Hero + ".ini");

            if (Hero == "Widowmaker")
                inisHeroes.Write("SK17", "false");
        }
    }
}
