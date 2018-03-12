using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Widowmaker
    {
        public Widowmaker()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "WIDOWMAKER";

            #region Skin
            //Rare
            Ciel_SK = "CIEL";
            Nuit_SK = "NUIT";
            Rose_SK = "ROSÉ";
            Vert_SK = "VERT";
            //Epic
            Patina_SK = "EDELROST";
            Winter_SK = "WINTER";
            Tricolore_SK = "TRICOLORE";//Summer 16
            //Legendary
            Nova_SK = "NOVA";
            Odette_SK = "ODETTE";
            Odile_SK = "ODILE";
            Comtesse_SK = "COMTESSE";
            Huntress_SK = "JÄGERIN";
            Noire_SK = "NOIRE";//Prepurchase Special
            Kerrigan_SK = "KERRYGAN";//Starcraft 20th Annyver
            Côte_DAzur_SK = "CÔTE D'AZUR";//Summer 17
            Black_Lily_SK = "SCHWARZE LILIE";//Lunar 18
            Talon_SK = "TALON";//Uprising 17
            #endregion
            #region Emotes
            //Epic
            A_rest_EM = "ABWARTEND";
            Curtain_Call_EM = "VERBEUGUNG";
            Delighted_EM = "ENTZÜCKT";
            Shot_Dead_EM = "ABGESCHOSSEN";
            Widows_Kiss_EM = "KUSS DER WITWE";
            Ballet_EM = "BALLETT";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Activating_Visor_VP = "VISORAKTIVIERUNG";
            Gaze_VP = "FESTER BLICK";
            Over_the_shoulder_VP = "SCHULTERBLICK";
            Medal_VP = "MEDAILLE";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "PROST";//Winter 17
            Fans_VP = "FÄCHER";//Lunar 18
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Ciel_SK { get; }//Rare
        public string Nuit_SK { get; }
        public string Rose_SK { get; }
        public string Vert_SK { get; }

        public string Patina_SK { get; }//Epic
        public string Winter_SK { get; }
        public string Tricolore_SK { get; }//Summer 16

        public string Nova_SK { get; }//Legendary
        public string Odette_SK { get; }
        public string Odile_SK { get; }
        public string Comtesse_SK { get; }
        public string Huntress_SK { get; }
        public string Noire_SK { get; }//Prepurchase Special
        public string Kerrigan_SK { get; }//Starcraft 20th Annyver
        public string Côte_DAzur_SK { get; }//Summer 17
        public string Black_Lily_SK { get; }//Lunar 18
        public string Talon_SK { get; }//Uprising 17
        #endregion
        #region Emotes

        public string A_rest_EM { get; }//Epic
        public string Curtain_Call_EM { get; }
        public string Delighted_EM { get; }
        public string Shot_Dead_EM { get; }
        public string Widows_Kiss_EM { get; }
        public string Ballet_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Activating_Visor_VP { get; }//Rare
        public string Gaze_VP { get; }
        public string Over_the_shoulder_VP { get; }
        public string Medal_VP { get; }//Summer 16
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 17
        public string Fans_VP { get; }//Lunar 18
        #endregion

        #endregion
    }
}
