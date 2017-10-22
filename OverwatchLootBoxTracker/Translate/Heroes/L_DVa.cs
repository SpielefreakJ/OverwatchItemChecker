using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_DVa
    {
        Languages.English.Heroes.EN_DVa EN;
        string myLang;

        public L_DVa(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_DVa();
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
        public string Blueberry_SK//1
        {
            get
            {
                //else
                {
                    return EN.Blueberry_SK;
                }
            }
        }

        public string Lemon_Lime_SK//2
        {
            get
            {
                //else
                {
                    return EN.Lemon_Lime_SK;
                }
            }
        }

        public string Tangerine_SK//3
        {
            get
            {
                //else
                {
                    return EN.Tangerine_SK;
                }
            }
        }

        public string Watermelon_SK//4
        {
            get
            {
                //else
                {
                    return EN.Watermelon_SK;
                }
            }
        }
        //Epic
        public string Carbon_Fiber_SK//5
        {
            get
            {
                //else
                {
                    return EN.Carbon_Fiber_SK;
                }
            }
        }

        public string White_Rabbit_SK//6
        {
            get
            {
                //else
                {
                    return EN.White_Rabbit_SK;
                }
            }
        }

        public string Taegeukgi_SK//7
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Taegeukgi_SK;
                }
            }
        }
        //Legendary
        public string Junker_SK//8
        {
            get
            {
                //else
                {
                    return EN.Junker_SK;
                }
            }
        }

        public string Scavenger_SK//9
        {
            get
            {
                //else
                {
                    return EN.Scavenger_SK;
                }
            }
        }

        public string BVa_SK//10
        {
            get
            {
                //else
                {
                    return EN.BVa_SK;
                }
            }
        }

        public string Junebug_SK//11
        {
            get
            {
                //else
                {
                    return EN.Junebug_SK;
                }
            }
        }

        public string Officer_SK//12
        {
            get
            {
                //else
                {
                    return EN.Officer_SK;
                }
            }
        }

        public string Palanquin_SK//13
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Palanquin_SK;
                }
            }
        }

        public string Cruiser_SK//14
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Cruiser_SK;
                }
            }
        }


        //Emotes
    }
}
