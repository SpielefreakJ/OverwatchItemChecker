using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Reaper : PictureBox
    {
        Languages.English.Heroes.EN_Reaper EN;
        Languages.German.Heroes.DE_Reaper DE;
        string myLang;

        public L_Reaper(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Reaper();
            DE = new Languages.German.Heroes.DE_Reaper();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Reaper_link.png");
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
        //Epic
        public string Cackle_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cackle_EM;
                }
                else
                {
                    return EN.Cackle_EM;
                }
            }
        }

        public string Not_Impressed_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Not_Impressed_EM;
                }
                else
                {
                    return EN.Not_Impressed_EM;
                }
            }
        }

        public string Shrug_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shrug_EM;
                }
                else
                {
                    return EN.Shrug_EM;
                }
            }
        }

        public string Slice_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Slice_EM;
                }
                else
                {
                    return EN.Slice_EM;
                }
            }
        }

        public string Slow_Clap_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Slow_Clap_EM;
                }
                else
                {
                    return EN.Slow_Clap_EM;
                }
            }
        }

        public string Take_a_knee_EM//6
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

        public string Dance_EM//7
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

        public string Enigmatic_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Enigmatic_VP;
                }
                else
                {
                    return EN.Enigmatic_VP;
                }
            }
        }

        public string Menacing_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Menacing_VP;
                }
                else
                {
                    return EN.Menacing_VP;
                }
            }
        }

        public string Shrug_VP//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shrug_VP;
                }
                else
                {
                    return EN.Shrug_VP;
                }
            }
        }

        public string Medal_VP//5
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

        public string RIP_VP//6
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
    }
}
