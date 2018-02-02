using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Sombra
    {
        public Sombra()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "SOMBRA";

            #region Skin
            //Rare
            Cidro_SK = "CIDRO";
            Incendio_SK = "INCENDIO";
            Mar_SK = "MAR";
            Noche_SK = "NOCHE";
            //Epic
            Glitch_SK = "GLITCH";
            Virus_SK = "VIRUS";
            Peppermint_SK = "PFEFFERMINZ";//Winter 16
            //Legendary
            Azúcar_SK = "AZÚCAR";
            Los_Muertos_SK = "LOS MUERTOS";
            Augmented_SK = "AUGMENTIERT";
            Cyberspace_SK = "CYBERSPACE";
            Tulum_SK = "TULUM";//Summer 17
            Rime_SK = "RAUREIF";//Winter 17
            #endregion
            #region Emotes
            //Epic
            Amused_EM = "AMÜSIERT";
            Boop_EM = "BUUP";
            Hold_on_EM = "SEKUNDE";
            Marioneta_EM = "MARIONETA";
            Masterpiece_EM = "MEISTERWERK";
            Sit_EM = "SITZEND";
            Dance_EM = "TANZEN";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Hacked_VP = "GEHACKT";
            Kneeling_VP = "KNIEND";
            Rising_VP = "SCHWEBEND";
            Medal_VP = "MEDAILLE";//Summer 17
            Pumpkinette_VP = "KÜRBIS";//Halloween 17
            Toast_VP = "PROST";//Winter 17
            Sparklers_VP = "WUNDERKERZEN";//Rooster 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Cidro_SK { get; }//Rare
        public string Incendio_SK { get; }
        public string Mar_SK { get; }
        public string Noche_SK { get; }

        public string Glitch_SK { get; }//Epic
        public string Virus_SK { get; }
        public string Peppermint_SK { get; }//Winter 2016

        public string Azúcar_SK { get; }//Legendary
        public string Los_Muertos_SK { get; }
        public string Augmented_SK { get; }
        public string Cyberspace_SK { get; }
        public string Tulum_SK { get; }//Summer 2017
        public string Rime_SK { get; }//Winter 17
        #endregion
        #region Emotes

        public string Amused_EM { get; }//Epic
        public string Boop_EM { get; }
        public string Hold_on_EM { get; }
        public string Marioneta_EM { get; }
        public string Masterpiece_EM { get; }
        public string Sit_EM { get; }
        public string Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Hacked_VP { get; }//Rare
        public string Kneeling_VP { get; }
        public string Rising_VP { get; }
        public string Medal_VP { get; }//Summer 17
        public string Pumpkinette_VP { get; }//Halloween 17
        public string Toast_VP { get; }//Winter 17
        public string Sparklers_VP { get; }//Rooster 17ß
        #endregion

        #endregion
    }
}
