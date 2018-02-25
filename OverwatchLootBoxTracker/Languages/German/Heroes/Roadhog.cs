using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Roadhog
    {
        public Roadhog()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "ROADHOG";

            #region Skin
            //Rare
            Kiwi_SK = "KIWI";
            Mud_SK = "SCHLAMM";
            Sand_SK = "SAND";
            Thistle_SK = "VEILCHEN";
            //Epic
            Pigpen_SK = "SCHWEINESTALL";
            Stitched_SK = "SCHWARTE";
            Rudolph_SK = "RUDOLPH";//Winter 16
            //Legendary
            Butcher_SK = "SCHLÄCHTER";
            Islander_SK = "INSELBEWOHNER";
            Toa_SK = "TOA";
            Mako_SK = "MAKO";
            Sharkbait_SK = "HAIHAPPEN";
            Junkensteins_Monster_SK = "JUNKENSTEINS MONSTER";//Halloween 16
            Ice_Fisherman_SK = "EISFISCHER";//Winter 17
            Bajie_SK = "BAJIE";//Rooster 17
            #endregion
            #region Emotes
            //Epic
            Belly_Laugh_EM = "PLATZT VOR LACHEN";
            Boo_EM = "BUH!";
            Can_Crusher_EM = "DOSENQUETSCHER";
            Headbanging_EM = "HEADBANGING";
            Tuckered_Out_EM = "VÖLLIG ERSCHÖPFT";
            Secret_friend_EM = "GEHEIMER FREUND";//Lunar 18
            Dance_EM = "TANZEN";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Pointing_to_the_sky_VP = "IN DEN HIMMEL ZEIGEND";
            Thumbs_Up_VP = "DAUMEN HOCH";
            Tuckered_out_VP = "ERSCHÖPFT";
            Medal_VP = "MEDAILLE";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "PROST";//Winter 17
            Whats_mine_is_mine_VP = "PFOTEN WEG, DAS IS' MEINS!";//Rooster 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Kiwi_SK { get; }//Rare
        public string Mud_SK { get; }
        public string Sand_SK { get; }
        public string Thistle_SK { get; }

        public string Pigpen_SK { get; }//Epic
        public string Stitched_SK { get; }
        public string Rudolph_SK { get; }//Winter 2016

        public string Butcher_SK { get; }//Legendary
        public string Islander_SK { get; }
        public string Toa_SK { get; }
        public string Mako_SK { get; }
        public string Sharkbait_SK { get; }
        public string Junkensteins_Monster_SK { get; }//Halloween 2016
        public string Ice_Fisherman_SK { get; }//Winter 17
        public string Bajie_SK { get; }//Rooster 17
        #endregion
        #region Emotes

        public string Belly_Laugh_EM { get; }//Epic
        public string Boo_EM { get; }
        public string Can_Crusher_EM { get; }
        public string Headbanging_EM { get; }
        public string Tuckered_Out_EM { get; }
        public string Secret_friend_EM { get; }//Lunar 18
        public string Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses
        //Rare
        public string Pointing_to_the_sky_VP { get; }
        public string Thumbs_Up_VP { get; }
        public string Tuckered_out_VP { get; }
        public string Medal_VP { get; }//Summer 16
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 17
        public string Whats_mine_is_mine_VP { get; }//Rooster 17
        #endregion

        #endregion
    }
}
