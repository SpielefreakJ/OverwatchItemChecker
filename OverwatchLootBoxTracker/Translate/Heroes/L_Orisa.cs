using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Orisa : PictureBox
    {
        Languages.English.Heroes.Orisa EN;
        Languages.German.Heroes.Orisa DE;
        string myLang;

        public L_Orisa(string Lang)
        {
            if (Lang != "")
            {
                myLang = Lang;
            }

            EN = new Languages.English.Heroes.Orisa();
            DE = new Languages.German.Heroes.Orisa();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Orisa_link.png");
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
        public string Dawn_SK//1
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

        public string Plains_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Plains_SK;
                }
                else
                {
                    return EN.Plains_SK;
                }
            }
        }

        public string Sunrise_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sunrise_SK;
                }
                else
                {
                    return EN.Sunrise_SK;
                }
            }
        }

        public string Twilight_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Twilight_SK;
                }
                else
                {
                    return EN.Twilight_SK;
                }
            }
        }
        //Epic
        public string Camouflage_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Camouflage_SK;
                }
                else
                {
                    return EN.Camouflage_SK;
                }
            }
        }

        public string OR15_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.OR15_SK;
                }
                else
                {
                    return EN.OR15_SK;
                }
            }
        }
        //Legendary
        public string Dynastinae_SK//7
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dynastinae_SK;
                }
                else
                {
                    return EN.Dynastinae_SK;
                }
            }
        }

        public string Megasoma_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Megasoma_SK;
                }
                else
                {
                    return EN.Megasoma_SK;
                }
            }
        }

        public string Carbon_Fiber_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Carbon_Fiber_SK;
                }
                else
                {
                    return EN.Carbon_Fiber_SK;
                }
            }
        }

        public string Protector_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Protector_SK;
                }
                else
                {
                    return EN.Protector_SK;
                }
            }
        }

        public string Null_Sector_SK//11
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Null_Sector_SK;
                }
                else
                {
                    return EN.Null_Sector_SK;
                }
            }
        }

        public string Immortal_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Protector_SK;
                }
                else
                {
                    return EN.Immortal_SK;
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

        public string Halt_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Halt_EM;
                }
                else
                {
                    return EN.Halt_EM;
                }
            }
        }

        public string Kicking_Dirt_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Kicking_Dirt_EM;
                }
                else
                {
                    return EN.Kicking_Dirt_EM;
                }
            }
        }

        public string Laugh_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Laugh_EM;
                }
                else
                {
                    return EN.Laugh_EM;
                }
            }
        }

        public string Sit_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sit_EM;
                }
                else
                {
                    return EN.Sit_EM;
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
        public string Puppy_EM//7
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dance_EM;
                }
                else
                {
                    return EN.Puppy_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Confident_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Confident_VP;
                }
                else
                {
                    return EN.Confident_VP;
                }
            }
        }

        public string Flex_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Flex_VP;
                }
                else
                {
                    return EN.Flex_VP;
                }
            }
        }

        public string Halt_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Halt_VP;
                }
                else
                {
                    return EN.Halt_VP;
                }
            }
        }

        public string Pumpkin_Head_VP//4
        {//Halloween 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Pumpkin_Head_VP;
                }
                else
                {
                    return EN.Pumpkin_Head_VP;
                }
            }
        }
    }
}
