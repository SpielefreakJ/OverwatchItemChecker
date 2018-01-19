using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class EN_Soldier_76
    {
        public EN_Soldier_76()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Soldier: 76";

            #region Skin
            //Rare
            Jet_SK = "Jet";
            Olive_SK = "Olive";
            Russet_SK = "Russet";
            Smoke_SK = "Smoke";
            //Epic
            Bone_SK = "Bone";
            Golden_SK = "Golden";
            Immortal_SK = "Immortal";//Halloween 2016
            //Legendary
            Commando_76_SK = "Commando: 76";
            Night_Ops_76_SK = "Night Ops: 76";
            Daredevil_76_SK = "Daredevil: 76";
            Stunt_Rider_76_SK = "Stunt Rider: 76";
            Strike_Commander_Morrison_SK = "Strike-Commander Morrison";//Origin Special
            Grillmaster_76_SK = "Grillmaster: 76";//Summer 17
            Alpine_76_SK = "Alpine: 76";//Winter 17
            Cyborg_76_SK = "Cyborg: 76";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Amused_EM = "Amused";
            Fist_EM = "Fist";
            I_see_you_EM = "I see you";
            Locked_and_Loaded_EM = "Locked and Loaded";
            Take_a_knee_EM = "Take a knee";
            Push_Ups_EM = "Push Ups";//Uprising 17
            Dance_EM = "Dance";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Fist_Pump_VP = "Fist Pump";
            Locked_and_Loaded_VP = "Locked and Loaded";
            Soldier_VP = "Soldier";
            Golf_Swing_VP = "Golf Swing";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "Toast";//Winter 16
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
        public string Immortal_SK { get; }//Halloween 2016

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
