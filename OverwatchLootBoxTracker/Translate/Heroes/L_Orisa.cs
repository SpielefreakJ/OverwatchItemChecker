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
        public string Dawn_SK
        {
            get
            {
                //else
                {
                    return EN.Dawn_SK;
                }
            }
        }

        public string Plains_SK
        {
            get
            {
                //else
                {
                    return EN.Plains_SK;
                }
            }
        }

        public string Sunrise_SK
        {
            get
            {
                //else
                {
                    return EN.Sunrise_SK;
                }
            }
        }

        public string Twilight_SK
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
        public string Camouflage_SK
        {
            get
            {
                //else
                {
                    return EN.Camouflage_SK;
                }
            }
        }

        public string OR15_SK
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
        public string Dynastinae_SK
        {
            get
            {
                //else
                {
                    return EN.Dynastinae_SK;
                }
            }
        }

        public string Megasoma_SK
        {
            get
            {
                //else
                {
                    return EN.Megasoma_SK;
                }
            }
        }

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

        public string Protector_SK
        {
            get
            {
                //else
                {
                    return EN.Protector_SK;
                }
            }
        }

        public string Null_Sector_SK
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
