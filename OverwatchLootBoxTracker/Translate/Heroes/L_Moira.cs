using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Moira
    {
        Languages.English.Heroes.EN_Moira EN;
        Languages.German.Heroes.DE_Moira DE;
        string myLang;

        public L_Moira(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Moira();
            DE = new Languages.German.Heroes.DE_Moira();
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
        public string I_SK//1
        {
            get
            {
                if (myLang=="DE")
                {
                    return DE.I_SK;
                }
                else
                {
                    return DE.I_SK;
                }
            }
        }

        public string II_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.II_SK;
                }
                else
                {
                    return EN.II_SK;
                }
            }
        }

        public string III_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.III_SK;
                }
                else
                {
                    return EN.III_SK;
                }
            }
        }

        public string IV_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.IV_SK;
                }
                else
                {
                    return EN.IV_SK;
                }
            }
        }
        //Epic
        public string V_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.V_SK;
                }
                else
                {
                    return EN.V_SK;
                }
            }
        }

        public string VI_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.VI_SK;
                }
                else
                {
                    return EN.VI_SK;
                }
            }
        }
        //Legendary
        public string VII_SK//7
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.VII_SK;
                }
                else
                {
                    return EN.VII_SK;
                }
            }
        }

        public string VIII_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.VIII_SK;
                }
                else
                {
                    return EN.VIII_SK;
                }
            }
        }

        public string IX_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.IX_SK;
                }
                else
                {
                    return EN.IX_SK;
                }
            }
        }

        public string X_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.X_SK;
                }
                else
                {
                    return EN.X_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string I_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.I_EM;
                }
                else
                {
                    return EN.I_EM;
                }
            }
        }

        public string II_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.II_EM;
                }
                else
                {
                    return EN.II_EM;
                }
            }
        }

        public string III_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.III_EM;
                }
                else
                {
                    return EN.III_EM;
                }
            }
        }

        public string IV_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.IV_EM;
                }
                else
                {
                    return EN.IV_EM;
                }
            }
        }

        public string V_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.V_EM;
                }
                else
                {
                    return EN.V_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string I_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.I_VP;
                }
                else
                {
                    return EN.I_VP;
                }
            }
        }

        public string II_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.II_VP;
                }
                else
                {
                    return EN.II_VP;
                }
            }
        }

        public string III_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.III_VP;
                }
                else
                {
                    return EN.III_VP;
                }
            }
        }
    }
}
