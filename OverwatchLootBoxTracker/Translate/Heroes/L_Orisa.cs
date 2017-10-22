using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Orisa
    {
        Languages.English.Heroes.EN_Orisa EN;
        string myLang;

        public L_Orisa(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Orisa();
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
        public string Dawn_SK//1
        {
            get
            {
                //else
                {
                    return EN.Dawn_SK;
                }
            }
        }

        public string Plains_SK//2
        {
            get
            {
                //else
                {
                    return EN.Plains_SK;
                }
            }
        }

        public string Sunrise_SK//3
        {
            get
            {
                //else
                {
                    return EN.Sunrise_SK;
                }
            }
        }

        public string Twilight_SK//4
        {
            get
            {
                //else
                {
                    return EN.Twilight_SK;
                }
            }
        }
        //Epic
        public string Camouflage_SK//5
        {
            get
            {
                //else
                {
                    return EN.Camouflage_SK;
                }
            }
        }

        public string OR15_SK//6
        {
            get
            {
                //else
                {
                    return EN.OR15_SK;
                }
            }
        }
        //Legendary
        public string Dynastinae_SK//7
        {
            get
            {
                //else
                {
                    return EN.Dynastinae_SK;
                }
            }
        }

        public string Megasoma_SK//8
        {
            get
            {
                //else
                {
                    return EN.Megasoma_SK;
                }
            }
        }

        public string Carbon_Fiber_SK//9
        {
            get
            {
                //else
                {
                    return EN.Carbon_Fiber_SK;
                }
            }
        }

        public string Protector_SK//10
        {
            get
            {
                //else
                {
                    return EN.Protector_SK;
                }
            }
        }

        public string Null_Sector_SK//11
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Null_Sector_SK;
                }
            }
        }


        //Emotes
    }
}
