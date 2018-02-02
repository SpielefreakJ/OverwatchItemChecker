using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Symmetra
    {
        public Symmetra()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Symmetra";

            #region Skin
            //Rare
            Cardamom_SK = "Cardamom";
            Hyacinth_SK = "Hyacinth";
            Saffron_SK = "Saffron";
            Technomancer_SK = "Technomancer";
            //Epic
            Peacock_SK = "PEACOCK";
            Regal_SK = "Regal";
            Utopaea_SK = "Utopaea";
            Vampire_SK = "Vampire";//Halloween 16
            Qipao_SK = "Qipao";//Rooster 17
            //Legendary
            Architech_SK = "Architech";
            Vishkar_SK = "Vishkar";
            Devi_SK = "Devi";
            Goddess_SK = "Goddess";
            Dragon_SK = "Dragon";//Halloween 17
            Oasis_SK = "Oasis";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Clap_EM = "Clap";
            Flow_EM = "Flow";
            Have_a_seat_EM = "Have a seat";
            Insignificant_EM = "Insignificant";
            Snicker_EM = "Snicker";
            Ribbon_EM = "Ribbon";//Summer 16
            Dance_EM = "Dance";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Balance_VP = "Balance";
            Creation_VP = "Creation";
            Dance_VP = "Dance";
            Medal_VP = "Medal";//Summer 17
            RIP_VP = "R.I.P.";//Halloween 16
            Light_Reading_VP = "Light Reading";//Uprising 17
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
        public string Light_Reading_VP { get; }//Uprising 17
        #endregion

        #endregion
    }
}
