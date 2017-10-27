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
        Languages.German.Heroes.DE_Mei DE;
        string myLang;

        public L_Mei(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Mei();
            DE = new Languages.German.Heroes.DE_Mei();
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
        public string Chrysanthemum_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Chrysanthemum_SK;
                }
                else
                {
                    return EN.Chrysanthemum_SK;
                }
            }
        }

        public string Heliotrope_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Heliotrope_SK;
                }
                else
                {
                    return EN.Heliotrope_SK;
                }
            }
        }

        public string Jade_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Jade_SK;
                }
                else
                {
                    return EN.Jade_SK;
                }
            }
        }

        public string Persimmon_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Persimmon_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Earthen_SK;
                }
                else
                {
                    return EN.Earthen_SK;
                }
            }
        }

        public string Snow_Plum_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Snow_Plum_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Firefighter_SK;
                }
                else
                {
                    return EN.Firefighter_SK;
                }
            }
        }

        public string Rescue_Mei_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Rescue_Mei_SK;
                }
                else
                {
                    return EN.Rescue_Mei_SK;
                }
            }
        }

        public string Abominable_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Abominable_SK;
                }
                else
                {
                    return EN.Abominable_SK;
                }
            }
        }

        public string Yeti_Hunter_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Yeti_Hunter_SK;
                }
                else
                {
                    return EN.Yeti_Hunter_SK;
                }
            }
        }

        public string Jiangshi_SK//11
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Jiangshi_SK;
                }
                else
                {
                    return EN.Jiangshi_SK;
                }
            }
        }

        public string Mei_rry_SK//12
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mei_rry_SK;
                }
                else
                {
                    return EN.Mei_rry_SK;
                }
            }
        }

        public string Chang_e_SK//13
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Chang_e_SK;
                }
                else
                {
                    return EN.Chang_e_SK;
                }
            }
        }

        public string Luna_SK//14
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Luna_SK;
                }
                else
                {
                    return EN.Luna_SK;
                }
            }
        }

        public string Beekeeper_SK//15
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Beekeeper_SK;
                }
                else
                {
                    return EN.Beekeeper_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Companion_EM//1
        {
            get
            {
                //else
                {
                    return EN.Companion_EM;
                }
            }
        }

        public string Gigle_EM//2
        {
            get
            {
                //else
                {
                    return EN.Gigle_EM;
                }
            }
        }

        public string Kneel_EM//3
        {
            get
            {
                //else
                {
                    return EN.Kneel_EM;
                }
            }
        }

        public string Spray_EM//4
        {
            get
            {
                //else
                {
                    return EN.Spray_EM;
                }
            }
        }

        public string Yaaaaaaaaay_EM//5
        {
            get
            {
                //else
                {
                    return EN.Yaaaaaaaaay_EM;
                }
            }
        }

        public string Hopping_EM//6
        {//Halloween 17
            get
            {
                //else
                {
                    return EN.Hopping_EM;
                }
            }
        }

        public string Snowman_EM//7
        {//Winter 16
            get
            {
                //else
                {
                    return EN.Snowman_EM;
                }
            }
        }

        public string So_excited_EM//8
        {//Rooster 17
            get
            {
                //else
                {
                    return EN.So_excited_EM;
                }
            }
        }

        public string Sunny_Dance_EM//9
        {//Annyver 17
            get
            {
                //else
                {
                    return EN.Sunny_Dance_EM;
                }
            }
        }
    }
}
