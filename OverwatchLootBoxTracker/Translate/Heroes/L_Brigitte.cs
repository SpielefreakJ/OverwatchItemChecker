using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Brigitte : PictureBox
    {
        Languages.English.Heroes.Brigitte EN;
        Languages.German.Heroes.Brigitte DE;
        string myLang;

        public L_Brigitte(string Lang)
        {
            if (Lang != "")
            {
                myLang = Lang;
            }

            EN = new Languages.English.Heroes.Brigitte();
            DE = new Languages.German.Heroes.Brigitte();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Brigitte_link.png");
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


        //Skins
        //Rare
        public string Blå_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blå_SK;
                }
                else
                {
                    return EN.Blå_SK;

                }
            }
        }

        public string Grön_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Grön_SK;
                }
                else
                {
                    return EN.Grön_SK;

                }
            }
        }

        public string Plommon_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Plommon_SK;
                }
                else
                {
                    return EN.Plommon_SK;

                }
            }
        }

        public string Röd_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Röd_SK;
                }
                else
                {
                    return EN.Röd_SK;

                }
            }
        }

        //Epic
        public string Carbon_Fiber_SK//5
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

        public string Ironclad_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ironclad_SK;
                }
                else
                {
                    return EN.Ironclad_SK;

                }
            }
        }

        //Legendary
        public string Máni_SK//7
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Máni_SK;
                }
                else
                {
                    return EN.Máni_SK;

                }
            }
        }

        public string Sól_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sól_SK;
                }
                else
                {
                    return EN.Sól_SK;

                }
            }
        }

        public string Engineer_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Engineer_SK;
                }
                else
                {
                    return EN.Engineer_SK;

                }
            }
        }

        public string Mechanic_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mechanic_SK;
                }
                else
                {
                    return EN.Mechanic_SK;

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

        public string Hilarious_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Hilarious_EM;
                }
                else
                {
                    return EN.Hilarious_EM;

                }
            }
        }

        public string Recalibrate_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Recalibrate_EM;
                }
                else
                {
                    return EN.Recalibrate_EM;

                }
            }
        }

        public string Taunt_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Taunt_EM;
                }
                else
                {
                    return EN.Taunt_EM;

                }
            }
        }


        //Victory Poses
        //Rare
        public string Confident_VL//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Confident_VL;
                }
                else
                {
                    return EN.Confident_VL;

                }
            }
        }

        public string Rally_VL//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Rally_VL;
                }
                else
                {
                    return EN.Rally_VL;

                }
            }
        }

        public string Relaxed_VL//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Relaxed_VL;
                }
                else
                {
                    return EN.Relaxed_VL;

                }
            }
        }
    }
}
