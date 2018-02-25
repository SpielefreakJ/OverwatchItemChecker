using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Roadhog
    {
        public Roadhog()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Roadhog";

            #region Skin
            //Rare
            Kiwi_SK = "Kiwi";
            Mud_SK = "Mud";
            Sand_SK = "Sand";
            Thistle_SK = "Thistle";
            //Epic
            Pigpen_SK = "Pigpen";
            Stitched_SK = "Stitched";
            Rudolph_SK = "Rudolph";//Winter 16
            //Legendary
            Butcher_SK = "BUTCHER";
            Islander_SK = "Islander";
            Toa_SK = "Toa";
            Mako_SK = "Mako";
            Sharkbait_SK = "Sharkbait";
            Junkensteins_Monster_SK = "Junkenstein's Monster";//Halloween 16
            Ice_Fisherman_SK = "Ice Fisherman";//Winter 17
            Bajie_SK = "Bajie";//Rooster 17
            #endregion
            #region Emotes
            //Epic
            Belly_Laugh_EM = "Belly laugh";
            Boo_EM = "Boo!";
            Can_Crusher_EM = "Can Crusher";
            Headbanging_EM = "Headbanging";
            Tuckered_Out_EM = "Tuckered out";
            Secret_friend_EM = "SECRET FRIEND";//Lunar 18
            Dance_EM = "Dance";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Pointing_to_the_sky_VP = "Pointing to the sky";
            Thumbs_Up_VP = "Thumbs Up";
            Tuckered_out_VP = "Tuckered out";
            Medal_VP = "Medal";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "Toast";//Winter 17
            Whats_mine_is_mine_VP = "What's mine is mine";//Rooster 17
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
