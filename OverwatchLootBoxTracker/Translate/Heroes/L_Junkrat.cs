using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Junkrat
    {
        Languages.English.Heroes.EN_Junkrat EN;
        string myLang;

        public L_Junkrat(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Junkrat();
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
                //else
                {
                    return EN.Name;
                }
            }
        }


        //Skin

        //Rare
        public string Bleached_SK//1
        {
            get
            {
                //else
                {
                    return EN.Bleached_SK;
                }
            }
        }

        public string Drowned_SK//2
        {
            get
            {
                //else
                {
                    return EN.Drowned_SK;
                }
            }
        }

        public string Irradiated_SK//3
        {
            get
            {
                //else
                {
                    return EN.Irradiated_SK;
                }
            }
        }

        public string Rusted_SK//4
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
        public string Jailbird_SK//5
        {
            get
            {
                //else
                {
                    return EN.Jailbird_SK;
                }
            }
        }

        public string Toasted_SK//6
        {
            get
            {
                //else
                {
                    return EN.Toasted_SK;
                }
            }
        }

        public string Firework_SK//7
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
        public string Fool_SK//8
        {
            get
            {
                //else
                {
                    return EN.Fool_SK;
                }
            }
        }

        public string Jester_SK//9
        {
            get
            {
                //else
                {
                    return EN.Jester_SK;
                }
            }
        }

        public string Hayseed_SK//10
        {
            get
            {
                //else
                {
                    return EN.Hayseed_SK;
                }
            }
        }

        public string Scarecrow_SK//11
        {
            get
            {
                //else
                {
                    return EN.Scarecrow_SK;
                }
            }
        }

        public string Dr_Junkenstein_SK//12
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Dr_Junkenstein_SK;
                }
            }
        }

        public string Cricket_SK//13
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
