using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Doomfist
    {
        public Doomfist()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "DOOMFIST";

            #region Skin
            //Rare
            Daisy_SK = "GERBERA";
            Lake_SK = "SEE";
            Plains_SK = "STEPPE";
            Sunset_SK = "SONNENUNTERGANG";
            //Epic
            Leopard_SK = "LEOPARD";
            Painted_SK = "KRIEGSBEMALUNG";
            //Legendary
            Blackhand_SK = "SCHWARZFAUST";
            Caution_SK = "ACHTUNG";
            Irin_SK = "ITIN";
            Avatar_SK = "REINKARNATION";
            Spirit_SK = "SEELENWANDERNG";
            FORMAL_SK = "FORMAL";//Annyver 18
            #endregion
            #region Emotes
            //Epic
            Fake_Out_EM = "ANGETÄUSCHT";
            Intimidate_EM = "EINSCHÜCHTERN";
            Ready_for_Battle_EM = "KAMPFBEREIT";
            Take_a_knee_EM = "IN DIE KNIE";
            Thumbs_Down_EM = "DAUMEN RUNTER";
            Crushing_EM = "FELSBROCKEN";//Lunar 18
            DANCE_EM = "DANCE";//Annyver 18
            #endregion
            #region Victory Poses
            //Rare
            Intense_VP = "VERSUCH ES NUR!";
            Seismic_Slam_VP = "SEISMISCHER SCHLAG";
            Superior_VP = "ÜBERLEGEN";
            CHARGING_VP = "CHARGING";//Annyver 18
            #endregion

            //TB Translated
            #region Voice Lines
            //Common
            Try_me_VL = "Try me";
            Combo_Breakere_VL = "Combo Breaker";
            Dont_get_back_up_VL = "Don't get back up";
            Go_and_sit_down_VL = "Go and sit down";
            I_havent_even_started_VL = "I haven't even started";
            K_O_VL = "K.O.";
            One_punch_is_all_i_need_VL = "One punch is all i need";
            Spare_me_the_commentary_VL = "Spare me the commentary";
            Talk_to_the_fist_VL = "Talk to the fist";
            Youre_not_bad_VL = "You're not bad";
            You_must_be_joking_VL = "You must be joking";
            You_test_my_patience_VL = "YOU TEST MY PATIENCE";
            I_make_medicine_sick_VL = "I make medicine sick";//Summer 17
            Make_you_punch_drunk_VL = "Make you punch drunk";//Summer 17
            I_have_something_for_you_VL = "I have something for you";//Halloween 17
            You_should_be_scared_VL = "You should be scared";//Halloween 17
            And_they_sais_chivalry_is_dead_VL = "And they said Chivalry is dead";//Winter 17
            Did_you_bring_me_a_present_VL = "Did you bring me a present?";//Winter 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Daisy_SK { get; }//Rare
        public string Lake_SK { get; }
        public string Plains_SK { get; }
        public string Sunset_SK { get; }

        public string Leopard_SK { get; }//Epic
        public string Painted_SK { get; }

        public string Blackhand_SK { get; }//Legendary
        public string Caution_SK { get; }
        public string Irin_SK { get; }
        public string Avatar_SK { get; }
        public string Spirit_SK { get; }
        public string FORMAL_SK { get; }//Annyver 18
        #endregion
        #region Emotes

        public string Fake_Out_EM { get; }//Epic
        public string Intimidate_EM { get; }
        public string Ready_for_Battle_EM { get; }
        public string Take_a_knee_EM { get; }
        public string Thumbs_Down_EM { get; }
        public string Crushing_EM { get; }//Lunar 18
        public string DANCE_EM { get; }//Annyver 18
        #endregion
        #region Victory Poses

        public string Intense_VP { get; }//Rare
        public string Seismic_Slam_VP { get; }
        public string Superior_VP { get; }
        public string CHARGING_VP { get; }//Annyver 18
        #endregion
        #region Voice Lines

        public string Try_me_VL { get; }//Common
        public string Combo_Breakere_VL { get; }
        public string Dont_get_back_up_VL { get; }
        public string Go_and_sit_down_VL { get; }
        public string I_havent_even_started_VL { get; }
        public string K_O_VL { get; }
        public string One_punch_is_all_i_need_VL { get; }
        public string Spare_me_the_commentary_VL { get; }
        public string Talk_to_the_fist_VL { get; }
        public string Youre_not_bad_VL { get; }
        public string You_must_be_joking_VL { get; }
        public string You_test_my_patience_VL { get; }
        public string I_make_medicine_sick_VL { get; }//Summer 17
        public string Make_you_punch_drunk_VL { get; }//Summer 17
        public string I_have_something_for_you_VL { get; }//Halloween 17
        public string You_should_be_scared_VL { get; }//Halloween 17
        public string And_they_sais_chivalry_is_dead_VL { get; }//Winter 17
        public string Did_you_bring_me_a_present_VL { get; }//Winter 17
        #endregion

        #endregion
    }
}
