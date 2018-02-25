using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Junkrat : PictureBox
    {
        Languages.English.Heroes.Junkrat EN;
        Languages.German.Heroes.Junkrat DE;
        string myLang;

        public L_Junkrat(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.Junkrat();
            DE = new Languages.German.Heroes.Junkrat();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Junkrat_link.png");
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
            }
        }

        public string GetName()
        {
            if (myLang == "DE")
            {
                return DE.Name;
            }
            else
            {
                return EN.Name;
            }
        }


        //Skin

        //Rare
        public string Bleached_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bleached_SK;
                }
                else
                {
                    return EN.Bleached_SK;
                }
            }
        }

        public string Drowned_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Drowned_SK;
                }
                else
                {
                    return EN.Drowned_SK;
                }
            }
        }

        public string Irradiated_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Irradiated_SK;
                }
                else
                {
                    return EN.Irradiated_SK;
                }
            }
        }

        public string Rusted_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Rusted_SK;
                }
                else
                {
                    return EN.Rusted_SK;
                }
            }
        }
        //Epic
        public string Jailbird_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Jailbird_SK;
                }
                else
                {
                    return EN.Jailbird_SK;
                }
            }
        }

        public string Toasted_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Toasted_SK;
                }
                else
                {
                    return EN.Toasted_SK;
                }
            }
        }

        public string Firework_SK//7
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Firework_SK;
                }
                else
                {
                    return EN.Firework_SK;
                }
            }
        }
        //Legendary
        public string Fool_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Fool_SK;
                }
                else
                {
                    return EN.Fool_SK;
                }
            }
        }

        public string Jester_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Jester_SK;
                }
                else
                {
                    return EN.Jester_SK;
                }
            }
        }

        public string Hayseed_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Hayseed_SK;
                }
                else
                {
                    return EN.Hayseed_SK;
                }
            }
        }

        public string Scarecrow_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Scarecrow_SK;
                }
                else
                {
                    return EN.Scarecrow_SK;
                }
            }
        }

        public string Cricket_SK//12
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cricket_SK;
                }
                else
                {
                    return EN.Cricket_SK;
                }
            }
        }

        public string Dr_Junkenstein_SK//13
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dr_Junkenstein_SK;
                }
                else
                {
                    return EN.Dr_Junkenstein_SK;
                }
            }
        }

        public string Beachrat_SK//14
        {//Winter 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dr_Junkenstein_SK;
                }
                else
                {
                    return EN.Beachrat_SK;
                }
            }
        }
        //Epic
        public string Caution_SK//15
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Caution_SK;
                }
                else
                {
                    return EN.Caution_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Cant_Deal_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cant_Deal_EM;
                }
                else
                {
                    return EN.Cant_Deal_EM;
                }
            }
        }

        public string Juggling_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Juggling_EM;
                }
                else
                {
                    return EN.Juggling_EM;
                }
            }
        }

        public string Lounging_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Lounging_EM;
                }
                else
                {
                    return EN.Lounging_EM;
                }
            }
        }

        public string Puppet_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Puppet_EM;
                }
                else
                {
                    return EN.Puppet_EM;
                }
            }
        }

        public string Vaudeville_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Vaudeville_EM;
                }
                else
                {
                    return EN.Vaudeville_EM;
                }
            }
        }

        public string Dud_EM//6
        {//Rooster 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dud_EM;
                }
                else
                {
                    return EN.Dud_EM;
                }
            }
        }

        public string Running_Rat_EM//7
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Running_Rat_EM;
                }
                else
                {
                    return EN.Running_Rat_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Itll_freeze_that_way_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Itll_freeze_that_way_VP;
                }
                else
                {
                    return EN.Itll_freeze_that_way_VP;
                }
            }
        }

        public string Kneeling_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Kneeling_VP;
                }
                else
                {
                    return EN.Kneeling_VP;
                }
            }
        }

        public string Nyah_Nyah_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Nyah_Nyah_VP;
                }
                else
                {
                    return EN.Nyah_Nyah_VP;
                }
            }
        }

        public string Medal_VP//4
        {//Summer 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Medal_VP;
                }
                else
                {
                    return EN.Medal_VP;
                }
            }
        }

        public string Pumpkin_VP//5
        {//Halloween 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Pumpkin_VP;
                }
                else
                {
                    return EN.Pumpkin_VP;
                }
            }
        }

        public string RIP_VP//6
        {//Halloween 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.RIP_VP;
                }
                else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string Bad_for_your_health_VP//7
        {//Rooster 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bad_for_your_health_VP;
                }
                else
                {
                    return EN.Bad_for_your_health_VP;
                }
            }
        }
    }
}
