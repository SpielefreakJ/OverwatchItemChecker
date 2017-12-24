using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker
{
    class CHeroImage : PictureBox
    {
        string myHero = "D.Va", myCategory = "Skins"; int myItemname = 5;
        #region ChangeLangVar
        Translate.L_Translate Translate; string myLang;
        //Heros
        Translate.L_Ana Ana;
        Translate.L_Bastion Bastion;
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
        Translate.L_Zarya Zarya;
        Translate.L_Zenyatta Zenyatta;
        #endregion

        public CHeroImage(string Lang)
        {
            SizeMode = PictureBoxSizeMode.AutoSize;

            Image = Image.FromFile("Images\\Items\\" + myHero + "\\" + myCategory + "\\" + myItemname + ".png");
            #region ChangeLangVarDecla
            myLang = Lang;

            Translate = new Translate.L_Translate(myLang);
            //Heros
            Ana = new Translate.L_Ana(myLang);
            Bastion = new Translate.L_Bastion(myLang);
            DVa = new Translate.L_DVa(myLang);
            Doomfist = new Translate.L_Doomfist(myLang);
            Genji = new Translate.L_Genji(myLang);
            Hanzo = new Translate.L_Hanzo(myLang);
            Junkrat = new Translate.L_Junkrat(myLang);
            Lúcio = new Translate.L_Lúcio(myLang);
            McCree = new Translate.L_McCree(myLang);
            Mei = new Translate.L_Mei(myLang);
            Mercy = new Translate.L_Mercy(myLang);
            Moira = new Translate.L_Moira(myLang);
            Orisa = new Translate.L_Orisa(myLang);
            Pharah = new Translate.L_Pharah(myLang);
            Reaper = new Translate.L_Reaper(myLang);
            Reinhardt = new Translate.L_Reinhardt(myLang);
            Roadhog = new Translate.L_Roadhog(myLang);
            Soldier_76 = new Translate.L_Soldier_76(myLang);
            Sombra = new Translate.L_Sombra(myLang);
            Symmetra = new Translate.L_Symmetra(myLang);
            Torbjörn = new Translate.L_Torbjörn(myLang);
            Tracer = new Translate.L_Tracer(myLang);
            Widowmaker = new Translate.L_Widowmaker(myLang);
            Winston = new Translate.L_Winston(myLang);
            Zarya = new Translate.L_Zarya(myLang);
            Zenyatta = new Translate.L_Zenyatta(myLang);
            #endregion
        }

        public void ChangeImage(string Hero, string Category, int Itemname)
        {
            try
            {
                myHero = Hero; myCategory = Category; myItemname = Itemname;

                #region ChangeLang

                if (Category == Translate.Skins)
                {
                    myCategory = "Skins";
                }
                if (Category == Translate.Emotes)
                {
                    myCategory = "Emotes";
                }
                if (Category == Translate.VictoryPoses)
                {
                    myCategory = "Victory Poses";
                }
                if (Category == Translate.Sprays)
                {
                    myCategory = "Sprays";
                }
                if (Category == Translate.HighlightIntros)
                {
                    myCategory = "Highlight Intros";
                }

                if (Hero == Ana.Name)
                {
                    myHero = "Ana";
                }
                if (Hero == Bastion.Name)
                {
                    myHero = "Bastion";
                }
                if (Hero == DVa.Name)
                {
                    myHero = "D.Va";
                }
                if (Hero == Doomfist.Name)
                {
                    myHero = "Doomfist";
                }
                if (Hero == Genji.Name)
                {
                    myHero = "Genji";
                }
                if (Hero == Hanzo.Name)
                {
                    myHero = "Hanzo";
                }
                if (Hero == Junkrat.Name)
                {
                    myHero = "Junkrat";
                }
                if (Hero == Lúcio.Name)
                {
                    myHero = "Lúcio";
                }
                if (Hero == McCree.Name)
                {
                    myHero = "McCree";
                }
                if (Hero == Mei.Name)
                {
                    myHero = "Mei";
                }
                //
                if (Hero == Mercy.Name)
                {
                    myHero = "Mercy";
                }
                if (Hero == Moira.Name)
                {
                    myHero = "Moira";
                }
                if (Hero == Orisa.Name)
                {
                    myHero = "Orisa";
                }
                if (Hero == Pharah.Name)
                {
                    myHero = "Pharah";
                }
                if (Hero == Reaper.Name)
                {
                    myHero = "Reaper";
                }
                if (Hero == Reinhardt.Name)
                {
                    myHero = "Reinhardt";
                }
                if (Hero == Roadhog.Name)
                {
                    myHero = "Roadhog";
                }
                if (Hero == Soldier_76.Name)
                {
                    myHero = "Soldier 76";
                }
                if (Hero == Sombra.Name)
                {
                    myHero = "Sombra";
                }
                if (Hero == Symmetra.Name)
                {
                    myHero = "Symmetra";
                }
                //
                if (Hero == Torbjörn.Name)
                {
                    myHero = "Torbjörn";
                }
                if (Hero == Tracer.Name)
                {
                    myHero = "Tracer";
                }
                if (Hero == Widowmaker.Name)
                {
                    myHero = "Widowmaker";
                }
                if (Hero == Winston.Name)
                {
                    myHero = "Winston";
                }
                if (Hero == Zarya.Name)
                {
                    myHero = "Zarya";
                }
                if (Hero == Zenyatta.Name)
                {
                    myHero = "Zenyatta";
                }
                #endregion

                Image = Image.FromFile("Images\\Items\\" + myHero + "\\" + myCategory + "\\" + myItemname + ".png");
            }
            catch
            {
                MessageBox.Show("An Crittical Error has appeared!\nPlease Post this Issue on GitHub with the Error Code\nError Code: 2","Error 2",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public Image SetImage
        {
            get
            {
                return Image;
            }
            set
            {
                Image = value;
            }
        }

        public string ChangeLang
        {
            get
            {
                return myLang;
            }
            set
            {
                myLang = value;

                Translate.ChangeLang = myLang;
                Ana.ChangeLang = myLang;
                Bastion.ChangeLang = myLang;
                DVa.ChangeLang = myLang;
                Doomfist.ChangeLang = myLang;
                Genji.ChangeLang = myLang;
                Hanzo.ChangeLang = myLang;
                Junkrat.ChangeLang = myLang;
                Lúcio.ChangeLang = myLang;
                McCree.ChangeLang = myLang;
                Mei.ChangeLang = myLang;
                Mercy.ChangeLang = myLang;
                Moira.ChangeLang = myLang;
                Orisa.ChangeLang = myLang;
                Pharah.ChangeLang = myLang;
                Reaper.ChangeLang = myLang;
                Reinhardt.ChangeLang = myLang;
                Roadhog.ChangeLang = myLang;
                Soldier_76.ChangeLang = myLang;
                Sombra.ChangeLang = myLang;
                Symmetra.ChangeLang = myLang;
                Torbjörn.ChangeLang = myLang;
                Tracer.ChangeLang = myLang;
                Widowmaker.ChangeLang = myLang;
                Winston.ChangeLang = myLang;
                Zarya.ChangeLang = myLang;
                Zenyatta.ChangeLang = myLang;
            }
        }
    }
}
