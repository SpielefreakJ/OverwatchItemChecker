using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Reaper
    {
        public Reaper()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "REAPER";

            #region Skin
            //Rare
            Blood_SK = "BLUT";
            Midnight_SK = "MITTERNACHT";
            Moss_SK = "MOOS";
            Royal_SK = "KÖNIGLICH";
            //Epic
            Desert_SK = "WÜSTE";
            Hellfire_SK = "HÖLLENFEUER";
            Wight_SK = "SCHNEE";
            Shiver_SK = "KALTER SCHAUER";//Winter 2016
            //Legendary
            Nevermore_SK = "NIMMERMEHR";
            Plague_Doctor_SK = "SEUCHENARZT";
            El_Blanco_SK = "EL BLANCO";
            Mariachi_SK = "MARIACHI";
            Blackwatch_Reyes_SK = "BLACKWATCH-REYES";//Origin Special
            Biker_SK = "BIKER";//Summer 17
            Dracula_SK = "DRACULA";//Halloween 17
            Pumpkin_SK = "KÜRBISKOPF";//Halloween 16
            #endregion
            #region Emotes
            //Epic
            Cackle_EM = "FIESE LACHE";
            Not_Impressed_EM = "UNBEEINDRUCKT";
            Shrug_EM = "ACHSELZUCKEND";
            Slice_EM = "AUFSCHLITZEN";
            Slow_Clap_EM = "LANGSAMES KLATSCHEN";
            Take_a_knee_EM = "KNIEND";
            Dance_EM = "TANZEN";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Casual_VP = "LÄSSIG";
            Enigmatic_VP = "GEHEIMNISVOLL";
            Menacing_VP = "BEDROHLICH";
            Shrug_VP = "ACHSELZUCKEN";
            Medal_VP = "MEDAILLE";//Summer 16
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
