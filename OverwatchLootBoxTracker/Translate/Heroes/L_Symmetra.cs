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
        public string Cardamom_SK//1
        {
            get
            {
                //else
                {
                    return EN.Cardamom_SK;
                }
            }
        }

        public string Hyacinth_SK//2
        {
            get
            {
                //else
                {
                    return EN.Hyacinth_SK;
                }
            }
        }

        public string Saffron_SK//3
        {
            get
            {
                //else
                {
                    return EN.Saffron_SK;
                }
            }
        }

        public string Technomancer_SK//4
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
        public string Regal_SK//5
        {
            get
            {
                //else
                {
                    return EN.Regal_SK;
                }
            }
        }

        public string Utopaea_SK//6
        {
            get
            {
                //else
                {
                    return EN.Utopaea_SK;
                }
            }
        }

        public string Vampire_SK//7
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Vampire_SK;
                }
            }
        }

        public string Qipao_SK//8
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
        public string Architech_SK//9
        {
            get
            {
                //else
                {
                    return EN.Architech_SK;
                }
            }
        }

        public string Vishkar_SK//10
        {
            get
            {
                //else
                {
                    return EN.Vishkar_SK;
                }
            }
        }

        public string Devi_SK//11
        {
            get
            {
                //else
                {
                    return EN.Devi_SK;
                }
            }
        }

        public string Goddess_SK//12
        {
            get
            {
                //else
                {
                    return EN.Goddess_SK;
                }
            }
        }

        public string Dragon_SK//13
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Dragon_SK;
                }
            }
        }

        public string Oasis_SK//14
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
