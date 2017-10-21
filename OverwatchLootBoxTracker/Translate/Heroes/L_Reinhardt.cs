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


        //Skin

        //Rare
        public string R2_Brass_SK
        {
            get
            {
                //else
                {
                    return EN.Brass_SK;
                }
            }
        }

        public string R2_Cobalt_SK
        {
            get
            {
                //else
                {
                    return EN.Cobalt_SK;
                }
            }
        }

        public string R2_Copper_SK
        {
            get
            {
                //else
                {
                    return EN.Copper_SK;
                }
            }
        }

        public string R2_Viridian_SK
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
        public string R2_Bundeswehr_SK
        {
            get
            {
                //else
                {
                    return EN.Bundeswehr_SK;
                }
            }
        }

        public string R2_Paragon_SK
        {
            get
            {
                //else
                {
                    return EN.Paragon_SK;
                }
            }
        }

        public string R2_Coldhardt_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Coldhardt_SK;
                }
            }
        }

        public string R2_Lieutenant_Wilhelm_SK
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
        public string R2_Blackhardt_SK
        {
            get
            {
                //else
                {
                    return EN.Blackhardt_SK;
                }
            }
        }

        public string R2_Bloodhardt_SK
        {
            get
            {
                //else
                {
                    return EN.Bloodhardt_SK;
                }
            }
        }

        public string R2_Lionhardt_SK
        {
            get
            {
                //else
                {
                    return EN.Lionhardt_SK;
                }
            }
        }

        public string R2_Stonehardt_SK
        {
            get
            {
                //else
                {
                    return EN.Stonehardt_SK;
                }
            }
        }

        public string R2_Balderich_SK
        {
            get
            {
                //else
                {
                    return EN.Balderich_SK;
                }
            }
        }

        public string R2_Greifhardt_SK
        {
            get
            {
                //else
                {
                    return EN.Greifhardt_SK;
                }
            }
        }

        public string R2_Wujing_SK
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
