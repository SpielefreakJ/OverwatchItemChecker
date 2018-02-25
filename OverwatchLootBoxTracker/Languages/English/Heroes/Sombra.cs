using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Sombra
    {
        public Sombra()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Sombra";

            #region Skin
            //Rare
            Cidro_SK = "Cidro";
            Incendio_SK = "Incendio";
            Mar_SK = "Mar";
            Noche_SK = "Noche";
            //Epic
            Glitch_SK = "Glitch";
            Virus_SK = "Virus";
            Peppermint_SK = "Peppermint";//Winter 16
            //Legendary
            Azúcar_SK = "Azúcar";
            Los_Muertos_SK = "Los Muertos";
            Augmented_SK = "Augmented";
            Cyberspace_SK = "Cyberspace";
            Tulum_SK = "Tulum";//Summer 17
            Rime_SK = "Rime";//Winter 17
            #endregion
            #region Emotes
            //Epic
            Amused_EM = "Amused";
            Boop_EM = "Boop";
            Hold_on_EM = "Hold on";
            Marioneta_EM = "MARIONETA";
            Masterpiece_EM = "Masterpiece";
            Sit_EM = "Sit";
            Dance_EM = "Dance";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Hacked_VP = "Hacked";
            Kneeling_VP = "Kneeling";
            Rising_VP = "Rising";
            Medal_VP = "Medal";//Summer 17
            Pumpkinette_VP = "Pumpkinette";//Halloween 17
            Toast_VP = "Toast";//Winter 17
            Sparklers_VP = "Sparklers";//Lunar 17
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
        public string Sparklers_VP { get; }//Lunar 18
        #endregion

        #endregion
    }
}
