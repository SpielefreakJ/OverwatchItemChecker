using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Doomfist : PictureBox
    {
        Languages.English.Heroes.Doomfist EN;
        Languages.German.Heroes.Doomfist DE;
        string myLang;

        public L_Doomfist(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.Doomfist();
            DE = new Languages.German.Heroes.Doomfist();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Doomfist_link.png");
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
        public string Daisy_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Daisy_SK;
                }
                else
                {
                    return EN.Daisy_SK;
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

        public string Plains_SK//3
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

        public string Sunset_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sunset_SK;
                }
                else
                {
                    return EN.Sunset_SK;
                }
            }
        }
        //Epic
        public string Leopard_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Leopard_SK;
                }
                else
                {
                    return EN.Leopard_SK;
                }
            }
        }

        public string Painted_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Painted_SK;
                }
                else
                {
                    return EN.Painted_SK;
                }
            }
        }
        //Legendary
        public string Caution_SK//7
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Caution_SK;
                }
                else
                {
                    return EN.Caution_SK;
                }
            }
        }

        public string Irin_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Irin_SK;
                }
                else
                {
                    return EN.Irin_SK;
                }
            }
        }

        public string Avatar_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Avatar_SK;
                }
                else
                {
                    return EN.Avatar_SK;
                }
            }
        }

        public string Spirit_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Spirit_SK;
                }
                else
                {
                    return EN.Spirit_SK;
                }
            }
        }

        public string Blackhand_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blackhand_SK;
                }
                else
                {
                    return EN.Blackhand_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Fake_Out_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Fake_Out_EM;
                }
                else
                {
                    return EN.Fake_Out_EM;
                }
            }
        }

        public string Intimidate_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Intimidate_EM;
                }
                else
                {
                    return EN.Intimidate_EM;
                }
            }
        }

        public string Ready_for_Battle_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ready_for_Battle_EM;
                }
                else
                {
                    return EN.Ready_for_Battle_EM;
                }
            }
        }

        public string Take_a_knee_EM//4
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

        public string Thumbs_Down_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Thumbs_Down_EM;
                }
                else
                {
                    return EN.Thumbs_Down_EM;
                }
            }
        }

        public string Crushing_EM//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Crushing_EM;
                }
                else
                {
                    return EN.Crushing_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Intense_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Intense_VP;
                }
                else
                {
                    return EN.Intense_VP;
                }
            }
        }

        public string Seismic_Slam_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Seismic_Slam_VP;
                }
                else
                {
                    return EN.Seismic_Slam_VP;
                }
            }
        }

        public string Superior_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Superior_VP;
                }
                else
                {
                    return EN.Superior_VP;
                }
            }
        }


        //Voice Lines
        //Common
        public string Try_me_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Try_me_VL;
                }
                else
                {
                    return EN.Try_me_VL;
                }
            }
        }

        public string Combo_Breakere_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Combo_Breakere_VL;
                }
                else
                {
                    return EN.Combo_Breakere_VL;
                }
            }
        }

        public string Dont_get_back_up_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dont_get_back_up_VL;
                }
                else
                {
                    return EN.Dont_get_back_up_VL;
                }
            }
        }

        public string Go_and_sit_down_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Go_and_sit_down_VL;
                }
                else
                {
                    return EN.Go_and_sit_down_VL;
                }
            }
        }

        public string I_havent_even_started_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.I_havent_even_started_VL;
                }
                else
                {
                    return EN.I_havent_even_started_VL;
                }
            }
        }

        public string K_O_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.K_O_VL;
                }
                else
                {
                    return EN.K_O_VL;
                }
            }
        }

        public string One_punch_is_all_i_need_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.One_punch_is_all_i_need_VL;
                }
                else
                {
                    return EN.One_punch_is_all_i_need_VL;
                }
            }
        }

        public string Spare_me_the_commentary_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Spare_me_the_commentary_VL;
                }
                else
                {
                    return EN.Spare_me_the_commentary_VL;
                }
            }
        }

        public string Talk_to_the_fist_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Talk_to_the_fist_VL;
                }
                else
                {
                    return EN.Talk_to_the_fist_VL;
                }
            }
        }

        public string Youre_not_bad_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Youre_not_bad_VL;
                }
                else
                {
                    return EN.Youre_not_bad_VL;
                }
            }
        }

        public string You_must_be_joking_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.You_must_be_joking_VL;
                }
                else
                {
                    return EN.You_must_be_joking_VL;
                }
            }
        }

        public string You_test_my_patience_VL
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.You_test_my_patience_VL;
                }
                else
                {
                    return EN.You_test_my_patience_VL;
                }
            }
        }

        public string I_make_medicine_sick_VL
        {//Summer 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.I_make_medicine_sick_VL;
                }
                else
                {
                    return EN.I_make_medicine_sick_VL;
                }
            }
        }

        public string Make_you_punch_drunk_VL
        {//Summer 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Make_you_punch_drunk_VL;
                }
                else
                {
                    return EN.Make_you_punch_drunk_VL;
                }
            }
        }

        public string I_have_something_for_you_VL
        {//Halloween 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.I_have_something_for_you_VL;
                }
                else
                {
                    return EN.I_have_something_for_you_VL;
                }
            }
        }

        public string You_should_be_scared_VL
        {//Halloween 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.You_should_be_scared_VL;
                }
                else
                {
                    return EN.You_should_be_scared_VL;
                }
            }
        }

        public string And_they_sais_chivalry_is_dead_VL
        {//Halloween 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.You_should_be_scared_VL;
                }
                else
                {
                    return EN.And_they_sais_chivalry_is_dead_VL;
                }
            }
        }

        public string Did_you_bring_me_a_present_VL
        {//Halloween 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.You_should_be_scared_VL;
                }
                else
                {
                    return EN.Did_you_bring_me_a_present_VL;
                }
            }
        }
    }
}
