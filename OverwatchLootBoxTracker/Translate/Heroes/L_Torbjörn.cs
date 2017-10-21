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
        string myLang;

        public L_Torbjörn(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Torbjörn();
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


        //Skin

        //Rare
        public string Blå_SK
        {
            get
            {
                //else
                {
                    return EN.Blå_SK;
                }
            }
        }

        public string Citron_SK
        {
            get
            {
                //else
                {
                    return EN.Citron_SK;
                }
            }
        }

        public string Grön_SK
        {
            get
            {
                //else
                {
                    return EN.Grön_SK;
                }
            }
        }

        public string Plommon_SK
        {
            get
            {
                //else
                {
                    return EN.Plommon_SK;
                }
            }
        }
        //Epic
        public string Cathode_SK
        {
            get
            {
                //else
                {
                    return EN.Cathode_SK;
                }
            }
        }

        public string Woodclad_SK
        {
            get
            {
                //else
                {
                    return EN.Woodclad_SK;
                }
            }
        }

        public string Tre_Kronor_SK
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Tre_Kronor_SK;
                }
            }
        }
        //Legendary
        public string Chopper_SK
        {
            get
            {
                //else
                {
                    return EN.Chopper_SK;
                }
            }
        }

        public string Deadlock_SK
        {
            get
            {
                //else
                {
                    return EN.Deadlock_SK;
                }
            }
        }

        public string Barbarossa_SK
        {
            get
            {
                //else
                {
                    return EN.Barbarossa_SK;
                }
            }
        }

        public string Blackbeard_SK
        {
            get
            {
                //else
                {
                    return EN.Blackbeard_SK;
                }
            }
        }

        public string Viking_SK
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Viking_SK;
                }
            }
        }

        public string Santaclad_SK
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Santaclad_SK;
                }
            }
        }

        public string Chief_Engineer_Lindholm_SK
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Chief_Engineer_Lindholm_SK;
                }
            }
        }

        public string Ironclad_SK
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Ironclad_SK;
                }
            }
        }


        //Emotes
    }
}
