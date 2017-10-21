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
        public string Chrysanthemum_SK
        {
            get
            {
                //else
                {
                    return EN.Chrysanthemum_SK;
                }
            }
        }

        public string Heliotrope_SK
        {
            get
            {
                //else
                {
                    return EN.Heliotrope_SK;
                }
            }
        }

        public string Jade_SK
        {
            get
            {
                //else
                {
                    return EN.Jade_SK;
                }
            }
        }

        public string Persimmon_SK
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
        public string Earthen_SK
        {
            get
            {
                //else
                {
                    return EN.Earthen_SK;
                }
            }
        }

        public string Snow_Plum_SK
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
        public string Firefighter_SK
        {
            get
            {
                //else
                {
                    return EN.Firefighter_SK;
                }
            }
        }

        public string Rescue_Mei_SK
        {
            get
            {
                //else
                {
                    return EN.Rescue_Mei_SK;
                }
            }
        }

        public string Abominable_SK
        {
            get
            {
                //else
                {
                    return EN.Abominable_SK;
                }
            }
        }

        public string Yeti_Hunter_SK
        {
            get
            {
                //else
                {
                    return EN.Yeti_Hunter_SK;
                }
            }
        }

        public string Jiangshi_SK
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Jiangshi_SK;
                }
            }
        }

        public string Mei_rry_SK
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Mei_rry_SK;
                }
            }
        }

        public string Chang_e_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Chang_e_SK;
                }
            }
        }

        public string Luna_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Luna_SK;
                }
            }
        }

        public string Beekeeper_SK
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
