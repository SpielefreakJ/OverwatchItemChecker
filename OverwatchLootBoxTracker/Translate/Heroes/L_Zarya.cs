using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Zarya : PictureBox
    {
        Languages.English.Heroes.Zarya EN;
        Languages.German.Heroes.Zarya DE;
        string myLang;

        public L_Zarya(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.Zarya();
            DE = new Languages.German.Heroes.Zarya();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Zarya_link.png");
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
        public string Brick_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Brick_SK;
                }
                else
                {
                    return EN.Brick_SK;
                }
            }
        }

        public string Goldenrod_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Goldenrod_SK;
                }
                else
                {
                    return EN.Goldenrod_SK;
                }
            }
        }

        public string Taiga_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Taiga_SK;
                }
                else
                {
                    return EN.Taiga_SK;
                }
            }
        }

        public string Violet_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Violet_SK;
                }
                else
                {
                    return EN.Violet_SK;
                }
            }
        }
        //Epic
        public string Dawn_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dawn_SK;
                }
                else
                {
                    return EN.Dawn_SK;
                }
            }
        }

        public string Midnight_SK//6
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

        public string Frosted_SK//7
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Frosted_SK;
                }
                else
                {
                    return EN.Frosted_SK;
                }
            }
        }
        //Legendary
        public string Arctic_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Arctic_SK;
                }
                else
                {
                    return EN.Arctic_SK;
                }
            }
        }

        public string Siberian_Front_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Siberian_Front_SK;
                }
                else
                {
                    return EN.Siberian_Front_SK;
                }
            }
        }

        public string Cybergoth_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cybergoth_SK;
                }
                else
                {
                    return EN.Cybergoth_SK;
                }
            }
        }

        public string Industrial_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Industrial_SK;
                }
                else
                {
                    return EN.Industrial_SK;
                }
            }
        }

        public string Champion_SK//12
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Champion_SK;
                }
                else
                {
                    return EN.Champion_SK;
                }
            }
        }

        public string Weightlifter_SK//13
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Weightlifter_SK;
                }
                else
                {
                    return EN.Weightlifter_SK;
                }
            }
        }

        public string Totally_80s_SK//14
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Totally_80s_SK;
                }
                else
                {
                    return EN.Totally_80s_SK;
                }
            }
        }

        public string Cyberian_SK//15
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cyberian_SK;
                }
                else
                {
                    return EN.Cyberian_SK;
                }
            }
        }

        public string Barbarian_SK//16
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Industrial_SK;
                }
                else
                {
                    return EN.Barbarian_SK;
                }
            }
        }

        public string Xuanwu_SK//17
        {//Lunar 18
            get
            {
                if (myLang == "DE")
                {
                    return DE.Xuanwu_SK;
                }
                else
                {
                    return EN.Xuanwu_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Bring_it_on_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bring_it_on_EM;
                }
                else
                {
                    return EN.Bring_it_on_EM;
                }
            }
        }

        public string Comedy_Gold_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Comedy_Gold_EM;
                }
                else
                {
                    return EN.Comedy_Gold_EM;
                }
            }
        }

        public string Chush_you_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Crush_you_EM;
                }
                else
                {
                    return EN.Crush_you_EM;
                }
            }
        }

        public string Pumping_Iron_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Punping_Iron_EM;
                }
                else
                {
                    return EN.Punping_Iron_EM;
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
        public string Mystery_Gift_EM//7
        {//YWinter 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mystery_Gift_EM;
                }
                else
                {
                    return EN.Mystery_Gift_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Casual_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Casual_VP;
                }
                else
                {
                    return EN.Casual_VP;
                }
            }
        }

        public string Check_out_this_gun_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Check_out_this_gun_VP;
                }
                else
                {
                    return EN.Check_out_this_gun_VP;
                }
            }
        }

        public string Flexing_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Flexing_VP;
                }
                else
                {
                    return EN.Flexing_VP;
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

        public string This_is_strength_VP//5
        {//Uprising 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.This_is_strength_VP;
                }
                else
                {
                    return EN.This_is_strength_VP;
                }
            }
        }

        public string Toast_VP//6
        {//Winter 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Toast_VP;
                }
                else
                {
                    return EN.Toast_VP;
                }
            }
        }

        public string Big_one_VP//7
        {//Lunar 18
            get
            {
                if (myLang == "DE")
                {
                    return DE.Big_one_VP;
                }
                else
                {
                    return EN.Big_one_VP;
                }
            }
        }
    }
}
