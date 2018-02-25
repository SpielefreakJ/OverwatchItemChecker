using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Widowmaker
    {
        public Widowmaker()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Widowmaker";

            #region Skin
            //Rare
            Ciel_SK = "Ciel";
            Nuit_SK = "Nuit";
            Rose_SK = "Rose";
            Vert_SK = "Vert";
            //Epic
            Patina_SK = "Patina";
            Winter_SK = "Winter";
            Tricolore_SK = "Tricolore";//Summer 16
            //Legendary
            Nova_SK = "NOVA";
            Odette_SK = "Odette";
            Odile_SK = "Odile";
            Comtesse_SK = "Comtesse";
            Huntress_SK = "Huntress";
            Noire_SK = "Noire";//Prepurchase Special
            Côte_DAzur_SK = "Côte D'Azur";//Summer 17
            Black_Lily_SK = "BLACK LILY";//Lunar 18
            Talon_SK = "Talon";//Uprising 17
            #endregion
            #region Emotes
            //Epic
            A_rest_EM = "A rest";
            Curtain_Call_EM = "Curtain Call";
            Delighted_EM = "Delighted";
            Shot_Dead_EM = "Shot Dead";
            Widows_Kiss_EM = "Widow's Kiss";
            Ballet_EM = "Ballet";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Activating_Visor_VP = "Activating Visor";
            Gaze_VP = "Gaze";
            Over_the_shoulder_VP = "Over the shoulder";
            Medal_VP = "Medal";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "Toast";//Winter 17
            Fans_VP = "FANS";//Lunar 18
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
