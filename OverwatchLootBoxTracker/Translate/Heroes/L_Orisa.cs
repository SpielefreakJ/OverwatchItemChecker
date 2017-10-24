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
        Languages.German.Heroes.DE_Orisa DE;
        string myLang;

        public L_Orisa(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Orisa();
            DE = new Languages.German.Heroes.DE_Orisa();
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
        public string Dawn_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dawn_SK;
                }
                else
                {
                    return EN.Dawn_SK;
                }
            }
        }

        public string Plains_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Plains_SK;
                }
                else
                {
                    return EN.Plains_SK;
                }
            }
        }

        public string Sunrise_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sunrise_SK;
                }
                else
                {
                    return EN.Sunrise_SK;
                }
            }
        }

        public string Twilight_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Twilight_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Camouflage_SK;
                }
                else
                {
                    return EN.Camouflage_SK;
                }
            }
        }

        public string OR15_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.OR15_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Dynastinae_SK;
                }
                else
                {
                    return EN.Dynastinae_SK;
                }
            }
        }

        public string Megasoma_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Megasoma_SK;
                }
                else
                {
                    return EN.Megasoma_SK;
                }
            }
        }

        public string Carbon_Fiber_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Carbon_Fiber_SK;
                }
                else
                {
                    return EN.Carbon_Fiber_SK;
                }
            }
        }

        public string Protector_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Protector_SK;
                }
                else
                {
                    return EN.Protector_SK;
                }
            }
        }

        public string Null_Sector_SK//11
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Null_Sector_SK;
                }
                else
                {
                    return EN.Null_Sector_SK;
                }
            }
        }


        //Emotes
    }
}
