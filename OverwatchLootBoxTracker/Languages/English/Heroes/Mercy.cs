using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Mercy
    {
        public Mercy()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Mercy";

            #region Skin
            //Rare
            Celestial_SK = "Celestial";
            Mist_SK = "Mist";
            Orchid_SK = "Orchid";
            Verdant_SK = "Verdant";
            //Epic
            Amber_SK = "Amber";
            Cobalt_SK = "Cobalt";
            Eidgenossin_SK = "Eidgenossin";//Summer 16
            Fortune_SK = "Fortune";//Rooster 17
            //Legendary
            Sigrun_SK = "Sigrún";
            Valkyrie_SK = "Valkyrie";
            Devil_SK = "Devil";
            IMP_SK = "IMP";
            Winged_Victory_SK = "Winged Victory";//Summer 17
            Witch_SK = "Witch";//Halloween 16
            Combat_Medic_Ziegler_SK = "Combat Medic Ziegler";//Uprising 17
            #endregion
            #region Emotes
            //Epic
            Applause_EM = "Applause";
            Caduceus_EM = "Caduceus";
            No_Pulse_EM = "No Pulse";
            Parasol_EM = "PARASOL";
            Relax_EM = "Relax";
            The_best_Medicine_EM = "The best Medicine";
            Hustle_EM = "Hustle";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Angelic_VP = "Angelic";
            Carefree_VP = "Carefree";
            Ready_for_Battle_VP = "Ready for Battle";
            Medal_VP = "Medal";//Summer 17
            RIP_VP = "R.I.P.";//Halloween 16
            Mistletoe_VP = "Mistletoe";//Winter 16
            Toast_VP = "Toast";//Winter 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Celestial_SK { get; }//Rare
        public string Mist_SK { get; }
        public string Orchid_SK { get; }
        public string Verdant_SK { get; }

        public string Amber_SK { get; }//Epic
        public string Cobalt_SK { get; }
        public string Eidgenossin_SK { get; }//Summer 16
        public string Fortune_SK { get; }//Rooster 17

        public string Sigrun_SK { get; }//Legendary
        public string Valkyrie_SK { get; }
        public string Devil_SK { get; }
        public string IMP_SK { get; }
        public string Winged_Victory_SK { get; }//Summer 17
        public string Witch_SK { get; }//Halloween 16
        public string Combat_Medic_Ziegler_SK { get; }//Uprising 17
        #endregion
        #region Emotes

        public string Applause_EM { get; }//Epic
        public string Caduceus_EM { get; }
        public string No_Pulse_EM { get; }
        public string Parasol_EM { get; }
        public string Relax_EM { get; }
        public string The_best_Medicine_EM { get; }
        public string Hustle_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Angelic_VP { get; }//Rare
        public string Carefree_VP { get; }
        public string Ready_for_Battle_VP { get; }
        public string Medal_VP { get; }//Summer 17
        public string RIP_VP { get; }//Halloween 16
        public string Mistletoe_VP { get; }//Winter 16
        public string Toast_VP { get; }//Winter 17
        #endregion

        #endregion
    }
}
