using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Junkrat
    {
        public Junkrat()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "JUNKRAT";

            #region Skin
            //Rare
            Bleached_SK = "AUSGELICHEN";
            Drowned_SK = "ERTRUNKEN";
            Irradiated_SK = "VERSTRAHLT";
            Rusted_SK = "VERROSTET";
            //Epic
            Caution_SK = "BRANDGEFAHR";
            Jailbird_SK = "GALBENVOGEL";
            Toasted_SK = "VERRUSST";
            Firework_SK = "FEUERWERK";//Rooster 17
            //Legendary
            Fool_SK = "SCHELM";
            Jester_SK = "HOFNARR";
            Hayseed_SK = "LANDEI";
            Scarecrow_SK = "VOGELSCHEUCHE";
            Cricket_SK = "CRICKET";//Summer 17
            Dr_Junkenstein_SK = "DR. JUNKENSTEIN";//Halloween 16
            Beachrat_SK = "WASSERRATTE";//Winter 17
            #endregion
            #region Emotes
            //Epic
            Cant_Deal_EM = "ZUM TOTLACHEN";
            Juggling_EM = "JONGLEUR";
            Lounging_EM = "ABHÄNGEN";
            Puppet_EM = "PUPPENSPIEL";
            Vaudeville_EM = "VAUDEVILLE";
            Dud_EM = "BLINDGÄNGER?";//Rooster 17
            Running_Rat_EM = "RUNNING RAT";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Itll_freeze_that_way_VP = "GRIMASSE";
            Kneeling_VP = "KNIEND";
            Nyah_Nyah_VP = "ÄTSCHEBÄTSCH";
            Medal_VP = "MEDAILLE";//Summer 17
            Pumpkin_VP = "KÜRBIS";//Halloween 17
            RIP_VP = "R.I.P.";//Halloween 16
            Bad_for_your_health_VP = "GEFÄHRLICH LEBEN";//Rooster 17
            #endregion

            //TB Translated
            #region Voice Lines
            //Common
            Tick_Tock_Tick_Tock_VL = "Tick-Tock-Tick-Tock";
            _blow_it_up_again_VL = "...blow it up again";
            Anyone_want_some_BBQ_VL = "Anyone want some BBQ?";
            Brrring_VL = "Brrring!";
            Coming_up_explodey_VL = "Coming up explodey!";
            Good_Morning_VL = "GOOD MORNING";
            Happy_Birthday_VL = "Happy Birthday";
            Have_a_nice_day_VL = "Have a nice day!";
            It_s_the_little_things_VL = "It's the little things";
            Kaboom_VL = "Kaboom";
            Ooh_shiny_VL = "Ooh, Shiny";
            Smile_VL = "Smile";
            I_give_it_a_10_VL = "I give it a 10!";//Summer 16
            I_give_it_a_3_VL = "I give it a 3!";//Summer 17
            Happy_Halloween_VL = "Happy Halloween";//Halloween 16
            I_m_alive_VL = "I'm alive!";//Halloween 17
            Go_on_give_it_a_shake_VL = "Go on... Give it a shake!";//Winter 17
            Merry_Christmas_VL = "Merry Christmas";//Winter 16
            Gong_xi_fa_cai_VL = "Gong xi fa cai";//Rooster 17
            Come_the_raw_prawn_VL = "Come the raw prawn";//Uprising 17
            Too_right_VL = "Too right";//Uprising 17
            Dipstick_VL = "Dipstick";//Annyver 17
            Oops_Dropped_something_VL = "Oops... Dropped something";//Annyver 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Bleached_SK { get; }//Rare
        public string Drowned_SK { get; }
        public string Irradiated_SK { get; }
        public string Rusted_SK { get; }

        public string Caution_SK { get; }//Epic
        public string Jailbird_SK { get; }
        public string Toasted_SK { get; }
        public string Firework_SK { get; }//Rooster 2017

        public string Fool_SK { get; }//Legendary
        public string Jester_SK { get; }
        public string Hayseed_SK { get; }
        public string Scarecrow_SK { get; }
        public string Cricket_SK { get; }//Summer 2017
        public string Dr_Junkenstein_SK { get; }//Halloween 2016
        public string Beachrat_SK { get; }//Winter 17

        #endregion
        #region Emotes

        public string Cant_Deal_EM { get; }//Epic
        public string Juggling_EM { get; }
        public string Lounging_EM { get; }
        public string Puppet_EM { get; }
        public string Vaudeville_EM { get; }
        public string Dud_EM { get; }//Rooster 17
        public string Running_Rat_EM { get; }//Annyver 17

        #endregion
        #region Victory Poses

        public string Itll_freeze_that_way_VP { get; }//Rare
        public string Kneeling_VP { get; }
        public string Nyah_Nyah_VP { get; }
        public string Medal_VP { get; }//Summer 17
        public string Pumpkin_VP { get; }//Halloween 17
        public string RIP_VP { get; }//Halloween 16
        public string Bad_for_your_health_VP { get; }//Rooster 17

        #endregion
        #region Voice Lines

        public string Tick_Tock_Tick_Tock_VL { get; }//Common
        public string _blow_it_up_again_VL { get; }
        public string Anyone_want_some_BBQ_VL { get; }
        public string Brrring_VL { get; }
        public string Coming_up_explodey_VL { get; }
        public string Good_Morning_VL { get; }
        public string Happy_Birthday_VL { get; }
        public string Have_a_nice_day_VL { get; }
        public string It_s_the_little_things_VL { get; }
        public string Kaboom_VL { get; }
        public string Ooh_shiny_VL { get; }
        public string Smile_VL { get; }
        public string I_give_it_a_10_VL { get; }//Summer 16
        public string I_give_it_a_3_VL { get; }//Summer 17
        public string Happy_Halloween_VL { get; }//Halloween 16
        public string I_m_alive_VL { get; }//Halloween 17
        public string Go_on_give_it_a_shake_VL { get; }//Winter 17
        public string Merry_Christmas_VL { get; }//Winter 16
        public string Gong_xi_fa_cai_VL { get; }//Rooster 17
        public string Come_the_raw_prawn_VL { get; }//Uprising 17
        public string Too_right_VL { get; }//Uprising 17
        public string Dipstick_VL { get; }//Annyver 17
        public string Oops_Dropped_something_VL { get; }//Annyver 17

        #endregion

        #endregion
    }
}