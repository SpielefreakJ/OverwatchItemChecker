using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Reaper
    {
        public Reaper()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Reaper";

            #region Skin
            //Rare
            Blood_SK = "Blood";
            Midnight_SK = "Midnight";
            Moss_SK = "Moss";
            Royal_SK = "Royal";
            //Epic
            Desert_SK = "Desert";
            Hellfire_SK = "HELLFIRE";
            Wight_SK = "Wight";
            Shiver_SK = "Shiver";//Winter 2016
            //Legendary
            Nevermore_SK = "Nevermore";
            Plague_Doctor_SK = "Plague Doctor";
            El_Blanco_SK = "El Blanco";
            Mariachi_SK = "Mariachi";
            Blackwatch_Reyes_SK = "Blackwatch Reyes";//Origin Special
            Biker_SK = "Biker";//Summer 17
            Dracula_SK = "Dracula";//Halloween 17
            Pumpkin_SK = "Pumpkin";//Halloween 16
            #endregion
            #region Emotes
            //Epic
            Cackle_EM = "Cackle";
            Not_Impressed_EM = "Not Impressed";
            Shrug_EM = "Shrug";
            Slice_EM = "Slice";
            Slow_Clap_EM = "Slow Clap";
            Take_a_knee_EM = "Take a knee";
            Dance_EM = "Dance";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Casual_VP = "Casual";
            Enigmatic_VP = "Enigmatic";
            Menacing_VP = "Menacing";
            Shrug_VP = "Shrug";
            Medal_VP = "Medal";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Blood_SK { get; }//Rare
        public string Midnight_SK { get; }
        public string Moss_SK { get; }
        public string Royal_SK { get; }

        public string Desert_SK { get; }//Epic
        public string Hellfire_SK { get; }
        public string Wight_SK { get; }
        public string Shiver_SK { get; }//Winter 2016

        public string Nevermore_SK { get; }//Legendary
        public string Plague_Doctor_SK { get; }
        public string El_Blanco_SK { get; }
        public string Mariachi_SK { get; }
        public string Blackwatch_Reyes_SK { get; }//Origin Special
        public string Biker_SK { get; }//Summer 17
        public string Dracula_SK { get; }//Halloween 17
        public string Pumpkin_SK { get; }//Halloween 16
        #endregion
        #region Emotes

        public string Cackle_EM { get; }//Epic
        public string Not_Impressed_EM { get; }
        public string Shrug_EM { get; }
        public string Slice_EM { get; }
        public string Slow_Clap_EM { get; }
        public string Take_a_knee_EM { get; }
        public string Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Casual_VP { get; }//Rare
        public string Enigmatic_VP { get; }
        public string Menacing_VP { get; }
        public string Shrug_VP { get; }
        public string Medal_VP { get; }//Summer 16
        public string RIP_VP { get; }//Halloween 16
        #endregion

        #endregion
    }
}
