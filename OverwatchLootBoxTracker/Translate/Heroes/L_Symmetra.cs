using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Symmetra
    {
        Languages.English.Heroes.EN_Symmetra EN;
        string myLang;

        public L_Symmetra(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Symmetra();
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
        public string Cardamom_SK
        {
            get
            {
                //else
                {
                    return EN.Cardamom_SK;
                }
            }
        }

        public string Hyacinth_SK
        {
            get
            {
                //else
                {
                    return EN.Hyacinth_SK;
                }
            }
        }

        public string Saffron_SK
        {
            get
            {
                //else
                {
                    return EN.Saffron_SK;
                }
            }
        }

        public string Technomancer_SK
        {
            get
            {
                //else
                {
                    return EN.Technomancer_SK;
                }
            }
        }
        //Epic
        public string Regal_SK
        {
            get
            {
                //else
                {
                    return EN.Regal_SK;
                }
            }
        }

        public string Utopaea_SK
        {
            get
            {
                //else
                {
                    return EN.Utopaea_SK;
                }
            }
        }

        public string Vampire_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Vampire_SK;
                }
            }
        }

        public string Qipao_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Qipao_SK;
                }
            }
        }
        //Legendary
        public string Architech_SK
        {
            get
            {
                //else
                {
                    return EN.Architech_SK;
                }
            }
        }

        public string Vishkar_SK
        {
            get
            {
                //else
                {
                    return EN.Vishkar_SK;
                }
            }
        }

        public string Devi_SK
        {
            get
            {
                //else
                {
                    return EN.Devi_SK;
                }
            }
        }

        public string Goddess_SK
        {
            get
            {
                //else
                {
                    return EN.Goddess_SK;
                }
            }
        }

        public string Dragon_SK
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Dragon_SK;
                }
            }
        }

        public string Oasis_SK
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Oasis_SK;
                }
            }
        }


        //Emotes
    }
}
