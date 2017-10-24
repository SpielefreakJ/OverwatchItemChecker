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
        Languages.German.Heroes.DE_Reaper DE;
        string myLang;

        public L_Reaper(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Reaper();
            DE = new Languages.German.Heroes.DE_Reaper();
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
        public string Blood_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blood_SK;
                }
                else
                {
                    return EN.Blood_SK;
                }
            }
        }

        public string Midnight_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Midnight_SK;
                }
                else
                {
                    return EN.Midnight_SK;
                }
            }
        }

        public string Moss_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Moss_SK;
                }
                else
                {
                    return EN.Moss_SK;
                }
            }
        }

        public string Royal_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Royal_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Desert_SK;
                }
                else
                {
                    return EN.Desert_SK;
                }
            }
        }

        public string Wight_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Wight_SK;
                }
                else
                {
                    return EN.Wight_SK;
                }
            }
        }

        public string Shiver_SK//7
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shiver_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Nevermore_SK;
                }
                else
                {
                    return EN.Nevermore_SK;
                }
            }
        }

        public string Plague_Doctor_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Plague_Doctor_SK;
                }
                else
                {
                    return EN.Plague_Doctor_SK;
                }
            }
        }

        public string El_Blanco_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.El_Blanco_SK;
                }
                else
                {
                    return EN.El_Blanco_SK;
                }
            }
        }

        public string Mariachi_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mariachi_SK;
                }
                else
                {
                    return EN.Mariachi_SK;
                }
            }
        }

        public string Blackwatch_Reyes_SK//12
        {//Origin Special
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blackwatch_Reyes_SK;
                }
                else
                {
                    return EN.Blackwatch_Reyes_SK;
                }
            }
        }

        public string Biker_SK//13
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Biker_SK;
                }
                else
                {
                    return EN.Biker_SK;
                }
            }
        }

        public string Dracula_SK//14
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dracula_SK;
                }
                else
                {
                    return EN.Dracula_SK;
                }
            }
        }

        public string Pumpkin_SK//15
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Pumpkin_SK;
                }
                else
                {
                    return EN.Pumpkin_SK;
                }
            }
        }


        //Emotes
    }
}
