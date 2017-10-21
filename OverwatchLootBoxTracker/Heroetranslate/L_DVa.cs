using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class L_DVa
    {
        Languages.English.Heroes.EN_DVa EN;
        string myLang;

        L_DVa(string Lang)
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


        //Skin

        //Rare
        public string D1_Blueberry_SK
        {
            get
            {
                //else
                {
                    return EN.Blueberry_SK;
                }
            }
        }

        public string D1_Lemon_Lime_SK
        {
            get
            {
                //else
                {
                    return EN.Lemon_Lime_SK;
                }
            }
        }

        public string D1_Tangerine_SK
        {
            get
            {
                //else
                {
                    return EN.Tangerine_SK;
                }
            }
        }

        public string D1_Watermelon_SK
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
        public string D1_Carbon_Fiber_SK
        {
            get
            {
                //else
                {
                    return EN.Carbon_Fiber_SK;
                }
            }
        }

        public string D1_White_Rabbit_SK
        {
            get
            {
                //else
                {
                    return EN.White_Rabbit_SK;
                }
            }
        }

        public string D1_Taegeukgi_SK
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
        public string D1_Junker_SK
        {
            get
            {
                //else
                {
                    return EN.Junker_SK;
                }
            }
        }

        public string D1_Scavenger_SK
        {
            get
            {
                //else
                {
                    return EN.Scavenger_SK;
                }
            }
        }

        public string D1_BVa_SK
        {
            get
            {
                //else
                {
                    return EN.BVa_SK;
                }
            }
        }

        public string D1_Junebug_SK
        {
            get
            {
                //else
                {
                    return EN.Junebug_SK;
                }
            }
        }

        public string D1_Officer_SK
        {
            get
            {
                //else
                {
                    return EN.Officer_SK;
                }
            }
        }

        public string D1_Palanquin_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Palanquin_SK;
                }
            }
        }

        public string D1_Cruiser_SK
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
