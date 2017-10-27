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
        Languages.German.Heroes.DE_Sombra DE;
        string myLang;

        public L_Sombra(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Sombra();
            DE = new Languages.German.Heroes.DE_Sombra();
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
        public string Cidro_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cidro_SK;
                }
                else
                {
                    return EN.Cidro_SK;
                }
            }
        }

        public string Incendio_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Incendio_SK;
                }
                else
                {
                    return EN.Incendio_SK;
                }
            }
        }

        public string Mar_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mar_SK;
                }
                else
                {
                    return EN.Mar_SK;
                }
            }
        }

        public string Noche_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Noche_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Glitch_SK;
                }
                else
                {
                    return EN.Glitch_SK;
                }
            }
        }

        public string Virus_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Virus_SK;
                }
                else
                {
                    return EN.Virus_SK;
                }
            }
        }

        public string Peppermint_SK//7
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Peppermint_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Azúcar_SK;
                }
                else
                {
                    return EN.Azúcar_SK;
                }
            }
        }

        public string Los_Muertos_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Los_Muertos_SK;
                }
                else
                {
                    return EN.Los_Muertos_SK;
                }
            }
        }

        public string Augmented_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Augmented_SK;
                }
                else
                {
                    return EN.Augmented_SK;
                }
            }
        }

        public string Cyberspace_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cyberspace_SK;
                }
                else
                {
                    return EN.Cyberspace_SK;
                }
            }
        }

        public string Tulum_SK//12
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Tulum_SK;
                }
                else
                {
                    return EN.Tulum_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Amused_EM//1
        {
            get
            {
                //else
                {
                    return EN.Amused_EM;
                }
            }
        }

        public string Boop_EM//2
        {
            get
            {
                //else
                {
                    return EN.Boop_EM;
                }
            }
        }

        public string Hold_on_EM//3
        {
            get
            {
                //else
                {
                    return EN.Hold_on_EM;
                }
            }
        }

        public string Masterpiece_EM//4
        {
            get
            {
                //else
                {
                    return EN.Masterpiece_EM;
                }
            }
        }

        public string Sit_EM//5
        {
            get
            {
                //else
                {
                    return EN.Sit_EM;
                }
            }
        }

        public string Dance_EM//6
        {//Annyver 17
            get
            {
                //else
                {
                    return EN.Dance_EM;
                }
            }
        }
    }
}
