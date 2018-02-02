using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Orisa
    {
        public Orisa()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "ORISA";

            #region Skin
            //Rare
            Dawn_SK = "MORGENGRAUEN";
            Plains_SK = "SAVANNE";
            Sunrise_SK = "SONNENAUFGANG";
            Twilight_SK = "ZWIELICHT";
            //Epic
            Camouflage_SK = "TARNUNG";
            OR15_SK = "OR15";
            //Legendary
            Immortal_SK = "UNSTERBLICHE";
            Dynastinae_SK = "DYNASTINAE";
            Megasoma_SK = "MEGASOMA";
            Carbon_Fiber_SK = "KOHLEFASER";
            Protector_SK = "WÄCHTERIN";
            Null_Sector_SK = "Null Sector";//Uprising 17
            #endregion
            #region Emotes
            //Epic
            Cheer_EM = "JUBELN";
            Halt_EM = "HALT!";
            Kicking_Dirt_EM = "STAUB SCHARREN";
            Laugh_EM = "LACHEN";
            Sit_EM = "SITZEND";
            Dance_EM = "TANZEN";//Annyver 17
            //Legendary
            Puppy_EM = "HÜNDCHEN";//Winter 17
            #endregion
            #region Victory Poses
            //Rare
            Confident_VP = "SELBSTBEWUSST";
            Flex_VP = "MUSKELSPIEL";
            Halt_VP = "HALT!";
            Pumpkin_Head_VP = "KÜRBISKOPF";//Halloween 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Dawn_SK { get; }//Rare
        public string Plains_SK { get; }
        public string Sunrise_SK { get; }
        public string Twilight_SK { get; }

        public string Camouflage_SK { get; }//Epic
        public string OR15_SK { get; }

        public string Immortal_SK { get; }//Legendary
        public string Dynastinae_SK { get; }
        public string Megasoma_SK { get; }
        public string Carbon_Fiber_SK { get; }
        public string Protector_SK { get; }
        public string Null_Sector_SK { get; }//Uprising 2017
        #endregion
        #region Emotes

        public string Cheer_EM { get; }//Epic
        public string Halt_EM { get; }
        public string Kicking_Dirt_EM { get; }
        public string Laugh_EM { get; }
        public string Sit_EM { get; }
        public string Dance_EM { get; }//Annyver 17

        public string Puppy_EM { get; }//Legendary //Winter 17
        #endregion
        #region Victory Poses

        public string Confident_VP { get; }//Rare
        public string Flex_VP { get; }
        public string Halt_VP { get; }
        public string Pumpkin_Head_VP { get; }//Halloween 17
        #endregion

        #endregion
    }
}
