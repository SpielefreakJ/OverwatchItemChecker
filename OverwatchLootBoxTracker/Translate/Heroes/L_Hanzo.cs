using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Hanzo
    {
        Languages.English.Heroes.EN_Hanzo EN;
        string myLang;

        public L_Hanzo(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Hanzo();
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
        public string Azuki_SK
        {
            get
            {
                //else
                {
                    return EN.Azuki_SK;
                }
            }
        }

        public string Kinoko_SK
        {
            get
            {
                //else
                {
                    return EN.Kinoko_SK;
                }
            }
        }

        public string Midori_SK
        {
            get
            {
                //else
                {
                    return EN.Midori_SK;
                }
            }
        }

        public string Sora_SK
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
        public string Cloud_SK
        {
            get
            {
                //else
                {
                    return EN.Cloud_SK;
                }
            }
        }

        public string Dragon_SK
        {
            get
            {
                //else
                {
                    return EN.Dragon_SK;
                }
            }
        }

        public string Demon_SK
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
        public string Young_Hanzo_SK
        {
            get
            {
                //else
                {
                    return EN.Young_Hanzo_SK;
                }
            }
        }

        public string Young_Master_SK
        {
            get
            {
                //else
                {
                    return EN.Young_Master_SK;
                }
            }
        }

        public string Lone_Wolf_SK
        {
            get
            {
                //else
                {
                    return EN.Lone_Wolf_SK;
                }
            }
        }

        public string Okami_SK
        {
            get
            {
                //else
                {
                    return EN.Okami_SK;
                }
            }
        }

        public string Cyberninja_SK
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
