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
        public string Blood_SK//1
        {
            get
            {
                //else
                {
                    return EN.Blood_SK;
                }
            }
        }

        public string Midnight_SK//2
        {
            get
            {
                //else
                {
                    return EN.Midnight_SK;
                }
            }
        }

        public string Moss_SK//3
        {
            get
            {
                //else
                {
                    return EN.Moss_SK;
                }
            }
        }

        public string Royal_SK//4
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
        public string Desert_SK//5
        {
            get
            {
                //else
                {
                    return EN.Desert_SK;
                }
            }
        }

        public string Wight_SK//6
        {
            get
            {
                //else
                {
                    return EN.Wight_SK;
                }
            }
        }

        public string Shiver_SK//7
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
        public string Nevermore_SK//8
        {
            get
            {
                //else
                {
                    return EN.Nevermore_SK;
                }
            }
        }

        public string Plague_Doctor_SK//9
        {
            get
            {
                //else
                {
                    return EN.Plague_Doctor_SK;
                }
            }
        }

        public string El_Blanco_SK//10
        {
            get
            {
                //else
                {
                    return EN.El_Blanco_SK;
                }
            }
        }

        public string Mariachi_SK//11
        {
            get
            {
                //else
                {
                    return EN.Mariachi_SK;
                }
            }
        }

        public string Blackwatch_Reyes_SK//12
        {//Origin Special
            get
            {
                //else
                {
                    return EN.Blackwatch_Reyes_SK;
                }
            }
        }

        public string Biker_SK//13
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Biker_SK;
                }
            }
        }

        public string Dracula_SK//14
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Dracula_SK;
                }
            }
        }

        public string Pumpkin_SK//15
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
