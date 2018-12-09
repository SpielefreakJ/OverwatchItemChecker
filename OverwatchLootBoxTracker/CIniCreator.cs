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
        String f = "False", t = "True";

        #region HeroImport
        Translate.L_Ana Ana;
        Translate.L_Bastion Bastion;
        Translate.L_Brigitte Brigitte;
        Translate.L_DVa DVa;
        Translate.L_Doomfist Doomfist;
        Translate.L_Genji Genji;
        Translate.L_Hanzo Hanzo;
        Translate.L_Junkrat Junkrat;
        Translate.L_Lúcio Lúcio;
        Translate.L_McCree McCree;
        Translate.L_Mei Mei;
        Translate.L_Mercy Mercy;
        Translate.L_Moira Moira;
        Translate.L_Orisa Orisa;
        Translate.L_Pharah Pharah;
        Translate.L_Reaper Reaper;
        Translate.L_Reinhardt Reinhardt;
        Translate.L_Roadhog Roadhog;
        Translate.L_Soldier_76 Soldier_76;
        Translate.L_Sombra Sombra;
        Translate.L_Symmetra Symmetra;
        Translate.L_Torbjörn Torbjörn;
        Translate.L_Tracer Tracer;
        Translate.L_Widowmaker Widowmaker;
        Translate.L_Winston Winston;
        Translate.L_WreckingBall WreckingBall;
        Translate.L_Zarya Zarya;
        Translate.L_Zenyatta Zenyatta;

        Translate.L_Translate Lang;
        #endregion

        Int64 Cost = 0;

        public CIniCreator(string Folder)
        {
            Path = Folder;

            Ana = new Translate.L_Ana("EN");
            Bastion = new Translate.L_Bastion("EN");
            Brigitte = new Translate.L_Brigitte("EN");
            DVa = new Translate.L_DVa("EN");
            Doomfist = new Translate.L_Doomfist("EN");
            Genji = new Translate.L_Genji("EN");
            Hanzo = new Translate.L_Hanzo("EN");
            Junkrat = new Translate.L_Junkrat("EN");
            Lúcio = new Translate.L_Lúcio("EN");
            McCree = new Translate.L_McCree("EN");
            Mei = new Translate.L_Mei("EN");
            Mercy = new Translate.L_Mercy("EN");
            Moira = new Translate.L_Moira("EN");
            Orisa = new Translate.L_Orisa("EN");
            Pharah = new Translate.L_Pharah("EN");
            Reaper = new Translate.L_Reaper("EN");
            Reinhardt = new Translate.L_Reinhardt("EN");
            Roadhog = new Translate.L_Roadhog("EN");
            Soldier_76 = new Translate.L_Soldier_76("EN");
            Sombra = new Translate.L_Sombra("EN");
            Symmetra = new Translate.L_Symmetra("EN");
            Torbjörn = new Translate.L_Torbjörn("EN");
            Tracer = new Translate.L_Tracer("EN");
            Widowmaker = new Translate.L_Widowmaker("EN");
            Winston = new Translate.L_Winston("EN");
            WreckingBall = new Translate.L_WreckingBall("EN");
            Zarya = new Translate.L_Zarya("EN");
            Zenyatta = new Translate.L_Zenyatta("EN");

            Lang = new Translate.L_Translate("EN");

        }

        #region Old
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

        #endregion

        // New Hero Roster

        public void Create(string HeroName)
        {
            #region Ana
            if (HeroName == "Ana")
            {
                inisHeroes = new IniStream(Path + "\\Ana.ini");
                #region Skins
                //Rare
                inisHeroes.Write(Ana.Citrine_SK[0], f); Cost = Convert.ToInt64(Ana.Citrine_SK[1]);
                inisHeroes.Write(Ana.Garnet_SK[0], f); Cost = Convert.ToInt64(Ana.Garnet_SK[1]);
                inisHeroes.Write(Ana.Peridot_SK[0], f); Cost = Convert.ToInt64(Ana.Peridot_SK[1]);
                inisHeroes.Write(Ana.Turquoise_SK[0], f); Cost = Convert.ToInt64(Ana.Turquoise_SK[1]);
                //Epic
                inisHeroes.Write(Ana.Merciful_SK[0], f); Cost = Convert.ToInt64(Ana.Merciful_SK[1]);
                inisHeroes.Write(Ana.Shrike_SK[0], f); Cost = Convert.ToInt64(Ana.Shrike_SK[1]);
                //Epic Event
                inisHeroes.Write(Ana.Ghoul_SK[0], f); Cost = Convert.ToInt64(Ana.Ghoul_SK[1]);
                inisHeroes.Write(Ana.Tal_SK[0], f); Cost = Convert.ToInt64(Ana.Tal_SK[1]);
                //Legendary
                inisHeroes.Write(Ana.Wadjet_SK[0], f); Cost = Convert.ToInt64(Ana.Wadjet_SK[1]);
                inisHeroes.Write(Ana.Wasteland_SK[0], f); Cost = Convert.ToInt64(Ana.Wasteland_SK[1]);
                inisHeroes.Write(Ana.Captain_Amari_SK[0], f); Cost = Convert.ToInt64(Ana.Captain_Amari_SK[1]);
                inisHeroes.Write(Ana.Horus_SK[0], f); Cost = Convert.ToInt64(Ana.Horus_SK[1]);
                //Legendary Event
                inisHeroes.Write(Ana.Corsair_SK[0], f); Cost = Convert.ToInt64(Ana.Corsair_SK[1]);
                inisHeroes.Write(Ana.Snow_Owl_SK[0], f); Cost = Convert.ToInt64(Ana.Snow_Owl_SK[1]);
                #endregion
                #region Emotes
                #endregion
                #region Victory Poses
                #endregion
            }
            #endregion

            #region D.Va
            if (HeroName == "D.Va")
            {
                inisHeroes = new IniStream(Path + "\\D.Va.ini");
                #region Skins
                //Rare
                inisHeroes.Write(DVa.Blueberry_SK[0], f); Cost = Convert.ToInt64(DVa.Blueberry_SK[1]);
                inisHeroes.Write(DVa.Lemon_Lime_SK[0], f); Cost = Convert.ToInt64(DVa.Lemon_Lime_SK[1]);
                inisHeroes.Write(DVa.Tangerine_SK[0], f); Cost = Convert.ToInt64(DVa.Tangerine_SK[1]);
                inisHeroes.Write(DVa.Watermelon_SK[0], f); Cost = Convert.ToInt64(DVa.Watermelon_SK[1]);
                //Epic
                inisHeroes.Write(DVa.Carbon_Fiber_SK[0], f); Cost = Convert.ToInt64(DVa.Carbon_Fiber_SK[1]);
                inisHeroes.Write(DVa.White_Rabbit_SK[0], f); Cost = Convert.ToInt64(DVa.White_Rabbit_SK[1]);
                //Epic Event
                inisHeroes.Write(DVa.Taegeukgi_SK[0], f); Cost = Convert.ToInt64(DVa.Taegeukgi_SK[1]);
                //Legendary
                inisHeroes.Write(DVa.Junker_SK[0], f); Cost = Convert.ToInt64(DVa.Junker_SK[1]);
                inisHeroes.Write(DVa.Scavenger_SK[0], f); Cost = Convert.ToInt64(DVa.Scavenger_SK[1]);
                inisHeroes.Write(DVa.BVa_SK[0], f); Cost = Convert.ToInt64(DVa.BVa_SK[1]);
                inisHeroes.Write(DVa.Junebug_SK[0], f); Cost = Convert.ToInt64(DVa.Junebug_SK[1]);
                inisHeroes.Write(DVa.Black_Cat_SK[0], f); Cost = Convert.ToInt64(DVa.Black_Cat_SK[1]);
                inisHeroes.Write(DVa.Officer_SK[0], f); Cost = Convert.ToInt64(DVa.Officer_SK[1]);
                //Legendary Event
                inisHeroes.Write(DVa.Waveracer_SK[0], f); Cost = Convert.ToInt64(DVa.Waveracer_SK[1]);
                inisHeroes.Write(DVa.Palanquin_SK[0], f); Cost = Convert.ToInt64(DVa.Palanquin_SK[1]);
                inisHeroes.Write(DVa.Cruiser_SK[0], f); Cost = Convert.ToInt64(DVa.Cruiser_SK[1]);
                #endregion
                #region Emotes
                #endregion
                #region Victory Poses
                #endregion
            }
            #endregion

            //------------------------------------------------------------//
            #region Weapon
            inisHeroes.Write(Lang.GoldWeapon, f);

            #endregion

            #region OWL
            inisHeroes.Write(Lang.OWL_Boston_Uprising, f);
            inisHeroes.Write(Lang.OWL_Dallas_Fuel, f);
            inisHeroes.Write(Lang.OWL_Florida_Mayhem, f);
            inisHeroes.Write(Lang.OWL_Houston_Outlaws, f);
            inisHeroes.Write(Lang.OWL_London_Spitfire, f);
            inisHeroes.Write(Lang.OWL_Los_Angeles_Gladiators, f);
            inisHeroes.Write(Lang.OWL_Los_Angeles_Valiant, f);
            inisHeroes.Write(Lang.OWL_New_York_Excelsior, f);
            inisHeroes.Write(Lang.OWL_Philadelphia_Fusion, f);
            inisHeroes.Write(Lang.OWL_San_Francisco_Shock, f);
            inisHeroes.Write(Lang.OWL_Seoul_Dynasty, f);
            inisHeroes.Write(Lang.OWL_Shanghai_Dragons, f);

            #endregion
        }

        private void CreateOWL()
        {
        }
    }
}
