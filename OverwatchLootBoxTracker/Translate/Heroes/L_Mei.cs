using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Mei
    {
        Languages.English.Heroes.EN_Mei EN;
        string myLang;

        public L_Mei(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Mei();
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
        public string Chrysanthemum_SK//1
        {
            get
            {
                //else
                {
                    return EN.Chrysanthemum_SK;
                }
            }
        }

        public string Heliotrope_SK//2
        {
            get
            {
                //else
                {
                    return EN.Heliotrope_SK;
                }
            }
        }

        public string Jade_SK//3
        {
            get
            {
                //else
                {
                    return EN.Jade_SK;
                }
            }
        }

        public string Persimmon_SK//4
        {
            get
            {
                //else
                {
                    return EN.Persimmon_SK;
                }
            }
        }
        //Epic
        public string Earthen_SK//5
        {
            get
            {
                //else
                {
                    return EN.Earthen_SK;
                }
            }
        }

        public string Snow_Plum_SK//6
        {
            get
            {
                //else
                {
                    return EN.Snow_Plum_SK;
                }
            }
        }
        //Legendary
        public string Firefighter_SK//7
        {
            get
            {
                //else
                {
                    return EN.Firefighter_SK;
                }
            }
        }

        public string Rescue_Mei_SK//8
        {
            get
            {
                //else
                {
                    return EN.Rescue_Mei_SK;
                }
            }
        }

        public string Abominable_SK//9
        {
            get
            {
                //else
                {
                    return EN.Abominable_SK;
                }
            }
        }

        public string Yeti_Hunter_SK//10
        {
            get
            {
                //else
                {
                    return EN.Yeti_Hunter_SK;
                }
            }
        }

        public string Jiangshi_SK//11
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Jiangshi_SK;
                }
            }
        }

        public string Mei_rry_SK//12
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Mei_rry_SK;
                }
            }
        }

        public string Chang_e_SK//13
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Chang_e_SK;
                }
            }
        }

        public string Luna_SK//14
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Luna_SK;
                }
            }
        }

        public string Beekeeper_SK//15
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Beekeeper_SK;
                }
            }
        }


        //Emotes
    }
}
