using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Winston
    {
        Languages.English.Heroes.EN_Winston EN;
        string myLang;

        public L_Winston(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Winston();
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
        public string Atmosphere_SK//1
        {
            get
            {
                //else
                {
                    return EN.Atmosphere_SK;
                }
            }
        }

        public string Banana_SK//2
        {
            get
            {
                //else
                {
                    return EN.Banana_SK;
                }
            }
        }

        public string Forest_SK//3
        {
            get
            {
                //else
                {
                    return EN.Forest_SK;
                }
            }
        }

        public string Red_Planet_SK//4
        {
            get
            {
                //else
                {
                    return EN.Red_Planet_SK;
                }
            }
        }
        //Epic
        public string Desert_SK//5
        {
            get
            {
                //else
                {
                    return EN.Desert_SK;
                }
            }
        }

        public string Horizon_SK//6
        {
            get
            {
                //else
                {
                    return EN.Horizon_SK;
                }
            }
        }

        public string Blizzcon_2017_SK//7
        {//BlizzCon 2017 Special
            get
            {
                //else
                {
                    return EN.Blizzcon_2017_SK;
                }
            }
        }
        //Legendary
        public string Frogston_SK//8
        {
            get
            {
                //else
                {
                    return EN.Frogston_SK;
                }
            }
        }

        public string Undersea_SK//9
        {
            get
            {
                //else
                {
                    return EN.Undersea_SK;
                }
            }
        }

        public string Explorer_SK//10
        {
            get
            {
                //else
                {
                    return EN.Explorer_SK;
                }
            }
        }

        public string Safari_SK//11
        {
            get
            {
                //else
                {
                    return EN.Safari_SK;
                }
            }
        }

        public string Yeti_SK//12
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Yeti_SK;
                }
            }
        }

        public string Wukong_SK//13
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Wukong_SK;
                }
            }
        }


        //Emotes
    }
}
