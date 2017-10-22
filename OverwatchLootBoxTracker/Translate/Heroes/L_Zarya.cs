using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Zarya
    {
        Languages.English.Heroes.EN_Zarya EN;
        string myLang;

        public L_Zarya(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Zarya();
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
        public string Brick_SK//1
        {
            get
            {
                //else
                {
                    return EN.Brick_SK;
                }
            }
        }

        public string Goldenrod_SK//2
        {
            get
            {
                //else
                {
                    return EN.Goldenrod_SK;
                }
            }
        }

        public string Taiga_SK//3
        {
            get
            {
                //else
                {
                    return EN.Taiga_SK;
                }
            }
        }

        public string Violet_SK//4
        {
            get
            {
                //else
                {
                    return EN.Violet_SK;
                }
            }
        }
        //Epic
        public string Dawn_SK//5
        {
            get
            {
                //else
                {
                    return EN.Dawn_SK;
                }
            }
        }

        public string Midnight_SK//6
        {
            get
            {
                //else
                {
                    return EN.Midnight_SK;
                }
            }
        }

        public string Frosted_SK//7
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Frosted_SK;
                }
            }
        }
        //Legendary
        public string Arctic_SK//8
        {
            get
            {
                //else
                {
                    return EN.Arctic_SK;
                }
            }
        }

        public string Siberian_Front_SK//9
        {
            get
            {
                //else
                {
                    return EN.Siberian_Front_SK;
                }
            }
        }

        public string Cybergoth_SK//10
        {
            get
            {
                //else
                {
                    return EN.Cybergoth_SK;
                }
            }
        }

        public string Industrial_SK//11
        {
            get
            {
                //else
                {
                    return EN.Industrial_SK;
                }
            }
        }

        public string Champion_SK//12
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Champion_SK;
                }
            }
        }

        public string Weightlifter_SK//13
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Weightlifter_SK;
                }
            }
        }

        public string Totally_80s_SK//14
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Totally_80s_SK;
                }
            }
        }

        public string Cyberian_SK//15
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Cyberian_SK;
                }
            }
        }


        //Emotes
    }
}
