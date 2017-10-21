using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Mercy
    {
        Languages.English.Heroes.EN_Mercy EN;
        string myLang;

        public L_Mercy(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Mercy();
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
        public string Celestial_SK
        {
            get
            {
                //else
                {
                    return EN.Celestial_SK;
                }
            }
        }

        public string Mist_SK
        {
            get
            {
                //else
                {
                    return EN.Mist_SK;
                }
            }
        }

        public string Orchid_SK
        {
            get
            {
                //else
                {
                    return EN.Orchid_SK;
                }
            }
        }

        public string Verdant_SK
        {
            get
            {
                //else
                {
                    return EN.Verdant_SK;
                }
            }
        }
        //Epic
        public string Amber_SK
        {
            get
            {
                //else
                {
                    return EN.Amber_SK;
                }
            }
        }

        public string Cobalt_SK
        {
            get
            {
                //else
                {
                    return EN.Cobalt_SK;
                }
            }
        }

        public string Eidgenossin_SK
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Eidgenossin_SK;
                }
            }
        }

        public string Fortune_SK
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN.Fortune_SK;
                }
            }
        }
        //Legendary
        public string Sigrun_SK
        {
            get
            {
                //else
                {
                    return EN.Sigrun_SK;
                }
            }
        }

        public string Valkyrie_SK
        {
            get
            {
                //else
                {
                    return EN.Valkyrie_SK;
                }
            }
        }

        public string Devil_SK
        {
            get
            {
                //else
                {
                    return EN.Devil_SK;
                }
            }
        }

        public string IMP_SK
        {
            get
            {
                //else
                {
                    return EN.IMP_SK;
                }
            }
        }

        public string Winged_Victory_SK
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Winged_Victory_SK;
                }
            }
        }

        public string Witch_SK
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN.Witch_SK;
                }
            }
        }

        public string Combat_Medic_Ziegler_SK
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Combat_Medic_Ziegler_SK;
                }
            }
        }


        //Emotes
    }
}
