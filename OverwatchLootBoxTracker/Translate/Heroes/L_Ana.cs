using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Ana : PictureBox
    {
        Languages.English.Heroes.Ana EN;
        Languages.German.Heroes.Ana DE;
        string myLang;

        public L_Ana(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.Ana();
            DE = new Languages.German.Heroes.Ana();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Ana_link.png");
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
        public string Citrine_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Citrine_SK;
                }
                else
                {
                    return EN.Citrine_SK;
                }
            }
        }

        public string Garnet_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Garnet_SK;
                }
                else
                {
                    return EN.Garnet_SK;
                }
            }
        }

        public string Peridot_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Peridot_SK;
                }
                else
                {
                    return EN.Peridot_SK;
                }
            }
        }

        public string Turquoise_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Turquoise_SK;
                }
                else
                {
                    return EN.Turquoise_SK;
                }
            }
        }

        //Epic
        public string Merciful_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Merciful_SK;
                }
                else
                {
                    return EN.Merciful_SK;
                }
            }
        }

        public string Shrike_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shrike_SK;
                }
                else
                {
                    return EN.Shrike_SK;
                }
            }
        }

        public string Ghoul_SK//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ghoul_SK;
                }
                else
                {
                    return EN.Ghoul_SK;
                }
            }
        }

        public string Tal_SK//8
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Tal_SK;
                }
                else
                {
                    return EN.Tal_SK;
                }
            }
        }

        //Legendary
        public string Wadjet_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Wadjet_SK;
                }
                else
                {
                    return EN.Wadjet_SK;
                }
            }
        }

        public string Wasteland_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Wasteland_SK;
                }
                else
                {
                    return EN.Wasteland_SK;
                }
            }
        }

        public string Captain_Amari_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Captain_Amari_SK;
                }
                else
                {
                    return EN.Captain_Amari_SK;
                }
            }
        }

        public string Horus_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Horus_SK;
                }
                else
                {
                    return EN.Horus_SK;
                }
            }
        }

        public string Corsair_SK//13
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Corsair_SK;
                }
                else
                {
                    return EN.Corsair_SK;
                }
            }
        }

        public string Snow_Owl_SK//14
        {//Winter 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Corsair_SK;
                }
                else
                {
                    return EN.Snow_Owl_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Not_Impressed_EM//1
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

        public string Disapproving_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Disapproving_EM;
                }
                else
                {
                    return EN.Disapproving_EM;
                }
            }
        }

        public string Protector_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Protector_EM;
                }
                else
                {
                    return EN.Protector_EM;
                }
            }
        }

        public string Take_A_Knee_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Take_A_Knee_EM;
                }
                else
                {
                    return EN.Take_A_Knee_EM;
                }
            }
        }

        public string Tea_Time_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Tea_Time_EM;
                }
                else
                {
                    return EN.Tea_Time_EM;
                }
            }
        }

        public string Beach_Ball_EM//6
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Beach_Ball_EM;
                }
                else
                {
                    return EN.Beach_Ball_EM;
                }
            }
        }

        public string Candy_EM//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Candy_EM;
                }
                else
                {
                    return EN.Candy_EM;
                }
            }
        }

        public string Dance_EM//8
        {//Annyver 2017
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
        public string Mission_Complete_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mission_Complete_VP;
                }
                else
                {
                    return EN.Mission_Complete_VP;
                }
            }
        }

        public string Protector_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Protector_VP;
                }
                else
                {
                    return EN.Protector_VP;
                }
            }
        }

        public string Seated_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Seated_VP;
                }
                else
                {
                    return EN.Seated_VP;
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

        public string Toast_VP//5
        {//Winter 16
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

        public string Folded_Hands_VP//6
        {//Rooster 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Folded_Hands_VP;
                }
                else
                {
                    return EN.Folded_Hands_VP;
                }
            }
        }


        //Voice Lines
        //Common
        public string Justice_Delivered_VL//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Justice_Delivered_VL;
                }
                else
                {
                    return EN.Justice_Delivered_VL;

                }
            }
        }

        public string Children_behave_VL//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Children_behave_VL;
                }
                else
                {
                    return EN.Children_behave_VL;
                }
            }
        }

        public string Everyone_dies_VL//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Everyone_dies_VL;
                }
                else
                {
                    return EN.Everyone_dies_VL;
                }
            }
        }

        public string Go_on_i_can_wait_VL//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Go_on_i_can_wait_VL;
                }
                else
                {
                    return EN.Go_on_i_can_wait_VL;
                }
            }
        }

        public string It_takes_a_woman_to_know_VL//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.It_takes_a_woman_to_know_VL;
                }
                else
                {
                    return EN.It_takes_a_woman_to_know_VL;
                }
            }
        }

        public string Justice_rains_from_above_VL//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Justice_rains_from_above_VL;
                }
                else
                {
                    return EN.Justice_rains_from_above_VL;
                }
            }
        }

        public string Mother_knows_best_VL//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mother_knows_best_VL;
                }
                else
                {
                    return EN.Mother_knows_best_VL;
                }
            }
        }

        public string No_scope_needed_VL//7
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.No_scope_needed_VL;
                }
                else
                {
                    return EN.No_scope_needed_VL;
                }
            }
        }

        public string What_are_you_thinking_VL//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.What_are_you_thinking_VL;
                }
                else
                {
                    return EN.What_are_you_thinking_VL;
                }
            }
        }

        public string Witness_me_VL//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Witness_me_VL;
                }
                else
                {
                    return EN.Witness_me_VL;
                }
            }
        }

        public string You_know_nothing_VL//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.You_know_nothing_VL;
                }
                else
                {
                    return EN.You_know_nothing_VL;
                }
            }
        }

        public string Someone_to_tuck_you_in_VL//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Someone_to_tuck_you_in_VL;
                }
                else
                {
                    return EN.Someone_to_tuck_you_in_VL;
                }
            }
        }

        public string Better_than_retirement_VL//12
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Better_than_retirement_VL;
                }
                else
                {
                    return EN.Better_than_retirement_VL;
                }
            }
        }

        public string Learn_from_the_pain_VL//13
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Learn_from_the_pain_VL;
                }
                else
                {
                    return EN.Learn_from_the_pain_VL;
                }
            }
        }

        public string Are_you_scared_VL//14
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Are_you_scared_VL;
                }
                else
                {
                    return EN.Are_you_scared_VL;
                }
            }
        }

        public string Dont_be_scared_VL//15
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dont_be_scared_VL;
                }
                else
                {
                    return EN.Dont_be_scared_VL;
                }
            }
        }

        public string Im_watching_out_for_you_VL//16
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Im_watching_out_for_you_VL;
                }
                else
                {
                    return EN.Im_watching_out_for_you_VL;
                }
            }
        }

        public string The_Moon_in_Winter_VL//17
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.The_Moon_in_Winter_VL;
                }
                else
                {
                    return EN.The_Moon_in_Winter_VL;
                }
            }
        }

        public string Damn_VL//18
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Damn_VL;
                }
                else
                {
                    return EN.Damn_VL;
                }
            }
        }

        public string The_Ghost_watches_VL//19
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.The_Ghost_watches_VL;
                }
                else
                {
                    return EN.The_Ghost_watches_VL;
                }
            }
        }

        public string Follow_me_VL//20
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Follow_me_VL;
                }
                else
                {
                    return EN.Follow_me_VL;
                }
            }
        }

        public string The_adults_are_talking_VL//21
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.The_adults_are_talking_VL;
                }
                else
                {
                    return EN.The_adults_are_talking_VL;
                }
            }
        }

        public string Im_too_old_for_surprises_VL//22
        {//Winter 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Im_watching_out_for_you_VL;
                }
                else
                {
                    return EN.Im_too_old_for_surprises_VL;
                }
            }
        }


        //Sprays
        //Common
        public string Action_SP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Action_SP;
                }
                else
                {
                    return EN.Action_SP;
                }
            }
        }

        public string Ana_SP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ana_SP;
                }
                else
                {
                    return EN.Ana_SP;
                }
            }
        }

        public string Bearer_SP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bearer_SP;
                }
                else
                {
                    return EN.Bearer_SP;
                }
            }
        }

        public string Cheer_SP//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cheer_SP;
                }
                else
                {
                    return EN.Cheer_SP;
                }
            }
        }

        public string Cracked_SP//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cracked_SP;
                }
                else
                {
                    return EN.Cracked_SP;
                }
            }
        }

        public string Cute_SP//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cute_SP;
                }
                else
                {
                    return EN.Cute_SP;
                }
            }
        }

        public string Eyepatch_SP//7
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Eyepatch_SP;
                }
                else
                {
                    return EN.Eyepatch_SP;
                }
            }
        }

        public string Fareeha_SP//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Fareeha_SP;
                }
                else
                {
                    return EN.Fareeha_SP;
                }
            }
        }

        public string Gaze_SP//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Gaze_SP;
                }
                else
                {
                    return EN.Gaze_SP;
                }
            }
        }

        public string Grenade_SP//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Grenade_SP;
                }
                else
                {
                    return EN.Grenade_SP;
                }
            }
        }

        public string Guardian_SP//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Guardian_SP;
                }
                else
                {
                    return EN.Guardian_SP;
                }
            }
        }

        public string Hesitation_SP//12
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Hesitation_SP;
                }
                else
                {
                    return EN.Hesitation_SP;
                }
            }
        }

        public string Icon_SP//13
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Icon_SP;
                }
                else
                {
                    return EN.Icon_SP;
                }
            }
        }

        public string Letter_SP//14
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Letter_SP;
                }
                else
                {
                    return EN.Letter_SP;
                }
            }
        }

        public string Old_Soldier_SP//15
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Old_Soldier_SP;
                }
                else
                {
                    return EN.Old_Soldier_SP;
                }
            }
        }

        public string Overhead_SP//16
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Overhead_SP;
                }
                else
                {
                    return EN.Overhead_SP;
                }
            }
        }

        public string Pillow_SP//17
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Pillow_SP;
                }
                else
                {
                    return EN.Pillow_SP;
                }
            }
        }

        public string Photograph_SP//18
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Photograph_SP;
                }
                else
                {
                    return EN.Photograph_SP;
                }
            }
        }

        public string Pixel_SP//19
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Pixel_SP;
                }
                else
                {
                    return EN.Pixel_SP;
                }
            }
        }

        public string Rifle_SP//20
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Rifle_SP;
                }
                else
                {
                    return EN.Rifle_SP;
                }
            }
        }

        public string Shadow_SP//21
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shadow_SP;
                }
                else
                {
                    return EN.Shadow_SP;
                }
            }
        }

        public string Shhh_SP//22
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shhh_SP;
                }
                else
                {
                    return EN.Shhh_SP;
                }
            }
        }

        public string Sidearm_SP//23
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sidearm_SP;
                }
                else
                {
                    return EN.Sidearm_SP;
                }
            }
        }

        public string Wasteland_SP//23
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Wasteland_SP;
                }
                else
                {
                    return EN.Wasteland_SP;
                }
            }
        }

        public string Wedjat_SP//24
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Wedjat_SP;
                }
                else
                {
                    return EN.Wedjat_SP;
                }
            }
        }

        public string Wrist_Launcher_SP//25
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Wrist_Launcher_SP;
                }
                else
                {
                    return EN.Wrist_Launcher_SP;
                }
            }
        }

        public string Zzz_SP//26
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Zzz_SP;
                }
                else
                {
                    return EN.Zzz_SP;
                }
            }
        }

        public string Shooting_SP//27
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shooting_SP;
                }
                else
                {
                    return EN.Shooting_SP;
                }
            }
        }

        public string Trick_or_Treat_SP//28
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Trick_or_Treat_SP;
                }
                else
                {
                    return EN.Trick_or_Treat_SP;
                }
            }
        }

        public string Ornament_SP//29
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ornament_SP;
                }
                else
                {
                    return EN.Ornament_SP;
                }
            }
        }

        public string Warm_SP//30
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Warm_SP;
                }
                else
                {
                    return EN.Warm_SP;
                }
            }
        }

        public string Dance_SP//31
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dance_SP;
                }
                else
                {
                    return EN.Dance_SP;
                }
            }
        }

        public string Dragon_Dance_SP//32
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dragon_Dance_SP;
                }
                else
                {
                    return EN.Dragon_Dance_SP;
                }
            }
        }

        public string Newborn_SP//33
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Newborn_SP;
                }
                else
                {
                    return EN.Newborn_SP;
                }
            }
        }

        public string Ace_of_Hearts_SP//34
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ace_of_Hearts_SP;
                }
                else
                {
                    return EN.Ace_of_Hearts_SP;
                }
            }
        }


        //Highlight Intros
        //Epic
        public string Guardian_HI//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Guardian_HI;
                }
                else
                {
                    return EN.Guardian_HI;
                }
            }
        }

        public string Locked_on_HI//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Locked_on_HI;
                }
                else
                {
                    return EN.Locked_on_HI;
                }
            }
        }

        public string Shh_HI//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shh_HI;
                }
                else
                {
                    return EN.Shh_HI;
                }
            }
        }

        public string Under_Fire_HI//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Under_Fire_HI;
                }
                else
                {
                    return EN.Under_Fire_HI;
                }
            }
        }


        //Player Icons
        //Rare
        public string Ana_PI//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ana_PI;
                }
                else
                {
                    return EN.Ana_PI;
                }
            }
        }

        public string Cute_Ana_PI//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cute_Ana_PI;
                }
                else
                {
                    return EN.Cute_Ana_PI;
                }
            }
        }

        public string Watcher_PI//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Watcher_PI;
                }
                else
                {
                    return EN.Watcher_PI;
                }
            }
        }

        public string Wedjat_PI//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Wedjat_PI;
                }
                else
                {
                    return EN.Wedjat_PI;
                }
            }
        }

        public string Shooting_PI//4
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Shooting_PI;
                }
                else
                {
                    return EN.Shooting_PI;
                }
            }
        }

        public string Corsair_PI//5
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Corsair_PI;
                }
                else
                {
                    return EN.Corsair_PI;
                }
            }
        }

        public string Anaversary_PI//6
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Anaversary_PI;
                }
                else
                {
                    return EN.Anaversary_PI;
                }
            }
        }
    }
}
