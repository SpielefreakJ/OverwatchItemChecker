using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Roadhog
    {
        Languages.English.Heroes.EN_Roadhog EN;
        string myLang;

        public L_Roadhog(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Roadhog();
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
        public string R3_Kiwi_SK
        {
            get
            {
                //else
                {
                    return EN.Kiwi_SK;
                }
            }
        }

        public string R3_Mud_SK
        {
            get
            {
                //else
                {
                    return EN.Mud_SK;
                }
            }
        }

        public string R3_Sand_SK
        {
            get
            {
                //else
                {
                    return EN.Sand_SK;
                }
            }
        }

        public string R3_Thistle_SK
        {
            get
            {
                //else
                {
                    return EN.Thistle_SK;
                }
            }
        }
        //Epic
        public string R3_Pigpen_SK
        {
            get
            {
                //else
                {
                    return EN.Pigpen_SK;
                }
            }
        }

        public string R3_Stitched_SK
        {
            get
            {
                //else
                {
                    return EN.Stitched_SK;
                }
            }
        }

        public string R3_Rudolph_SK
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Rudolph_SK;
                }
            }
        }
        //Legendary
        public string R3_Islander_SK
        {
            get
            {
                //else
                {
                    return EN.Islander_SK;
                }
            }
        }

        public string R3_Toa_SK
        {
            get
            {
                //else
                {
                    return EN.Toa_SK;
                }
            }
        }

        public string R3_Mako_SK
        {
            get
            {
                //else
                {
                    return EN.Mako_SK;
                }
            }
        }

        public string R3_Sharkbait_SK
        {
            get
            {
                //else
                {
                    return EN.Sharkbait_SK;
                }
            }
        }

        public string R3_Junkensteins_Monster_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Junkensteins_Monster_SK;
                }
            }
        }

        public string R3_Bajie_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Bajie_SK;
                }
            }
        }


        //Emotes
    }
}
