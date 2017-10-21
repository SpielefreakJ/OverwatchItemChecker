using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class L_Ana
    {
        Languages.English.Heroes.EN_Ana EN;
        string myLang;

        L_Ana(string Lang)
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


        //Skins
        //Rare
        public string A1_Citrine
        {
            get
            {
                //else
                {
                    return EN.Citrine_SK;
                }
            }
        }

        public string A1_Garnet
        {
            get
            {
                //else
                {
                    return EN.Garnet_SK;
                }
            }
        }

        public string A1_Peridot
        {
            get
            {
                //else
                {
                    return EN.Peridot_SK;
                }
            }
        }

        public string A1_Turquoise
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
        public string A1_Merciful
        {
            get
            {
                //else
                {
                    return EN.Merciful_SK;
                }
            }
        }

        public string A1_Shrike
        {
            get
            {
                //else
                {
                    return EN.Shrike_SK;
                }
            }
        }

        public string A1_Ghoul
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Ghoul_SK;
                }
            }
        }

        public string A1_Tal
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
        public string A1_Wadjet
        {
            get
            {
                //else
                {
                    return EN.Wadjet_SK;
                }
            }
        }

        public string A1_Wasteland
        {
            get
            {
                //else
                {
                    return EN.Wasteland_SK;
                }
            }
        }

        public string A1_Captain_Amari
        {
            get
            {
                //else
                {
                    return EN.Captain_Amari_SK;
                }
            }
        }

        public string A1_Horus
        {
            get
            {
                //else
                {
                    return EN.Horus_SK;
                }
            }
        }

        public string A1_Corsair
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Corsair_SK;
                }
            }
        }


        //Victory Poses
        //Rare
        public string A1_Mission_Complete_VP
        {
            get
            {
                //else
                {
                    return EN.Mission_Complete_VP;
                }
            }
        }

        public string A1_Protector_VP
        {
            get
            {
                //else
                {
                    return EN.Protector_VP;
                }
            }
        }

        public string A1_Seated_VP
        {
            get
            {
                //else
                {
                    return EN.Seated_VP;
                }
            }
        }

        public string A1_RIP_VP
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string A1_Toast_VP
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Toast_VP;
                }
            }
        }

        public string A1_Folded_Hands_VP
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
        public string A1_Justice_Delivered_VL
        {
            get
            {
                //else
                {
                    return EN.Justice_Delivered_VL;

                }
            }
        }

        public string A1_Children_behave_VL
        {
            get
            {
                //else
                {
                    return EN.Children_behave_VL;
                }
            }
        }

        public string A1_Everyone_dies_VL
        {
            get
            {
                //else
                {
                    return EN.Everyone_dies_VL;
                }
            }
        }

        public string A1_It_takes_a_woman_to_know_VL
        {
            get
            {
                //else
                {
                    return EN.It_takes_a_woman_to_know_VL;
                }
            }
        }

        public string A1_Justice_rains_from_above_VL
        {
            get
            {
                //else
                {
                    return EN.Justice_rains_from_above_VL;
                }
            }
        }

        public string A1_Mother_knows_best_VL
        {
            get
            {
                //else
                {
                    return EN.Mother_knows_best_VL;
                }
            }
        }

        public string A1_No_scope_needed_VL
        {
            get
            {
                //else
                {
                    return EN.No_scope_needed_VL;
                }
            }
        }

        public string A1_What_are_you_thinking_VL
        {
            get
            {
                //else
                {
                    return EN.What_are_you_thinking_VL;
                }
            }
        }

        public string A1_Witness_me_VL
        {
            get
            {
                //else
                {
                    return EN.Witness_me_VL;
                }
            }
        }

        public string A1_You_know_nothing_VL
        {
            get
            {
                //else
                {
                    return EN.You_know_nothing_VL;
                }
            }
        }

        public string A1_Someone_to_tuck_you_in_VL
        {
            get
            {
                //else
                {
                    return "Someone to tuck you in?";
                }
            }
        }

        public string A1_Learn_from_the_pain_VL
        {//Summer 2016
            get
            {
                //else
                {
                    return "Learn from the pain";
                }
            }
        }

        public string A1_Are_you_scared_VL
        {//Halloween 2016
            get
            {
                //else
                {
                    return "Are you scared?";
                }
            }
        }

        public string A1_Dont_be_scared_VL
        {//Halloween 2017
            get
            {
                //else
                {
                    return "Don't be Scared";
                }
            }
        }

        public string A1_Im_watching_out_for_you_VL
        {//Winter 2016
            get
            {
                //else
                {
                    return "I'm watching out for you";
                }
            }
        }

        public string A1_The_Moon_in_Winter_VL
        {//Rooster 2017
            get
            {
                //else
                {
                    return "The Moon in Winter";
                }
            }
        }

        public string A1_Damn_VL
        {//Uprising 2017
            get
            {
                //else
                {
                    return "Damn";
                }
            }
        }

        public string A1_The_Ghost_watches_VL
        {//Uprising 2017
            get
            {
                //else
                {
                    return "The Ghost watches";
                }
            }
        }

        public string A1_Follow_me
        {//Annyver 2017
            get
            {
                //else
                {
                    return "Follow me";
                }
            }
        }

        public string A1_The_adults_are_talking_VL
        {//Annyver 2017
            get
            {
                //else
                {
                    return "The adults are talking";
                }
            }
        }


        //Sprays
        //Common
        public string A1_Action_SP
        {
            get
            {
                //else
                {
                    return "Action";
                }
            }
        }

        public string A1_Ana_SP
        {
            get
            {
                //else
                {
                    return "Ana";
                }
            }
        }

        public string A1_Bearer_SP
        {
            get
            {
                //else
                {
                    return "Bearer";
                }
            }
        }

        public string A1_Cheer_SP
        {
            get
            {
                //else
                {
                    return "Cheer";
                }
            }
        }

        public string A1_Cracked_SP
        {
            get
            {
                //else
                {
                    return "Cracked";
                }
            }
        }

        public string A1_Cute_SP
        {
            get
            {
                //else
                {
                    return "Cute";
                }
            }
        }

        public string A1_Eyepatch_SP
        {
            get
            {
                //else
                {
                    return "Eyepatch";
                }
            }
        }

        public string A1_Fareeha_SP
        {
            get
            {
                //else
                {
                    return "Fareeha";
                }
            }
        }

        public string A1_Gaze_SP
        {
            get
            {
                //else
                {
                    return "Gaze";
                }
            }
        }

        public string A1_Grenade_SP
        {
            get
            {
                //else
                {
                    return "Grenade";
                }
            }
        }

        public string A1_Guardian_SP
        {
            get
            {
                //else
                {
                    return "Guardian";
                }
            }
        }

        public string A1_Hesitation_SP
        {
            get
            {
                //else
                {
                    return "Hesitation";
                }
            }
        }

        public string A1_Icon_SP
        {
            get
            {
                //else
                {
                    return "Icon";
                }
            }
        }

        public string A1_Letter_SP
        {
            get
            {
                //else
                {
                    return "Letter";
                }
            }
        }

        public string A1_Old_Soldier_SP
        {
            get
            {
                //else
                {
                    return "Old Soldier";
                }
            }
        }

        public string A1_Overhead_SP
        {
            get
            {
                //else
                {
                    return "Overhead";
                }
            }
        }

        public string A1_Photograph_SP
        {
            get
            {
                //else
                {
                    return "Photograph";
                }
            }
        }

        public string A1_Pixel_SP
        {
            get
            {
                //else
                {
                    return "Pixel";
                }
            }
        }

        public string A1_Rifle_SP
        {
            get
            {
                //else
                {
                    return "Rifle";
                }
            }
        }

        public string A1_Shadow_SP
        {
            get
            {
                //else
                {
                    return "Shadow";
                }
            }
        }

        public string A1_Shhh_SP
        {
            get
            {
                //else
                {
                    return "Shhh";
                }
            }
        }

        public string A1_Sidearm_SP
        {
            get
            {
                //else
                {
                    return "Sidearm";
                }
            }
        }

        public string A1_Wedjat_SP
        {
            get
            {
                //else
                {
                    return "Wedjat";
                }
            }
        }

        public string A1_Wrist_Launcher_SP
        {
            get
            {
                //else
                {
                    return "Wrist Launcher";
                }
            }
        }

        public string A1_Zzz_SP
        {
            get
            {
                //else
                {
                    return "Zzz";
                }
            }
        }

        public string A1_Shooting_SP
        {//Summer 2016
            get
            {
                //else
                {
                    return "Shooting";
                }
            }
        }

        public string A1_Trick_or_Treat_SP
        {//Halloween 2016
            get
            {
                //else
                {
                    return "Trick or Treat";
                }
            }
        }

        public string A1_Ornament_SP
        {//Winter 2016
            get
            {
                //else
                {
                    return "Ornament";
                }
            }
        }

        public string A1_Warm_SP
        {//Winter 2016
            get
            {
                //else
                {
                    return "Warm";
                }
            }
        }

        public string A1_Dance_SP
        {//Rooster 2017
            get
            {
                //else
                {
                    return "Dance";
                }
            }
        }

        public string A1_Dragon_Dance_SP
        {//Rooster 2017
            get
            {
                //else
                {
                    return "Dragon Dance";
                }
            }
        }

        public string A1_Newborn_SP
        {//Uprising 2017
            get
            {
                //else
                {
                    return "Newborn";
                }
            }
        }

        public string A1_Ace_of_Hearts_SP
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
        public string A1_Guardian_HI
        {
            get
            {
                //else
                {
                    return "Guardian";
                }
            }
        }

        public string A1_Locked_on_HI
        {
            get
            {
                //else
                {
                    return "Locked on";
                }
            }
        }

        public string A1_Shh_HI
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
        public string A1_Ana_PI
        {
            get
            {
                //else
                {
                    return "Ana";
                }
            }
        }

        public string A1_Watcher_PI
        {
            get
            {
                //else
                {
                    return "Watcher";
                }
            }
        }

        public string A1_Wedjat_PI
        {
            get
            {
                //else
                {
                    return "Wedjat";
                }
            }
        }

        public string A1_Shooting_PI
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
