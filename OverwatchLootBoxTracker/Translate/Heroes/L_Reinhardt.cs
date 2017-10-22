using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Reinhardt
    {
        Languages.English.Heroes.EN_Reinhardt EN;
        string myLang;

        public L_Reinhardt(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Reinhardt();
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
        public string Brass_SK//1
        {
            get
            {
                //else
                {
                    return EN.Brass_SK;
                }
            }
        }

        public string Cobalt_SK//2
        {
            get
            {
                //else
                {
                    return EN.Cobalt_SK;
                }
            }
        }

        public string Copper_SK//3
        {
            get
            {
                //else
                {
                    return EN.Copper_SK;
                }
            }
        }

        public string Viridian_SK//4
        {
            get
            {
                //else
                {
                    return EN.Viridian_SK;
                }
            }
        }
        //Epic
        public string Bundeswehr_SK//5
        {
            get
            {
                //else
                {
                    return EN.Bundeswehr_SK;
                }
            }
        }

        public string Paragon_SK//6
        {
            get
            {
                //else
                {
                    return EN.Paragon_SK;
                }
            }
        }

        public string Coldhardt_SK//7
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Coldhardt_SK;
                }
            }
        }

        public string Lieutenant_Wilhelm_SK//8
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Lieutenant_Wilhelm_SK;
                }
            }
        }
        //Legendary
        public string Blackhardt_SK//9
        {
            get
            {
                //else
                {
                    return EN.Blackhardt_SK;
                }
            }
        }

        public string Bloodhardt_SK//10
        {
            get
            {
                //else
                {
                    return EN.Bloodhardt_SK;
                }
            }
        }

        public string Lionhardt_SK//11
        {
            get
            {
                //else
                {
                    return EN.Lionhardt_SK;
                }
            }
        }

        public string Stonehardt_SK//12
        {
            get
            {
                //else
                {
                    return EN.Stonehardt_SK;
                }
            }
        }

        public string Balderich_SK//13
        {
            get
            {
                //else
                {
                    return EN.Balderich_SK;
                }
            }
        }

        public string Greifhardt_SK//14
        {
            get
            {
                //else
                {
                    return EN.Greifhardt_SK;
                }
            }
        }

        public string Wujing_SK//15
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Wujing_SK;
                }
            }
        }


        //Emotes
    }
}
