using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Zarya
    {
        public Zarya()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Zarya";

            #region Skin
            //Rare
            Brick_SK = "Brick";
            Goldenrod_SK = "Goldenrod";
            Taiga_SK = "Taiga";
            Violet_SK = "Violet";
            //Epic
            Dawn_SK = "Dawn";
            Midnight_SK = "Midnight";
            Frosted_SK = "Frosted";//Winter 16
            //Legendary
            Barbarian_SK = "BARBARIAN";
            Arctic_SK = "Arctic";
            Siberian_Front_SK = "Siberian Front";
            Cybergoth_SK = "Cybergoth";
            Industrial_SK = "Industrial";
            Champion_SK = "Champion";//Summer 16
            Weightlifter_SK = "Weightlifter";//Summer 16
            Totally_80s_SK = "Totally 80's";//Halloween 17
            Xuanwu_SK = "XUANWU";//Lunar 18
            Cyberian_SK = "Cyberian";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Bring_it_on_EM = "Bring it on";
            Comedy_Gold_EM = "Comedy Gold";
            Crush_you_EM = "Crush you";
            Punping_Iron_EM = "Pumping Iron";
            Take_a_knee_EM = "Take a knee";
            Dance_EM = "Dance";//Annyver 17
            //Legendary
            Mystery_Gift_EM = "Mystery Gift";//Winter 16
            #endregion
            #region Victory Poses
            //Rare
            Casual_VP = "Casual";
            Check_out_this_gun_VP = "Check out this gun";
            Flexing_VP = "Flexing";
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "Toast";//Winter 17
            Big_one_VP = "BIG ONE";//Lunar 18
            This_is_strength_VP = "This is strength";//Uprising 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Brick_SK { get; }//Rare
        public string Goldenrod_SK { get; }
        public string Taiga_SK { get; }
        public string Violet_SK { get; }

        public string Dawn_SK { get; }//Epic
        public string Midnight_SK { get; }
        public string Frosted_SK { get; }//Winter 16

        public string Barbarian_SK { get; }//Legendary
        public string Arctic_SK { get; }
        public string Siberian_Front_SK { get; }
        public string Cybergoth_SK { get; }
        public string Industrial_SK { get; }
        public string Champion_SK { get; }//Summer 16
        public string Weightlifter_SK { get; }//Summer 16
        public string Totally_80s_SK { get; }//Halloween 17
        public string Xuanwu_SK { get; }//Lunar 18
        public string Cyberian_SK { get; }//Annyver 17
        #endregion
        #region Emotes

        public string Bring_it_on_EM { get; }//Epic
        public string Comedy_Gold_EM { get; }
        public string Crush_you_EM { get; }
        public string Punping_Iron_EM { get; }
        public string Take_a_knee_EM { get; }
        public string Dance_EM { get; }//Annyver 17

        public string Mystery_Gift_EM { get; }//Legendary //Winter 16
        #endregion
        #region Victory Poses

        public string Casual_VP { get; }//Rare
        public string Check_out_this_gun_VP { get; }
        public string Flexing_VP { get; }
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 17
        public string Big_one_VP { get; }//Lunar 18
        public string This_is_strength_VP { get; }//Uprising 17
        #endregion

        #endregion
    }
}
