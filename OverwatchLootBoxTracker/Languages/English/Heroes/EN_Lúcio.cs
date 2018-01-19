using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class EN_Lúcio
    {
        public EN_Lúcio()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Lúcio";

            #region Skin
            //Rare
            Azul_SK = "Azul";
            Laranja_SK = "Laranja";
            Roxo_SK = "Roxo";
            Vermelho_SK = "Vermelho";
            //Epic
            Auditiva_SK = "Auditiva";
            Synaesthesia_SK = "Synaesthesia";
            Andes_SK = "Andes";//Winter 16
                               //Legendary
            Hippityhop_SK = "Hippityhop";
            Ribbit_SK = "Ribbit";
            Breakaway_SK = "Breakaway";
            Slapshot_SK = "Slapshot";
            Seleção_SK = "Seleção";//Summer 16
            Striker_SK = "Striker";//Summer 16
            Jazzy_SK = "Jazzy";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Capoeira_EM = "Capoeira";
            Chilling_EM = "Chilling";
            In_the_Groove_EM = "In the Groove";
            Knee_Slapper_EM = "Knee Slapper";
            Nah_EM = "Nah!";
            Juggle_EM = "Juggle";//Summer 16
            Smooth_EM = "Smooth";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Confident_VP = "Confident";
            Grooving_VP = "Groovy";
            Ready_for_action_VP = "Ready for action";
            Pumpkin_Control_VP = "Pumpkin Control";//Halloween 17
            RIP_VP = "R.I.P.";//Halloween 16
            Handstand_VP = "Handstand";//Uprising 17
            #endregion
            #region Voice Lines
            //Common
            To_the_Rrhythm_VL = "TO THE RHYTHM";
            Cant_stop_wont_stop_VL = "CAN'T STOP, WON'T STOP";
            Hit_me_VL = "HIT ME!";
            I_could_do_this_all_day_VL = "I COULD DO THIS ALL DAY";
            Im_on_top_of_the_world_VL = "I'M ON TOP OF THE WORLD";
            Jackpot_VL = "JACKPOT!";
            Not_hearing_that_noise_VL = "NOT HEARING THAT NOISE";
            Oh_Yeah_VL = "OH, YEAH!";
            Tinitus_VL = "TINITUS";
            Why_are_you_so_angry_VL = "WHY ARE YOU SO ANGRY?";
            You_gotta_believe_VL = "YOU GOTTA BELIEVE!";
            Be_Champions_VL = "BE CHAMPIONS";//Summer 16
            Subotrimal_VL = "SUBOPTIMAL";//Summer 17
            Killed_it_VL = "KILLED IT!";//Halloween 16
            So_good_its_scary_VL = "SO GOOD IT'S SCARY!";//Halloween 17
            Climbing_the_Charts_VL = "CLIMBING THE CHARTS!";//Winter 17
            Happy_Holidays_VL = "HAPPY HOLIDAYS!";//Winter 16
            I_make_this_look_good_VL = "I MAKE THIS LOOK GOOD...";//Rooster 17
            Boop_VL = "BOOP";//Uprising 17
            Learn_to_take_it_easy_VL = "LEARN TO TAKE IT EASY";//Uprising 17
            Everyone_gets_their_1_VL = "EVERYONE GETS THEIR +1";//Annyver 17
            Have_some_Lúcio_ohs_VL = "HEVE SOME LÚCIO-OH'S!";//Annyver 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Azul_SK { get; }//Rare
        public string Laranja_SK { get; }
        public string Roxo_SK { get; }
        public string Vermelho_SK { get; }

        public string Auditiva_SK { get; }//Epic
        public string Synaesthesia_SK { get; }
        public string Andes_SK { get; }//Winter 2016

        public string Hippityhop_SK { get; }//Legendary
        public string Ribbit_SK { get; }
        public string Breakaway_SK { get; }
        public string Slapshot_SK { get; }
        public string Seleção_SK { get; }//Summer 16
        public string Striker_SK { get; }//Summer 16
        public string Jazzy_SK { get; }//Annyver 17
        #endregion
        #region Emotes

        public string Capoeira_EM { get; }//Epic
        public string Chilling_EM { get; }
        public string In_the_Groove_EM { get; }
        public string Knee_Slapper_EM { get; }
        public string Nah_EM { get; }
        public string Juggle_EM { get; }//Summer 16
        public string Smooth_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Confident_VP { get; }//Rare
        public string Grooving_VP { get; }
        public string Ready_for_action_VP { get; }
        public string Pumpkin_Control_VP { get; }//Halloween 17
        public string RIP_VP { get; }//Halloween 16
        public string Handstand_VP { get; }//Uprising 17
        #endregion
        #region Voice Lines

        public string To_the_Rrhythm_VL { get; }//Common
        public string Cant_stop_wont_stop_VL { get; }
        public string Hit_me_VL { get; }
        public string I_could_do_this_all_day_VL { get; }
        public string Im_on_top_of_the_world_VL { get; }
        public string Jackpot_VL { get; }
        public string Not_hearing_that_noise_VL { get; }
        public string Oh_Yeah_VL { get; }
        public string Tinitus_VL { get; }
        public string Why_are_you_so_angry_VL { get; }
        public string You_gotta_believe_VL { get; }
        public string Be_Champions_VL { get; }//Summer 16
        public string Subotrimal_VL { get; }//Summer 17
        public string Killed_it_VL { get; }//Halloween 16
        public string So_good_its_scary_VL { get; }//Halloween 17
        public string Climbing_the_Charts_VL { get; }//Winter 17
        public string Happy_Holidays_VL { get; }//Winter 16
        public string I_make_this_look_good_VL { get; }//Rooster 17
        public string Boop_VL { get; }//Uprising 17
        public string Learn_to_take_it_easy_VL { get; }//Uprising 17
        public string Everyone_gets_their_1_VL { get; }//Annyver 17
        public string Have_some_Lúcio_ohs_VL { get; }//Annyver 17
        #endregion

        #endregion
    }
}
