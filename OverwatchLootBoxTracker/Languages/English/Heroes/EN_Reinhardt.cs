using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class EN_Reinhardt
    {
        public EN_Reinhardt()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Reinhardt";

            #region Skin
            //Rare
            Brass_SK = "Brass";
            Cobalt_SK = "Cobalt";
            Copper_SK = "Copper";
            Viridian_SK = "Viridian";
            //Epic
            Bundeswehr_SK = "Bundeswehr";
            Paragon_SK = "Paragon";
            Coldhardt_SK = "Coldhardt";//Halloween 16
            Lieutenant_Wilhelm_SK = "Lieutenant Wilhelm";//Uprising 17
            //Legendary
            Blackhardt_SK = "Blackhardt";
            Bloodhardt_SK = "Bloodhardt";
            Lionhardt_SK = "Lionhardt";
            Stonehardt_SK = "Stonehardt";
            Balderich_SK = "Balderich";
            Greifhardt_SK = "Greifhardt";
            Crusader_SK = "Crusader";
            Wujing_SK = "Wujing";//Rooster 2017
            #endregion
            #region Emotes
            //Epic
            Flex_EM = "Flex";
            Knee_EM = "Knee";
            Taunt_EM = "Taunt";
            Uproarious_EM = "Uproarious";
            Warriors_Salute_EM = "Warrior's Salute";
            Punpkin_Smash_EM = "Pumpkin smash";//Halloween 16
            Sweethardt_EM = "Sweedhardt";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Confident_VP = "Confident";
            Flex_VP = "Flex";
            Legendary_VP = "Legendary";
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "Toast";//Winter 16
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Brass_SK { get; }//Rare
        public string Cobalt_SK { get; }
        public string Copper_SK { get; }
        public string Viridian_SK { get; }

        public string Bundeswehr_SK { get; }//Epic
        public string Paragon_SK { get; }
        public string Coldhardt_SK { get; }//Halloween 2016
        public string Lieutenant_Wilhelm_SK { get; }//Uprising 2017

        public string Blackhardt_SK { get; }//Legendary
        public string Bloodhardt_SK { get; }
        public string Lionhardt_SK { get; }
        public string Stonehardt_SK { get; }
        public string Balderich_SK { get; }
        public string Greifhardt_SK { get; }
        public string Crusader_SK { get; }
        public string Wujing_SK { get; }//Rooster 2017
        #endregion
        #region Emotes

        public string Flex_EM { get; }//Epic
        public string Knee_EM { get; }
        public string Taunt_EM { get; }
        public string Uproarious_EM { get; }
        public string Warriors_Salute_EM { get; }
        public string Punpkin_Smash_EM { get; }//Halloween 16
        public string Sweethardt_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Confident_VP { get; }//Rare
        public string Flex_VP { get; }
        public string Legendary_VP { get; }
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 16
        #endregion

        #endregion
    }
}
