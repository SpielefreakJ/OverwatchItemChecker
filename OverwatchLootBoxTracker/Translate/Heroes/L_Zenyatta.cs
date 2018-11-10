using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Zenyatta : PictureBox
    {
        Languages.English.Heroes.Zenyatta EN;
        Languages.German.Heroes.Zenyatta DE;
        string myLang;

        public L_Zenyatta(string Lang)
        {
            if (Lang != "")
            {
                myLang = Lang;
            }

            EN = new Languages.English.Heroes.Zenyatta();
            DE = new Languages.German.Heroes.Zenyatta();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Zenyatta_link.png");
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
        public string Air_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Air_SK;
                }
                else
                {
                    return EN.Air_SK;
                }
            }
        }

        public string Earth_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Earth_SK;
                }
                else
                {
                    return EN.Earth_SK;
                }
            }
        }

        public string Leaf_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Leaf_SK;
                }
                else
                {
                    return EN.Leaf_SK;
                }
            }
        }

        public string Water_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Water_SK;
                }
                else
                {
                    return EN.Water_SK;
                }
            }
        }
        //Epic
        public string Ascendant_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ascendant_SK;
                }
                else
                {
                    return EN.Ascendant_SK;
                }
            }
        }

        public string Harmonious_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Harmonious_SK;
                }
                else
                {
                    return EN.Harmonious_SK;
                }
            }
        }

        public string Skullyatta_SK//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Skullyatta_SK;
                }
                else
                {
                    return EN.Skullyatta_SK;
                }
            }
        }
        //Legendary
        public string Djinnyatta_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Djinnyatta_SK;
                }
                else
                {
                    return EN.Djinnyatta_SK;
                }
            }
        }

        public string Ifrit_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ifrit_SK;
                }
                else
                {
                    return EN.Ifrit_SK;
                }
            }
        }

        public string Ra_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ra_SK;
                }
                else
                {
                    return EN.Ra_SK;
                }
            }
        }

        public string Sunyatta_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sunyatta_SK;
                }
                else
                {
                    return EN.Sunyatta_SK;
                }
            }
        }

        public string Cultist_SK//12
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cultist_SK;
                }
                else
                {
                    return EN.Cultist_SK;
                }
            }
        }

        public string Nutcracker_SK//13
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Nutcracker_SK;
                }
                else
                {
                    return EN.Nutcracker_SK;
                }
            }
        }

        public string Sanzang_SK//14
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sanzang_SK;
                }
                else
                {
                    return EN.Sanzang_SK;
                }
            }
        }
        //Epic
        public string Carbon_Fiber_SK//15
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Carbon_Fiber_SK;
                }
                else
                {
                    return EN.Carbon_Fiber_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Focusing_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Focusiong_EM;
                }
                else
                {
                    return EN.Focusiong_EM;
                }
            }
        }

        public string Meditate_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Meditate_EM;
                }
                else
                {
                    return EN.Meditate_EM;
                }
            }
        }

        public string Round_of_Applause_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Round_of_Applause_EM;
                }
                else
                {
                    return EN.Round_of_Applause_EM;
                }
            }
        }

        public string Taunt_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Taunt_EM;
                }
                else
                {
                    return EN.Taunt_EM;
                }
            }
        }

        public string Tickled_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Tickled_EM;
                }
                else
                {
                    return EN.Tickled_EM;
                }
            }
        }

        public string Dance_EM//6
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dance_EM;
                }
                else
                {
                    return EN.Dance_EM;
                }
            }
        }

        public string Snowflake_EM//7
        {//Winter 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dance_EM;
                }
                else
                {
                    return EN.Snowflake_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Balance_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Balance_VP;
                }
                else
                {
                    return EN.Balance_VP;
                }
            }
        }

        public string Harmony_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Harmony_VP;
                }
                else
                {
                    return EN.Harmony_VP;
                }
            }
        }

        public string Peace_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Peace_VP;
                }
                else
                {
                    return EN.Peace_VP;
                }
            }
        }

        public string Medals_VP//4
        {//Summer 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Medals_VP;
                }
                else
                {
                    return EN.Medals_VP;
                }
            }
        }

        public string RIP_VP//5
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

        public string Toast_VP//6
        {//Winter 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.RIP_VP;
                }
                else
                {
                    return EN.Toast_VP;
                }
            }
        }
    }
}
