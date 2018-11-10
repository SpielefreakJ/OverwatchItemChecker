using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Moira
    {
        public Moira()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "MOIRA";

            #region Skin
            //Rare
            Fiery_SK = "FEURIG";
            Royal_SK = "ROYAL";
            Selkie_SK = "SELKIE";
            Whiskey_SK = "WHISKEY";
            //Epic
            Ornate_SK = "PRÄCHTIG";
            Pale_SK = "BLASS";
            //Legendary
            Minister_SK = "MINISTERIN";
            Oasis_SK = "OASIS";
            Glam_SK = "GLAM";
            Moon_SK = "MOND";
            #endregion
            #region Emotes
            //Epic
            A_your_service_EM = "ZU EUREN DIENSTEN";
            Come_here_EM = "KOMM HER";
            Facepalm_EM = "FACEPALM";
            Give_and_take_EM = "GEBEN UND NEMEN";
            How_amusing_EM = "WIE AMÜSANT";
            Waiting_EM = "WARTEND";
            DANCE_EM = "DANCE";//Annyver 18
            #endregion
            #region Victory Poses
            //Rare
            Orbs_VP = "SPHÄREN";
            Prim_VP = "KORREKT";
            Steepling_VP = "FINGERSPITZEN";
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Fiery_SK { get; }//Rare
        public string Royal_SK { get; }
        public string Selkie_SK { get; }
        public string Whiskey_SK { get; }

        public string Ornate_SK { get; }//Epic
        public string Pale_SK { get; }

        public string Minister_SK { get; }//Legendary
        public string Oasis_SK { get; }
        public string Glam_SK { get; }
        public string Moon_SK { get; }
        #endregion
        #region Emotes
        //Epic
        public string A_your_service_EM { get; }
        public string Come_here_EM { get; }
        public string Facepalm_EM { get; }
        public string Give_and_take_EM { get; }
        public string How_amusing_EM { get; }
        public string Waiting_EM { get; }
        public string DANCE_EM { get; }//Annyver 18
        #endregion
        #region Victory Poses
        //Rare
        public string Orbs_VP { get; }
        public string Prim_VP { get; }
        public string Steepling_VP { get; }
        #endregion

        #endregion
    }
}
