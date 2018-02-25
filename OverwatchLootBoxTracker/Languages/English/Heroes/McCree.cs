using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class McCree
    {
        public McCree()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "McCree";


            #region Skin
            //Rare
            Ebony_SK = "Ebony";
            Lake_SK = "Lake";
            Sage_SK = "Sage";
            Wheat_SK = "Wheat";
            //Epic
            On_The_Range_SK = "On the Range";
            Royal_SK = "Royal";
            White_Hat_SK = "White Hat";
            American_SK = "American";//Summer 16
            Scrooge_SK = "Scrooge";//Winter 16
            //Legendary
            Gambler_SK = "Gambler";
            Riverboat_SK = "Riverboat";
            Mystery_Man_SK = "Mystery Man";
            Vigilante_SK = "Vigilante";
            Lifeguard_SK = "Lifeguard";//Summer 17
            Van_Helsing_SK = "Van Helsing";//Halloween 17
            Magistrate_SK = "MAGISTRATE";//Lunar 18
            Blackwatch_SK = "Blackwatch";//Uprising 17
            #endregion
            #region Emotes
            //Epic
            Gunspinning_EM = "Gunnspinning";
            Hat_Tip_EM = "Hat Tip";
            Joker_EM = "Joker";
            Spit_EM = "Spit";
            Take_a_load_off_EM = "Take a load off";
            Hat_Trick_EM = "Hat Trick";//Winter 16
            Line_Dance_EM = "Line Dance";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Contemplative_VP = "Contemplative";
            Over_the_shoulder_VP = "Over the shoulder";
            Take_it_easy_VP = "Take it easy";
            RIP_VP = "R.I.P.";//Halloween 16
            Fire_in_the_hole_VP = "FIRE IN THE HOLE";//Lunar 18
            Showdown_VP = "Showdown";//Uprising 17
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
