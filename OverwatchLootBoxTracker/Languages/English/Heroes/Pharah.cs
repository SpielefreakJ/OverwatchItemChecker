using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Pharah
    {
        public Pharah()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Pharah";

            #region Skin
            //Rare
            Amethyst_SK = "Amethyst";
            Copper_SK = "Copper";
            Emerald_SK = "Emerald";
            Titanium_SK = "Titanium";
            //Epic
            Anubis_SK = "Anubis";
            Jackal_SK = "Jackal";
            Possessed_SK = "Possessed";//Halloween 16
            Frostbite_SK = "Frostbite";//Winter 16
            //Legendary
            Asp_SK = "ASP";
            Mechaqueen_SK = "Mechaqueen";
            Raptorion_SK = "Raptorion";
            Raindancer_SK = "Raindancer";
            Thunderbird_SK = "Thunderbird";
            Security_Chief_SK = "Security Chief";//Origin Special
            Qinglong_SK = "QINGLONG";//Lunar 18
            Bedouin_SK = "Bedouin";//Annyver 2017
            #endregion
            #region Emotes
            //Epic
            Cheer_EM = "Cheer";
            Chuckle_EM = "Chuckle";
            Flourish_EM = "Flourish";
            Knuckles_EM = "Knuckles";
            Take_a_knee_EM = "Take a knee";
            Flair_EM = "Flair";//Uprising 17
            Rocket_Guitar_EM = "Rocket Guitar";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Guardian_VP = "Guardian";
            Kneeling_VP = "Kneeling";
            Jump_Jet_VP = "Jump Jet";
            Medal_VP = "Medal";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "Toast";//Winter 16
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Amethyst_SK { get; }//Rare
        public string Copper_SK { get; }
        public string Emerald_SK { get; }
        public string Titanium_SK { get; }

        public string Anubis_SK { get; }//Epic
        public string Jackal_SK { get; }
        public string Possessed_SK { get; }//Halloween 16
        public string Frostbite_SK { get; }//Winter 16

        public string Asp_SK { get; }//Legendary
        public string Mechaqueen_SK { get; }
        public string Raptorion_SK { get; }
        public string Raindancer_SK { get; }
        public string Thunderbird_SK { get; }
        public string Security_Chief_SK { get; }//Origin Special
        public string Qinglong_SK { get; }//Lunar 18
        public string Bedouin_SK { get; }//Annyver 2017
        #endregion
        #region Emotes

        public string Cheer_EM { get; }//Epic
        public string Chuckle_EM { get; }
        public string Flourish_EM { get; }
        public string Knuckles_EM { get; }
        public string Take_a_knee_EM { get; }
        public string Flair_EM { get; }//Uprising 17
        public string Rocket_Guitar_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Guardian_VP { get; }//Rare
        public string Kneeling_VP { get; }
        public string Jump_Jet_VP { get; }
        public string Medal_VP { get; }//Summer 16
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 16
        #endregion

        #endregion
    }
}
