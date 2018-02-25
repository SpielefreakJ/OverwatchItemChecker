using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Mercy
    {
        public Mercy()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "MERCY";

            #region Skin
            //Rare
            Celestial_SK = "HIMMLISCH";
            Mist_SK = "NEBEL";
            Orchid_SK = "ORCHIDEE";
            Verdant_SK = "GRÜN";
            //Epic
            Amber_SK = "BERNSTEIN";
            Cobalt_SK = "KOBALT";
            Eidgenossin_SK = "EIDGENOSSIN";//Summer 16
            Fortune_SK = "GLÜCK";//Rooster 17
            //Legendary
            Sigrun_SK = "SIGRÚN";
            Valkyrie_SK = "WALKÜRE";
            Devil_SK = "TEUFELIN";
            IMP_SK = "DÄMON";
            Winged_Victory_SK = "SIEGESGÖTTIN";//Summer 17
            Witch_SK = "HEXE";//Halloween 16
            Zhuque_SK = "ZHUQUE";//Lunar 18
            Combat_Medic_Ziegler_SK = "FELDSANITÄTERIN ZIEGLER";//Uprising 17
            #endregion
            #region Emotes
            //Epic
            Applause_EM = "APPLAUS";
            Caduceus_EM = "CADCEUS";
            No_Pulse_EM = "KEIN PULS";
            Parasol_EM = "SONNENSCHIRM";
            Relax_EM = "ENTSPANNT";
            The_best_Medicine_EM = "DIE BESTE MEDIZIN";
            Hustle_EM = "HUSTLE";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Angelic_VP = "ENGELSGLEICH";
            Carefree_VP = "ENTSPANNT";
            Parasol_VP = "SONNENSCHIRM";
            Ready_for_Battle_VP = "KAMPFBEREIT";
            Medal_VP = "MEDAILLE";//Summer 17
            RIP_VP = "R.I.P.";//Halloween 16
            Mistletoe_VP = "MISTELZWEIG";//Winter 16
            Toast_VP = "PROST";//Winter 17
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
        public string Zhuque_SK { get; }//Lunar 18
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
        public string Parasol_VP { get; }
        public string Ready_for_Battle_VP { get; }
        public string Medal_VP { get; }//Summer 17
        public string RIP_VP { get; }//Halloween 16
        public string Mistletoe_VP { get; }//Winter 16
        public string Toast_VP { get; }//Winter 17
        #endregion

        #endregion
    }
}
