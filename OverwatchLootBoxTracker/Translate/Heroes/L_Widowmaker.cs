using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Widowmaker
    {
        Languages.English.Heroes.EN_Widowmaker EN;
        string myLang;

        public L_Widowmaker(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Widowmaker();
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
        public string Ciel_SK//1
        {
            get
            {
                //else
                {
                    return EN.Ciel_SK;
                }
            }
        }

        public string Nuit_SK//2
        {
            get
            {
                //else
                {
                    return EN.Nuit_SK;
                }
            }
        }

        public string Rose_SK//3
        {
            get
            {
                //else
                {
                    return EN.Rose_SK;
                }
            }
        }

        public string Vert_SK//4
        {
            get
            {
                //else
                {
                    return EN.Vert_SK;
                }
            }
        }
        //Epic
        public string Patina_SK//5
        {
            get
            {
                //else
                {
                    return EN.Patina_SK;
                }
            }
        }

        public string Winter_SK//6
        {
            get
            {
                //else
                {
                    return EN.Winter_SK;
                }
            }
        }

        public string Tricolore_SK//7
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Tricolore_SK;
                }
            }
        }
        //Legendary
        public string Odette_SK//8
        {
            get
            {
                //else
                {
                    return EN.Odette_SK;
                }
            }
        }

        public string Odile_SK//9
        {
            get
            {
                //else
                {
                    return EN.Odile_SK;
                }
            }
        }

        public string Comtesse_SK//10
        {
            get
            {
                //else
                {
                    return EN.Comtesse_SK;
                }
            }
        }

        public string Huntress_SK//11
        {
            get
            {
                //else
                {
                    return EN.Huntress_SK;
                }
            }
        }

        public string Noire_SK//12
        {//Prepurchase Special
            get
            {
                //else
                {
                    return EN.Noire_SK;
                }
            }
        }

        public string Côte_DAzur_SK//13
        {//Summer 2017
            get
            {
                //else
                {
                    return EN.Côte_DAzur_SK;
                }
            }
        }

        public string Talon_SK//14
        {//Uprising 2017
            get
            {
                //else
                {
                    return EN.Talon_SK;
                }
            }
        }


        //Emotes
    }
}
