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
        Languages.German.Heroes.DE_Mercy DE;
        string myLang;

        public L_Mercy(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Mercy();
            DE = new Languages.German.Heroes.DE_Mercy();
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
        public string Celestial_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Celestial_SK;
                }
                else
                {
                    return EN.Celestial_SK;
                }
            }
        }

        public string Mist_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mist_SK;
                }
                else
                {
                    return EN.Mist_SK;
                }
            }
        }

        public string Orchid_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Orchid_SK;
                }
                else
                {
                    return EN.Orchid_SK;
                }
            }
        }

        public string Verdant_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Verdant_SK;
                }
                else
                {
                    return EN.Verdant_SK;
                }
            }
        }
        //Epic
        public string Amber_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Amber_SK;
                }
                else
                {
                    return EN.Amber_SK;
                }
            }
        }

        public string Cobalt_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cobalt_SK;
                }
                else
                {
                    return EN.Cobalt_SK;
                }
            }
        }

        public string Eidgenossin_SK//7
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Eidgenossin_SK;
                }
                else
                {
                    return EN.Eidgenossin_SK;
                }
            }
        }

        public string Fortune_SK//8
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Fortune_SK;
                }
                else
                {
                    return EN.Fortune_SK;
                }
            }
        }
        //Legendary
        public string Sigrun_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sigrun_SK;
                }
                else
                {
                    return EN.Sigrun_SK;
                }
            }
        }

        public string Valkyrie_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Valkyrie_SK;
                }
                else
                {
                    return EN.Valkyrie_SK;
                }
            }
        }

        public string Devil_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Devil_SK;
                }
                else
                {
                    return EN.Devil_SK;
                }
            }
        }

        public string IMP_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.IMP_SK;
                }
                else
                {
                    return EN.IMP_SK;
                }
            }
        }

        public string Winged_Victory_SK//13
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Winged_Victory_SK;
                }
                else
                {
                    return EN.Winged_Victory_SK;
                }
            }
        }

        public string Witch_SK//14
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Witch_SK;
                }
                else
                {
                    return EN.Witch_SK;
                }
            }
        }

        public string Combat_Medic_Ziegler_SK//15
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Combat_Medic_Ziegler_SK;
                }
                else
                {
                    return EN.Combat_Medic_Ziegler_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Applause_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Applause_EM;
                }
                else
                {
                    return EN.Applause_EM;
                }
            }
        }

        public string Caduceus_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Caduceus_EM;
                }
                else
                {
                    return EN.Caduceus_EM;
                }
            }
        }

        public string No_Pulse_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.No_Pulse_EM;
                }
                else
                {
                    return EN.No_Pulse_EM;
                }
            }
        }

        public string Relax_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Relax_EM;
                }
                else
                {
                    return EN.Relax_EM;
                }
            }
        }

        public string The_best_Medicine_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.The_best_Medicine_EM;
                }
                else
                {
                    return EN.The_best_Medicine_EM;
                }
            }
        }

        public string Hustle_EM//6
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Hustle_EM;
                }
                else
                {
                    return EN.Hustle_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Angelic_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Angelic_VP;
                }
                else
                {
                    return EN.Angelic_VP;
                }
            }
        }

        public string Carefree_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Carefree_VP;
                }
                else
                {
                    return EN.Carefree_VP;
                }
            }
        }

        public string Ready_for_Battle_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ready_for_Battle_VP;
                }
                else
                {
                    return EN.Ready_for_Battle_VP;
                }
            }
        }

        public string Medal_VP//4
        {//Summer 17
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

        public string Mistletoe_VP//6
        {//Winter 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mistletoe_VP;
                }
                else
                {
                    return EN.Mistletoe_VP;
                }
            }
        }

        public string Toast_VP//7
        {//Winter 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mistletoe_VP;
                }
                else
                {
                    return EN.Toast_VP;
                }
            }
        }
    }
}
