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
        public string Azul_SK
        {
            get
            {
                //else
                {
                    return EN.Azul_SK;
                }
            }
        }

        public string Laranja_SK
        {
            get
            {
                //else
                {
                    return EN.Laranja_SK;
                }
            }
        }

        public string Roxo_SK
        {
            get
            {
                //else
                {
                    return EN.Roxo_SK;
                }
            }
        }

        public string Vermelho_SK
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
        public string Auditiva_SK
        {
            get
            {
                //else
                {
                    return EN.Auditiva_SK;
                }
            }
        }

        public string Synaesthesia_SK
        {
            get
            {
                //else
                {
                    return EN.Synaesthesia_SK;
                }
            }
        }

        public string Andes_SK
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
        public string Hippityhop_SK
        {
            get
            {
                //else
                {
                    return EN.Hippityhop_SK;
                }
            }
        }

        public string Ribbit_SK
        {
            get
            {
                //else
                {
                    return EN.Ribbit_SK;
                }
            }
        }

        public string Breakaway_SK
        {
            get
            {
                //else
                {
                    return EN.Breakaway_SK;
                }
            }
        }

        public string Slapshot_SK
        {
            get
            {
                //else
                {
                    return EN.Slapshot_SK;
                }
            }
        }

        public string Seleção_SK
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Seleção_SK;
                }
            }
        }

        public string Striker_SK
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Striker_SK;
                }
            }
        }

        public string Jazzy_SK
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
