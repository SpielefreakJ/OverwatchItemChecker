using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Reinhardt
    {
        public Reinhardt()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "REINHARDT";

            #region Skin
            //Rare
            Brass_SK = "MESSING";
            Cobalt_SK = "KOBALT";
            Copper_SK = "KUPFER";
            Viridian_SK = "CHROMGRÜN";
            //Epic
            Bundeswehr_SK = "BUNDESWEHR";
            Paragon_SK = "PRACHTKERL";
            Coldhardt_SK = "KALTHARDT";//Halloween 16
            Lieutenant_Wilhelm_SK = "LIEUTENANT WILHELM";//Uprising 17
            //Legendary
            Crusader_SK = "CRUSADER";
            Blackhardt_SK = "SCHWARZER RITTER";
            Bloodhardt_SK = "BLUTROTER RITTER";
            Lionhardt_SK = "REINHARDT LÖWENHERZ";
            Stonehardt_SK = "STEINHARDT";
            Balderich_SK = "BALDERICH";
            Greifhardt_SK = "GREIFHARDT";
            Wujing_SK = "WUJING";//Rooster 2017
            #endregion
            #region Emotes
            //Epic
            Flex_EM = "MUSKELSPIEL";
            Knee_EM = "KNIEND";
            Taunt_EM = "HERAUSFORDERUNG";
            Uproarious_EM = "ZUM BRÜLLEN";
            Warriors_Salute_EM = "SALUT EINES KRIEGERS";
            Punpkin_Smash_EM = "KÜRBIS ZERMATSCHEN";//Halloween 16
            Sweethardt_EM = "MEINE TEUERSTE";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Confident_VP = "SELBSTBEWUSST";
            Flex_VP = "MUSKELSPIEL";
            Legendary_VP = "LEGENDÄR";
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "BRÖSCHDERLEI";//Winter 16
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

        public string Crusader_SK { get; }//Legendary
        public string Blackhardt_SK { get; }
        public string Bloodhardt_SK { get; }
        public string Lionhardt_SK { get; }
        public string Stonehardt_SK { get; }
        public string Balderich_SK { get; }
        public string Greifhardt_SK { get; }
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
