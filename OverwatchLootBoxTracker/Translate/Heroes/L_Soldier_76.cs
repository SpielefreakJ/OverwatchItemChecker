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
        string myLang;

        public L_Soldier_76(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Soldier_76();
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


        //Skin

        //Rare
        public string Jet_SK//1
        {
            get
            {
                //else
                {
                    return EN.Jet_SK;
                }
            }
        }

        public string Olive_SK//2
        {
            get
            {
                //else
                {
                    return EN.Olive_SK;
                }
            }
        }

        public string Russet_SK//3
        {
            get
            {
                //else
                {
                    return EN.Russet_SK;
                }
            }
        }

        public string Smoke_SK//4
        {
            get
            {
                //else
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
                //else
                {
                    return EN.Bone_SK;
                }
            }
        }

        public string Golden_SK//6
        {
            get
            {
                //else
                {
                    return EN.Golden_SK;
                }
            }
        }

        public string Immortal_SK//7
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Immortal_SK;
                }
            }
        }
        //Legendary
        public string Commander_76_SK//8
        {
            get
            {
                //else
                {
                    return EN.Commander_76_SK;
                }
            }
        }

        public string Night_Ops_76_SK//9
        {
            get
            {
                //else
                {
                    return EN.Night_Ops_76_SK;
                }
            }
        }

        public string Daredevil_76_SK//10
        {
            get
            {
                //else
                {
                    return EN.Daredevil_76_SK;
                }
            }
        }

        public string Stunt_Rider_76_SK//11
        {
            get
            {
                //else
                {
                    return EN.Stunt_Rider_76_SK;
                }
            }
        }

        public string Strike_Commander_Morrison_SK//12
        {//Origin Special
            get
            {
                //else
                {
                    return EN.Strike_Commander_Morrison_SK;
                }
            }
        }

        public string Grillmaster_76_SK//13
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Grillmaster_76_SK;
                }
            }
        }

        public string Cyborg_76_SK//14
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Cyborg_76_SK;
                }
            }
        }


        //Emotes
    }
}
