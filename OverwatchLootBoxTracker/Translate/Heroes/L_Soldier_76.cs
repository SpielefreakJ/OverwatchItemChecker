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
    }
}
