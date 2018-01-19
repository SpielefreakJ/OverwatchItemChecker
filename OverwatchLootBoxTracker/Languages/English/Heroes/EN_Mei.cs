using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class EN_Mei
    {
        public EN_Mei()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Mei";

            #region Skin
            //Rare
            Chrysanthemum_SK = "Chrysanthemum";
            Heliotrope_SK = "Heliotrope";
            Jade_SK = "Jade";
            Persimmon_SK = "Persimmon";
            //Epic
            Earthen_SK = "Earthen";
            Snow_Plum_SK = "Snow Plum";
            //Legendary
            Firefighter_SK = "Firefighter";
            Rescue_Mei_SK = "Rescue Mei";
            Abominable_SK = "Abominable";
            Yeti_Hunter_SK = "Yeti Hunter";
            Ecopoint_SK = "Ecopoint";
            Jiangshi_SK = "Jiangshi";//Halloween 17
            Mei_rry_SK = "Mei-rry";//Winter 16
            Chang_e_SK = "Chang'e";//Rooster 17
            Luna_SK = "Luna";//Rooster 17
            Beekeeper_SK = "Beekeeper";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Companion_EM = "Companion";
            Gigle_EM = "Gigle";
            Kneel_EM = "Kneel";
            Spray_EM = "Spray";
            Yaaaaaaaaay_EM = "Yaaaaaaaaay!";

            Hopping_EM = "Hopping";//Halloween 17
            Snowman_EM = "Snowman";//Winter 16
            So_excited_EM = "So excited";//Rooster 17
            Sunny_Dance_EM = "Sunny Dance";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Casual_VP = "Casual";
            Hands_on_hips_VP = "Hands on hips";
            Kneeling_VP = "Kneeling";
            Medal_VP = "Medal";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Lucky_VP = "Lucky!";//Rooster 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Chrysanthemum_SK { get; }//Rare
        public string Heliotrope_SK { get; }
        public string Jade_SK { get; }
        public string Persimmon_SK { get; }

        public string Earthen_SK { get; }//Epic
        public string Snow_Plum_SK { get; }

        public string Firefighter_SK { get; }//Legendary
        public string Rescue_Mei_SK { get; }
        public string Abominable_SK { get; }
        public string Yeti_Hunter_SK { get; }
        public string Ecopoint_SK { get; }
        public string Jiangshi_SK { get; }//Halloween 17
        public string Mei_rry_SK { get; }//Winter 16
        public string Chang_e_SK { get; }//Rooster 17
        public string Luna_SK { get; }//Rooster 17
        public string Beekeeper_SK { get; }//Annyver 17
        #endregion
        #region Emotes

        public string Companion_EM { get; }//Epic
        public string Gigle_EM { get; }
        public string Kneel_EM { get; }
        public string Spray_EM { get; }
        public string Yaaaaaaaaay_EM { get; }
        public string Hopping_EM { get; }//Halloween 17
        public string Snowman_EM { get; }//Winter 16
        public string So_excited_EM { get; }//Rooster 17
        public string Sunny_Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Casual_VP { get; }//Rare
        public string Hands_on_hips_VP { get; }
        public string Kneeling_VP { get; }
        public string Medal_VP { get; }//Summer 16
        public string RIP_VP { get; }//Halloween 16
        public string Lucky_VP { get; }//Rooster 17
        #endregion

        #endregion
    }
}
