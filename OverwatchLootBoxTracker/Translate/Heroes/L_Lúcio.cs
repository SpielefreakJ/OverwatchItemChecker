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
        Languages.German.Heroes.DE_Lúcio DE;
        string myLang;

        public L_Lúcio(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Lúcio();
            DE = new Languages.German.Heroes.DE_Lúcio();
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
        public string Azul_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Azul_SK;
                }
                else
                {
                    return EN.Azul_SK;
                }
            }
        }

        public string Laranja_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Laranja_SK;
                }
                else
                {
                    return EN.Laranja_SK;
                }
            }
        }

        public string Roxo_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Roxo_SK;
                }
                else
                {
                    return EN.Roxo_SK;
                }
            }
        }

        public string Vermelho_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Vermelho_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Auditiva_SK;
                }
                else
                {
                    return EN.Auditiva_SK;
                }
            }
        }

        public string Synaesthesia_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Synaesthesia_SK;
                }
                else
                {
                    return EN.Synaesthesia_SK;
                }
            }
        }

        public string Andes_SK//7
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Andes_SK;
                }
                else
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
                if (myLang == "DE")
                {
                    return DE.Hippityhop_SK;
                }
                else
                {
                    return EN.Hippityhop_SK;
                }
            }
        }

        public string Ribbit_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ribbit_SK;
                }
                else
                {
                    return EN.Ribbit_SK;
                }
            }
        }

        public string Breakaway_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Breakaway_SK;
                }
                else
                {
                    return EN.Breakaway_SK;
                }
            }
        }

        public string Slapshot_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Slapshot_SK;
                }
                else
                {
                    return EN.Slapshot_SK;
                }
            }
        }

        public string Seleção_SK//12
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Seleção_SK;
                }
                else
                {
                    return EN.Seleção_SK;
                }
            }
        }

        public string Striker_SK//13
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Striker_SK;
                }
                else
                {
                    return EN.Striker_SK;
                }
            }
        }

        public string Jazzy_SK//14
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Jazzy_SK;
                }
                else
                {
                    return EN.Jazzy_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string Capoeira_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Capoeira_EM;
                }
                else
                {
                    return EN.Capoeira_EM;
                }
            }
        }

        public string Chilling_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Chilling_EM;
                }
                else
                {
                    return EN.Chilling_EM;
                }
            }
        }

        public string In_the_Groove_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.In_the_Groove_EM;
                }
                else
                {
                    return EN.In_the_Groove_EM;
                }
            }
        }

        public string Knee_Slapper_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Knee_Slapper_EM;
                }
                else
                {
                    return EN.Knee_Slapper_EM;
                }
            }
        }

        public string Nah_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Nah_EM;
                }
                else
                {
                    return EN.Nah_EM;
                }
            }
        }

        public string Juggle_EM//6
        {//Summer 16
            get
            {
                if (myLang == "DE")
                {
                    return DE.Juggle_EM;
                }
                else
                {
                    return EN.Juggle_EM;
                }
            }
        }

        public string Smooth_EM//7
        {//Annyver 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Smooth_EM;
                }
                else
                {
                    return EN.Smooth_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Configent_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Confident_VP;
                }
                else
                {
                    return EN.Confident_VP;
                }
            }
        }

        public string Grooving_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Grooving_VP;
                }
                else
                {
                    return EN.Grooving_VP;
                }
            }
        }

        public string Ready_for_action_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ready_for_action_VP;
                }
                else
                {
                    return EN.Ready_for_action_VP;
                }
            }
        }

        public string Pumpkin_Control_VP//4
        {//Halloween 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Pumpkin_Control_VP;
                }
                else
                {
                    return EN.Pumpkin_Control_VP;
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

        public string Handstand_VP//6
        {//Uprising 17
            get
            {
                if (myLang == "DE")
                {
                    return DE.Handstand_VP;
                }
                else
                {
                    return EN.Handstand_VP;
                }
            }
        }
    }
}
