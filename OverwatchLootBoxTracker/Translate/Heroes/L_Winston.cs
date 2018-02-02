using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Winston : PictureBox
    {
        Languages.English.Heroes.Winston EN;
        Languages.German.Heroes.Winston DE;
        string myLang;

        public L_Winston(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.Winston();
            DE = new Languages.German.Heroes.Winston();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Winston_link.png");
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
        public string Atmosphere_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Atmosphere_SK;
                }
                else
                {
                    return EN.Atmosphere_SK;
                }
            }
        }

        public string Banana_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Banana_SK;
                }
                else
                {
                    return EN.Banana_SK;
                }
            }
        }

        public string Forest_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Forest_SK;
                }
                else
                {
                    return EN.Forest_SK;
                }
            }
        }

        public string Red_Planet_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Red_Planet_SK;
                }
                else
                {
                    return EN.Red_Planet_SK;
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

        public string Horizon_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Horizon_SK;
                }
                else
                {
                    return EN.Horizon_SK;
                }
            }
        }

        public string Blizzcon_2017_SK//7
        {//BlizzCon 2017 Special
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blizzcon_2017_SK;
                }
                else
                {
                    return EN.Blizzcon_2017_SK;
                }
            }
        }
        //Legendary
        public string Frogston_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Frogston_SK;
                }
                else
                {
                    return EN.Frogston_SK;
                }
            }
        }

        public string Undersea_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Undersea_SK;
                }
                else
                {
                    return EN.Undersea_SK;
                }
            }
        }

        public string Explorer_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Explorer_SK;
                }
                else
                {
                    return EN.Explorer_SK;
                }
            }
        }

        public string Safari_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Safari_SK;
                }
                else
                {
                    return EN.Safari_SK;
                }
            }
        }

        public string Yeti_SK//12
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Yeti_SK;
                }
                else
                {
                    return EN.Yeti_SK;
                }
            }
        }

        public string Wukong_SK//13
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Wukong_SK;
                }
                else
                {
                    return EN.Wukong_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Laugh_matter_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Laughing_matter_EM;
                }
                else
                {
                    return EN.Laughing_matter_EM;
                }
            }
        }

        public string Monkey_Buisness_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Monkey_Buisness_EM;
                }
                else
                {
                    return EN.Monkey_Buisness_EM;
                }
            }
        }

        public string Peanut_Butter_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Peanut_Butter_EM;
                }
                else
                {
                    return EN.Peanut_Butter_EM;
                }
            }
        }

        public string Roar_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Roar_EM;
                }
                else
                {
                    return EN.Roar_EM;
                }
            }
        }

        public string Sitting_around_EM//5
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

        public string Shadow_Puppets_EM//6
        {//Halloween 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shadow_Puppets_EM;
                }
                else
                {
                    return EN.Shadow_Puppets_EM;
                }
            }
        }

        public string Twist_EM//7
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Twist_EM;
                }
                else
                {
                    return EN.Twist_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Beast_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Beast_VP;
                }
                else
                {
                    return EN.Beast_VP;
                }
            }
        }

        public string Glasses_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Glasses_VP;
                }
                else
                {
                    return EN.Glasses_VP;
                }
            }
        }

        public string The_Thinker_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.The_Thinker_VP;
                }
                else
                {
                    return EN.The_Thinker_VP;
                }
            }
        }

        public string Medal_VP//4
        {//Summer 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Medal_VP;
                }
                else
                {
                    return EN.Medal_VP;
                }
            }
        }

        public string RIP_VP//5
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

        public string Peanut_Butter_VP//6
        {//Uprising 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Peanut_Butter_EM;
                }
                else
                {
                    return EN.Peanut_Butter_EM;
                }
            }
        }
    }
}
