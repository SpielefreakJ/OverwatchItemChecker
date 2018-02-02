using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Tracer
    {
        public Tracer()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Tracer";

            #region Skin
            //Rare
            Electric_Purple_SK = "Electric Purple";
            Hot_Pink_SK = "Hot Pink";
            Neon_Green_SK = "Neon Green";
            Royal_Blue_SK = "Royal Blue";
            //Epic
            Posh_SK = "Posh";
            Sporty_SK = "Sporty";
            Rose_SK = "Rose";//Rooster 2017
            //Legendary
            Punk_SK = "Punk";
            Ultraviolet_SK = "Ultraviolet";
            Mach_T_SK = "Mach T";
            T_Racer_SK = "T. Racer";
            Slipstream_SK = "Slipstream";//Origin Special
            Sprinter_SK = "Sprinter";//Summer 16
            Track_and_Field_SK = "Track and Field";//summer 16
            Jingle_SK = "Jingle";//Winter 16
            Cadet_Oxton_SK = "Cadet Oxton";//Uprising 17
            Graffiti_SK = "Graffiti";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Bomb_Spin_EM = "BOMB SPIN";
            Cheer_EM = "Cheer";
            Finger_guns_EM = "Finger guns";
            Having_a_laugh_EM = "Having a laugh";
            Sitting_around_EM = "Sitting around...";
            Spin_EM = "Spin";
            Charleston_EM = "Charleston";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Over_the_shoulder_VP = "Over the shoulder";
            Salute_VP = "Salute";
            Sitting_VP = "Sitting";
            Medal_VP = "Medal";//Summer 17
            Pumpkin_VP = "Pumpkin";//Halloween 17
            RIP_VP = "R.I.P.";//Halloween 16
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
        #endregion

        #endregion
    }
}
