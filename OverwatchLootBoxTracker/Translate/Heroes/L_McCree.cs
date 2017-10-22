using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_McCree
    {
        Languages.English.Heroes.EN_McCree EN;
        string myLang;

        public L_McCree(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_McCree();
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
        public string Ebony_SK//1
        {
            get
            {
                //else
                {
                    return EN.Ebony_SK;
                }
            }
        }

        public string Lake_SK//2
        {
            get
            {
                //else
                {
                    return EN.Lake_SK;
                }
            }
        }

        public string Sage_SK//3
        {
            get
            {
                //else
                {
                    return EN.Sage_SK;
                }
            }
        }

        public string Wheat_SK//4
        {
            get
            {
                //else
                {
                    return EN.Wheat_SK;
                }
            }
        }
        //Epic
        public string On_The_Range_SK//5
        {
            get
            {
                //else
                {
                    return EN.On_The_Range_SK;
                }
            }
        }

        public string White_Hat_SK//6
        {
            get
            {
                //else
                {
                    return EN.White_Hat_SK;
                }
            }
        }

        public string American_SK//7
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.American_SK;
                }
            }
        }

        public string Scrooge_SK//8
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Scrooge_SK;
                }
            }
        }
        //Legendary
        public string Gambler_SK//9
        {
            get
            {
                //else
                {
                    return EN.Gambler_SK;
                }
            }
        }

        public string Riverboat_SK//10
        {
            get
            {
                //else
                {
                    return EN.Riverboat_SK;
                }
            }
        }

        public string Mystery_Man_SK//11
        {
            get
            {
                //else
                {
                    return EN.Mystery_Man_SK;
                }
            }
        }

        public string Vigilante_SK//12
        {
            get
            {
                //else
                {
                    return EN.Vigilante_SK;
                }
            }
        }

        public string Lifeguard_SK//13
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Lifeguard_SK;
                }
            }
        }

        public string Blackwatch_SK//14
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Blackwatch_SK;
                }
            }
        }

        public string Van_Helsing_SK//15
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Van_Helsing_SK;
                }
            }
        }


        //Emotes
    }
}
