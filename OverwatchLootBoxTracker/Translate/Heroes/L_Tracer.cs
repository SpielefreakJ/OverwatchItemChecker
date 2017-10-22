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
        string myLang;

        public L_Tracer(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Tracer();
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
        public string Electric_Purple_SK//1
        {
            get
            {
                //else
                {
                    return EN.Electric_Purple_SK;
                }
            }
        }

        public string Hot_Pink_SK//2
        {
            get
            {
                //else
                {
                    return EN.Hot_Pink_SK;
                }
            }
        }

        public string Neon_Green_SK//3
        {
            get
            {
                //else
                {
                    return EN.Neon_Green_SK;
                }
            }
        }

        public string Royal_Blue_SK//4
        {
            get
            {
                //else
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
                //else
                {
                    return EN.Posh_SK;
                }
            }
        }

        public string Sporty_SK//6
        {
            get
            {
                //else
                {
                    return EN.Sporty_SK;
                }
            }
        }

        public string Rose_SK//7
        {//Rooster 2017
            get
            {
                //else
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
                //else
                {
                    return EN.Punk_SK;
                }
            }
        }

        public string Ultraviolet_SK//9
        {
            get
            {
                //else
                {
                    return EN.Ultraviolet_SK;
                }
            }
        }

        public string Mach_T_SK//10
        {
            get
            {
                //else
                {
                    return EN.Mach_T_SK;
                }
            }
        }

        public string T_Racer_SK//11
        {
            get
            {
                //else
                {
                    return EN.T_Racer_SK;
                }
            }
        }

        public string Slipstream_SK//12
        {//Origin Special
            get
            {
                //else
                {
                    return EN.Slipstream_SK;
                }
            }
        }

        public string Sprinter_SK//13
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Sprinter_SK;
                }
            }
        }

        public string Track_and_Field_SK//14
        {//summer 2016
            get
            {
                //else
                {
                    return EN.Track_and_Field_SK;
                }
            }
        }

        public string Jingle_SK//15
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Jingle_SK;
                }
            }
        }

        public string Cadet_Oxton_SK//16
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Cadet_Oxton_SK;
                }
            }
        }

        public string Graffiti_SK//17
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Graffiti_SK;
                }
            }
        }


        //Emotes
    }
}
