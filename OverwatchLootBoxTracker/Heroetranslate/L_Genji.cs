using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class L_Genji
    {
        Languages.English.Heroes.EN_Genji EN;
        string myLang;

        L_Genji(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Genji();
        }


        //Skin

        //Rare
        public string G1_Azurite_SK
        {
            get
            {
                //else
                {
                    return EN.Azurite_SK;
                }
            }
        }

        public string G1_Cinnabar_SK
        {
            get
            {
                //else
                {
                    return EN.Cinnabar_SK;
                }
            }
        }

        public string G1_Malachite_SK
        {
            get
            {
                //else
                {
                    return EN.Malachite_SK;
                }
            }
        }
        //Epic
        public string G1_Carbon_Fiber_SK
        {
            get
            {
                //else
                {
                    return EN.Carbon_Fiber_SK;
                }
            }
        }

        public string G1_Chrome_SK
        {
            get
            {
                //else
                {
                    return EN.Chrome_SK;
                }
            }
        }

        public string G1_Nihon_SK
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Nihon_SK;
                }
            }
        }
        //Legendary
        public string G1_Sparrow_SK
        {
            get
            {
                //else
                {
                    return EN.Sparrow_SK;
                }
            }
        }

        public string G1_Young_Genji_SK
        {
            get
            {
                //else
                {
                    return EN.Young_Genji_SK;
                }
            }
        }

        public string G1_Bedouin_SK
        {
            get
            {
                //else
                {
                    return EN.Bedouin_SK;
                }
            }
        }

        public string G1_Nomad_SK
        {
            get
            {
                //else
                {
                    return EN.Nomad_SK;
                }
            }
        }

        public string G1_Oni_SK
        {
            get
            {
                //else
                {
                    return EN.Oni_SK;
                }
            }
        }

        public string G1_Blackwatch_SK
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Blackwatch_SK;
                }
            }
        }

        public string G1_Sentai_SK
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Sentai_SK;
                }
            }
        }


        //Emotes
    }
}
