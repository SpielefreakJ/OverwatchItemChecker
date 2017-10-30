using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Pharah
    {
        Languages.English.Heroes.EN_Pharah EN;
        Languages.German.Heroes.DE_Pharah DE;
        string myLang;

        public L_Pharah(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Pharah();
            DE = new Languages.German.Heroes.DE_Pharah();
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
        public string Amethyst_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Amethyst_SK;
                }
                else
                {
                    return EN.Amethyst_SK;
                }
            }
        }

        public string Copper_SK//2
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

        public string Emerald_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Emerald_SK;
                }
                else
                {
                    return EN.Emerald_SK;
                }
            }
        }

        public string Titanium_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Titanium_SK;
                }
                else
                {
                    return EN.Titanium_SK;
                }
            }
        }
        //Epic
        public string Anubis_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Anubis_SK;
                }
                else
                {
                    return EN.Anubis_SK;
                }
            }
        }

        public string Jackal_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Jackal_SK;
                }
                else
                {
                    return EN.Jackal_SK;
                }
            }
        }

        public string Possessed_SK//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Possessed_SK;
                }
                else
                {
                    return EN.Possessed_SK;
                }
            }
        }

        public string Frostbite_SK//8
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Frostbite_SK;
                }
                else
                {
                    return EN.Frostbite_SK;
                }
            }
        }
        //Legendary
        public string Mechaqueen_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mechaqueen_SK;
                }
                else
                {
                    return EN.Mechaqueen_SK;
                }
            }
        }

        public string Raptorion_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Raptorion_SK;
                }
                else
                {
                    return EN.Raptorion_SK;
                }
            }
        }

        public string Raindancer_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Raindancer_SK;
                }
                else
                {
                    return EN.Raindancer_SK;
                }
            }
        }

        public string Thunderbird_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Thunderbird_SK;
                }
                else
                {
                    return EN.Thunderbird_SK;
                }
            }
        }

        public string Security_Chief_SK//13
        {//Origin Special
            get
            {
                if (myLang == "DE")
                {
                    return DE.Security_Chief_SK;
                }
                else
                {
                    return EN.Security_Chief_SK;
                }
            }
        }

        public string Bedouin_SK//14
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bedouin_SK;
                }
                else
                {
                    return EN.Bedouin_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Cheer_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cheer_EM;
                }
                else
                {
                    return EN.Cheer_EM;
                }
            }
        }

        public string Chuckle_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Chuckle_EM;
                }
                else
                {
                    return EN.Chuckle_EM;
                }
            }
        }

        public string Flourish_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Flourish_EM;
                }
                else
                {
                    return EN.Flourish_EM;
                }
            }
        }

        public string Knuckles_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Knuckles_EM;
                }
                else
                {
                    return EN.Knuckles_EM;
                }
            }
        }

        public string Take_a_knee_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Take_a_knee_EM;
                }
                else
                {
                    return EN.Take_a_knee_EM;
                }
            }
        }

        public string Flair_EM//6
        {//Uprising 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Flair_EM;
                }
                else
                {
                    return EN.Flair_EM;
                }
            }
        }

        public string Rocket_Guitar_EM//7
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Rocket_Guitar_EM;
                }
                else
                {
                    return EN.Rocket_Guitar_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Guardian_VP//1
        {
            get
            {
                //else
                {
                    return EN.Guardian_VP;
                }
            }
        }

        public string Kneeling_VP//2
        {
            get
            {
                //else
                {
                    return EN.Kneeling_VP;
                }
            }
        }

        public string Jump_Jet_VP//3
        {
            get
            {
                //else
                {
                    return EN.Jump_Jet_VP;
                }
            }
        }

        public string Medal_VP//4
        {//Summer 16
            get
            {
                //else
                {
                    return EN.Medal_VP;
                }
            }
        }

        public string RIP_VP//5
        {//Halloween 16
            get
            {
                //else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string Toast_VP//6
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
