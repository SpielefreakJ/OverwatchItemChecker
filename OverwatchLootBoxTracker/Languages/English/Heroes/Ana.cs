using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Ana
    {

        public Ana()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Ana";

            #region Skins
            //Rare
            Citrine_SK = "Citrine";
            Garnet_SK = "Garnet";
            Peridot_SK = "Peridot";
            Turquoise_SK = "Turquoise";
            //Epic
            Merciful_SK = "Merciful";
            Shrike_SK = "Shrike";
            Ghoul_SK = "Ghoul";//Halloween 16
            Tal_SK = "Tal";//Rooster 17#
            Bastet_SK = "BASTET";//Special
            //Legendary
            Wadjet_SK = "Wadjet";
            Wasteland_SK = "Wasteland";
            Captain_Amari_SK = "Captain Amari";
            Horus_SK = "Horus";
            Cabana_SK = "CABANA";//Summer 18
            Corsair_SK = "Corsair";//Halloween 17
            Snow_Owl_SK = "Snow Owl";//Winter 17
            #endregion
            #region Emotes
            //Epic
            Disapproving_EM = "Disapproving";
            Not_Impressed_EM = "Not Impressed";
            Protector_EM = "Protector";
            Take_A_Knee_EM = "Take a knee";
            Tea_Time_EM = "Tea Time";
            Beach_Ball_EM = "Beach Ball";//Summer 17
            Candy_EM = "Candy";//Halloween 16
            Dance_EM = "Dance"; ;//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Mission_Complete_VP = "Mission Complete";
            Protector_VP = "Protector";
            Seated_VP = "Seated";
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "Toast";//Winter 16
            Folded_Hands_VP = "Folded Hands";//Rooster 17
            #endregion
            #region Voice Lines
            //Default
            Justice_Delivered_VL = "Justice Delivered";
            //Common
            Children_behave_VL = "Children, behave";
            Everyone_dies_VL = "Everyone dies";
            Go_on_i_can_wait_VL = "GO ON... I CAN WAIT";
            It_takes_a_woman_to_know_VL = "It takes a woman to know";
            Justice_rains_from_above_VL = "Justice rains from above";
            Mother_knows_best_VL = "Mother knows best";
            No_scope_needed_VL = "No scope needed";
            What_are_you_thinking_VL = "What are you thinking?";
            Witness_me_VL = "Witness me";
            You_know_nothing_VL = "You know nothing";
            Someone_to_tuck_you_in_VL = "Someone to tuck you in?";
            Better_than_retirement_VL = "Better than retirement";//Summer 17
            Learn_from_the_pain_VL = "Learn from the pain";//Summer 16
            Are_you_scared_VL = "Are you scared?";//Halloween 16
            Dont_be_scared_VL = "Don't be Scared";//Halloween 17
            Im_too_old_for_surprises_VL = "I'm too old for Surprises";//Winter 2017
            Im_watching_out_for_you_VL = "I'm watching out for you";//Winter 2016
            The_Moon_in_Winter_VL = "The Moon in Winter";//Rooster 2017
            Damn_VL = "Damn";//Uprising 2017
            The_Ghost_watches_VL = "The Ghost watches";//Uprising 2017
            Follow_me_VL = "Follow me";//Annyver 2017
            The_adults_are_talking_VL = "The adults are talking";//Annyver 2017
            #endregion
            #region Sprays
            //Common
            Action_SP = "Action";
            Ana_SP = "Ana";
            Bearer_SP = "Bearer";
            Cheer_SP = "Cheer";
            Cracked_SP = "Cracked";
            Cute_SP = "Cute";
            Eyepatch_SP = "Eyepatch";
            Fareeha_SP = "Fareeha";
            Gaze_SP = "Gaze";
            Grenade_SP = "Grenade";
            Guardian_SP = "Guardian";
            Hesitation_SP = "Hesitation";
            Icon_SP = "Icon";
            Letter_SP = "Letter";
            Old_Soldier_SP = "Old Soldier";
            Overhead_SP = "Overhead";
            Pillow_SP = "Pillow";
            Photograph_SP = "Photograph";
            Pixel_SP = "Pixel";
            Rifle_SP = "Rifle";
            Shadow_SP = "Shadow";
            Shhh_SP = "Shhh";
            Sidearm_SP = "Sidearm";
            Wasteland_SP = "WASTELAND";
            Wedjat_SP = "Wedjat";
            Wrist_Launcher_SP = "Wrist Launcher";
            Zzz_SP = "Zzz";
            Shooting_SP = "Shooting";//Summer 16
            Trick_or_Treat_SP = "Trick or Treat";//Halloween 16
            Ornament_SP = "Ornament";//Winter 16
            Warm_SP = "Warm";//Winter 16
            Dance_SP = "Dance";//Rooster 17
            Dragon_Dance_SP = "Dragon Dance";//Rooster 17
            Newborn_SP = "Newborn";//Uprising 17
            Ace_of_Hearts_SP = "Ace of Hearts";//Annyver 17
            #endregion
            #region Highlight Intros
            //Epic
            Guardian_HI = "Guardian";
            Locked_on_HI = "Locked on";
            Shh_HI = "Shh...";
            Under_Fire_HI = "UNDER FIRE";
            #endregion
            #region Player Icons
            //Rare
            Ana_PI = "Ana";
            Cute_Ana_PI = "CUTE ANA";
            Watcher_PI = "Watcher";
            Wedjat_PI = "Wedjat";
            Shooting_PI = "Shooting";//Summer 16
            Corsair_PI = "Corsair";//Halloween 17
            Anaversary_PI = "Anaversary";//Annyver 17
            #endregion
        }

        #region Variablen
        public string Name { get; }

        #region Skins

        public string Citrine_SK { get; }//Rare
        public string Garnet_SK { get; }
        public string Peridot_SK { get; }
        public string Turquoise_SK { get; }

        public string Merciful_SK { get; }//Epic
        public string Shrike_SK { get; }
        public string Ghoul_SK { get; }//Halloween 16
        public string Tal_SK { get; }//Rooster 17
        public string Bastet_SK { get; }//Special

        public string Wadjet_SK { get; }//Legendary
        public string Wasteland_SK { get; }
        public string Captain_Amari_SK { get; }
        public string Horus_SK { get; }
        public string Cabana_SK { get; }//Summer 18
        public string Corsair_SK { get; }//Halloween 17
        public string Snow_Owl_SK { get; }//Winter 17
        #endregion
        #region Emotes

        public string Disapproving_EM { get; }
        public string Not_Impressed_EM { get; }
        public string Protector_EM { get; }
        public string Take_A_Knee_EM { get; }
        public string Tea_Time_EM { get; }
        public string Beach_Ball_EM { get; }//Summer 17
        public string Candy_EM { get; }//Halloween 16
        public string Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Mission_Complete_VP { get; }//Rare
        public string Protector_VP { get; }
        public string Seated_VP { get; }
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 16
        public string Folded_Hands_VP { get; }//Rooster 17
        #endregion
        #region Voice Lines

        public string Justice_Delivered_VL { get; }//Default

        public string Children_behave_VL { get; }//Common
        public string Everyone_dies_VL { get; }
        public string Go_on_i_can_wait_VL { get; }
        public string It_takes_a_woman_to_know_VL { get; }
        public string Justice_rains_from_above_VL { get; }
        public string Mother_knows_best_VL { get; }
        public string No_scope_needed_VL { get; }
        public string What_are_you_thinking_VL { get; }
        public string Witness_me_VL { get; }
        public string You_know_nothing_VL { get; }
        public string Someone_to_tuck_you_in_VL { get; }
        public string Better_than_retirement_VL { get; }//Summer 17
        public string Learn_from_the_pain_VL { get; }//Summer 16
        public string Are_you_scared_VL { get; }//Halloween 16
        public string Dont_be_scared_VL { get; }//Halloween 17
        public string Im_too_old_for_surprises_VL { get; }//Winter 17
        public string Im_watching_out_for_you_VL { get; }//Winter 16
        public string The_Moon_in_Winter_VL { get; }//Rooster 17
        public string Damn_VL { get; }//Uprising 17
        public string The_Ghost_watches_VL { get; }//Uprising 17
        public string Follow_me_VL { get; }//Annyver 17
        public string The_adults_are_talking_VL { get; }//Annyver 17
        #endregion
        #region Sprays

        public string Action_SP { get; }//Common
        public string Ana_SP { get; }
        public string Bearer_SP { get; }
        public string Cheer_SP { get; }
        public string Cracked_SP { get; }
        public string Cute_SP { get; }
        public string Eyepatch_SP { get; }
        public string Fareeha_SP { get; }
        public string Gaze_SP { get; }
        public string Grenade_SP { get; }
        public string Guardian_SP { get; }
        public string Hesitation_SP { get; }
        public string Icon_SP { get; }
        public string Letter_SP { get; }
        public string Old_Soldier_SP { get; }
        public string Overhead_SP { get; }
        public string Pillow_SP { get; }
        public string Photograph_SP { get; }
        public string Pixel_SP { get; }
        public string Rifle_SP { get; }
        public string Shadow_SP { get; }
        public string Shhh_SP { get; }
        public string Sidearm_SP { get; }
        public string Wasteland_SP { get; }
        public string Wedjat_SP { get; }
        public string Wrist_Launcher_SP { get; }
        public string Zzz_SP { get; }
        public string Shooting_SP { get; }//Summer 16
        public string Trick_or_Treat_SP { get; }//Halloween 16
        public string Ornament_SP { get; }//Winter 16
        public string Warm_SP { get; }//Winter 16
        public string Dance_SP { get; }//Rooster 17
        public string Dragon_Dance_SP { get; }//Rooster 17
        public string Newborn_SP { get; }//Uprising 17
        public string Ace_of_Hearts_SP { get; }//Annyver 17
        #endregion
        #region Highlight Intros

        public string Guardian_HI { get; }//Epic
        public string Locked_on_HI { get; }
        public string Shh_HI { get; }
        public string Under_Fire_HI { get; }
        #endregion
        #region Player Icons

        public string Ana_PI { get; }//Rare
        public string Cute_Ana_PI { get; }
        public string Watcher_PI { get; }
        public string Wedjat_PI { get; }
        public string Shooting_PI { get; }//Summer 16
        public string Corsair_PI { get; }//Halloween 17
        public string Anaversary_PI { get; }//Annyver 17
        #endregion

        #endregion
    }
}
