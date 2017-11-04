using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Soldier_76
    {
        Languages.English.Heroes.EN_Soldier_76 EN;
        Languages.German.Heroes.DE_Soldier_76 DE;
        string myLang;

        public L_Soldier_76(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Soldier_76();
            DE = new Languages.German.Heroes.DE_Soldier_76();
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
                if (myLang == "DE")
                {
                    return DE.Name;
                }
                else
                {
                    return EN.Name;
                }
            }
        }


        //Skin

        //Rare
        public string Jet_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Jet_SK;
                }
                else
                {
                    return EN.Jet_SK;
                }
            }
        }

        public string Olive_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Olive_SK;
                }
                else
                {
                    return EN.Olive_SK;
                }
            }
        }

        public string Russet_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Russet_SK;
                }
                else
                {
                    return EN.Russet_SK;
                }
            }
        }

        public string Smoke_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Smoke_SK;
                }
                else
                {
                    return EN.Smoke_SK;
                }
            }
        }
        //Epic
        public string Bone_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bone_SK;
                }
                else
                {
                    return EN.Bone_SK;
                }
            }
        }

        public string Golden_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Golden_SK;
                }
                else
                {
                    return EN.Golden_SK;
                }
            }
        }

        public string Immortal_SK//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Immortal_SK;
                }
                else
                {
                    return EN.Immortal_SK;
                }
            }
        }
        //Legendary
        public string Commando_76_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Commando_76_SK;
                }
                else
                {
                    return EN.Commando_76_SK;
                }
            }
        }

        public string Night_Ops_76_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Night_Ops_76_SK;
                }
                else
                {
                    return EN.Night_Ops_76_SK;
                }
            }
        }

        public string Daredevil_76_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Daredevil_76_SK;
                }
                else
                {
                    return EN.Daredevil_76_SK;
                }
            }
        }

        public string Stunt_Rider_76_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Stunt_Rider_76_SK;
                }
                else
                {
                    return EN.Stunt_Rider_76_SK;
                }
            }
        }

        public string Strike_Commander_Morrison_SK//12
        {//Origin Special
            get
            {
                if (myLang == "DE")
                {
                    return DE.Strike_Commander_Morrison_SK;
                }
                else
                {
                    return EN.Strike_Commander_Morrison_SK;
                }
            }
        }

        public string Grillmaster_76_SK//13
        {//Summer 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Grillmaster_76_SK;
                }
                else
                {
                    return EN.Grillmaster_76_SK;
                }
            }
        }

        public string Cyborg_76_SK//14
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cyborg_76_SK;
                }
                else
                {
                    return EN.Cyborg_76_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Amused_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Amused_EM;
                }
                else
                {
                    return EN.Amused_EM;
                }
            }
        }

        public string Fist_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Fist_EM;
                }
                else
                {
                    return EN.Fist_EM;
                }
            }
        }

        public string I_see_you_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.I_see_you_EM;
                }
                else
                {
                    return EN.I_see_you_EM;
                }
            }
        }

        public string Locked_and_Loaded_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Locked_and_Loaded_EM;
                }
                else
                {
                    return EN.Locked_and_Loaded_EM;
                }
            }
        }

        public string Take_a_knee_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Take_a_knee_EM;
                }
                else
                {
                    return EN.Take_a_knee_EM;
                }
            }
        }

        public string Push_Ups_EM//6
        {//Uprising 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Push_Ups_EM;
                }
                else
                {
                    return EN.Push_Ups_EM;
                }
            }
        }

        public string Dance_EM//7
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Dance_EM;
                }
                else
                {
                    return EN.Dance_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Fist_Pump_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Fist_Pump_VP;
                }
                else
                {
                    return EN.Fist_Pump_VP;
                }
            }
        }

        public string Locked_and_Loaded_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Locked_and_Loaded_VP;
                }
                else
                {
                    return EN.Locked_and_Loaded_VP;
                }
            }
        }

        public string Soldier_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Soldier_VP;
                }
                else
                {
                    return EN.Soldier_VP;
                }
            }
        }

        public string Golf_Swing_VP//4
        {//Summer 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Golf_Swing_VP;
                }
                else
                {
                    return EN.Golf_Swing_VP;
                }
            }
        }

        public string RIP_VP//5
        {//Halloween 16
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

        public string Toast_VP//6
        {//Winter 16
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
    }
}
