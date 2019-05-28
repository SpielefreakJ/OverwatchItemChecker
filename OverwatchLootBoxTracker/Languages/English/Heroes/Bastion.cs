using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.English.Heroes
{
    class Bastion
    {
        public Bastion()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Bastion";

            #region Skins
            //Rare
            Dawn_SK = "Dawn";
            Meadow_SK = "Meadow";
            Sky_SK = "Sky";
            Soot_SK = "Soot";
            //Epic
            Defense_Matrix_SK = "Defense Matrix";
            Omnic_Crisis_SK = "Omnic Crisis";
            Tombstone_SK = "Tombstone";//Halloween 16
            Gift_Wrap_SK = "GIFT WRAP";//Winter 19
            Rooster_SK = "Rooster";//Rooster 17
            Null_Sector_SK = "Null Sector";//Uprising 17
            BlizzCon_2016_SK = "BlizzCon 2016";//BlizzCon 16
            //Legendary
            Antique_SK = "Antique";
            Woodbot_SK = "Woodbot";
            Gearbot_SK = "Gearbot";
            Steambot_SK = "Steambot";
            Avalanche_SK = "Avalanche";//Winter 17
            Gwishin_SK = "GWISHIN";//Archiv 18
            Dune_Buggy_SK = "Dune Buggy";//Annyver 17
            STEALTH_SK = "STEALTH";//Annyver 18
            Overgrown_SK = "Overgrown";//Origin Special
            #endregion
            #region Emotes
            //Epic
            Alert_Alert_EM = "Alert! Alert!";
            Chortle_EM = "Chortle";
            Dizzy_EM = "Dizzy";
            Rest_Mode_EM = "Rest Mode";
            Robot_EM = "Robot";
            Boxing_EM = "Boxing";//Summer 16
            Robo_Boogie_EM = "Robo Boogie";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Birdwatching_VP = "Birdwatching";
            Pop_up_VP = "Pop up";
            Tank_EM = "Tank";
            Medal_VP = "Medal";//Summer 17
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "Toast";//Winter 17
            Firework_VP = "Firework";//Rooster 17
            #endregion
            #region Voice Lines
            //Common
            Doo_Woo_VL = "Doo-Woo";
            Beeple_VL = "Beeple";
            Boo_Boo_Doo_De_Doo_VL = "Boo Boo Doo De Doo";
            Bweeeeeeeeeee_VL = "Bweeeeeeeeeee";
            Chirr_Chirr_Chirr_VL = "Chirr Chirr Chirr";
            Dah_Dah_Weeeee_VL = "Da-Da Weeeee!";
            Dun_Dun_Boop_Boop_VL = "Dun Dun Boop Boop";
            Dweet_Dweet_Dweet_VL = "Dweet Dweet Dweet";
            Hee_Hoo_Hoo_VL = "Hee Hoo Hoo";
            Ooh_ooo_hoo_hoo_VL = "OOH-OOO-HOO-HOO";
            Sh_Sh_Sh_VL = "Sh-Sh-Sh";
            Zwee_VL = "Zwee?";
            Doo_Do_Doo_Dee_VL = "Doo-Do-Doo Dee!";//Summer 17
            Whoo_Vweeeeee_VL = "Whoo-VWeeeeee";//Summer 16
            Oooooooooooo_VL = "Oooooooooooo...";//Halloween 17
            W_W_Wooooo_VL = "W-W-Wooooo...?";//Halloween 16
            Bwoo_Bwoo_Bwoo_VL = "Bwoo Bwoo Bwoo";//Winter 17
            Dwee_Doo_Hoo_VL = "Dwee Doo Hoo";//Winter 16
            Woop_Doo_Woo_Dun_Woop_VL = "Woop Doo Woo Dun Woop";//Rooster 17
            Dwee_Wee_Woh_VL = "Dwee Wee Woh";//Uprising 17
            Zwee_Ah_Wheee_Doo_Woo_VL = "Zwee-Ah Wheee Doo Woo";//Uprising 17
            Bew_Woo_Bew_Woo_VL = "Bew-Woo Bew-Woo";//Annyver 17
            Doo_Dun_Dun_Woo_VL = "Doo Dun Dun Woo";//Annyver 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skins

        public string Dawn_SK { get; }//Rare
        public string Meadow_SK { get; }
        public string Sky_SK { get; }
        public string Soot_SK { get; }

        public string Defense_Matrix_SK { get; }//Epic
        public string Omnic_Crisis_SK { get; }
        public string Tombstone_SK { get; }//Halloween 16
        public string Gift_Wrap_SK { get; }//Winter 18
        public string Rooster_SK { get; }//Rooster 17
        public string Null_Sector_SK { get; }//Uprising 17
        public string BlizzCon_2016_SK { get; }//BlizzCon 16

        public string Antique_SK { get; }//Legendary
        public string Woodbot_SK { get; }
        public string Gearbot_SK { get; }
        public string Steambot_SK { get; }
        public string Avalanche_SK { get; }//Winter 17
        public string Gwishin_SK { get; }//Archiv 18
        public string Dune_Buggy_SK { get; }//Annyver 17
        public string STEALTH_SK { get; }//Annyver 18
        public string Overgrown_SK { get; }//Origin Special
        #endregion
        #region Emotes
        
        public string Alert_Alert_EM { get; }//Rare
        public string Chortle_EM { get; }
        public string Dizzy_EM { get; }
        public string Rest_Mode_EM { get; }
        public string Robot_EM { get; }
        public string Boxing_EM { get; }//Summer 16
        public string Robo_Boogie_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses
        
        public string Birdwatching_VP { get; }//Rare
        public string Pop_up_VP { get; }
        public string Tank_EM { get; }
        public string Medal_VP { get; }//Summer 17
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 17
        public string Firework_VP { get; }//Rooster 17
        #endregion
        #region Voice Lines

        public string Doo_Woo_VL { get; }//Common
        public string Beeple_VL { get; }
        public string Boo_Boo_Doo_De_Doo_VL { get; }
        public string Bweeeeeeeeeee_VL { get; }
        public string Chirr_Chirr_Chirr_VL { get; }
        public string Dah_Dah_Weeeee_VL { get; }
        public string Dun_Dun_Boop_Boop_VL { get; }
        public string Dweet_Dweet_Dweet_VL { get; }
        public string Hee_Hoo_Hoo_VL { get; }
        public string Ooh_ooo_hoo_hoo_VL { get; }
        public string Sh_Sh_Sh_VL { get; }
        public string Zwee_VL { get; }
        public string Doo_Do_Doo_Dee_VL { get; }//Summer 17
        public string Whoo_Vweeeeee_VL { get; }//Summer 16
        public string Oooooooooooo_VL { get; }//Halloween 17
        public string W_W_Wooooo_VL { get; }//Halloween 16
        public string Bwoo_Bwoo_Bwoo_VL { get; }//Winter 17
        public string Dwee_Doo_Hoo_VL { get; }//Winter 16
        public string Woop_Doo_Woo_Dun_Woop_VL { get; }//Rooster 17
        public string Dwee_Wee_Woh_VL { get; }//Uprising 17
        public string Zwee_Ah_Wheee_Doo_Woo_VL { get; }//Uprising 17
        public string Bew_Woo_Bew_Woo_VL { get; }//Annyver 17
        public string Doo_Dun_Dun_Woo_VL { get; }
        #endregion

        #endregion
    }
}
