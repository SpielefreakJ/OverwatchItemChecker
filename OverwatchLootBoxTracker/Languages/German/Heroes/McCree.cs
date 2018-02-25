using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class McCree
    {
        public McCree()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "MCCREE";


            #region Skin
            //Rare
            Ebony_SK = "EBENHOLZ";
            Lake_SK = "FLUSS";
            Sage_SK = "SALBEI";
            Wheat_SK = "WEIZEN";
            //Epic
            On_The_Range_SK = "WEITES LAND";
            Royal_SK = "MUSKELTIER";
            White_Hat_SK = "GET GUTE";
            American_SK = "AMERICAN";//Summer 16
            Scrooge_SK = "SCROOGE";//Winter 16
            //Legendary
            Gambler_SK = "POKER-ASS";
            Riverboat_SK = "MISSISSIPPI";
            Mystery_Man_SK = "GROSSER UNBEKANNTER";
            Vigilante_SK = "MASKIERTER RÄCHER";
            Lifeguard_SK = "RETTUNGSSCHWIMMER";//Summer 17
            Van_Helsing_SK = "VAN HELSING";//Halloween 17
            Magistrate_SK = "MAGISTRATE";//Lunar 18
            Blackwatch_SK = "BLACKWATCH";//Uprising 17
            #endregion
            #region Emotes
            //Epic
            Gunspinning_EM = "MIT REVOLVER SPIELEN";
            Hat_Tip_EM = "HUT ANTIPPEN";
            Joker_EM = "WITZBOLD";
            Spit_EM = "AUSSPUCKEN";
            Take_a_load_off_EM = "ALLE VIERE GERADE SEIN LASSEN";
            Hat_Trick_EM = "HATTRICK";//Winter 16
            Line_Dance_EM = "LINE DANCE";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Contemplative_VP = "NACHDENKLICH";
            Over_the_shoulder_VP = "SCHULTERBLICK";
            Take_it_easy_VP = "SORGLOS";
            RIP_VP = "R.I.P.";//Halloween 16
            Fire_in_the_hole_VP = "RAKETE";//Lunar 18
            Showdown_VP = "SHOWDOWN";//Uprising 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Ebony_SK { get; }//Rare
        public string Lake_SK { get; }
        public string Sage_SK { get; }
        public string Wheat_SK { get; }

        public string On_The_Range_SK { get; }//Epic
        public string Royal_SK { get; }
        public string White_Hat_SK { get; }
        public string American_SK { get; }//Summer 16
        public string Scrooge_SK { get; }//Winter 16

        public string Gambler_SK { get; }//Legendary
        public string Riverboat_SK { get; }
        public string Mystery_Man_SK { get; }
        public string Vigilante_SK { get; }
        public string Lifeguard_SK { get; }//Summer 17
        public string Van_Helsing_SK { get; }//Halloween 17
        public string Magistrate_SK { get; }//Lunar 18
        public string Blackwatch_SK { get; }//Uprising 17
        #endregion
        #region Emotes

        public string Gunspinning_EM { get; }//Epic
        public string Hat_Tip_EM { get; }
        public string Joker_EM { get; }
        public string Spit_EM { get; }
        public string Take_a_load_off_EM { get; }
        public string Hat_Trick_EM { get; }//Winter 16
        public string Line_Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses
        //Rare
        public string Contemplative_VP { get; }
        public string Over_the_shoulder_VP { get; }
        public string Take_it_easy_VP { get; }
        public string RIP_VP { get; }//Halloween 16
        public string Fire_in_the_hole_VP { get; }//Lunar 18
        public string Showdown_VP { get; }//Uprising 17
        #endregion

        #endregion
    }
}
