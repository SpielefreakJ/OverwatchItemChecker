using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Ana : PictureBox
    {
        Languages.English.Heroes.Ana EN;
        Languages.German.Heroes.Ana DE;
        CCost Costs;
        string myLang;
        string[] LangAndCost;

        public L_Ana(string Lang)
        {
            if (Lang != "")
            {
                myLang = Lang;
            }

            Costs = new CCost();
            EN = new Languages.English.Heroes.Ana();
            DE = new Languages.German.Heroes.Ana();

            LangAndCost = new string[2];

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Ana_link.png");
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
        public string[] Citrine_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Citrine_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Citrine_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                return LangAndCost;
            }
        }

        public string[] Garnet_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Garnet_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Garnet_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                return LangAndCost;
            }
        }

        public string[] Peridot_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Peridot_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Peridot_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                return LangAndCost;
            }
        }

        public string[] Turquoise_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Turquoise_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Turquoise_SK;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                return LangAndCost;
            }
        }

        //Epic
        public string[] Merciful_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Merciful_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Merciful_SK;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Shrike_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Shrike_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Shrike_SK;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Ghoul_SK//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Ghoul_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Ghoul_SK;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Tal_SK//8
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Tal_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Tal_SK;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        //Legendary
        public string[] Wadjet_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Wadjet_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Wadjet_SK;
                }
                LangAndCost[1] = Costs.Legendary.ToString();
                return LangAndCost;
            }
        }

        public string[] Wasteland_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Wasteland_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Wasteland_SK;
                }
                LangAndCost[1] = Costs.Legendary.ToString();
                return LangAndCost;
            }
        }

        public string[] Captain_Amari_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Captain_Amari_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Captain_Amari_SK;
                }
                LangAndCost[1] = Costs.Legendary.ToString();
                return LangAndCost;
            }
        }

        public string[] Horus_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Horus_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Horus_SK;
                }
                LangAndCost[1] = Costs.Legendary.ToString();
                return LangAndCost;
            }
        }

        public string[] Corsair_SK//13
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Corsair_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Corsair_SK;
                }
                LangAndCost[1] = Costs.Legendary.ToString();
                return LangAndCost;
            }
        }

        public string[] Snow_Owl_SK//14
        {//Winter 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Snow_Owl_SK;
                }
                else
                {
                    LangAndCost[0] = EN.Snow_Owl_SK;
                }
                LangAndCost[1] = Costs.LegendaryEvent.ToString();
                return LangAndCost;
            }
        }


        //Emotes
        //Epic
        public string[] Not_Impressed_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Not_Impressed_EM;
                }
                else
                {
                    LangAndCost[0] = EN.Not_Impressed_EM;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Disapproving_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Disapproving_EM;
                }
                else
                {
                    LangAndCost[0] = EN.Disapproving_EM;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Protector_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Protector_EM;
                }
                else
                {
                    LangAndCost[0] = EN.Protector_EM;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Take_A_Knee_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Take_A_Knee_EM;
                }
                else
                {
                    LangAndCost[0] = EN.Take_A_Knee_EM;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Tea_Time_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Tea_Time_EM;
                }
                else
                {
                    LangAndCost[0] = EN.Tea_Time_EM;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Beach_Ball_EM//6
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Beach_Ball_EM;
                }
                else
                {
                    LangAndCost[0] = EN.Beach_Ball_EM;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Candy_EM//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Candy_EM;
                }
                else
                {
                    LangAndCost[0] = EN.Candy_EM;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Dance_EM//8
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Dance_EM;
                }
                else
                {
                    LangAndCost[0] = EN.Dance_EM;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }


        //Victory Poses
        //Rare
        public string[] Mission_Complete_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Mission_Complete_VP;
                }
                else
                {
                    LangAndCost[0] = EN.Mission_Complete_VP;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                return LangAndCost;
            }
        }

        public string[] Protector_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Protector_VP;
                }
                else
                {
                    LangAndCost[0] = EN.Protector_VP;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                return LangAndCost;
            }
        }

        public string[] Seated_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Seated_VP;
                }
                else
                {
                    LangAndCost[0] = EN.Seated_VP;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                return LangAndCost;
            }
        }

        public string[] RIP_VP//4
        {//Halloween 16
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.RIP_VP;
                }
                else
                {
                    LangAndCost[0] = EN.RIP_VP;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                return LangAndCost;
            }
        }

        public string[] Toast_VP//5
        {//Winter 16
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Toast_VP;
                }
                else
                {
                    LangAndCost[0] = EN.Toast_VP;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                return LangAndCost;
            }
        }

        public string[] Folded_Hands_VP//6
        {//Rooster 17
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Folded_Hands_VP;
                }
                else
                {
                    LangAndCost[0] = EN.Folded_Hands_VP;
                }
                LangAndCost[1] = Costs.Rare.ToString();
                return LangAndCost;
            }
        }


        //Voice Lines
        //Common
        public string[] Justice_Delivered_VL//1
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Justice_Delivered_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Justice_Delivered_VL;
                }
                LangAndCost[1] = Costs.Classic.ToString();
                return LangAndCost;
            }
        }

        public string[] Children_behave_VL//2
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Children_behave_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Children_behave_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Everyone_dies_VL//3
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Everyone_dies_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Everyone_dies_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Go_on_i_can_wait_VL//3
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Go_on_i_can_wait_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Go_on_i_can_wait_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] It_takes_a_woman_to_know_VL//4
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.It_takes_a_woman_to_know_VL;
                }
                else
                {
                    LangAndCost[0] = EN.It_takes_a_woman_to_know_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Justice_rains_from_above_VL//5
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Justice_rains_from_above_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Justice_rains_from_above_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Mother_knows_best_VL//6
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Mother_knows_best_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Mother_knows_best_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] No_scope_needed_VL//7
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.No_scope_needed_VL;
                }
                else
                {
                    LangAndCost[0] = EN.No_scope_needed_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] What_are_you_thinking_VL//8
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.What_are_you_thinking_VL;
                }
                else
                {
                    LangAndCost[0] = EN.What_are_you_thinking_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Witness_me_VL//9
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Witness_me_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Witness_me_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] You_know_nothing_VL//10
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.You_know_nothing_VL;
                }
                else
                {
                    LangAndCost[0] = EN.You_know_nothing_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Someone_to_tuck_you_in_VL//11
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Someone_to_tuck_you_in_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Someone_to_tuck_you_in_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Better_than_retirement_VL//12
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Better_than_retirement_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Better_than_retirement_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Learn_from_the_pain_VL//13
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Learn_from_the_pain_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Learn_from_the_pain_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Are_you_scared_VL//14
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Are_you_scared_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Are_you_scared_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Dont_be_scared_VL//15
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Dont_be_scared_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Dont_be_scared_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Im_watching_out_for_you_VL//16
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Im_watching_out_for_you_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Im_watching_out_for_you_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] The_Moon_in_Winter_VL//17
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.The_Moon_in_Winter_VL;
                }
                else
                {
                    LangAndCost[0] = EN.The_Moon_in_Winter_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Damn_VL//18
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Damn_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Damn_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] The_Ghost_watches_VL//19
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.The_Ghost_watches_VL;
                }
                else
                {
                    LangAndCost[0] = EN.The_Ghost_watches_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Follow_me_VL//20
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Follow_me_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Follow_me_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] The_adults_are_talking_VL//21
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.The_adults_are_talking_VL;
                }
                else
                {
                    LangAndCost[0] = EN.The_adults_are_talking_VL;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Im_too_old_for_surprises_VL//22
        {//Winter 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Im_too_old_for_surprises_VL;
                }
                else
                {
                    LangAndCost[0] = EN.Im_too_old_for_surprises_VL;
                }
                LangAndCost[1] = Costs.CommonEvent.ToString();
                return LangAndCost;
            }
        }


        //Sprays
        //Common
        public string[] Action_SP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Action_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Action_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Ana_SP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Ana_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Ana_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Bearer_SP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Bearer_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Bearer_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Cheer_SP//4
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Cheer_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Cheer_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Cracked_SP//5
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Cracked_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Cracked_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Cute_SP//6
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Cute_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Cute_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Eyepatch_SP//7
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Eyepatch_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Eyepatch_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Fareeha_SP//8
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Fareeha_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Fareeha_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Gaze_SP//9
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Gaze_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Gaze_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Grenade_SP//10
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Grenade_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Grenade_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Guardian_SP//11
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Guardian_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Guardian_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Hesitation_SP//12
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Hesitation_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Hesitation_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Icon_SP//13
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Icon_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Icon_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Letter_SP//14
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Letter_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Letter_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Old_Soldier_SP//15
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Old_Soldier_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Old_Soldier_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Overhead_SP//16
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Overhead_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Overhead_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Pillow_SP//17
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Pillow_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Pillow_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Photograph_SP//18
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Photograph_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Photograph_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Pixel_SP//19
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Pixel_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Pixel_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Rifle_SP//20
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Rifle_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Rifle_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Shadow_SP//21
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Shadow_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Shadow_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Shhh_SP//22
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Shhh_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Shhh_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Sidearm_SP//23
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Sidearm_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Sidearm_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Wasteland_SP//23
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Wasteland_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Wasteland_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Wedjat_SP//24
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Wedjat_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Wedjat_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Wrist_Launcher_SP//25
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Wrist_Launcher_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Wrist_Launcher_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Zzz_SP//26
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Zzz_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Zzz_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Shooting_SP//27
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Shooting_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Shooting_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Trick_or_Treat_SP//28
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Trick_or_Treat_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Trick_or_Treat_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Ornament_SP//29
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Ornament_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Ornament_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Warm_SP//30
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Warm_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Warm_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Dance_SP//31
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Dance_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Dance_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Dragon_Dance_SP//32
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Dragon_Dance_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Dragon_Dance_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Newborn_SP//33
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Newborn_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Newborn_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }

        public string[] Ace_of_Hearts_SP//34
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Ace_of_Hearts_SP;
                }
                else
                {
                    LangAndCost[0] = EN.Ace_of_Hearts_SP;
                }
                LangAndCost[1] = Costs.Common.ToString();
                return LangAndCost;
            }
        }


        //Highlight Intros
        //Epic
        public string[] Guardian_HI//1
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Guardian_HI;
                }
                else
                {
                    LangAndCost[0] = EN.Guardian_HI;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Locked_on_HI//2
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Locked_on_HI;
                }
                else
                {
                    LangAndCost[0] = EN.Locked_on_HI;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Shh_HI//3
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Shh_HI;
                }
                else
                {
                    LangAndCost[0] = EN.Shh_HI;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }

        public string[] Under_Fire_HI//3
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Under_Fire_HI;
                }
                else
                {
                    LangAndCost[0] = EN.Under_Fire_HI;
                }
                LangAndCost[1] = Costs.Epic.ToString();
                return LangAndCost;
            }
        }


        //Player Icons
        //Rare
        public string[] Ana_PI//1
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Ana_PI;
                }
                else
                {
                    LangAndCost[0] = EN.Ana_PI;
                }
                LangAndCost[1] = Costs.Unknown.ToString();
                return LangAndCost;
            }
        }

        public string[] Cute_Ana_PI//7
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Cute_Ana_PI;
                }
                else
                {
                    LangAndCost[0] = EN.Cute_Ana_PI;
                }
                LangAndCost[1] = Costs.Unknown.ToString();
                return LangAndCost;
            }
        }

        public string[] Watcher_PI//2
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Watcher_PI;
                }
                else
                {
                    LangAndCost[0] = EN.Watcher_PI;
                }
                LangAndCost[1] = Costs.Unknown.ToString();
                return LangAndCost;
            }
        }

        public string[] Wedjat_PI//3
        {
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Wedjat_PI;
                }
                else
                {
                    LangAndCost[0] = EN.Wedjat_PI;
                }
                LangAndCost[1] = Costs.Unknown.ToString();
                return LangAndCost;
            }
        }

        public string[] Shooting_PI//4
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Shooting_PI;
                }
                else
                {
                    LangAndCost[0] = EN.Shooting_PI;
                }
                LangAndCost[1] = Costs.Unknown.ToString();
                return LangAndCost;
            }
        }

        public string[] Corsair_PI//5
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Corsair_PI;
                }
                else
                {
                    LangAndCost[0] = EN.Corsair_PI;
                }
                LangAndCost[1] = Costs.Unknown.ToString();
                return LangAndCost;
            }
        }

        public string[] Anaversary_PI//6
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    LangAndCost[0] = DE.Anaversary_PI;
                }
                else
                {
                    LangAndCost[0] = EN.Anaversary_PI;
                }
                LangAndCost[1] = Costs.Unknown.ToString();
                return LangAndCost;
            }
        }
    }
}
