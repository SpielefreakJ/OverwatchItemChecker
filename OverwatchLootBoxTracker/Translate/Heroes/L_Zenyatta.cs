using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Zenyatta
    {
        Languages.English.Heroes.EN_Zenyatta EN;
        string myLang;

        public L_Zenyatta(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Zenyatta();
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
        public string Air_SK
        {
            get
            {
                //else
                {
                    return EN.Air_SK;
                }
            }
        }

        public string Earth_SK
        {
            get
            {
                //else
                {
                    return EN.Earth_SK;
                }
            }
        }

        public string Leaf_SK
        {
            get
            {
                //else
                {
                    return EN.Leaf_SK;
                }
            }
        }

        public string Water_SK
        {
            get
            {
                //else
                {
                    return EN.Water_SK;
                }
            }
        }
        //Epic
        public string Ascendant_SK
        {
            get
            {
                //else
                {
                    return EN.Ascendant_SK;
                }
            }
        }

        public string Harmonious_SK
        {
            get
            {
                //else
                {
                    return EN.Harmonious_SK;
                }
            }
        }

        public string Skullyatta_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Skullyatta_SK;
                }
            }
        }
        //Legendary
        public string Djinnyatta_SK
        {
            get
            {
                //else
                {
                    return EN.Djinnyatta_SK;
                }
            }
        }

        public string Ifrit_SK
        {
            get
            {
                //else
                {
                    return EN.Ifrit_SK;
                }
            }
        }

        public string Ra_SK
        {
            get
            {
                //else
                {
                    return EN.Ra_SK;
                }
            }
        }

        public string Sunyatta_SK
        {
            get
            {
                //else
                {
                    return EN.Sunyatta_SK;
                }
            }
        }

        public string Cultist_SK
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Cultist_SK;
                }
            }
        }

        public string Nutcracker_SK
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Nutcracker_SK;
                }
            }
        }

        public string Sanzang_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Sanzang_SK;
                }
            }
        }


        //Emotes
    }
}
