using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class L_Bastion
    {
        Languages.English.Heroes.EN_Bastion EN;
        string myLang;

        L_Bastion(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Bastion();
        }

        public string ChangeLang
        {
            get
            {
                return myLang;
            }
            set
            {
                myLang = value;
            }
        }


        //Skins
        //Rare
        public string B1_Dawn_SK
        {
            get
            {
                //else
                {
                    return EN.Dawn_SK;
                }
            }
        }

        public string B1_Meadow_SK
        {
            get
            {
                //else
                {
                    return EN.Meadow_SK;
                }
            }
        }

        public string B1_Sky_SK
        {
            get
            {
                //else
                {
                    return EN.Sky_SK;
                }
            }
        }

        public string B1_Soot_SK
        {
            get
            {
                //else
                {
                    return EN.Soot_SK;
                }
            }
        }
        //Epic
        public string B1_Defense_Matrix_SK
        {
            get
            {
                //else
                {
                    return EN.Defense_Matrix_SK;
                }
            }
        }

        public string B1_Omnic_Crisis_SK
        {
            get
            {
                //else
                {
                    return EN.Omnic_Crisis_SK;
                }
            }
        }

        public string B1_BlizzCon_2016_SK
        {//BlizzCon 2016
            get
            {
                //else
                {
                    return EN.BlizzCon_2016_SK;
                }
            }
        }

        public string B1_Tombstone_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Tombstone_SK;
                }
            }
        }

        public string B1_Rooster_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Rooster_SK;
                }
            }
        }

        public string B1_Null_Sector_SK
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Null_Sector_SK;
                }
            }
        }
        //Legendary
        public string B1_Antique_SK
        {
            get
            {
                //else
                {
                    return EN.Antique_SK;
                }
            }
        }

        public string B1_Woodbot_SK
        {
            get
            {
                //else
                {
                    return EN.Woodbot_SK;
                }
            }
        }

        public string B1_Gearbot_SK
        {
            get
            {
                //else
                {
                    return EN.Gearbot_SK;
                }
            }
        }

        public string B1_Steambot_SK
        {
            get
            {
                //else
                {
                    return EN.Steambot_SK;
                }
            }
        }

        public string B1_Overgrown_SK
        {//Origin Special
            get
            {
                //else
                {
                    return EN.Overgrown_SK;
                }
            }
        }

        public string B1_Dune_Buggy_SK
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Dune_Buggy_SK;
                }
            }
        }


        //Emotes
        //Rare
        public string B1_Alert_Alert_EM
        {
            get
            {
                //else
                {
                    return EN.Alert_Alert_EM;
                }
            }
        }

        public string B1_Chortle_EM
        {
            get
            {
                //else
                {
                    return EN.Chortle_EM;
                }
            }
        }

        public string B1_Dizzy_EM
        {
            get
            {
                //else
                {
                    return EN.Dizzy_EM;
                }
            }
        }

        public string B1_Rest_Mode_EM
        {
            get
            {
                //else
                {
                    return EN.Rest_Mode_EM;
                }
            }
        }

        public string B1_Robot_EM
        {
            get
            {
                //else
                {
                    return EN.Robot_EM;
                }
            }
        }

        public string B1_Boxing_EM
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Boxing_EM;
                }
            }
        }

        public string B1_Robo_Boogie_EM
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Robo_Boogie_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string B1_Birdwatching_VP
        {
            get
            {
                //else
                {
                    return EN.Birdwatching_VP;
                }
            }
        }

        public string B1_Pop_up_VP
        {
            get
            {
                //else
                {
                    return EN.Pop_up_VP;
                }
            }
        }

        public string B1_Tank_EM
        {
            get
            {
                //else
                {
                    return EN.Tank_EM;
                }
            }
        }

        public string B1_Medal_VP
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Medal_VP;
                }
            }
        }

        public string B1_RIP_VP
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string B1_Firework_VP
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Firework_VP;
                }
            }
        }


        //Voice Lines
        //Common
        public string B1_Doo_Woo_VL
        {
            get
            {
                //else
                {
                    return EN.Doo_Woo_VL;
                }
            }
        }

        public string B1_Beeple_VL
        {
            get
            {
                //else
                {
                    return EN.Beeple_VL;
                }
            }
        }

        public string B1_Boo_Boo_Doo_De_Doo_VL
        {
            get
            {
                //else
                {
                    return EN.Boo_Boo_Doo_De_Doo_VL;
                }
            }
        }

        public string B1_Bweeeeeeeeeee_VL
        {
            get
            {
                //else
                {
                    return EN.Bweeeeeeeeeee_VL;
                }
            }
        }

        public string B1_Chirr_Chirr_Chirr_VL
        {
            get
            {
                //else
                {
                    return EN.Chirr_Chirr_Chirr_VL;
                }
            }
        }

        public string B1_Dah_Dah_Weeeee
        {
            get
            {
                //else
                {
                    return EN.Dah_Dah_Weeeee;
                }
            }
        }

        public string B1_Dun_Dun_Boop_Boop_VL
        {
            get
            {
                //else
                {
                    return EN.Dun_Dun_Boop_Boop_VL;
                }
            }
        }

        public string B1_Dweet_Dweet_Dweet_VL
        {
            get
            {
                //else
                {
                    return EN.Dweet_Dweet_Dweet_VL;
                }
            }
        }

        public string B1_Hee_Hoo_Hoo_VL
        {
            get
            {
                //else
                {
                    return EN.Hee_Hoo_Hoo_VL;
                }
            }
        }

        public string B1_Sh_Sh_Sh_VL
        {
            get
            {
                //else
                {
                    return EN.Sh_Sh_Sh_VL;
                }
            }
        }

        public string B1_Zwee_VL
        {
            get
            {
                //else
                {
                    return EN.Zwee_VL;
                }
            }
        }

        public string B1_Doo_Do_Doo_Dee_VL
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Doo_Do_Doo_Dee_VL;
                }
            }
        }

        public string B1_Whoo_Vweeeeee_VL
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Whoo_Vweeeeee_VL;
                }
            }
        }

        public string Oooooooooooo_VL
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Oooooooooooo_VL;
                }
            }
        }

        public string B1_W_W_Wooooo_VL
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.W_W_Wooooo_VL;
                }
            }
        }

        public string B1_Dwee_Doo_Hoo_VL
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Dwee_Doo_Hoo_VL;
                }
            }
        }

        public string B1_Woop_Doo_Woo_Dun_Woop_VL
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Woop_Doo_Woo_Dun_Woop_VL;
                }
            }
        }

        public string B1_Dwee_Wee_Woh_VL
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Dwee_Doo_Hoo_VL;
                }
            }
        }

        public string B1_Zwee_Ah_Wheee_Doo_Woo_VL
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Zwee_Ah_Wheee_Doo_Woo_VL;
                }
            }
        }

        public string B1_Bew_Woo_Bew_Woo_VL
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Bew_Woo_Bew_Woo_VL;
                }
            }
        }

        public string B1_Doo_Dun_Dun_Woo_VL
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Doo_Dun_Dun_Woo_VL;
                }
            }
        }


        //Sprays
    }
}
