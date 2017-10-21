using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Bastion
    {
        Languages.English.Heroes.EN_Bastion EN;
        string myLang;

        public L_Bastion(string Lang)
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
        public string Dawn_SK
        {
            get
            {
                //else
                {
                    return EN.Dawn_SK;
                }
            }
        }

        public string Meadow_SK
        {
            get
            {
                //else
                {
                    return EN.Meadow_SK;
                }
            }
        }

        public string Sky_SK
        {
            get
            {
                //else
                {
                    return EN.Sky_SK;
                }
            }
        }

        public string Soot_SK
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
        public string Defense_Matrix_SK
        {
            get
            {
                //else
                {
                    return EN.Defense_Matrix_SK;
                }
            }
        }

        public string Omnic_Crisis_SK
        {
            get
            {
                //else
                {
                    return EN.Omnic_Crisis_SK;
                }
            }
        }

        public string BlizzCon_2016_SK
        {//BlizzCon 2016
            get
            {
                //else
                {
                    return EN.BlizzCon_2016_SK;
                }
            }
        }

        public string Tombstone_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Tombstone_SK;
                }
            }
        }

        public string Rooster_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Rooster_SK;
                }
            }
        }

        public string Null_Sector_SK
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
        public string Antique_SK
        {
            get
            {
                //else
                {
                    return EN.Antique_SK;
                }
            }
        }

        public string Woodbot_SK
        {
            get
            {
                //else
                {
                    return EN.Woodbot_SK;
                }
            }
        }

        public string Gearbot_SK
        {
            get
            {
                //else
                {
                    return EN.Gearbot_SK;
                }
            }
        }

        public string Steambot_SK
        {
            get
            {
                //else
                {
                    return EN.Steambot_SK;
                }
            }
        }

        public string Overgrown_SK
        {//Origin Special
            get
            {
                //else
                {
                    return EN.Overgrown_SK;
                }
            }
        }

        public string Dune_Buggy_SK
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
        public string Alert_Alert_EM
        {
            get
            {
                //else
                {
                    return EN.Alert_Alert_EM;
                }
            }
        }

        public string Chortle_EM
        {
            get
            {
                //else
                {
                    return EN.Chortle_EM;
                }
            }
        }

        public string Dizzy_EM
        {
            get
            {
                //else
                {
                    return EN.Dizzy_EM;
                }
            }
        }

        public string Rest_Mode_EM
        {
            get
            {
                //else
                {
                    return EN.Rest_Mode_EM;
                }
            }
        }

        public string Robot_EM
        {
            get
            {
                //else
                {
                    return EN.Robot_EM;
                }
            }
        }

        public string Boxing_EM
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Boxing_EM;
                }
            }
        }

        public string Robo_Boogie_EM
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
        public string Birdwatching_VP
        {
            get
            {
                //else
                {
                    return EN.Birdwatching_VP;
                }
            }
        }

        public string Pop_up_VP
        {
            get
            {
                //else
                {
                    return EN.Pop_up_VP;
                }
            }
        }

        public string Tank_EM
        {
            get
            {
                //else
                {
                    return EN.Tank_EM;
                }
            }
        }

        public string Medal_VP
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Medal_VP;
                }
            }
        }

        public string RIP_VP
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string Firework_VP
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
        public string Doo_Woo_VL
        {
            get
            {
                //else
                {
                    return EN.Doo_Woo_VL;
                }
            }
        }

        public string Beeple_VL
        {
            get
            {
                //else
                {
                    return EN.Beeple_VL;
                }
            }
        }

        public string Boo_Boo_Doo_De_Doo_VL
        {
            get
            {
                //else
                {
                    return EN.Boo_Boo_Doo_De_Doo_VL;
                }
            }
        }

        public string Bweeeeeeeeeee_VL
        {
            get
            {
                //else
                {
                    return EN.Bweeeeeeeeeee_VL;
                }
            }
        }

        public string Chirr_Chirr_Chirr_VL
        {
            get
            {
                //else
                {
                    return EN.Chirr_Chirr_Chirr_VL;
                }
            }
        }

        public string Dah_Dah_Weeeee
        {
            get
            {
                //else
                {
                    return EN.Dah_Dah_Weeeee;
                }
            }
        }

        public string Dun_Dun_Boop_Boop_VL
        {
            get
            {
                //else
                {
                    return EN.Dun_Dun_Boop_Boop_VL;
                }
            }
        }

        public string Dweet_Dweet_Dweet_VL
        {
            get
            {
                //else
                {
                    return EN.Dweet_Dweet_Dweet_VL;
                }
            }
        }

        public string Hee_Hoo_Hoo_VL
        {
            get
            {
                //else
                {
                    return EN.Hee_Hoo_Hoo_VL;
                }
            }
        }

        public string Sh_Sh_Sh_VL
        {
            get
            {
                //else
                {
                    return EN.Sh_Sh_Sh_VL;
                }
            }
        }

        public string Zwee_VL
        {
            get
            {
                //else
                {
                    return EN.Zwee_VL;
                }
            }
        }

        public string Doo_Do_Doo_Dee_VL
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Doo_Do_Doo_Dee_VL;
                }
            }
        }

        public string Whoo_Vweeeeee_VL
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

        public string W_W_Wooooo_VL
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.W_W_Wooooo_VL;
                }
            }
        }

        public string Dwee_Doo_Hoo_VL
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Dwee_Doo_Hoo_VL;
                }
            }
        }

        public string Woop_Doo_Woo_Dun_Woop_VL
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Woop_Doo_Woo_Dun_Woop_VL;
                }
            }
        }

        public string Dwee_Wee_Woh_VL
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Dwee_Doo_Hoo_VL;
                }
            }
        }

        public string Zwee_Ah_Wheee_Doo_Woo_VL
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Zwee_Ah_Wheee_Doo_Woo_VL;
                }
            }
        }

        public string Bew_Woo_Bew_Woo_VL
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Bew_Woo_Bew_Woo_VL;
                }
            }
        }

        public string Doo_Dun_Dun_Woo_VL
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
