using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class CLang
    {
        string myLang;

        //Langs
        Lang.L_DE DE;
        Lang.L_EN EN;

        public CLang(string Lang)
        {
            myLang = Lang;

            //Langs
            DE = new Lang.L_DE();
            EN = new Lang.L_EN();
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


        //All Settings

        public string Settingsbutton
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Settingsbutton;
                }
                else
                {
                    return EN.Settingsbutton;
                }
            }
        }

        public string LangChangeBox
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.LangSettingsBox;
                }
                else
                {
                    return EN.LangSettingsBox;
                }
            }
        }



        //On Close
        

        public string AppClose
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.AppClose;
                }
                else
                {
                    return EN.AppClose;
                }
            }
        }



        //Remaining Text

        public string remaining1
        {
            get
            {
                if (myLang=="DE")
                {
                    return DE.remaining1;
                }
                else
                {
                    return EN.remaining1;
                }
            }
        }

        public string remaining2
        {
            get
            {
                if (myLang=="DE")
                {
                    return DE.remaining2;
                }
                else
                {
                    return EN.remaining2;
                }
            }
        }

        public string remaining3
        {
            get
            {
                if (myLang=="DE")
                {
                    return DE.remaining3;
                }
                else
                {
                    return EN.remaining3;
                }
            }
        }
    }
}
