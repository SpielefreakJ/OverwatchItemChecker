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
        public string Cidro_SK//1
        {
            get
            {
                //else
                {
                    return EN.Cidro_SK;
                }
            }
        }

        public string Incendio_SK//2
        {
            get
            {
                //else
                {
                    return EN.Incendio_SK;
                }
            }
        }

        public string Mar_SK//3
        {
            get
            {
                //else
                {
                    return EN.Mar_SK;
                }
            }
        }

        public string Noche_SK//4
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
        public string Glitch_SK//5
        {
            get
            {
                //else
                {
                    return EN.Glitch_SK;
                }
            }
        }

        public string Virus_SK//6
        {
            get
            {
                //else
                {
                    return EN.Virus_SK;
                }
            }
        }

        public string Peppermint_SK//7
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
        public string Azúcar_SK//8
        {
            get
            {
                //else
                {
                    return EN.Azúcar_SK;
                }
            }
        }

        public string Los_Muertos_SK//9
        {
            get
            {
                //else
                {
                    return EN.Los_Muertos_SK;
                }
            }
        }

        public string Augmented_SK//10
        {
            get
            {
                //else
                {
                    return EN.Augmented_SK;
                }
            }
        }

        public string Cyberspace_SK//11
        {
            get
            {
                //else
                {
                    return EN.Cyberspace_SK;
                }
            }
        }

        public string Tulum_SK//12
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
