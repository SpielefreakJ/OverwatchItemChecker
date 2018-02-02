using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Winston
    {
        public Winston()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "WINSTON";

            #region Skin
            //Rare
            Atmosphere_SK = "ATMOSPHÄRE";
            Banana_SK = "BANANE";
            Forest_SK = "WALD";
            Red_Planet_SK = "ROTER PLANET";
            //Epic
            Desert_SK = "wWÜSTE";
            Horizon_SK = "HORIZON";
            Blizzcon_2017_SK = "BLIZZCON 2017";//BlizzCon 2017 Special
            //Legendary
            Frogston_SK = "FROGSTON";
            Undersea_SK = "TIEFSEE";
            Explorer_SK = "FORSCHER";
            Safari_SK = "SAFARI";
            Yeti_SK = "YETI";//Winter 16
            Wukong_SK = "WUKONG";//Rooster 17
            #endregion
            #region Emotes
            //Epic
            Laughing_matter_EM = "ZWERGFELLBELASTUNGSTEST";
            Monkey_Buisness_EM = "AFFIG";
            Peanut_Butter_EM = "ERDNUSSBUTTER?";
            Roar_EM = "BRUSTKLOPFER";
            Sitting_around_EM = "RUMSITZEN";
            Shadow_Puppets_EM = "SCHATTENFIGUREN";//Halloween 16
            Twist_EM = "TWIST";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Beast_VP = "WILDES BIEST";
            Glasses_VP = "BRILLE";
            The_Thinker_VP = "DENKERPOSE";
            Medal_VP = "MEDAILLE";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Peanut_Butter_VP = "ERDNUSSBUTTER";//Uprising 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Atmosphere_SK { get; }//Rare
        public string Banana_SK { get; }
        public string Forest_SK { get; }
        public string Red_Planet_SK { get; }

        public string Desert_SK { get; }//Epic
        public string Horizon_SK { get; }
        public string Blizzcon_2017_SK { get; }//BlizzCon 2017 Special

        public string Frogston_SK { get; }//Legendary
        public string Undersea_SK { get; }
        public string Explorer_SK { get; }
        public string Safari_SK { get; }
        public string Yeti_SK { get; }//Winter 16
        public string Wukong_SK { get; }//Rooster 17
        #endregion
        #region Emotes

        public string Laughing_matter_EM { get; }//Epic
        public string Monkey_Buisness_EM { get; }
        public string Peanut_Butter_EM { get; }
        public string Roar_EM { get; }
        public string Sitting_around_EM { get; }
        public string Shadow_Puppets_EM { get; }//Halloween 16
        public string Twist_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Beast_VP { get; }//Rare
        public string Glasses_VP { get; }
        public string The_Thinker_VP { get; }
        public string Medal_VP { get; }//Summer 16
        public string RIP_VP { get; }//Halloween 16
        public string Peanut_Butter_VP { get; }//Uprising 17
        #endregion

        #endregion
    }
}
