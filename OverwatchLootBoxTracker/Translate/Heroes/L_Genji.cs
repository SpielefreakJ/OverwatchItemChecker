using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Genji
    {
        Languages.English.Heroes.EN_Genji EN;
        string myLang;

        public L_Genji(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Genji();
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
        public string Azurite_SK
        {
            get
            {
                //else
                {
                    return EN.Azurite_SK;
                }
            }
        }

        public string Cinnabar_SK
        {
            get
            {
                //else
                {
                    return EN.Cinnabar_SK;
                }
            }
        }

        public string Malachite_SK
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
        public string Carbon_Fiber_SK
        {
            get
            {
                //else
                {
                    return EN.Carbon_Fiber_SK;
                }
            }
        }

        public string Chrome_SK
        {
            get
            {
                //else
                {
                    return EN.Chrome_SK;
                }
            }
        }

        public string Nihon_SK
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
        public string Sparrow_SK
        {
            get
            {
                //else
                {
                    return EN.Sparrow_SK;
                }
            }
        }

        public string Young_Genji_SK
        {
            get
            {
                //else
                {
                    return EN.Young_Genji_SK;
                }
            }
        }

        public string Bedouin_SK
        {
            get
            {
                //else
                {
                    return EN.Bedouin_SK;
                }
            }
        }

        public string Nomad_SK
        {
            get
            {
                //else
                {
                    return EN.Nomad_SK;
                }
            }
        }

        public string Oni_SK
        {
            get
            {
                //else
                {
                    return EN.Oni_SK;
                }
            }
        }

        public string Blackwatch_SK
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Blackwatch_SK;
                }
            }
        }

        public string Sentai_SK
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
