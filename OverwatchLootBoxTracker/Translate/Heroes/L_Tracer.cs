using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Tracer
    {
        Languages.English.Heroes.EN_Tracer EN;
        Languages.German.Heroes.DE_Tracer DE;
        string myLang;

        public L_Tracer(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Tracer();
            DE = new Languages.German.Heroes.DE_Tracer();
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
        public string Electric_Purple_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Electric_Purple_SK;
                }
                else
                {
                    return EN.Electric_Purple_SK;
                }
            }
        }

        public string Hot_Pink_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Hot_Pink_SK;
                }
                else
                {
                    return EN.Hot_Pink_SK;
                }
            }
        }

        public string Neon_Green_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Neon_Green_SK;
                }
                else
                {
                    return EN.Neon_Green_SK;
                }
            }
        }

        public string Royal_Blue_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Royal_Blue_SK;
                }
                else
                {
                    return EN.Royal_Blue_SK;
                }
            }
        }
        //Epic
        public string Posh_SK//
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Posh_SK;
                }
                else
                {
                    return EN.Posh_SK;
                }
            }
        }

        public string Sporty_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sporty_SK;
                }
                else
                {
                    return EN.Sporty_SK;
                }
            }
        }

        public string Rose_SK//7
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Rose_SK;
                }
                else
                {
                    return EN.Rose_SK;
                }
            }
        }
        //Legendary
        public string Punk_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Punk_SK;
                }
                else
                {
                    return EN.Punk_SK;
                }
            }
        }

        public string Ultraviolet_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ultraviolet_SK;
                }
                else
                {
                    return EN.Ultraviolet_SK;
                }
            }
        }

        public string Mach_T_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mach_T_SK;
                }
                else
                {
                    return EN.Mach_T_SK;
                }
            }
        }

        public string T_Racer_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.T_Racer_SK;
                }
                else
                {
                    return EN.T_Racer_SK;
                }
            }
        }

        public string Slipstream_SK//12
        {//Origin Special
            get
            {
                if (myLang == "DE")
                {
                    return DE.Slipstream_SK;
                }
                else
                {
                    return EN.Slipstream_SK;
                }
            }
        }

        public string Sprinter_SK//13
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sprinter_SK;
                }
                else
                {
                    return EN.Sprinter_SK;
                }
            }
        }

        public string Track_and_Field_SK//14
        {//summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Track_and_Field_SK;
                }
                else
                {
                    return EN.Track_and_Field_SK;
                }
            }
        }

        public string Jingle_SK//15
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Jingle_SK;
                }
                else
                {
                    return EN.Jingle_SK;
                }
            }
        }

        public string Cadet_Oxton_SK//16
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cadet_Oxton_SK;
                }
                else
                {
                    return EN.Cadet_Oxton_SK;
                }
            }
        }

        public string Graffiti_SK//17
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Graffiti_SK;
                }
                else
                {
                    return EN.Graffiti_SK;
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

        public string Finger_guns_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Finger_guns_EM;
                }
                else
                {
                    return EN.Finger_guns_EM;
                }
            }
        }

        public string Having_a_laugh_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Having_a_laugh_EM;
                }
                else
                {
                    return EN.Having_a_laugh_EM;
                }
            }
        }

        public string Sitting_arround_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sitting_around_EM;
                }
                else
                {
                    return EN.Sitting_around_EM;
                }
            }
        }

        public string Spin_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Spin_EM;
                }
                else
                {
                    return EN.Spin_EM;
                }
            }
        }

        public string Charleston_EM//6
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Charleston_EM;
                }
                else
                {
                    return EN.Charleston_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Over_the_shoulder_VP//1
        {
            get
            {
                //else
                {
                    return EN.Over_the_shoulder_VP;
                }
            }
        }

        public string Salute_VP//2
        {
            get
            {
                //else
                {
                    return EN.Salute_VP;
                }
            }
        }

        public string Sitting_VP//3
        {
            get
            {
                //else
                {
                    return EN.Sitting_VP;
                }
            }
        }

        public string Medal_VP//4
        {//Summer 17
            get
            {
                //else
                {
                    return EN.Medal_VP;
                }
            }
        }

        public string Pumpkin_VP//5
        {//Halloween 17
            get
            {
                //else
                {
                    return EN.Pumpkin_VP;
                }
            }
        }

        public string RIP_VP//6
        {//Halloween 16
            get
            {
                //else
                {
                    return EN.RIP_VP;
                }
            }
        }
    }
}
