using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Sombra
    {
        Languages.English.Heroes.EN_Sombra EN;
        string myLang;

        public L_Sombra(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Sombra();
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
        public string S2_Cidro_SK
        {
            get
            {
                //else
                {
                    return EN.Cidro_SK;
                }
            }
        }

        public string S2_Incendio_SK
        {
            get
            {
                //else
                {
                    return EN.Incendio_SK;
                }
            }
        }

        public string S2_Mar_SK
        {
            get
            {
                //else
                {
                    return EN.Mar_SK;
                }
            }
        }

        public string S2_Noche_SK
        {
            get
            {
                //else
                {
                    return EN.Noche_SK;
                }
            }
        }
        //Epic
        public string S2_Glitch_SK
        {
            get
            {
                //else
                {
                    return EN.Glitch_SK;
                }
            }
        }

        public string S2_Virus_SK
        {
            get
            {
                //else
                {
                    return EN.Virus_SK;
                }
            }
        }

        public string S2_Peppermint_SK
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Peppermint_SK;
                }
            }
        }
        //Legendary
        public string S2_Azúcar_SK
        {
            get
            {
                //else
                {
                    return EN.Azúcar_SK;
                }
            }
        }

        public string S2_Los_Muertos_SK
        {
            get
            {
                //else
                {
                    return EN.Los_Muertos_SK;
                }
            }
        }

        public string S2_Augmented_SK
        {
            get
            {
                //else
                {
                    return EN.Augmented_SK;
                }
            }
        }

        public string S2_Cyberspace_SK
        {
            get
            {
                //else
                {
                    return EN.Cyberspace_SK;
                }
            }
        }

        public string S2_Tulum_SK
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Tulum_SK;
                }
            }
        }


        //Emotes
    }
}
