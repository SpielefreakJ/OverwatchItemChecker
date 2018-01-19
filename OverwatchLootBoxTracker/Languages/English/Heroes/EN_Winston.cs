using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class EN_Winston
    {
        public EN_Winston()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Winston";

            #region Skin
            //Rare
            Atmosphere_SK = "Atmosphere";
            Banana_SK = "Banana";
            Forest_SK = "Forest";
            Red_Planet_SK = "Red Planet";
            //Epic
            Desert_SK = "Desert";
            Horizon_SK = "Horizon";
            Blizzcon_2017_SK = "BlizzCon 2017";//BlizzCon 2017 Special
            //Legendary
            Frogston_SK = "Frogston";
            Undersea_SK = "Undersea";
            Explorer_SK = "Explorer";
            Safari_SK = "Safari";
            Yeti_SK = "Yeti";//Winter 16
            Wukong_SK = "Wukong";//Rooster 17
            #endregion
            #region Emotes
            //Epic
            Laughing_matter_EM = "Laughing matter";
            Monkey_Buisness_EM = "Monkey Buisness";
            Peanut_Butter_EM = "Peanut Butter?";
            Roar_EM = "Roar";
            Sitting_around_EM = "Sitting around";
            Shadow_Puppets_EM = "Shadow Puppets";//Halloween 16
            Twist_EM = "Twist";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Beast_VP = "Beast";
            Glasses_VP = "Glases";
            The_Thinker_VP = "The Thinker";
            Medal_VP = "Medal";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Peanut_Butter_VP = "Peanut Butter";//Uprising 17
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
