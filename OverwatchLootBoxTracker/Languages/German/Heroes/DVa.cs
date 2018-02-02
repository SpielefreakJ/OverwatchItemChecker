using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class DVa
    {
        public DVa()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "D.VA";

            #region Skin
            //Rare
            Blueberry_SK = "BLAUBEERE";
            Lemon_Lime_SK = "LIMETTE";
            Tangerine_SK = "MANDARINE";
            Watermelon_SK = "WASSERMELONE";
            //Epic
            Carbon_Fiber_SK = "KOHLEFASER";
            White_Rabbit_SK = "WEISSES KANINCHEN";
            Taegeukgi_SK = "TAEGEUKI";//Summer 16
            //Legendary
            Junker_SK = "JUNKER";
            Scavenger_SK = "ROSTLAUBE";
            BVa_SK = "B.Va";
            Junebug_SK = "PRACHTKÄFER";
            Black_Cat_SK = "SCHWARZE KATZE";
            Officer_SK = "WACHMEISTERIN";
            Palanquin_SK = "SÄNFTE";//Rooster 17
            Cruiser_SK = "ROCKABILLY";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            _O__EM = "^O^";
            Bunny_Hop_EM = "BUNNY HOP";
            Heartbreaker_EM = "HERZENSBRECHERIN";
            Party_Time_EM = "DISCO";
            Bow_EM = "VERBEUGUNG";//Rooster 17
            Dance_EM = "TANZEN";//Annyver 17
            //Legendary
            Game_On_EM = "ZOCKEN";
            #endregion
            #region Victory Poses
            //Rare
            I_Heart_You_VP = "HERZCHEN";
            Peace_VP = "PEACE";
            Sitting_VP = "SITZEND";
            RIP_VP = "R.I.P.";//Halloween 16
            Festive_VP = "FESTLICH";//Winter 16
            Lucky_Pouch_VP = "GLÜCKSSÄCKCHEN";//Rooster 17
            #endregion

            //TB Translated
            #region Voice Lines
            //Common
            Love_DVa_VL = "Love, D.Va";
            Winkyface_VL = ";)";
            A_new_challenger_VL = "A new challenger";
            AFK_VL = "AFK";
            Aw_Yeah_VL = "Aw, Yeah!";
            DVa_1_Bad_Guys_0_VL = "D.Va: 1, Bad Guys: 0";
            GG_VL = "GG!";
            I_play_to_win_VL = "I play to win";
            Is_this_Easy_Mode_VL = "Is this Easy Mode?";
            LOL_VL = "LOL";
            Nice_try_VL = "NICE TRY";
            No_hacks_required_VL = "No hacks required";
            Im_N_1_VL = "I'm #1";//Summer 16
            Scoreboard_VL = "Scoreboard";//Summer 17
            Happy_Halloween_VL = "Happy Halloween!";//Halloween 16
            Im_not_scared_VL = "I'm not scared";//Halloween 17
            Aw_you_shouldnt_have_VL = "Aw, you schouldn't have";//Winter 16
            Happy_Holidays_VL = "Happy Holidays";//Winter 17
            The_best_things_in_life_VL = "The best things in life";//Rooster 17
            Not_taking_me_seriously_VL = "Not taking me seriously";//Uprising 17
            Try_and_keep_up_VL = "Try annd keep up";//Uprising 17
            Level_Up_VL = "Level Up!";//Annyver 17
            No_Way_VL = "No way";//Annyver 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Blueberry_SK { get; }//Rare
        public string Lemon_Lime_SK { get; }
        public string Tangerine_SK { get; }
        public string Watermelon_SK { get; }

        public string Carbon_Fiber_SK { get; }//Epic
        public string White_Rabbit_SK { get; }
        public string Taegeukgi_SK { get; }//Summer 16

        public string Junker_SK { get; }//Legendary
        public string Scavenger_SK { get; }
        public string BVa_SK { get; }
        public string Junebug_SK { get; }
        public string Black_Cat_SK { get; }
        public string Officer_SK { get; }
        public string Palanquin_SK { get; }//Rooster 17
        public string Cruiser_SK { get; }//Annyver 17
        #endregion
        #region Emotes

        public string _O__EM { get; }//Epic
        public string Bunny_Hop_EM { get; }
        public string Heartbreaker_EM { get; }
        public string Party_Time_EM { get; }
        public string Bow_EM { get; }
        public string Dance_EM { get; }//Annyver 17
        public string Game_On_EM { get; }//Legendary
        #endregion
        #region Victory Poses

        public string I_Heart_You_VP { get; }//Rare
        public string Peace_VP { get; }
        public string Sitting_VP { get; }
        public string RIP_VP { get; }//Halloween 16
        public string Festive_VP { get; }//Winter 16
        public string Lucky_Pouch_VP { get; }//Rooster 17
        #endregion
        #region Voice Lines

        public string Love_DVa_VL { get; }//Common
        public string Winkyface_VL { get; }
        public string A_new_challenger_VL { get; }
        public string AFK_VL { get; }
        public string Aw_Yeah_VL { get; }
        public string DVa_1_Bad_Guys_0_VL { get; }
        public string GG_VL { get; }
        public string I_play_to_win_VL { get; }
        public string Is_this_Easy_Mode_VL { get; }
        public string LOL_VL { get; }
        public string Nice_try_VL { get; }
        public string No_hacks_required_VL { get; }
        public string Im_N_1_VL { get; }//Summer 16
        public string Scoreboard_VL { get; }//Summer 17
        public string Happy_Halloween_VL { get; }//Halloween 16
        public string Im_not_scared_VL { get; }//Halloween 17
        public string Aw_you_shouldnt_have_VL { get; }//Winter 16
        public string Happy_Holidays_VL { get; }//Winter 17
        public string The_best_things_in_life_VL { get; }//Rooster 17
        public string Not_taking_me_seriously_VL { get; }//Uprising 17
        public string Try_and_keep_up_VL { get; }//Uprising 17
        public string Level_Up_VL { get; }//Annyver 17
        public string No_Way_VL { get; }//Annyver 17
        #endregion

        #endregion
    }
}
