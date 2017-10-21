using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class L_Hanzo
    {
        Languages.English.Heroes.EN_Hanzo EN;
        string myLang;

        L_Hanzo(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Hanzo();
        }


        //Skin

        //Rare
        public string H1_Azuki_SK
        {
            get
            {
                //else
                {
                    return EN.Azuki_SK;
                }
            }
        }

        public string H1_Kinoko_SK
        {
            get
            {
                //else
                {
                    return EN.Kinoko_SK;
                }
            }
        }

        public string H1_Midori_SK
        {
            get
            {
                //else
                {
                    return EN.Midori_SK;
                }
            }
        }

        public string H1_Sora_SK
        {
            get
            {
                //else
                {
                    return EN.Sora_SK;
                }
            }
        }
        //Epic
        public string H1_Cloud_SK
        {
            get
            {
                //else
                {
                    return EN.Cloud_SK;
                }
            }
        }

        public string H1_Dragon_SK
        {
            get
            {
                //else
                {
                    return EN.Dragon_SK;
                }
            }
        }

        public string H1_Demon_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Demon_SK;
                }
            }
        }
        //Legendary
        public string H1_Young_Hanzo_SK
        {
            get
            {
                //else
                {
                    return EN.Young_Hanzo_SK;
                }
            }
        }

        public string H1_Young_Master_SK
        {
            get
            {
                //else
                {
                    return EN.Young_Master_SK;
                }
            }
        }

        public string H1_Lone_Wolf_SK
        {
            get
            {
                //else
                {
                    return EN.Lone_Wolf_SK;
                }
            }
        }

        public string H1_Okami_SK
        {
            get
            {
                //else
                {
                    return EN.Okami_SK;
                }
            }
        }

        public string H1_Cyberninja_SK
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Cyberninja_SK;
                }
            }
        }


        //Emotes
    }
}
