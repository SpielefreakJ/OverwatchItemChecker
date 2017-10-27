using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Doomfist
    {
        Languages.English.Heroes.EN_Doomfist EN;
        Languages.German.Heroes.DE_Doomfist DE;
        string myLang;

        public L_Doomfist(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Doomfist();
            DE = new Languages.German.Heroes.DE_Doomfist();
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
        public string Daisy_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Daisy_SK;
                }
                else
                {
                    return EN.Daisy_SK;
                }
            }
        }

        public string Lake_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Lake_SK;
                }
                else
                {
                    return EN.Lake_SK;
                }
            }
        }

        public string Plains_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Plains_SK;
                }
                else
                {
                    return EN.Plains_SK;
                }
            }
        }

        public string Sunset_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sunset_SK;
                }
                else
                {
                    return EN.Sunset_SK;
                }
            }
        }
        //Epic
        public string Leopard_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Leopard_SK;
                }
                else
                {
                    return EN.Leopard_SK;
                }
            }
        }

        public string Painted_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Painted_SK;
                }
                else
                {
                    return EN.Painted_SK;
                }
            }
        }
        //Legendary
        public string Caution_SK//7
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Caution_SK;
                }
                else
                {
                    return EN.Caution_SK;
                }
            }
        }

        public string Irin_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Irin_SK;
                }
                else
                {
                    return EN.Irin_SK;
                }
            }
        }

        public string Avatar_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Avatar_SK;
                }
                else
                {
                    return EN.Avatar_SK;
                }
            }
        }

        public string Spirit_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Spirit_SK;
                }
                else
                {
                    return EN.Spirit_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Fake_Out_EM//1
        {
            get
            {
                //else
                {
                    return EN.Fake_Out_EM;
                }
            }
        }

        public string Intimidate_EM//2
        {
            get
            {
                //else
                {
                    return EN.Intimidate_EM;
                }
            }
        }

        public string Ready_for_Battle_EM//3
        {
            get
            {
                //else
                {
                    return EN.Ready_for_Battle_EM;
                }
            }
        }

        public string Take_a_knee_EM//4
        {
            get
            {
                //else
                {
                    return EN.Take_a_knee_EM;
                }
            }
        }

        public string Thumbs_Down_EM//5
        {
            get
            {
                //else
                {
                    return EN.Thumbs_Down_EM;
                }
            }
        }
    }
}
