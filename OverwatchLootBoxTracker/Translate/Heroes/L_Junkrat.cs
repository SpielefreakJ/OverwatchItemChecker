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
        Languages.German.Heroes.DE_Junkrat DE;
        string myLang;

        public L_Junkrat(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Junkrat();
            DE = new Languages.German.Heroes.DE_Junkrat();
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

        public string Dr_Junkenstein_SK//12
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

        public string Cricket_SK//13
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


        //Emotes
    }
}
