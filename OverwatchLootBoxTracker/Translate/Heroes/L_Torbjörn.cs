using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Torbjörn : PictureBox
    {
        Languages.English.Heroes.Torbjörn EN;
        Languages.German.Heroes.Torbjörn DE;
        string myLang;

        public L_Torbjörn(string Lang)
        {
            if (Lang != "")
            {
                myLang = Lang;
            }

            EN = new Languages.English.Heroes.Torbjörn();
            DE = new Languages.German.Heroes.Torbjörn();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Torbjörn_link.png");
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
        public string Blå_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blå_SK;
                }
                else
                {
                    return EN.Blå_SK;
                }
            }
        }

        public string Citron_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Citron_SK;
                }
                else
                {
                    return EN.Citron_SK;
                }
            }
        }

        public string Grön_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Grön_SK;
                }
                else
                {
                    return EN.Grön_SK;
                }
            }
        }

        public string Plommon_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Plommon_SK;
                }
                else
                {
                    return EN.Plommon_SK;
                }
            }
        }
        //Epic
        public string Cathode_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cathode_SK;
                }
                else
                {
                    return EN.Cathode_SK;
                }
            }
        }

        public string Woodclad_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Woodclad_SK;
                }
                else
                {
                    return EN.Woodclad_SK;
                }
            }
        }

        public string Tre_Kronor_SK//7
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Tre_Kronor_SK;
                }
                else
                {
                    return EN.Tre_Kronor_SK;
                }
            }
        }
        //Legendary
        public string Chopper_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Chopper_SK;
                }
                else
                {
                    return EN.Chopper_SK;
                }
            }
        }

        public string Deadlock_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Deadlock_SK;
                }
                else
                {
                    return EN.Deadlock_SK;
                }
            }
        }

        public string Barbarossa_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Barbarossa_SK;
                }
                else
                {
                    return EN.Barbarossa_SK;
                }
            }
        }

        public string Blackbeard_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blackbeard_SK;
                }
                else
                {
                    return EN.Blackbeard_SK;
                }
            }
        }

        public string Viking_SK//12
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Viking_SK;
                }
                else
                {
                    return EN.Viking_SK;
                }
            }
        }

        public string Santaclad_SK//13
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Santaclad_SK;
                }
                else
                {
                    return EN.Santaclad_SK;
                }
            }
        }

        public string Chief_Engineer_Lindholm_SK//14
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Chief_Engineer_Lindholm_SK;
                }
                else
                {
                    return EN.Chief_Engineer_Lindholm_SK;
                }
            }
        }

        public string Ironclad_SK//15
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ironclad_SK;
                }
                else
                {
                    return EN.Ironclad_SK;
                }
            }
        }

        public string Magni_SK//16
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Magni_SK;
                }
                else
                {
                    return EN.Magni_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Clicking_heels_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Clicking_heels_EM;
                }
                else
                {
                    return EN.Clicking_heels_EM;
                }
            }
        }

        public string Fisticuffs_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Fisticuffs_EM;
                }
                else
                {
                    return EN.Fisticuffs_EM;
                }
            }
        }

        public string Guffaw_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Guffaw_EM;
                }
                else
                {
                    return EN.Guffaw_EM;
                }
            }
        }

        public string Overload_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Overload_EM;
                }
                else
                {
                    return EN.Overload_EM;
                }
            }
        }

        public string Taking_a_break_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Taking_a_break_EM;
                }
                else
                {
                    return EN.Taking_a_break_EM;
                }
            }
        }

        public string Batter_Up_EM//6
        {//Halloween 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Batter_Up_EM;
                }
                else
                {
                    return EN.Batter_Up_EM;
                }
            }
        }

        public string Dance_EM//7
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


        //Victory Poses
        //Rare
        public string Hammer_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Hammer_VP;
                }
                else
                {
                    return EN.Hammer_VP;
                }
            }
        }

        public string Sitting_pretty_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sitting_pretty_VP;
                }
                else
                {
                    return EN.Sitting_pretty_VP;
                }
            }
        }

        public string Take_Five_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Take_Five_VP;
                }
                else
                {
                    return EN.Take_Five_VP;
                }
            }
        }

        public string Medal_VP//4
        {//Summer 16
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
        {//Winter 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Toast_VP;
                }
                else
                {
                    return EN.Toast_VP;
                }
            }
        }
    }
}
