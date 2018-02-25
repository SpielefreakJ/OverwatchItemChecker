using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Widowmaker : PictureBox
    {
        Languages.English.Heroes.Widowmaker EN;
        Languages.German.Heroes.Widowmaker DE;
        string myLang;

        public L_Widowmaker(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.Widowmaker();
            DE = new Languages.German.Heroes.Widowmaker();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Widowmaker_link.png");
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
        public string Ciel_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ciel_SK;
                }
                else
                {
                    return EN.Ciel_SK;
                }
            }
        }

        public string Nuit_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Nuit_SK;
                }
                else
                {
                    return EN.Nuit_SK;
                }
            }
        }

        public string Rose_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Rose_SK;
                }
                else
                {
                    return EN.Rose_SK;
                }
            }
        }

        public string Vert_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Vert_SK;
                }
                else
                {
                    return EN.Vert_SK;
                }
            }
        }
        //Epic
        public string Patina_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Patina_SK;
                }
                else
                {
                    return EN.Patina_SK;
                }
            }
        }

        public string Winter_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Winter_SK;
                }
                else
                {
                    return EN.Winter_SK;
                }
            }
        }

        public string Tricolore_SK//7
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Tricolore_SK;
                }
                else
                {
                    return EN.Tricolore_SK;
                }
            }
        }
        //Legendary
        public string Odette_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Odette_SK;
                }
                else
                {
                    return EN.Odette_SK;
                }
            }
        }

        public string Odile_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Odile_SK;
                }
                else
                {
                    return EN.Odile_SK;
                }
            }
        }

        public string Comtesse_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Comtesse_SK;
                }
                else
                {
                    return EN.Comtesse_SK;
                }
            }
        }

        public string Huntress_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Huntress_SK;
                }
                else
                {
                    return EN.Huntress_SK;
                }
            }
        }

        public string Noire_SK//12
        {//Prepurchase Special
            get
            {
                if (myLang == "DE")
                {
                    return DE.Noire_SK;
                }
                else
                {
                    return EN.Noire_SK;
                }
            }
        }

        public string Côte_DAzur_SK//13
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Côte_DAzur_SK;
                }
                else
                {
                    return EN.Côte_DAzur_SK;
                }
            }
        }

        public string Talon_SK//14
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Talon_SK;
                }
                else
                {
                    return EN.Talon_SK;
                }
            }
        }

        public string Nova_SK//15
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Huntress_SK;
                }
                else
                {
                    return EN.Nova_SK;
                }
            }
        }

        public string Black_Lily_SK//16
        {//Lunar 18
            get
            {
                if (myLang == "DE")
                {
                    return DE.Black_Lily_SK;
                }
                else
                {
                    return EN.Black_Lily_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string A_rest_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.A_rest_EM;
                }
                else
                {
                    return EN.A_rest_EM;
                }
            }
        }

        public string Curtain_Call_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Curtain_Call_EM;
                }
                else
                {
                    return EN.Curtain_Call_EM;
                }
            }
        }

        public string Delighted_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Delighted_EM;
                }
                else
                {
                    return EN.Delighted_EM;
                }
            }
        }

        public string Shot_Dead_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shot_Dead_EM;
                }
                else
                {
                    return EN.Shot_Dead_EM;
                }
            }
        }

        public string Widows_Kiss_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Widows_Kiss_EM;
                }
                else
                {
                    return EN.Widows_Kiss_EM;
                }
            }
        }

        public string Ballet_EM//6
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ballet_EM;
                }
                else
                {
                    return EN.Ballet_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Activating_Visor_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Activating_Visor_VP;
                }
                else
                {
                    return EN.Activating_Visor_VP;
                }
            }
        }

        public string Gaze_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Gaze_VP;
                }
                else
                {
                    return EN.Gaze_VP;
                }
            }
        }

        public string Over_the_shoulder_VP//3
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

        public string Toast_VP//6
        {//Winter 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.RIP_VP;
                }
                else
                {
                    return EN.Toast_VP;
                }
            }
        }

        public string Fans_VP//7
        {//Lunar 18
            get
            {
                if (myLang == "DE")
                {
                    return DE.Fans_VP;
                }
                else
                {
                    return EN.Fans_VP;
                }
            }
        }
    }
}
