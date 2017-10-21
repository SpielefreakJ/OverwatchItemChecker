using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class L_Junkrat
    {
        Languages.English.Heroes.EN_Junkrat EN;
        string myLang;

        L_Junkrat(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Junkrat();
        }

        public string J1_ChangeLang
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
        public string J1_Bleached_SK
        {
            get
            {
                //else
                {
                    return EN.Bleached_SK;
                }
            }
        }

        public string J1_Drowned_SK
        {
            get
            {
                //else
                {
                    return EN.Drowned_SK;
                }
            }
        }

        public string J1_Irradiated_SK
        {
            get
            {
                //else
                {
                    return EN.Irradiated_SK;
                }
            }
        }

        public string J1_Rusted_SK
        {
            get
            {
                //else
                {
                    return EN.Rusted_SK;
                }
            }
        }
        //Epic
        public string J1_Jailbird_SK
        {
            get
            {
                //else
                {
                    return EN.Jailbird_SK;
                }
            }
        }

        public string J1_Toasted_SK
        {
            get
            {
                //else
                {
                    return EN.Toasted_SK;
                }
            }
        }

        public string J1_Firework_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Firework_SK;
                }
            }
        }
        //Legendary
        public string J1_Fool_SK
        {
            get
            {
                //else
                {
                    return EN.Fool_SK;
                }
            }
        }

        public string J1_Jester_SK
        {
            get
            {
                //else
                {
                    return EN.Jester_SK;
                }
            }
        }

        public string J1_Hayseed_SK
        {
            get
            {
                //else
                {
                    return EN.Hayseed_SK;
                }
            }
        }

        public string J1_Scarecrow_SK
        {
            get
            {
                //else
                {
                    return EN.Scarecrow_SK;
                }
            }
        }

        public string J1_Dr_Junkenstein_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Dr_Junkenstein_SK;
                }
            }
        }

        public string J1_Cricket_SK
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Cricket_SK;
                }
            }
        }


        //Emotes
    }
}
