using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Symmetra
    {
        public Symmetra()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "SYMMETRA";

            #region Skin
            //Rare
            Cardamom_SK = "KARDAMOM";
            Hyacinth_SK = "HYAZINTH";
            Saffron_SK = "SAFRAN";
            Technomancer_SK = "TECHNOMATIN";
            //Epic
            Peacock_SK = "PFAU";
            Regal_SK = "MAJESTÄTISCH";
            Utopaea_SK = "UTOPAEA";
            Vampire_SK = "VAMPIR";//Halloween 16
            Qipao_SK = "QIPAO";//Rooster 17
            //Legendary
            Architech_SK = "ARCHITECH";
            Vishkar_SK = "VISHKAR";
            Devi_SK = "DEVI";
            Goddess_SK = "GÖTTIN";
            Dragon_SK = "DRACHE";//Halloween 17
            Oasis_SK = "OASIS";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Clap_EM = "KLATSCHEN";
            Flow_EM = "FLIESSENDEN BEWEGUNG";
            Have_a_seat_EM = "ORDENTLICH SITZEND";
            Insignificant_EM = "UNBEDEUTEND";
            Snicker_EM = "KICHERND";
            Ribbon_EM = "BAND";//Summer 16
            Dance_EM = "TANZEN";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Balance_VP = "BALANCE";
            Creation_VP = "LICHTKREATION";
            Dance_VP = "TANZEN";
            Medal_VP = "MEDAILLE";//Summer 17
            RIP_VP = "R.I.P.";//Halloween 16
            Fan_VP = "FÄCHER";//Lunar 18
            Light_Reading_VP = "LEICHTE LEKTÜRE";//Uprising 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Cardamom_SK { get; }//Rare
        public string Hyacinth_SK { get; }
        public string Saffron_SK { get; }
        public string Technomancer_SK { get; }

        public string Peacock_SK { get; }//Epic
        public string Regal_SK { get; }
        public string Utopaea_SK { get; }
        public string Vampire_SK { get; }//Halloween 16
        public string Qipao_SK { get; }//Rooster 2017

        public string Architech_SK { get; }//Legendary
        public string Vishkar_SK { get; }
        public string Devi_SK { get; }
        public string Goddess_SK { get; }
        public string Dragon_SK { get; }//Halloween 17
        public string Oasis_SK { get; }//Annyver 17
        #endregion
        #region Emotes

        public string Clap_EM { get; }//Epic
        public string Flow_EM { get; }
        public string Have_a_seat_EM { get; }
        public string Insignificant_EM { get; }
        public string Snicker_EM { get; }
        public string Ribbon_EM { get; }//Summer 16
        public string Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Balance_VP { get; }//Rare
        public string Creation_VP { get; }
        public string Dance_VP { get; }
        public string Medal_VP { get; }//Summer 17
        public string RIP_VP { get; }//Halloween 16
        public string Fan_VP { get; }//Lunar 18
        public string Light_Reading_VP { get; }//Uprising 17
        #endregion

        #endregion
    }
}
