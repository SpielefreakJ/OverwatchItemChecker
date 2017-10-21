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


        //Skins
        //Rare
        public string Citrine_SK
        {
            get
            {
                //else
                {
                    return EN.Citrine_SK;
                }
            }
        }

        public string Garnet_SK
        {
            get
            {
                //else
                {
                    return EN.Garnet_SK;
                }
            }
        }

        public string Peridot_SK
        {
            get
            {
                //else
                {
                    return EN.Peridot_SK;
                }
            }
        }

        public string Turquoise_SK
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
        public string Merciful_SK
        {
            get
            {
                //else
                {
                    return EN.Merciful_SK;
                }
            }
        }

        public string Shrike_SK
        {
            get
            {
                //else
                {
                    return EN.Shrike_SK;
                }
            }
        }

        public string Ghoul_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Ghoul_SK;
                }
            }
        }

        public string Tal_SK
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
        public string Wadjet_SK
        {
            get
            {
                //else
                {
                    return EN.Wadjet_SK;
                }
            }
        }

        public string Wasteland_SK
        {
            get
            {
                //else
                {
                    return EN.Wasteland_SK;
                }
            }
        }

        public string Captain_Amari_SK
        {
            get
            {
                //else
                {
                    return EN.Captain_Amari_SK;
                }
            }
        }

        public string Horus_SK
        {
            get
            {
                //else
                {
                    return EN.Horus_SK;
                }
            }
        }

        public string Corsair_SK
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
        public string Mission_Complete_VP
        {
            get
            {
                //else
                {
                    return EN.Mission_Complete_VP;
                }
            }
        }

        public string Protector_VP
        {
            get
            {
                //else
                {
                    return EN.Protector_VP;
                }
            }
        }

        public string Seated_VP
        {
            get
            {
                //else
                {
                    return EN.Seated_VP;
                }
            }
        }

        public string RIP_VP
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string Toast_VP
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Toast_VP;
                }
            }
        }

        public string Folded_Hands_VP
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
        public string Justice_Delivered_VL
        {
            get
            {
                //else
                {
                    return EN.Justice_Delivered_VL;

                }
            }
        }

        public string Children_behave_VL
        {
            get
            {
                //else
                {
                    return EN.Children_behave_VL;
                }
            }
        }

        public string Everyone_dies_VL
        {
            get
            {
                //else
                {
                    return EN.Everyone_dies_VL;
                }
            }
        }

        public string It_takes_a_woman_to_know_VL
        {
            get
            {
                //else
                {
                    return EN.It_takes_a_woman_to_know_VL;
                }
            }
        }

        public string Justice_rains_from_above_VL
        {
            get
            {
                //else
                {
                    return EN.Justice_rains_from_above_VL;
                }
            }
        }

        public string Mother_knows_best_VL
        {
            get
            {
                //else
                {
                    return EN.Mother_knows_best_VL;
                }
            }
        }

        public string No_scope_needed_VL
        {
            get
            {
                //else
                {
                    return EN.No_scope_needed_VL;
                }
            }
        }

        public string What_are_you_thinking_VL
        {
            get
            {
                //else
                {
                    return EN.What_are_you_thinking_VL;
                }
            }
        }

        public string Witness_me_VL
        {
            get
            {
                //else
                {
                    return EN.Witness_me_VL;
                }
            }
        }

        public string You_know_nothing_VL
        {
            get
            {
                //else
                {
                    return EN.You_know_nothing_VL;
                }
            }
        }

        public string Someone_to_tuck_you_in_VL
        {
            get
            {
                //else
                {
                    return "Someone to tuck you in?";
                }
            }
        }

        public string Learn_from_the_pain_VL
        {//Summer 2016
            get
            {
                //else
                {
                    return "Learn from the pain";
                }
            }
        }

        public string Are_you_scared_VL
        {//Halloween 2016
            get
            {
                //else
                {
                    return "Are you scared?";
                }
            }
        }

        public string Dont_be_scared_VL
        {//Halloween 2017
            get
            {
                //else
                {
                    return "Don't be Scared";
                }
            }
        }

        public string Im_watching_out_for_you_VL
        {//Winter 2016
            get
            {
                //else
                {
                    return "I'm watching out for you";
                }
            }
        }

        public string The_Moon_in_Winter_VL
        {//Rooster 2017
            get
            {
                //else
                {
                    return "The Moon in Winter";
                }
            }
        }

        public string Damn_VL
        {//Uprising 2017
            get
            {
                //else
                {
                    return "Damn";
                }
            }
        }

        public string The_Ghost_watches_VL
        {//Uprising 2017
            get
            {
                //else
                {
                    return "The Ghost watches";
                }
            }
        }

        public string Follow_me
        {//Annyver 2017
            get
            {
                //else
                {
                    return "Follow me";
                }
            }
        }

        public string The_adults_are_talking_VL
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
        public string Action_SP
        {
            get
            {
                //else
                {
                    return "Action";
                }
            }
        }

        public string Ana_SP
        {
            get
            {
                //else
                {
                    return "Ana";
                }
            }
        }

        public string Bearer_SP
        {
            get
            {
                //else
                {
                    return "Bearer";
                }
            }
        }

        public string Cheer_SP
        {
            get
            {
                //else
                {
                    return "Cheer";
                }
            }
        }

        public string Cracked_SP
        {
            get
            {
                //else
                {
                    return "Cracked";
                }
            }
        }

        public string Cute_SP
        {
            get
            {
                //else
                {
                    return "Cute";
                }
            }
        }

        public string Eyepatch_SP
        {
            get
            {
                //else
                {
                    return "Eyepatch";
                }
            }
        }

        public string Fareeha_SP
        {
            get
            {
                //else
                {
                    return "Fareeha";
                }
            }
        }

        public string Gaze_SP
        {
            get
            {
                //else
                {
                    return "Gaze";
                }
            }
        }

        public string Grenade_SP
        {
            get
            {
                //else
                {
                    return "Grenade";
                }
            }
        }

        public string Guardian_SP
        {
            get
            {
                //else
                {
                    return "Guardian";
                }
            }
        }

        public string Hesitation_SP
        {
            get
            {
                //else
                {
                    return "Hesitation";
                }
            }
        }

        public string Icon_SP
        {
            get
            {
                //else
                {
                    return "Icon";
                }
            }
        }

        public string Letter_SP
        {
            get
            {
                //else
                {
                    return "Letter";
                }
            }
        }

        public string Old_Soldier_SP
        {
            get
            {
                //else
                {
                    return "Old Soldier";
                }
            }
        }

        public string Overhead_SP
        {
            get
            {
                //else
                {
                    return "Overhead";
                }
            }
        }

        public string Photograph_SP
        {
            get
            {
                //else
                {
                    return "Photograph";
                }
            }
        }

        public string Pixel_SP
        {
            get
            {
                //else
                {
                    return "Pixel";
                }
            }
        }

        public string Rifle_SP
        {
            get
            {
                //else
                {
                    return "Rifle";
                }
            }
        }

        public string Shadow_SP
        {
            get
            {
                //else
                {
                    return "Shadow";
                }
            }
        }

        public string Shhh_SP
        {
            get
            {
                //else
                {
                    return "Shhh";
                }
            }
        }

        public string Sidearm_SP
        {
            get
            {
                //else
                {
                    return "Sidearm";
                }
            }
        }

        public string Wedjat_SP
        {
            get
            {
                //else
                {
                    return "Wedjat";
                }
            }
        }

        public string Wrist_Launcher_SP
        {
            get
            {
                //else
                {
                    return "Wrist Launcher";
                }
            }
        }

        public string Zzz_SP
        {
            get
            {
                //else
                {
                    return "Zzz";
                }
            }
        }

        public string Shooting_SP
        {//Summer 2016
            get
            {
                //else
                {
                    return "Shooting";
                }
            }
        }

        public string Trick_or_Treat_SP
        {//Halloween 2016
            get
            {
                //else
                {
                    return "Trick or Treat";
                }
            }
        }

        public string Ornament_SP
        {//Winter 2016
            get
            {
                //else
                {
                    return "Ornament";
                }
            }
        }

        public string Warm_SP
        {//Winter 2016
            get
            {
                //else
                {
                    return "Warm";
                }
            }
        }

        public string Dance_SP
        {//Rooster 2017
            get
            {
                //else
                {
                    return "Dance";
                }
            }
        }

        public string Dragon_Dance_SP
        {//Rooster 2017
            get
            {
                //else
                {
                    return "Dragon Dance";
                }
            }
        }

        public string Newborn_SP
        {//Uprising 2017
            get
            {
                //else
                {
                    return "Newborn";
                }
            }
        }

        public string Ace_of_Hearts_SP
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
        public string Guardian_HI
        {
            get
            {
                //else
                {
                    return "Guardian";
                }
            }
        }

        public string Locked_on_HI
        {
            get
            {
                //else
                {
                    return "Locked on";
                }
            }
        }

        public string Shh_HI
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
        public string Ana_PI
        {
            get
            {
                //else
                {
                    return "Ana";
                }
            }
        }

        public string Watcher_PI
        {
            get
            {
                //else
                {
                    return "Watcher";
                }
            }
        }

        public string Wedjat_PI
        {
            get
            {
                //else
                {
                    return "Wedjat";
                }
            }
        }

        public string Shooting_PI
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
