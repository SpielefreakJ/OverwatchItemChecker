using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Torbjörn
    {
        Languages.English.Heroes.EN_Torbjörn EN;
        Languages.German.Heroes.DE_Torbjörn DE;
        string myLang;

        public L_Torbjörn(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Torbjörn();
            DE = new Languages.German.Heroes.DE_Torbjörn();
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

        public string Name
        {
            get
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


        //Emotes
        //Epic
        public string Clicking_heels_EM//1
        {
            get
            {
                //else
                {
                    return EN.Clicking_heels_EM;
                }
            }
        }

        public string Fisticuffs_EM//2
        {
            get
            {
                //else
                {
                    return EN.Fisticuffs_EM;
                }
            }
        }

        public string Guffaw_EM//3
        {
            get
            {
                //else
                {
                    return EN.Guffaw_EM;
                }
            }
        }

        public string Overload_EM//4
        {
            get
            {
                //else
                {
                    return EN.Overload_EM;
                }
            }
        }

        public string Taking_a_break_EM//5
        {
            get
            {
                //else
                {
                    return EN.Taking_a_break_EM;
                }
            }
        }

        public string Batter_Up_EM//6
        {//Halloween 17
            get
            {
                //else
                {
                    return EN.Batter_Up_EM;
                }
            }
        }

        public string Dance_EM//7
        {//Annyver 17
            get
            {
                //else
                {
                    return EN.Dance_EM;
                }
            }
        }
    }
}
