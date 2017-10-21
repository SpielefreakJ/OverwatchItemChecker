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


        //Skin

        //Rare
        public string S1_Jet_SK
        {
            get
            {
                //else
                {
                    return EN.Jet_SK;
                }
            }
        }

        public string S1_Olive_SK
        {
            get
            {
                //else
                {
                    return EN.Olive_SK;
                }
            }
        }

        public string S1_Russet_SK
        {
            get
            {
                //else
                {
                    return EN.Russet_SK;
                }
            }
        }

        public string S1_Smoke_SK
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
        public string S1_Bone_SK
        {
            get
            {
                //else
                {
                    return EN.Bone_SK;
                }
            }
        }

        public string S1_Golden_SK
        {
            get
            {
                //else
                {
                    return EN.Golden_SK;
                }
            }
        }

        public string S1_Immortal_SK
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
        public string S1_Commander_76_SK
        {
            get
            {
                //else
                {
                    return EN.Commander_76_SK;
                }
            }
        }

        public string S1_Night_Ops_76_SK
        {
            get
            {
                //else
                {
                    return EN.Night_Ops_76_SK;
                }
            }
        }

        public string S1_Daredevil_76_SK
        {
            get
            {
                //else
                {
                    return EN.Daredevil_76_SK;
                }
            }
        }

        public string S1_Stunt_Rider_76_SK
        {
            get
            {
                //else
                {
                    return EN.Stunt_Rider_76_SK;
                }
            }
        }

        public string S1_Strike_Commander_Morrison_SK
        {//Origin Special
            get
            {
                //else
                {
                    return EN.Strike_Commander_Morrison_SK;
                }
            }
        }

        public string S1_Grillmaster_76_SK
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Grillmaster_76_SK;
                }
            }
        }

        public string S1_Cyborg_76_SK
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
