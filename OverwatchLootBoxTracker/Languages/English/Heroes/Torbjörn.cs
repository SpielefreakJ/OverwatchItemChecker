using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Torbjörn
    {
        public Torbjörn()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Torbjörn";

            #region Skin
            //Rare
            Blå_SK = "Blå";
            Citron_SK = "Citron";
            Grön_SK = "Grön";
            Plommon_SK = "Plommon";
            //Epic
            Cathode_SK = "Cathode";
            Woodclad_SK = "Woodclad";
            Tre_Kronor_SK = "Tre Kronor";//Summer 2016
            //Legendary
            Magni_SK = "MAGNI";
            Chopper_SK = "Chopper";
            Deadlock_SK = "Deadlock";
            Barbarossa_SK = "Barbarossa";
            Blackbeard_SK = "Blackbeard";
            Viking_SK = "Viking";//Halloween 17
            Santaclad_SK = "Santaclad";//Winter 16
            Chief_Engineer_Lindholm_SK = "Chief Engineer Lindholm";//Uprising 17
            Ironclad_SK = "Ironclad";//Uprising 17
            #endregion
            #region Emotes
            //Epic
            Clicking_heels_EM = "Clicking heels";
            Fisticuffs_EM = "Fisticuffs";
            Guffaw_EM = "Guffaw";
            Overload_EM = "Overload";
            Taking_a_break_EM = "Taking a break";
            Batter_Up_EM = "Batter up";//Halloween 17
            Dance_EM = "Dance";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Hammer_VP = "Hammer";
            Sitting_pretty_VP = "Sitting pretty";
            Take_Five_VP = "Take Five";
            Medal_VP = "Medal";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "Toast";//Winter 16
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Blå_SK { get; }//Rare
        public string Citron_SK { get; }
        public string Grön_SK { get; }
        public string Plommon_SK { get; }

        public string Cathode_SK { get; }//Epic
        public string Woodclad_SK { get; }
        public string Tre_Kronor_SK { get; }//Summer 16

        public string Magni_SK { get; }//Legendary
        public string Chopper_SK { get; }
        public string Deadlock_SK { get; }
        public string Barbarossa_SK { get; }
        public string Blackbeard_SK { get; }
        public string Viking_SK { get; }//Halloween 17
        public string Santaclad_SK { get; }//Winter 16
        public string Chief_Engineer_Lindholm_SK { get; }//Uprising 17
        public string Ironclad_SK { get; }//Uprising 17
        #endregion
        #region Emotes

        public string Clicking_heels_EM { get; }//Epic
        public string Fisticuffs_EM { get; }
        public string Guffaw_EM { get; }
        public string Overload_EM { get; }
        public string Taking_a_break_EM { get; }
        public string Batter_Up_EM { get; }//Halloween 17
        public string Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Hammer_VP { get; }//Rare
        public string Sitting_pretty_VP { get; }
        public string Take_Five_VP { get; }
        public string Medal_VP { get; }//Summer 16
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 16
        #endregion

        #endregion
    }
}
