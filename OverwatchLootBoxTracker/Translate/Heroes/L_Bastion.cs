using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Bastion : PictureBox
    {
        Languages.English.Heroes.Bastion EN;
        Languages.German.Heroes.Bastion DE;
        Translate.L_Translate Translate;
        CCost Costs;
        string myLang;
        string[] LangAndCost;

        public L_Bastion(string Lang)
        {
            if (Lang != "")
            {
                myLang = Lang;
            }

            Costs = new CCost();
            EN = new Languages.English.Heroes.Bastion();
            DE = new Languages.German.Heroes.Bastion();
            Translate = new Translate.L_Translate(Lang);

            LangAndCost = new string[3];

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Bastion_link.png");
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

        public string GetName()
        {
            if (myLang == "DE")
            {
                return DE.Name;
            }
            else
            {
                return EN.Name;
            }
        }


        //Skins
        //Rare
        public string[] Dawn_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0]= DE.Dawn_SK;
                }
                else
                {
                    LangAndCost[0]= EN.Dawn_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Meadow_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0]= DE.Meadow_SK;
                }
                else
                {
                    LangAndCost[0]= EN.Meadow_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Sky_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Sky_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Sky_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Soot_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Soot_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Soot_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }
        //Epic
        public string[] Defense_Matrix_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Defense_Matrix_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Defense_Matrix_SK;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                LangAndCost[2] = Translate.Epic;
                return LangAndCost;
            }
        }

        public string[] Omnic_Crisis_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Omnic_Crisis_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Omnic_Crisis_SK;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                LangAndCost[2] = Translate.Epic;
                return LangAndCost;
            }
        }

        public string[] BlizzCon_2016_SK//7
        {//BlizzCon 16
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.BlizzCon_2016_SK;
                }
                else
                {
                    LangAndCost[0] = EN.BlizzCon_2016_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Tombstone_SK//8
        {//Halloween 16
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Tombstone_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Tombstone_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Gift_Wrap_SK//8
        {//Winter 18
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Tombstone_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Gift_Wrap_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Rooster_SK//9
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Rooster_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Rooster_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Null_Sector_SK//10
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Null_Sector_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Null_Sector_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }
        //Legendary
        public string[] Antique_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Antique_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Antique_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Woodbot_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Woodbot_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Woodbot_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Gearbot_SK//13
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Gearbot_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Gearbot_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Steambot_SK//14
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Steambot_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Steambot_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Overgrown_SK//15
        {//Origin Special
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Overgrown_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Overgrown_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Dune_Buggy_SK//16
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Dune_Buggy_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Dune_Buggy_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Avalanche_SK//17
        {//Winter 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Avalanche_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Avalanche_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] Gwishin_SK//17
        {//Archiv 18
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Avalanche_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Gwishin_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }

        public string[] STEALTH_SK//18
        {//Annyver 18
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.STEALTH_SK;
                }
                else
                {
                    LangAndCost[0] = EN.STEALTH_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                LangAndCost[2] = Translate.Rare;
                return LangAndCost;
            }
        }


        //Emotes
        //Rare
        public string Alert_Alert_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Alert_Alert_EM;
                }
                else
                {
                    return EN.Alert_Alert_EM;
                }
            }
        }

        public string Chortle_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Chortle_EM;
                }
                else
                {
                    return EN.Chortle_EM;
                }
            }
        }

        public string Dizzy_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dizzy_EM;
                }
                else
                {
                    return EN.Dizzy_EM;
                }
            }
        }

        public string Rest_Mode_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Rest_Mode_EM;
                }
                else
                {
                    return EN.Rest_Mode_EM;
                }
            }
        }

        public string Robot_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Robot_EM;
                }
                else
                {
                    return EN.Robot_EM;
                }
            }
        }

        public string Boxing_EM//6
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Boxing_EM;
                }
                else
                {
                    return EN.Boxing_EM;
                }
            }
        }

        public string Robo_Boogie_EM//7
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Robo_Boogie_EM;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Birdwatching_VP;
                }
                else
                {
                    return EN.Birdwatching_VP;
                }
            }
        }

        public string Pop_up_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Pop_up_VP;
                }
                else
                {
                    return EN.Pop_up_VP;
                }
            }
        }

        public string Tank_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Tank_EM;
                }
                else
                {
                    return EN.Tank_EM;
                }
            }
        }

        public string Medal_VP//4
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Medal_VP;
                }
                else
                {
                    return EN.Medal_VP;
                }
            }
        }

        public string RIP_VP//5
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.RIP_VP;
                }
                else
                {
                    return EN.RIP_VP;
                }
            }
        }

        public string Toast_VP//5
        {//Winter 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Toast_VP;
                }
                else
                {
                    return EN.Toast_VP;
                }
            }
        }

        public string Firework_VP//6
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Firework_VP;
                }
                else
                {
                    return EN.Firework_VP;
                }
            }
        }


        //Voice Lines
        //Common
        public string Doo_Woo_VL//0
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Doo_Woo_VL;
                }
                else
                {
                    return EN.Doo_Woo_VL;
                }
            }
        }

        public string Beeple_VL//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Beeple_VL;
                }
                else
                {
                    return EN.Beeple_VL;
                }
            }
        }

        public string Boo_Boo_Doo_De_Doo_VL//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Boo_Boo_Doo_De_Doo_VL;
                }
                else
                {
                    return EN.Boo_Boo_Doo_De_Doo_VL;
                }
            }
        }

        public string Bweeeeeeeeeee_VL//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bweeeeeeeeeee_VL;
                }
                else
                {
                    return EN.Bweeeeeeeeeee_VL;
                }
            }
        }

        public string Chirr_Chirr_Chirr_VL//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Chirr_Chirr_Chirr_VL;
                }
                else
                {
                    return EN.Chirr_Chirr_Chirr_VL;
                }
            }
        }

        public string Dah_Dah_Weeeee_VL//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dah_Dah_Weeeee_VL;
                }
                else
                {
                    return EN.Dah_Dah_Weeeee_VL;
                }
            }
        }

        public string Dun_Dun_Boop_Boop_VL//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dun_Dun_Boop_Boop_VL;
                }
                else
                {
                    return EN.Dun_Dun_Boop_Boop_VL;
                }
            }
        }

        public string Dweet_Dweet_Dweet_VL//7
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dweet_Dweet_Dweet_VL;
                }
                else
                {
                    return EN.Dweet_Dweet_Dweet_VL;
                }
            }
        }

        public string Hee_Hoo_Hoo_VL//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Hee_Hoo_Hoo_VL;
                }
                else
                {
                    return EN.Hee_Hoo_Hoo_VL;
                }
            }
        }

        public string Ooh_ooo_hoo_hoo_VL//09
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ooh_ooo_hoo_hoo_VL;
                }
                else
                {
                    return EN.Ooh_ooo_hoo_hoo_VL;
                }
            }
        }

        public string Sh_Sh_Sh_VL//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sh_Sh_Sh_VL;
                }
                else
                {
                    return EN.Sh_Sh_Sh_VL;
                }
            }
        }

        public string Zwee_VL//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Zwee_VL;
                }
                else
                {
                    return EN.Zwee_VL;
                }
            }
        }

        public string Doo_Do_Doo_Dee_VL//12
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Doo_Do_Doo_Dee_VL;
                }
                else
                {
                    return EN.Doo_Do_Doo_Dee_VL;
                }
            }
        }

        public string Whoo_Vweeeeee_VL//13
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Whoo_Vweeeeee_VL;
                }
                else
                {
                    return EN.Whoo_Vweeeeee_VL;
                }
            }
        }

        public string Oooooooooooo_VL//14
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Oooooooooooo_VL;
                }
                else
                {
                    return EN.Oooooooooooo_VL;
                }
            }
        }

        public string W_W_Wooooo_VL//15
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.W_W_Wooooo_VL;
                }
                else
                {
                    return EN.W_W_Wooooo_VL;
                }
            }
        }

        public string Dwee_Doo_Hoo_VL//16
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dwee_Doo_Hoo_VL;
                }
                else
                {
                    return EN.Dwee_Doo_Hoo_VL;
                }
            }
        }

        public string Woop_Doo_Woo_Dun_Woop_VL//17
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Woop_Doo_Woo_Dun_Woop_VL;
                }
                else
                {
                    return EN.Woop_Doo_Woo_Dun_Woop_VL;
                }
            }
        }

        public string Dwee_Wee_Woh_VL//18
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dwee_Doo_Hoo_VL;
                }
                else
                {
                    return EN.Dwee_Doo_Hoo_VL;
                }
            }
        }

        public string Zwee_Ah_Wheee_Doo_Woo_VL//19
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Zwee_Ah_Wheee_Doo_Woo_VL;
                }
                else
                {
                    return EN.Zwee_Ah_Wheee_Doo_Woo_VL;
                }
            }
        }

        public string Bew_Woo_Bew_Woo_VL//20
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bew_Woo_Bew_Woo_VL;
                }
                else
                {
                    return EN.Bew_Woo_Bew_Woo_VL;
                }
            }
        }

        public string Doo_Dun_Dun_Woo_VL//21
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Doo_Dun_Dun_Woo_VL;
                }
                else
                {
                    return EN.Doo_Dun_Dun_Woo_VL;
                }
            }
        }

        public string Bwoo_Bwoo_Bwoo_VL//22
        {//Winter 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dwee_Doo_Hoo_VL;
                }
                else
                {
                    return EN.Bwoo_Bwoo_Bwoo_VL;
                }
            }
        }


        //Sprays
    }
}
