using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Pharah
    {
        public Pharah()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "PHARAH";

            #region Skin
            //Rare
            Amethyst_SK = "AMETHYST";
            Copper_SK = "KUPFER";
            Emerald_SK = "SMARAGD";
            Titanium_SK = "TITAN";
            //Epic
            Anubis_SK = "ANUBIS";
            Jackal_SK = "SCHAKAL";
            Possessed_SK = "BESESSENE";//Halloween 16
            Frostbite_SK = "UNTERKÜHLT";//Winter 16
            //Legendary
            Asp_SK = "KOBRA";
            Mechaqueen_SK = "MECHAQUEEN";
            Raptorion_SK = "RAPTORION";
            Raindancer_SK = "REGENTÄNZERIN";
            Thunderbird_SK = "DONNERVOGEL";
            Security_Chief_SK = "SICHERHEITSCHEFIN";//Origin Special
            Bedouin_SK = "BEDUININ";//Annyver 2017
            #endregion
            #region Emotes
            //Epic
            Cheer_EM = "JUBELN";
            Chuckle_EM = "KICHERN";
            Flourish_EM = "GEWEHR PRÄSENTIEREN";
            Knuckles_EM = "SO NICHT";
            Take_a_knee_EM = "KNIEFALL";
            Flair_EM = "FINGERSPITZENGEFÜHL";//Uprising 17
            Rocket_Guitar_EM = "LUFTRAKETE";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Guardian_VP = "WÄCHTER";
            Kneeling_VP = "KNIEND";
            Jump_Jet_VP = "SENKRECHTSTARTER";
            Medal_VP = "MEDAILLE";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "PROST";//Winter 16
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
