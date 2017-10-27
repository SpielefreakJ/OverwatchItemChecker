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
        Languages.German.Heroes.DE_Hanzo DE;
        string myLang;

        public L_Hanzo(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Hanzo();
            DE = new Languages.German.Heroes.DE_Hanzo();
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
                if (myLang == "DE")
                {
                    return DE.Name;
                }
                else
                {
                    return EN.Name;
                }
            }
        }


        //Skin

        //Rare
        public string Azuki_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Azuki_SK;
                }
                else
                {
                    return EN.Azuki_SK;
                }
            }
        }

        public string Kinoko_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Kinoko_SK;
                }
                else
                {
                    return EN.Kinoko_SK;
                }
            }
        }

        public string Midori_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Midori_SK;
                }
                else
                {
                    return EN.Midori_SK;
                }
            }
        }

        public string Sora_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sora_SK;
                }
                else
                {
                    return EN.Sora_SK;
                }
            }
        }
        //Epic
        public string Cloud_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cloud_SK;
                }
                else
                {
                    return EN.Cloud_SK;
                }
            }
        }

        public string Dragon_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dragon_SK;
                }
                else
                {
                    return EN.Dragon_SK;
                }
            }
        }

        public string Demon_SK//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Demon_SK;
                }
                else
                {
                    return EN.Demon_SK;
                }
            }
        }
        //Legendary
        public string Young_Hanzo_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Young_Hanzo_SK;
                }
                else
                {
                    return EN.Young_Hanzo_SK;
                }
            }
        }

        public string Young_Master_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Young_Master_SK;
                }
                else
                {
                    return EN.Young_Master_SK;
                }
            }
        }

        public string Lone_Wolf_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Lone_Wolf_SK;
                }
                else
                {
                    return EN.Lone_Wolf_SK;
                }
            }
        }

        public string Okami_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Okami_SK;
                }
                else
                {
                    return EN.Okami_SK;
                }
            }
        }

        public string Cyberninja_SK//12
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cyberninja_SK;
                }
                else
                {
                    return EN.Cyberninja_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Beckon_EM//1
        {
            get
            {
                //else
                {
                    return EN.Beckon_EM;
                }
            }
        }

        public string Brush_Shoulder_EM//2
        {
            get
            {
                //else
                {
                    return EN.Brush_Shoulder_EM;
                }
            }
        }

        public string Chuckle_EM//3
        {
            get
            {
                //else
                {
                    return EN.Chuckle_EM;
                }
            }
        }

        public string Meditate_EM//4
        {
            get
            {
                //else
                {
                    return EN.Meditate_EM;
                }
            }
        }

        public string Victory_EM//5
        {
            get
            {
                //else
                {
                    return EN.Victory_EM;
                }
            }
        }

        public string Training_EM//6
        {//Uprising 17
            get
            {
                //else
                {
                    return EN.Training_EM;
                }
            }
        }

        public string Fisherman_Dance_EM//7
        {//Annyver 17
            get
            {
                //else
                {
                    return EN.Fisherman_Dance_EM;
                }
            }
        }
    }
}
