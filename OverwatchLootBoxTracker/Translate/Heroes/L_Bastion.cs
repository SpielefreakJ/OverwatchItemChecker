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

        public string Name
        {
            get
            {
                //else
                {
                    return EN.Name;
                }
            }
        }


        //Skins
        //Rare
        public string Dawn_SK//1
        {
            get
            {
                //else
                {
                    return EN.Dawn_SK;
                }
            }
        }

        public string Meadow_SK//2
        {
            get
            {
                //else
                {
                    return EN.Meadow_SK;
                }
            }
        }

        public string Sky_SK//3
        {
            get
            {
                //else
                {
                    return EN.Sky_SK;
                }
            }
        }

        public string Soot_SK//4
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
        public string Defense_Matrix_SK//5
        {
            get
            {
                //else
                {
                    return EN.Defense_Matrix_SK;
                }
            }
        }

        public string Omnic_Crisis_SK//6
        {
            get
            {
                //else
                {
                    return EN.Omnic_Crisis_SK;
                }
            }
        }

        public string BlizzCon_2016_SK//7
        {//BlizzCon 2016
            get
            {
                //else
                {
                    return EN.BlizzCon_2016_SK;
                }
            }
        }

        public string Tombstone_SK//8
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Tombstone_SK;
                }
            }
        }

        public string Rooster_SK//9
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Rooster_SK;
                }
            }
        }

        public string Null_Sector_SK//10
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
        public string Antique_SK//11
        {
            get
            {
                //else
                {
                    return EN.Antique_SK;
                }
            }
        }

        public string Woodbot_SK//12
        {
            get
            {
                //else
                {
                    return EN.Woodbot_SK;
                }
            }
        }

        public string Gearbot_SK//13
        {
            get
            {
                //else
                {
                    return EN.Gearbot_SK;
                }
            }
        }

        public string Steambot_SK//14
        {
            get
            {
                //else
                {
                    return EN.Steambot_SK;
                }
            }
        }

        public string Overgrown_SK//15
        {//Origin Special
            get
            {
                //else
                {
                    return EN.Overgrown_SK;
                }
            }
        }

        public string Dune_Buggy_SK//16
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
        public string Alert_Alert_EM//1
        {
            get
            {
                //else
                {
                    return EN.Alert_Alert_EM;
                }
            }
        }

        public string Chortle_EM//2
        {
            get
            {
                //else
                {
                    return EN.Chortle_EM;
                }
            }
        }

        public string Dizzy_EM//3
        {
            get
            {
                //else
                {
                    return EN.Dizzy_EM;
                }
            }
        }

        public string Rest_Mode_EM//4
        {
            get
            {
                //else
                {
                    return EN.Rest_Mode_EM;
                }
            }
        }

        public string Robot_EM//5
        {
            get
            {
                //else
                {
                    return EN.Robot_EM;
                }
            }
        }

        public string Boxing_EM//6
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Boxing_EM;
                }
            }
        }

        public string Robo_Boogie_EM//7
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
        public string Birdwatching_VP//1
        {
            get
            {
                //else
                {
                    return EN.Birdwatching_VP;
                }
            }
        }

        public string Pop_up_VP//2
        {
            get
            {
                //else
                {
                    return EN.Pop_up_VP;
                }
            }
        }

        public string Tank_EM//3
        {
            get
            {
                //else
                {
                    return EN.Tank_EM;
                }
            }
        }

        public string Medal_VP//4
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Medal_VP;
                }
            }
        }

        public string RIP_VP//5
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string Firework_VP//6
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
        public string Doo_Woo_VL//1
        {
            get
            {
                //else
                {
                    return EN.Doo_Woo_VL;
                }
            }
        }

        public string Beeple_VL//2
        {
            get
            {
                //else
                {
                    return EN.Beeple_VL;
                }
            }
        }

        public string Boo_Boo_Doo_De_Doo_VL//3
        {
            get
            {
                //else
                {
                    return EN.Boo_Boo_Doo_De_Doo_VL;
                }
            }
        }

        public string Bweeeeeeeeeee_VL//4
        {
            get
            {
                //else
                {
                    return EN.Bweeeeeeeeeee_VL;
                }
            }
        }

        public string Chirr_Chirr_Chirr_VL//5
        {
            get
            {
                //else
                {
                    return EN.Chirr_Chirr_Chirr_VL;
                }
            }
        }

        public string Dah_Dah_Weeeee//6
        {
            get
            {
                //else
                {
                    return EN.Dah_Dah_Weeeee;
                }
            }
        }

        public string Dun_Dun_Boop_Boop_VL//7
        {
            get
            {
                //else
                {
                    return EN.Dun_Dun_Boop_Boop_VL;
                }
            }
        }

        public string Dweet_Dweet_Dweet_VL//8
        {
            get
            {
                //else
                {
                    return EN.Dweet_Dweet_Dweet_VL;
                }
            }
        }

        public string Hee_Hoo_Hoo_VL//9
        {
            get
            {
                //else
                {
                    return EN.Hee_Hoo_Hoo_VL;
                }
            }
        }

        public string Sh_Sh_Sh_VL//10
        {
            get
            {
                //else
                {
                    return EN.Sh_Sh_Sh_VL;
                }
            }
        }

        public string Zwee_VL//11
        {
            get
            {
                //else
                {
                    return EN.Zwee_VL;
                }
            }
        }

        public string Doo_Do_Doo_Dee_VL//12
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Doo_Do_Doo_Dee_VL;
                }
            }
        }

        public string Whoo_Vweeeeee_VL//13
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Whoo_Vweeeeee_VL;
                }
            }
        }

        public string Oooooooooooo_VL//14
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Oooooooooooo_VL;
                }
            }
        }

        public string W_W_Wooooo_VL//15
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.W_W_Wooooo_VL;
                }
            }
        }

        public string Dwee_Doo_Hoo_VL//16
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Dwee_Doo_Hoo_VL;
                }
            }
        }

        public string Woop_Doo_Woo_Dun_Woop_VL//17
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Woop_Doo_Woo_Dun_Woop_VL;
                }
            }
        }

        public string Dwee_Wee_Woh_VL//18
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Dwee_Doo_Hoo_VL;
                }
            }
        }

        public string Zwee_Ah_Wheee_Doo_Woo_VL//19
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Zwee_Ah_Wheee_Doo_Woo_VL;
                }
            }
        }

        public string Bew_Woo_Bew_Woo_VL//20
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Bew_Woo_Bew_Woo_VL;
                }
            }
        }

        public string Doo_Dun_Dun_Woo_VL//21
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
