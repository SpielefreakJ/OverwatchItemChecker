using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Bastion
    {
        public Bastion()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "BASTION";

            #region Skins
            //Rare
            Dawn_SK = "MORGENRÖTE";
            Meadow_SK = "WIESE";
            Sky_SK = "HIMMEL";
            Soot_SK = "RUSS";
            //Epic
            Defense_Matrix_SK = "DEFENSIVMATRIX";
            Omnic_Crisis_SK = "OMNIC-KRIESE";
            BlizzCon_2016_SK = "BLIZZCON 2016";//BlizzCon 16
            Tombstone_SK = "GRABSTEIN";//Halloween 16
            Rooster_SK = "HAHN";//Rooster 17
            Null_Sector_SK = "NULL SECTOR";//Uprising 17
            //Legendary
            Antique_SK = "ANTIK";
            Woodbot_SK = "HOLZBOT";
            Gearbot_SK = "UHRWERKBOT";
            Steambot_SK = "STEAMBOT";
            Overgrown_SK = "ÜBERWUCHERT";//Origin Special
            Avalanche_SK = "LAWINE";//Winter 17
            Dune_Buggy_SK = "STRANDBUGGY";//Annyver 17
            #endregion
            #region Emotes
            //Rare
            Alert_Alert_EM = "ROTER ALARM!";
            Chortle_EM = "GLUCKSEND";
            Dizzy_EM = "SCHWINDELIG";
            Rest_Mode_EM = "RUHEMODUS";
            Robot_EM = "ROBOTER";
            Boxing_EM = "BOXEN";//Summer 16
            Robo_Boogie_EM = "ROBO-BOOGIE";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Birdwatching_VP = "VOGELBEOBACHTUNG";
            Pop_up_VP = "GESCHÜTZ";
            Tank_EM = "PANZER";
            Medal_VP = "MEDAILLE";//Summer 17
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "PROST";//Winter 17
            Firework_VP = "RAKETE";//Rooster 17
            #endregion

            //TB Translated
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
        public string BlizzCon_2016_SK { get; }//BlizzCon 16
        public string Tombstone_SK { get; }//Halloween 16
        public string Rooster_SK { get; }//Rooster 17
        public string Null_Sector_SK { get; }//Uprising 17

        public string Antique_SK { get; }//Legendary
        public string Woodbot_SK { get; }
        public string Gearbot_SK { get; }
        public string Steambot_SK { get; }
        public string Overgrown_SK { get; }//Origin Special
        public string Avalanche_SK { get; }//Winter 17
        public string Dune_Buggy_SK { get; }//Annyver 17
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
