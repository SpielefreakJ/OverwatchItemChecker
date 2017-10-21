using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Reaper
    {
        Languages.English.Heroes.EN_Reaper EN;
        string myLang;

        public L_Reaper(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Reaper();
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
        public string R1_Blood_SK
        {
            get
            {
                //else
                {
                    return EN.Blood_SK;
                }
            }
        }

        public string R1_Midnight_SK
        {
            get
            {
                //else
                {
                    return EN.Midnight_SK;
                }
            }
        }

        public string R1_Moss_SK
        {
            get
            {
                //else
                {
                    return EN.Moss_SK;
                }
            }
        }

        public string R1_Royal_SK
        {
            get
            {
                //else
                {
                    return EN.Royal_SK;
                }
            }
        }
        //Epic
        public string R1_Desert_SK
        {
            get
            {
                //else
                {
                    return EN.Desert_SK;
                }
            }
        }

        public string R1_Wight_SK
        {
            get
            {
                //else
                {
                    return EN.Wight_SK;
                }
            }
        }

        public string R1_Shiver_SK
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Shiver_SK;
                }
            }
        }
        //Legendary
        public string R1_Nevermore_SK
        {
            get
            {
                //else
                {
                    return EN.Nevermore_SK;
                }
            }
        }

        public string R1_Plague_Doctor_SK
        {
            get
            {
                //else
                {
                    return EN.Plague_Doctor_SK;
                }
            }
        }

        public string R1_El_Blanco_SK
        {
            get
            {
                //else
                {
                    return EN.El_Blanco_SK;
                }
            }
        }

        public string R1_Mariachi_SK
        {
            get
            {
                //else
                {
                    return EN.Mariachi_SK;
                }
            }
        }

        public string R1_Blackwatch_Reyes_SK
        {//Origin Special
            get
            {
                //else
                {
                    return EN.Blackwatch_Reyes_SK;
                }
            }
        }

        public string R1_Biker_SK
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Biker_SK;
                }
            }
        }

        public string R1_Dracula_SK
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Dracula_SK;
                }
            }
        }

        public string R1_Pumpkin_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Pumpkin_SK;
                }
            }
        }


        //Emotes
    }
}
