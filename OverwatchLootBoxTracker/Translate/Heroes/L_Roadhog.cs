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
        Languages.German.Heroes.DE_Roadhog DE;
        string myLang;

        public L_Roadhog(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Roadhog();
            DE = new Languages.German.Heroes.DE_Roadhog();
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
        public string Kiwi_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Kiwi_SK;
                }
                else
                {
                    return EN.Kiwi_SK;
                }
            }
        }

        public string Mud_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mud_SK;
                }
                else
                {
                    return EN.Mud_SK;
                }
            }
        }

        public string Sand_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sand_SK;
                }
                else
                {
                    return EN.Sand_SK;
                }
            }
        }

        public string Thistle_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Thistle_SK;
                }
                else
                {
                    return EN.Thistle_SK;
                }
            }
        }
        //Epic
        public string Pigpen_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Pigpen_SK;
                }
                else
                {
                    return EN.Pigpen_SK;
                }
            }
        }

        public string Stitched_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Stitched_SK;
                }
                else
                {
                    return EN.Stitched_SK;
                }
            }
        }

        public string Rudolph_SK//7
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Rudolph_SK;
                }
                else
                {
                    return EN.Rudolph_SK;
                }
            }
        }
        //Legendary
        public string Islander_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Islander_SK;
                }
                else
                {
                    return EN.Islander_SK;
                }
            }
        }

        public string Toa_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Toa_SK;
                }
                else
                {
                    return EN.Toa_SK;
                }
            }
        }

        public string Mako_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mako_SK;
                }
                else
                {
                    return EN.Mako_SK;
                }
            }
        }

        public string Sharkbait_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sharkbait_SK;
                }
                else
                {
                    return EN.Sharkbait_SK;
                }
            }
        }

        public string Junkensteins_Monster_SK//12
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Junkensteins_Monster_SK;
                }
                else
                {
                    return EN.Junkensteins_Monster_SK;
                }
            }
        }

        public string Bajie_SK//13
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bajie_SK;
                }
                else
                {
                    return EN.Bajie_SK;
                }
            }
        }


        //Emotes
    }
}
