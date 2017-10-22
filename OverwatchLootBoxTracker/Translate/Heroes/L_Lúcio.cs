using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Lúcio
    {
        Languages.English.Heroes.EN_Lúcio EN;
        string myLang;

        public L_Lúcio(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Lúcio();
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
        public string Azul_SK//1
        {
            get
            {
                //else
                {
                    return EN.Azul_SK;
                }
            }
        }

        public string Laranja_SK//2
        {
            get
            {
                //else
                {
                    return EN.Laranja_SK;
                }
            }
        }

        public string Roxo_SK//3
        {
            get
            {
                //else
                {
                    return EN.Roxo_SK;
                }
            }
        }

        public string Vermelho_SK//4
        {
            get
            {
                //else
                {
                    return EN.Vermelho_SK;
                }
            }
        }
        //Epic
        public string Auditiva_SK//5
        {
            get
            {
                //else
                {
                    return EN.Auditiva_SK;
                }
            }
        }

        public string Synaesthesia_SK//6
        {
            get
            {
                //else
                {
                    return EN.Synaesthesia_SK;
                }
            }
        }

        public string Andes_SK//7
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Andes_SK;
                }
            }
        }
        //Legendary
        public string Hippityhop_SK//8
        {
            get
            {
                //else
                {
                    return EN.Hippityhop_SK;
                }
            }
        }

        public string Ribbit_SK//9
        {
            get
            {
                //else
                {
                    return EN.Ribbit_SK;
                }
            }
        }

        public string Breakaway_SK//10
        {
            get
            {
                //else
                {
                    return EN.Breakaway_SK;
                }
            }
        }

        public string Slapshot_SK//11
        {
            get
            {
                //else
                {
                    return EN.Slapshot_SK;
                }
            }
        }

        public string Seleção_SK//12
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Seleção_SK;
                }
            }
        }

        public string Striker_SK//13
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Striker_SK;
                }
            }
        }

        public string Jazzy_SK//14
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Jazzy_SK;
                }
            }
        }


        //Emotes
    }
}
