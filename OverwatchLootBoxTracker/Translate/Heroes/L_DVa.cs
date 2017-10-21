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


        //Skin

        //Rare
        public string Blueberry_SK
        {
            get
            {
                //else
                {
                    return EN.Blueberry_SK;
                }
            }
        }

        public string Lemon_Lime_SK
        {
            get
            {
                //else
                {
                    return EN.Lemon_Lime_SK;
                }
            }
        }

        public string Tangerine_SK
        {
            get
            {
                //else
                {
                    return EN.Tangerine_SK;
                }
            }
        }

        public string Watermelon_SK
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
        public string Carbon_Fiber_SK
        {
            get
            {
                //else
                {
                    return EN.Carbon_Fiber_SK;
                }
            }
        }

        public string White_Rabbit_SK
        {
            get
            {
                //else
                {
                    return EN.White_Rabbit_SK;
                }
            }
        }

        public string Taegeukgi_SK
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
        public string Junker_SK
        {
            get
            {
                //else
                {
                    return EN.Junker_SK;
                }
            }
        }

        public string Scavenger_SK
        {
            get
            {
                //else
                {
                    return EN.Scavenger_SK;
                }
            }
        }

        public string BVa_SK
        {
            get
            {
                //else
                {
                    return EN.BVa_SK;
                }
            }
        }

        public string Junebug_SK
        {
            get
            {
                //else
                {
                    return EN.Junebug_SK;
                }
            }
        }

        public string Officer_SK
        {
            get
            {
                //else
                {
                    return EN.Officer_SK;
                }
            }
        }

        public string Palanquin_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Palanquin_SK;
                }
            }
        }

        public string Cruiser_SK
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
