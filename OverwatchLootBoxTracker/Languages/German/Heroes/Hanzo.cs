using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Hanzo
    {
        public Hanzo()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "HANZO";

            #region Skin
            //Rare
            Azuki_SK = "AZUKI";
            Kinoko_SK = "KINOKO";
            Midori_SK = "MIDORI";
            Sora_SK = "SORA";
            //Epic
            Cloud_SK = "WOLKE";
            Dragon_SK = "DRACHE";
            Demon_SK = "DÄMON";//Halloween 16
            //Legendary
            Kabuki_SK = "KABUKI";
            Young_Hanzo_SK = "JUNGER HANZO";
            Young_Master_SK = "JUNGER MEISTER";
            Lone_Wolf_SK = "EINSAMER WOLF";
            Okami_SK = "OKAMI";
            Casual_SK = "LÄSSIG";//Winter 17
            Cyberninja_SK = "BYBERNINJA";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Beckon_EM = "HERAUSFORDERUNG";
            Brush_Shoulder_EM = "ABPUTZEN";
            Chuckle_EM = "KICHERN";
            Meditate_EM = "MEDITIEREND";
            Victory_EM = "SIEG";
            Training_EM = "KAMPFÜBUNGEN";//Uprising 17
            Fisherman_Dance_EM = "FISCHERTANZ";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Confident_VP = "SELBSTBEWUSST";
            Kneeling_VP = "KNIEND";
            Over_the_shoulder_VP = "SCHULTERBLICK";
            Medal_VP = "MEDAILLE";//Summer 17
            RIP_VP = "R.I.P.";//Halloween 16
            Skewered_VP = "DURCHBOHRT";//Halloween 17
            #endregion

            //TB Translated
            #region Voice Lines
            //Common
            Expect_nothing_less_VL = "Expect nothing less";
            Flow_like_water_VL = "Flow like water";
            From_one_thing_VL = "From one thing";
            Hm_VL = "Hm...";
            I_do_what_i_must_VL = "I do what i must";
            Never_in_doubt_VL = "Never in doubt";
            Never_second_best_VL = "Never second best";
            Remember_this_moment_VL = "Remember this moment";
            Sake_VL = "Sake";
            Spirit_Dragon_VL = "Spirit Dragon";
            Step_into_the_Dojo_VL = "Step into the Dojo";
            You_fought_well_VL = "YOU FOUGHT WELL...";
            Defeat_is_the_fist_step_VL = "Defeat is the first step";//Summer 17
            Ignore_all_distractions_VL = "Ignore all distractions";//Summer 16
            Master_your_fears_VL = "Master your fears";//Halloween 17
            You_are_already_dead_VL = "You are already dead";//Halloween 16
            A_gift_for_you_VL = "A gift for you";//Winter 16
            Cold_as_Ice_VL = "Cold as Ice";//Winter 17
            When_the_moon_is_full_VL = "When the moon is full";//Rooster 17
            Beauty_in_simplicity_VL = "Beauty in simplicity";//Uprising 17
            Unacceptable_VL = "Unacceptable";//Uprising 17
            An_error_in_judgment_VL = "An error in judgment";//Annyver 17
            Just_so_VL = "Just so";//Annyver 17

            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Azuki_SK { get; }//Rare
        public string Kinoko_SK { get; }
        public string Midori_SK { get; }
        public string Sora_SK { get; }

        public string Cloud_SK { get; }//Epic
        public string Dragon_SK { get; }
        public string Demon_SK { get; }//Halloween 16

        public string Kabuki_SK { get; }//Legendary
        public string Young_Hanzo_SK { get; }
        public string Young_Master_SK { get; }
        public string Lone_Wolf_SK { get; }
        public string Okami_SK { get; }
        public string Casual_SK { get; }//Winter 17
        public string Cyberninja_SK { get; }//Annyver 17
        #endregion
        #region Emotes

        public string Beckon_EM { get; }//Epic
        public string Brush_Shoulder_EM { get; }
        public string Chuckle_EM { get; }
        public string Meditate_EM { get; }
        public string Victory_EM { get; }
        public string Training_EM { get; }//Uprising 17
        public string Fisherman_Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Confident_VP { get; }//Rare
        public string Kneeling_VP { get; }
        public string Over_the_shoulder_VP { get; }
        public string Medal_VP { get; }//Summer 17
        public string RIP_VP { get; }//Halloween 16
        public string Skewered_VP { get; }//Halloween 17
        #endregion
        #region Voice Lines

        public string Expect_nothing_less_VL { get; }//Common
        public string Flow_like_water_VL { get; }
        public string From_one_thing_VL { get; }
        public string Hm_VL { get; }
        public string I_do_what_i_must_VL { get; }
        public string Never_in_doubt_VL { get; }
        public string Never_second_best_VL { get; }
        public string Remember_this_moment_VL { get; }
        public string Sake_VL { get; }
        public string Spirit_Dragon_VL { get; }
        public string Step_into_the_Dojo_VL { get; }
        public string You_fought_well_VL { get; }
        public string Defeat_is_the_fist_step_VL { get; }//Summer 17
        public string Ignore_all_distractions_VL { get; }//Summer 16
        public string Master_your_fears_VL { get; }//Halloween 17
        public string You_are_already_dead_VL { get; }//Halloween 16
        public string A_gift_for_you_VL { get; }//Winter 16
        public string Cold_as_Ice_VL { get; }//Winter 17
        public string When_the_moon_is_full_VL { get; }//Rooster 17
        public string Beauty_in_simplicity_VL { get; }//Uprising 17
        public string Unacceptable_VL { get; }//Uprising 17
        public string An_error_in_judgment_VL { get; }//Annyver 17
        public string Just_so_VL { get; }//Annyver 17
        #endregion
        #endregion
    }
}
