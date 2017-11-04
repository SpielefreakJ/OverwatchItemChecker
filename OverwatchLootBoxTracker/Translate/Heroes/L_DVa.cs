using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_DVa
    {
        Languages.English.Heroes.EN_DVa EN;
        Languages.German.Heroes.DE_DVa DE;
        string myLang;

        public L_DVa(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_DVa();
            DE = new Languages.German.Heroes.DE_DVa();
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
        public string Blueberry_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blueberry_SK;
                }
                else
                {
                    return EN.Blueberry_SK;
                }
            }
        }

        public string Lemon_Lime_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Lemon_Lime_SK;
                }
                else
                {
                    return EN.Lemon_Lime_SK;
                }
            }
        }

        public string Tangerine_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Tangerine_SK;
                }
                else
                {
                    return EN.Tangerine_SK;
                }
            }
        }

        public string Watermelon_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Watermelon_SK;
                }
                else
                {
                    return EN.Watermelon_SK;
                }
            }
        }
        //Epic
        public string Carbon_Fiber_SK//5
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

        public string White_Rabbit_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.White_Rabbit_SK;
                }
                else
                {
                    return EN.White_Rabbit_SK;
                }
            }
        }

        public string Taegeukgi_SK//7
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Taegeukgi_SK;
                }
                else
                {
                    return EN.Taegeukgi_SK;
                }
            }
        }
        //Legendary
        public string Junker_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Junker_SK;
                }
                else
                {
                    return EN.Junker_SK;
                }
            }
        }

        public string Scavenger_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Scavenger_SK;
                }
                else
                {
                    return EN.Scavenger_SK;
                }
            }
        }

        public string BVa_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.BVa_SK;
                }
                else
                {
                    return EN.BVa_SK;
                }
            }
        }

        public string Junebug_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Junebug_SK;
                }
                else
                {
                    return EN.Junebug_SK;
                }
            }
        }

        public string Officer_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Officer_SK;
                }
                else
                {
                    return EN.Officer_SK;
                }
            }
        }

        public string Palanquin_SK//13
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Palanquin_SK;
                }
                else
                {
                    return EN.Palanquin_SK;
                }
            }
        }

        public string Cruiser_SK//14
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cruiser_SK;
                }
                else
                {
                    return EN.Cruiser_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string _O__EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE._O__EM;
                }
                else
                {
                    return EN._O__EM;
                }
            }
        }

        public string Bunny_Hop_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bunny_Hop_EM;
                }
                else
                {
                    return EN.Bunny_Hop_EM;
                }
            }
        }

        public string Heartbreaker_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Heartbreaker_EM;
                }
                else
                {
                    return EN.Heartbreaker_EM;
                }
            }
        }

        public string Party_Time_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Party_Time_EM;
                }
                else
                {
                    return EN.Party_Time_EM;
                }
            }
        }

        public string Bow_EM//5
        {//Rooster 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bow_EM;
                }
                else
                {
                    return EN.Bow_EM;
                }
            }
        }

        public string Dance_EM//6
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dance_EM;
                }
                else
                {
                    return EN.Dance_EM;
                }
            }
        }
        //Legendary
        public string Game_On_EM
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Game_On_EM;
                }
                else
                {
                    return EN.Game_On_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string I_Heart_You_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.I_Heart_You_VP;
                }
                else
                {
                    return EN.I_Heart_You_VP;
                }
            }
        }

        public string Peace_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Peace_VP;
                }
                else
                {
                    return EN.Peace_VP;
                }
            }
        }

        public string Sitting_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sitting_VP;
                }
                else
                {
                    return EN.Sitting_VP;
                }
            }
        }

        public string RIP_VP//4
        {//Halloween 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.RIP_VP;
                }
                else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string Festive_VP//5
        {//Winter 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Festive_VP;
                }
                else
                {
                    return EN.Festive_VP;
                }
            }
        }

        public string Lucky_Pouch_VP//6
        {//Rooster 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Lucky_Pouch_VP;
                }
                else
                {
                    return EN.Lucky_Pouch_VP;
                }
            }
        }
    }
}
