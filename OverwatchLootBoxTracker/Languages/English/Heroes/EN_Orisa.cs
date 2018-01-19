using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class EN_Orisa
    {
        public EN_Orisa()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Orisa";

            #region Skin
            //Rare
            Dawn_SK = "Dawn";
            Plains_SK = "Plains";
            Sunrise_SK = "Sunrise";
            Twilight_SK = "Twilight";
            //Epic
            Camouflage_SK = "Camouflage";
            OR15_SK = "OR15";
            //Legendary
            Dynastinae_SK = "Dynastinae";
            Megasoma_SK = "Megasoma";
            Carbon_Fiber_SK = "Carbon Fiber";
            Protector_SK = "Protector";
            Immortal_SK = "Immortal";
            Null_Sector_SK = "Null Sector";//Uprising 17
            #endregion
            #region Emotes
            //Epic
            Cheer_EM = "Cheer";
            Halt_EM = "Halt!";
            Kicking_Dirt_EM = "Kicking Dirt";
            Laugh_EM = "Laugh";
            Sit_EM = "Sit";
            Dance_EM = "Dance";//Annyver 17
            //Legendary
            Puppy_EM = "Puppy";//Winter 17
            #endregion
            #region Victory Poses
            //Rare
            Confident_VP = "Confident";
            Flex_VP = "Flex";
            Halt_VP = "Halt!";
            Pumpkin_Head_VP = "Pumpkin Head";//Halloween 17
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

        public string Dynastinae_SK { get; }//Legendary
        public string Megasoma_SK { get; }
        public string Carbon_Fiber_SK { get; }
        public string Protector_SK { get; }
        public string Immortal_SK { get; }
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
