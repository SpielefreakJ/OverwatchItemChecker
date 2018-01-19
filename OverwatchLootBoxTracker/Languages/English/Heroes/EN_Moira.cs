using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class EN_Moira
    {
        public EN_Moira()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Moira";

            #region Skin
            //Rare
            Fiery_SK = "Fiery";
            Royal_SK = "Royal";
            Selkie_SK = "Selkie";
            Whiskey_SK = "Whiskey";
            //Epic
            Ornate_SK = "Ornate";
            Pale_SK = "Pale";
            //Legendary
            Minister_SK = "Minister";
            Oasis_SK = "Oasis";
            Glam_SK = "Glam";
            Moon_SK = "Moon";
            #endregion
            #region Emotes
            //Epic
            A_your_service_EM = "At your service";
            Come_here_EM = "Come here";
            Give_and_take_EM = "Give and take";
            How_amusing_EM = "How amusing";
            Waiting_EM = "Waiting";
            #endregion
            #region Victory Poses
            //Rare
            Orbs_VP = "Orbs";
            Prim_VP = "Prim";
            Steepling_VP = "Steepling";
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
        public string Give_and_take_EM { get; }
        public string How_amusing_EM { get; }
        public string Waiting_EM { get; }
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
