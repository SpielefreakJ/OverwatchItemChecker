using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class L_Doomfist
    {
        Languages.English.Heroes.EN_Doomfist EN;
        string myLang;

        L_Doomfist(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Doomfist();
        }


        //Skin

        //Rare
        public string D2_Daisy_SK
        {
            get
            {
                //else
                {
                    return EN.Daisy_SK;
                }
            }
        }

        public string D2_Lake_SK
        {
            get
            {
                //else
                {
                    return EN.Lake_SK;
                }
            }
        }

        public string D2_Plains_SK
        {
            get
            {
                //else
                {
                    return EN.Plains_SK;
                }
            }
        }

        public string D2_Sunset_SK
        {
            get
            {
                //else
                {
                    return EN.Sunset_SK;
                }
            }
        }
        //Epic
        public string D2_Leopard_SK
        {
            get
            {
                //else
                {
                    return EN.Leopard_SK;
                }
            }
        }

        public string D2_Painted_SK
        {
            get
            {
                //else
                {
                    return EN.Painted_SK;
                }
            }
        }
        //Legendary
        public string D2_Caution_SK
        {
            get
            {
                //else
                {
                    return EN.Caution_SK;
                }
            }
        }

        public string D2_Irin_SK
        {
            get
            {
                //else
                {
                    return EN.Irin_SK;
                }
            }
        }

        public string D2_Avatar_SK
        {
            get
            {
                //else
                {
                    return EN.Avatar_SK;
                }
            }
        }

        public string D2_Spirit_SK
        {
            get
            {
                //else
                {
                    return EN.Spirit_SK;
                }
            }
        }


        //Emotes
    }
}
