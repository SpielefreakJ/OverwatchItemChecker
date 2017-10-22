using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Ana
    {
        Languages.English.Heroes.EN_Ana EN;
        string myLang;

        public L_Ana(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Ana();
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


        //Skins
        //Rare
        public string Citrine_SK//1
        {
            get
            {
                //else
                {
                    return EN.Citrine_SK;
                }
            }
        }

        public string Garnet_SK//2
        {
           get
            {
                //else
                {
                    return EN.Garnet_SK;
                }
            }
        }

        public string Peridot_SK//3
        {
            get
            {
                //else
                {
                    return EN.Peridot_SK;
                }
            }
        }

        public string Turquoise_SK//4
        {
            get
            {
                //else
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
                //else
                {
                    return EN.Merciful_SK;
                }
            }
        }

        public string Shrike_SK//6
        {
            get
            {
                //else
                {
                    return EN.Shrike_SK;
                }
            }
        }

        public string Ghoul_SK//7
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Ghoul_SK;
                }
            }
        }

        public string Tal_SK//8
        {//Rooster 2017
            get
            {
                //else
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
                //else
                {
                    return EN.Wadjet_SK;
                }
            }
        }

        public string Wasteland_SK//10
        {
            get
            {
                //else
                {
                    return EN.Wasteland_SK;
                }
            }
        }

        public string Captain_Amari_SK//11
        {
            get
            {
                //else
                {
                    return EN.Captain_Amari_SK;
                }
            }
        }

        public string Horus_SK//12
        {
            get
            {
                //else
                {
                    return EN.Horus_SK;
                }
            }
        }

        public string Corsair_SK//13
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Corsair_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Not_Impressed_EM//1
        {
            get
            {
                //else
                {
                    return EN.Not_Impressed_EM;
                }
            }
        }

        public string Disapproving_EM//2
        {
            get
            {
                //else
                {
                    return EN.Disapproving_EM;
                }
            }
        }

        public string Protector_EM//3
        {
            get
            {
                //else
                {
                    return EN.Protector_EM;
                }
            }
        }

        public string Take_A_Knee_EM//4
        {
            get
            {
                //else
                {
                    return EN.Take_A_Knee_EM;
                }
            }
        }

        public string Tea_Time_EM//5
        {
            get
            {
                //else
                {
                    return EN.Tea_Time_EM;
                }
            }
        }

        public string Beach_Ball_EM//6
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Beach_Ball_EM;
                }
            }
        }

        public string Candy_EM//7
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Candy_EM;
                }
            }
        }

        public string Dance_EM//8
        {//Annyver 2017
            get
            {
                //else
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
                //else
                {
                    return EN.Mission_Complete_VP;
                }
            }
        }

        public string Protector_VP//2
        {
            get
            {
                //else
                {
                    return EN.Protector_VP;
                }
            }
        }

        public string Seated_VP//3
        {
            get
            {
                //else
                {
                    return EN.Seated_VP;
                }
            }
        }

        public string RIP_VP//4
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string Toast_VP//5
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Toast_VP;
                }
            }
        }

        public string Folded_Hands_VP//6
        {//Rooster 2017
            get
            {
                //else
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
                //else
                {
                    return EN.Justice_Delivered_VL;

                }
            }
        }

        public string Children_behave_VL//2
        {
            get
            {
                //else
                {
                    return EN.Children_behave_VL;
                }
            }
        }

        public string Everyone_dies_VL//3
        {
            get
            {
                //else
                {
                    return EN.Everyone_dies_VL;
                }
            }
        }

        public string It_takes_a_woman_to_know_VL//4
        {
            get
            {
                //else
                {
                    return EN.It_takes_a_woman_to_know_VL;
                }
            }
        }

        public string Justice_rains_from_above_VL//5
        {
            get
            {
                //else
                {
                    return EN.Justice_rains_from_above_VL;
                }
            }
        }

        public string Mother_knows_best_VL//6
        {
            get
            {
                //else
                {
                    return EN.Mother_knows_best_VL;
                }
            }
        }

        public string No_scope_needed_VL//7
        {
            get
            {
                //else
                {
                    return EN.No_scope_needed_VL;
                }
            }
        }

        public string What_are_you_thinking_VL//8
        {
            get
            {
                //else
                {
                    return EN.What_are_you_thinking_VL;
                }
            }
        }

        public string Witness_me_VL//9
        {
            get
            {
                //else
                {
                    return EN.Witness_me_VL;
                }
            }
        }

        public string You_know_nothing_VL//10
        {
            get
            {
                //else
                {
                    return EN.You_know_nothing_VL;
                }
            }
        }

        public string Someone_to_tuck_you_in_VL//11
        {
            get
            {
                //else
                {
                    return EN.Someone_to_tuck_you_in_VL;
                }
            }
        }

        public string Learn_from_the_pain_VL//12
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Learn_from_the_pain_VL;
                }
            }
        }

        public string Are_you_scared_VL//13
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Are_you_scared_VL;
                }
            }
        }

        public string Dont_be_scared_VL//14
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Dont_be_scared_VL;
                }
            }
        }

        public string Im_watching_out_for_you_VL//15
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Im_watching_out_for_you_VL;
                }
            }
        }

        public string The_Moon_in_Winter_VL//16
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.The_Moon_in_Winter_VL;
                }
            }
        }

        public string Damn_VL//17
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Damn_VL;
                }
            }
        }

        public string The_Ghost_watches_VL//18
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.The_Ghost_watches_VL;
                }
            }
        }

        public string Follow_me_VL//19
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Follow_me_VL;
                }
            }
        }

        public string The_adults_are_talking_VL//20
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.The_adults_are_talking_VL;
                }
            }
        }


        //Sprays
        //Common
        public string Action_SP//1
        {
            get
            {
                //else
                {
                    return EN.Action_SP;
                }
            }
        }

        public string Ana_SP//2
        {
            get
            {
                //else
                {
                    return EN.Ana_SP;
                }
            }
        }

        public string Bearer_SP//3
        {
            get
            {
                //else
                {
                    return "Bearer";
                }
            }
        }

        public string Cheer_SP//4
        {
            get
            {
                //else
                {
                    return "Cheer";
                }
            }
        }

        public string Cracked_SP//5
        {
            get
            {
                //else
                {
                    return "Cracked";
                }
            }
        }

        public string Cute_SP//6
        {
            get
            {
                //else
                {
                    return "Cute";
                }
            }
        }

        public string Eyepatch_SP//7
        {
            get
            {
                //else
                {
                    return "Eyepatch";
                }
            }
        }

        public string Fareeha_SP//8
        {
            get
            {
                //else
                {
                    return "Fareeha";
                }
            }
        }

        public string Gaze_SP//9
        {
            get
            {
                //else
                {
                    return "Gaze";
                }
            }
        }

        public string Grenade_SP//10
        {
            get
            {
                //else
                {
                    return "Grenade";
                }
            }
        }

        public string Guardian_SP//11
        {
            get
            {
                //else
                {
                    return "Guardian";
                }
            }
        }

        public string Hesitation_SP//12
        {
            get
            {
                //else
                {
                    return "Hesitation";
                }
            }
        }

        public string Icon_SP//13
        {
            get
            {
                //else
                {
                    return "Icon";
                }
            }
        }

        public string Letter_SP//14
        {
            get
            {
                //else
                {
                    return "Letter";
                }
            }
        }

        public string Old_Soldier_SP//15
        {
            get
            {
                //else
                {
                    return "Old Soldier";
                }
            }
        }

        public string Overhead_SP//16
        {
            get
            {
                //else
                {
                    return "Overhead";
                }
            }
        }

        public string Photograph_SP//17
        {
            get
            {
                //else
                {
                    return "Photograph";
                }
            }
        }

        public string Pixel_SP//18
        {
            get
            {
                //else
                {
                    return "Pixel";
                }
            }
        }

        public string Rifle_SP//19
        {
            get
            {
                //else
                {
                    return "Rifle";
                }
            }
        }

        public string Shadow_SP//20
        {
            get
            {
                //else
                {
                    return "Shadow";
                }
            }
        }

        public string Shhh_SP//21
        {
            get
            {
                //else
                {
                    return "Shhh";
                }
            }
        }

        public string Sidearm_SP//22
        {
            get
            {
                //else
                {
                    return "Sidearm";
                }
            }
        }

        public string Wedjat_SP//23
        {
            get
            {
                //else
                {
                    return "Wedjat";
                }
            }
        }

        public string Wrist_Launcher_SP//24
        {
            get
            {
                //else
                {
                    return "Wrist Launcher";
                }
            }
        }

        public string Zzz_SP//25
        {
            get
            {
                //else
                {
                    return "Zzz";
                }
            }
        }

        public string Shooting_SP//26
        {//Summer 2016
            get
            {
                //else
                {
                    return "Shooting";
                }
            }
        }

        public string Trick_or_Treat_SP//27
        {//Halloween 2016
            get
            {
                //else
                {
                    return "Trick or Treat";
                }
            }
        }

        public string Ornament_SP//28
        {//Winter 2016
            get
            {
                //else
                {
                    return "Ornament";
                }
            }
        }

        public string Warm_SP//29
        {//Winter 2016
            get
            {
                //else
                {
                    return "Warm";
                }
            }
        }

        public string Dance_SP//30
        {//Rooster 2017
            get
            {
                //else
                {
                    return "Dance";
                }
            }
        }

        public string Dragon_Dance_SP//31
        {//Rooster 2017
            get
            {
                //else
                {
                    return "Dragon Dance";
                }
            }
        }

        public string Newborn_SP//32
        {//Uprising 2017
            get
            {
                //else
                {
                    return "Newborn";
                }
            }
        }

        public string Ace_of_Hearts_SP//33
        {//Annyver 2017
            get
            {
                //else
                {
                    return "Ace of Hearts";
                }
            }
        }


        //Highlight Intros
        //Epic
        public string Guardian_HI//1
        {
            get
            {
                //else
                {
                    return "Guardian";
                }
            }
        }

        public string Locked_on_HI//2
        {
            get
            {
                //else
                {
                    return "Locked on";
                }
            }
        }

        public string Shh_HI//3
        {
            get
            {
                //else
                {
                    return "Shh...";
                }
            }
        }


        //Player Icons
        //Rare
        public string Ana_PI//1
        {
            get
            {
                //else
                {
                    return "Ana";
                }
            }
        }

        public string Watcher_PI//2
        {
            get
            {
                //else
                {
                    return "Watcher";
                }
            }
        }

        public string Wedjat_PI//3
        {
            get
            {
                //else
                {
                    return "Wedjat";
                }
            }
        }

        public string Shooting_PI//4
        {//Summer 2016
            get
            {
                //else
                {
                    return "Shooting";
                }
            }
        }
    }
}
