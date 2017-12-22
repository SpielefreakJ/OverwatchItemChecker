using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_McCree : PictureBox
    {
        Languages.English.Heroes.EN_McCree EN;
        Languages.German.Heroes.DE_McCree DE;
        string myLang;

        public L_McCree(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_McCree();
            DE = new Languages.German.Heroes.DE_McCree();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\McCree_link.png");
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

        public string GetName()
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


        //Skin

        //Rare
        public string Ebony_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ebony_SK;
                }
                else
                {
                    return EN.Ebony_SK;
                }
            }
        }

        public string Lake_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Lake_SK;
                }
                else
                {
                    return EN.Lake_SK;
                }
            }
        }

        public string Sage_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sage_SK;
                }
                else
                {
                    return EN.Sage_SK;
                }
            }
        }

        public string Wheat_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Wheat_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.On_The_Range_SK;
                }
                else
                {
                    return EN.On_The_Range_SK;
                }
            }
        }

        public string White_Hat_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.White_Hat_SK;
                }
                else
                {
                    return EN.White_Hat_SK;
                }
            }
        }

        public string American_SK//7
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.American_SK;
                }
                else
                {
                    return EN.American_SK;
                }
            }
        }

        public string Scrooge_SK//8
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Scrooge_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Gambler_SK;
                }
                else
                {
                    return EN.Gambler_SK;
                }
            }
        }

        public string Riverboat_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Riverboat_SK;
                }
                else
                {
                    return EN.Riverboat_SK;
                }
            }
        }

        public string Mystery_Man_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mystery_Man_SK;
                }
                else
                {
                    return EN.Mystery_Man_SK;
                }
            }
        }

        public string Vigilante_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Vigilante_SK;
                }
                else
                {
                    return EN.Vigilante_SK;
                }
            }
        }

        public string Lifeguard_SK//13
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Lifeguard_SK;
                }
                else
                {
                    return EN.Lifeguard_SK;
                }
            }
        }

        public string Van_Helsing_SK//14
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Van_Helsing_SK;
                }
                else
                {
                    return EN.Van_Helsing_SK;
                }
            }
        }

        public string Blackwatch_SK//15
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blackwatch_SK;
                }
                else
                {
                    return EN.Blackwatch_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Gunspinning_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Gunspinning_EM;
                }
                else
                {
                    return EN.Gunspinning_EM;
                }
            }
        }

        public string Hat_Tip_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Hat_Tip_EM;
                }
                else
                {
                    return EN.Hat_Tip_EM;
                }
            }
        }

        public string Joker_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Joker_EM;
                }
                else
                {
                    return EN.Joker_EM;
                }
            }
        }

        public string Spit_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Spit_EM;
                }
                else
                {
                    return EN.Spit_EM;
                }
            }
        }

        public string Take_a_load_off_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Take_a_load_off_EM;
                }
                else
                {
                    return EN.Take_a_load_off_EM;
                }
            }
        }

        public string Hat_Trick_EM//6
        {//Winter 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Hat_Trick_EM;
                }
                else
                {
                    return EN.Hat_Trick_EM;
                }
            }
        }

        public string Line_Dance_EM//7
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Line_Dance_EM;
                }
                else
                {
                    return EN.Line_Dance_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Contemplative_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Contemplative_VP;
                }
                else
                {
                    return EN.Contemplative_VP;
                }
            }
        }

        public string Over_the_shoulder_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Over_the_shoulder_VP;
                }
                else
                {
                    return EN.Over_the_shoulder_VP;
                }
            }
        }

        public string Take_it_easy_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Take_a_load_off_EM;
                }
                else
                {
                    return EN.Take_a_load_off_EM;
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

        public string Showdown_VP//5
        {//Uprising 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Showdown_VP;
                }
                else
                {
                    return EN.Showdown_VP;
                }
            }
        }
    }
}
