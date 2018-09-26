using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Soldier_76
    {
        public Soldier_76()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "SOLDIER: 76";

            #region Skin
            //Rare
            Jet_SK = "PECHSCHWARZ";
            Olive_SK = "OLIVGRÜN";
            Russet_SK = "ROSTBRAUN";
            Smoke_SK = "RAUCH";
            //Epic
            Bone_SK = "KNOCHEN";
            Golden_SK = "GOLDEN";
            Immortal_SK = "UNSTERBLICH";//Halloween 16
            VENOM_SK = "VENOM";//Annyver 18
            //Legendary
            Commando_76_SK = "KOMANDO: 76";
            Night_Ops_76_SK = "NACHTWACHE: 76";
            Daredevil_76_SK = "DAREDEVIL: 76";
            Stunt_Rider_76_SK = "STUNTMAN: 76";
            Strike_Commander_Morrison_SK = "STRIKE COMMANDER MORRISON";//Origin Special
            Grillmaster_76_SK = "GRILLMEISTER: 76";//Summer 17
            Alpine_76_SK = "GEBIRGSJÄGER: 76";//Winter 17
            Cyborg_76_SK = "CYBORG: 76";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Amused_EM = "AMÜSIERT";
            Fist_EM = "FAUST";
            I_see_you_EM = "ICH HAB DICH IM AUGE";
            Locked_and_Loaded_EM = "GELADEN UND ENTSICHERT";
            Take_a_knee_EM = "KNIEND";
            Push_Ups_EM = "LIEGESTÜTZEN";//Uprising 17
            Dance_EM = "TANZEN";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Fist_Pump_VP = "GEBALLTE FAUST";
            Locked_and_Loaded_VP = "GELADEN UND ENTSICHERT";
            Soldier_VP = "SOLDIER";
            Golf_Swing_VP = "GOLFSCHLAG";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "PROST";//Winter 16
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Jet_SK { get; }//Rare
        public string Olive_SK { get; }
        public string Russet_SK { get; }
        public string Smoke_SK { get; }

        public string Bone_SK { get; }//Epic
        public string Golden_SK { get; }
        public string Immortal_SK { get; }//Halloween 16
        public string VENOM_SK { get; }//Annyver 18

        public string Commando_76_SK { get; }//Legendary
        public string Night_Ops_76_SK { get; }
        public string Daredevil_76_SK { get; }
        public string Stunt_Rider_76_SK { get; }
        public string Strike_Commander_Morrison_SK { get; }//Origin Special
        public string Grillmaster_76_SK { get; }//Summer 17
        public string Alpine_76_SK { get; }//Winter 17
        public string Cyborg_76_SK { get; }//Annyver 17
        #endregion
        #region Emotes

        public string Amused_EM { get; }//Epic
        public string Fist_EM { get; }
        public string I_see_you_EM { get; }
        public string Locked_and_Loaded_EM { get; }
        public string Take_a_knee_EM { get; }
        public string Push_Ups_EM { get; }//Uprising 17
        public string Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Fist_Pump_VP { get; }//Rare
        public string Locked_and_Loaded_VP { get; }
        public string Soldier_VP { get; }
        public string Golf_Swing_VP { get; }//Summer 16
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 16
        #endregion

        #endregion
    }
}
