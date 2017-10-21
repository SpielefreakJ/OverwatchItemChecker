using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Pharah
    {
        Languages.English.Heroes.EN_Pharah EN;
        string myLang;

        public L_Pharah(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Pharah();
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
        public string P1_Amethyst_SK
        {
            get
            {
                //else
                {
                    return EN.Amethyst_SK;
                }
            }
        }

        public string P1_Copper_SK
        {
            get
            {
                //else
                {
                    return EN.Copper_SK;
                }
            }
        }

        public string P1_Emerald_SK
        {
            get
            {
                //else
                {
                    return EN.Emerald_SK;
                }
            }
        }

        public string P1_Titanium_SK
        {
            get
            {
                //else
                {
                    return EN.Titanium_SK;
                }
            }
        }
        //Epic
        public string P1_Anubis_SK
        {
            get
            {
                //else
                {
                    return EN.Anubis_SK;
                }
            }
        }

        public string P1_Jackal_SK
        {
            get
            {
                //else
                {
                    return EN.Jackal_SK;
                }
            }
        }

        public string P1_Possessed_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Possessed_SK;
                }
            }
        }

        public string P1_Frostbite_SK
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Frostbite_SK;
                }
            }
        }
        //Legendary
        public string P1_Mechaqueen_SK
        {
            get
            {
                //else
                {
                    return EN.Mechaqueen_SK;
                }
            }
        }

        public string P1_Raptorion_SK
        {
            get
            {
                //else
                {
                    return EN.Raptorion_SK;
                }
            }
        }

        public string P1_Raindancer_SK
        {
            get
            {
                //else
                {
                    return EN.Raindancer_SK;
                }
            }
        }

        public string P1_Thunderbird_SK
        {
            get
            {
                //else
                {
                    return EN.Thunderbird_SK;
                }
            }
        }

        public string P1_Security_Chief_SK
        {//Origin Special
            get
            {
                //else
                {
                    return EN.Security_Chief_SK;
                }
            }
        }

        public string P1_Bedouin_SK
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Bedouin_SK;
                }
            }
        }


        //Emotes
    }
}
