using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Zenyatta
    {
        public Zenyatta()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "ZENYATTA";

            #region Skin
            //Rare
            Air_SK = "LUFT";
            Earth_SK = "ERDE";
            Leaf_SK = "BLATTGRÜN";
            Water_SK = "WASSER";
            //Epic
            Ascendant_SK = "AUFGESTIEGEN";
            Carbon_Fiber_SK = "KOHLEFASER";
            Harmonious_SK = "HARMONISCH";
            Skullyatta_SK = "SKELEYATTA";//Halloween 16
            //Legendary
            Djinnyatta_SK = "SCHINNYATTA";
            Ifrit_SK = "IFRIT";
            Ra_SK = "RA";
            Sunyatta_SK = "SONNYATTA";
            Cultist_SK = "KULTIST";//Halloween 17
            Nutcracker_SK = "NUSSKNACKER";//Winter 16
            Sanzang_SK = "SANZANG";//Rooster 17
            #endregion
            #region Emotes
            //Epic
            Focusiong_EM = "FAKUSSIERT";
            Meditate_EM = "MEDITIEREND";
            Round_of_Applause_EM = "EINE RUNDE APPLAUS";
            Taunt_EM = "SPOTT";
            Tickled_EM = "GEKITZELT";
            Snowflake_EM = "SCHNEEFLOCKE";//Winter 17
            Dance_EM = "TANZEN";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Balance_VP = "BALANCIEREND";
            Harmony_VP = "HARMONIE";
            Peace_VP = "PEACE";
            Medals_VP = "MEDAILLEN";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "PROST";//Winter 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Air_SK { get; }//Rare
        public string Earth_SK { get; }
        public string Leaf_SK { get; }
        public string Water_SK { get; }

        public string Ascendant_SK { get; }//Epic
        public string Carbon_Fiber_SK { get; }
        public string Harmonious_SK { get; }
        public string Skullyatta_SK { get; }//Halloween 16

        public string Djinnyatta_SK { get; }//Legendary
        public string Ifrit_SK { get; }
        public string Ra_SK { get; }
        public string Sunyatta_SK { get; }
        public string Cultist_SK { get; }//Halloween 17
        public string Nutcracker_SK { get; }//Winter 16
        public string Sanzang_SK { get; }//Rooster 17
        #endregion
        #region Emotes

        public string Focusiong_EM { get; }//Epic
        public string Meditate_EM { get; }
        public string Round_of_Applause_EM { get; }
        public string Taunt_EM { get; }
        public string Tickled_EM { get; }
        public string Snowflake_EM { get; }//Winter 17
        public string Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Balance_VP { get; }//Rare
        public string Harmony_VP { get; }
        public string Peace_VP { get; }
        public string Medals_VP { get; }//Summer 16
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 17
        #endregion

        #endregion
    }
}
