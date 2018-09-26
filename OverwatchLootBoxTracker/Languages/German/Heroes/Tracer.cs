using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Tracer
    {
        public Tracer()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "TRACER";

            #region Skin
            //Rare
            Electric_Purple_SK = "ELEKTRISCHES VIOLETT";
            Hot_Pink_SK = "HEISSES PINK";
            Neon_Green_SK = "NEONGRÜN";
            Royal_Blue_SK = "KÖNIGSBLAU";
            //Epic
            Posh_SK = "POSH";
            Sporty_SK = "SPORTY";
            Rose_SK = "ROSE";//Rooster 17
            LIGHTNING_SK = "LIGHTNING";//Annyver 18
            //Legendary
            Punk_SK = "PUNK";
            Ultraviolet_SK = "ULTRAVIOLETT";
            Mach_T_SK = "MACH T";
            T_Racer_SK = "T. RACER";
            Slipstream_SK = "SLIPSTREAM";//Origin Special
            Sprinter_SK = "SPRINTER";//Summer 16
            Track_and_Field_SK = "LEICHTATLETIK";//summer 16
            Jingle_SK = "WICHTEL";//Winter 16
            Cadet_Oxton_SK = "KADETTIN OXTON";//Uprising 17
            Graffiti_SK = "GRAFITTI";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Bomb_Spin_EM = "BOMBENDREHER";
            Cheer_EM = "JUBELN";
            Finger_guns_EM = "PEW PEW PEW!";
            Having_a_laugh_EM = "LÄSSIGER LACHER";
            Sitting_around_EM = "RUMSITZEN ...";
            Spin_EM = "WAFFENWIRBEL";
            Charleston_EM = "CHARLESTON";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Over_the_shoulder_VP = "SCHULTERBLICK";
            Salute_VP = "SALUTIEREND";
            Sitting_VP = "SITZEND";
            Medal_VP = "MEDAILLE";//Summer 17
            Pumpkin_VP = "KÜRBIS";//Halloween 17
            RIP_VP = "R.I.P.";//Halloween 16
            Fireworks_VP = "RAKETEN";//Lunar 18
            WINK_VP = "WINK";//Annyver 18
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Electric_Purple_SK { get; }//Rare
        public string Hot_Pink_SK { get; }
        public string Neon_Green_SK { get; }
        public string Royal_Blue_SK { get; }

        public string Posh_SK { get; }//Epic
        public string Sporty_SK { get; }
        public string Rose_SK { get; }//Rooster 17
        public string LIGHTNING_SK { get; }//Annyver 18

        public string Punk_SK { get; }//Legendary
        public string Ultraviolet_SK { get; }
        public string Mach_T_SK { get; }
        public string T_Racer_SK { get; }
        public string Slipstream_SK { get; }//Origin Special
        public string Sprinter_SK { get; }//Summer 16
        public string Track_and_Field_SK { get; }//summer 16
        public string Jingle_SK { get; }//Winter 16
        public string Cadet_Oxton_SK { get; }//Uprising 17
        public string Graffiti_SK { get; }//Annyver 17
        #endregion
        #region Emotes

        public string Bomb_Spin_EM { get; }//Epic
        public string Cheer_EM { get; }
        public string Finger_guns_EM { get; }
        public string Having_a_laugh_EM { get; }
        public string Sitting_around_EM { get; }
        public string Spin_EM { get; }
        public string Charleston_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Over_the_shoulder_VP { get; }//Rare
        public string Salute_VP { get; }
        public string Sitting_VP { get; }
        public string Medal_VP { get; }//Summer 17
        public string Pumpkin_VP { get; }//Halloween 17
        public string RIP_VP { get; }//Halloween 16
        public string Fireworks_VP { get; }//Lunar 18
        public string WINK_VP { get; }//Annyver 18
        #endregion

        #endregion
    }
}
