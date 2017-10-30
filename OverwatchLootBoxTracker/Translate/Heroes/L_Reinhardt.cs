using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Reinhardt
    {
        Languages.English.Heroes.EN_Reinhardt EN;
        Languages.German.Heroes.DE_Reinhardt DE;
        string myLang;

        public L_Reinhardt(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Reinhardt();
            DE = new Languages.German.Heroes.DE_Reinhardt();
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
        public string Brass_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Brass_SK;
                }
                else
                {
                    return EN.Brass_SK;
                }
            }
        }

        public string Cobalt_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cobalt_SK;
                }
                else
                {
                    return EN.Cobalt_SK;
                }
            }
        }

        public string Copper_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Copper_SK;
                }
                else
                {
                    return EN.Copper_SK;
                }
            }
        }

        public string Viridian_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Viridian_SK;
                }
                else
                {
                    return EN.Viridian_SK;
                }
            }
        }
        //Epic
        public string Bundeswehr_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bundeswehr_SK;
                }
                else
                {
                    return EN.Bundeswehr_SK;
                }
            }
        }

        public string Paragon_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Paragon_SK;
                }
                else
                {
                    return EN.Paragon_SK;
                }
            }
        }

        public string Coldhardt_SK//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Coldhardt_SK;
                }
                else
                {
                    return EN.Coldhardt_SK;
                }
            }
        }

        public string Lieutenant_Wilhelm_SK//8
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Lieutenant_Wilhelm_SK;
                }
                else
                {
                    return EN.Lieutenant_Wilhelm_SK;
                }
            }
        }
        //Legendary
        public string Blackhardt_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blackhardt_SK;
                }
                else
                {
                    return EN.Blackhardt_SK;
                }
            }
        }

        public string Bloodhardt_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bloodhardt_SK;
                }
                else
                {
                    return EN.Bloodhardt_SK;
                }
            }
        }

        public string Lionhardt_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Lionhardt_SK;
                }
                else
                {
                    return EN.Lionhardt_SK;
                }
            }
        }

        public string Stonehardt_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Stonehardt_SK;
                }
                else
                {
                    return EN.Stonehardt_SK;
                }
            }
        }

        public string Balderich_SK//13
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Balderich_SK;
                }
                else
                {
                    return EN.Balderich_SK;
                }
            }
        }

        public string Greifhardt_SK//14
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Greifhardt_SK;
                }
                else
                {
                    return EN.Greifhardt_SK;
                }
            }
        }

        public string Wujing_SK//15
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Wujing_SK;
                }
                else
                {
                    return EN.Wujing_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Flex_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Flex_EM;
                }
                else
                {
                    return EN.Flex_EM;
                }
            }
        }

        public string Knee_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Knee_EM;
                }
                else
                {
                    return EN.Knee_EM;
                }
            }
        }

        public string Taunt_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Taunt_EM;
                }
                else
                {
                    return EN.Taunt_EM;
                }
            }
        }

        public string Uproarious_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Uproarious_EM;
                }
                else
                {
                    return EN.Uproarious_EM;
                }
            }
        }

        public string Warriors_Salute_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Warriors_Salute_EM;
                }
                else
                {
                    return EN.Warriors_Salute_EM;
                }
            }
        }

        public string Punpkin_Smash_EM//6
        {//Halloween 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Punpkin_Smash_EM;
                }
                else
                {
                    return EN.Punpkin_Smash_EM;
                }
            }
        }

        public string Sweethardt_EM//7
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sweethardt_EM;
                }
                else
                {
                    return EN.Sweethardt_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Confident_VP//1
        {
            get
            {
                //else
                {
                    return EN.Confident_VP;
                }
            }
        }

        public string Flex_VP//2
        {
            get
            {
                //else
                {
                    return EN.Flex_EM;
                }
            }
        }

        public string Legendary_VP//3
        {
            get
            {
                //else
                {
                    return EN.Legendary_VP;
                }
            }
        }

        public string RIP_VP//4
        {//Halloween 16
            get
            {
                //else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string Toast_VP//5
        {//Winter 16
            get
            {
                //else
                {
                    return EN.Toast_VP;
                }
            }
        }
    }
}
