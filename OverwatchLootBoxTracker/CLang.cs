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
        CCost Cost;
        CGoldweapon GoldWeapon;

        //Langs
        Lang.L_DE DE;
        Lang.L_EN EN;

        public CLang(string Lang)
        {
            myLang = Lang;
            Cost = new CCost();
            GoldWeapon = new CGoldweapon();

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


        public string MoreCost
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.MoreCost;
                }
                else
                {
                    return EN.MoreCost;
                }
            }
        }



        //On Close


        public string Close
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Close;
                }
                else
                {
                    return EN.Close;
                }
            }
        }


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


        //Overlay Text

        public string Skins
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Skin;
                }
                else
                {
                    return EN.Skin;
                }
            }
        }

        public string Emotes
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Emotes;
                }
                else
                {
                    return EN.Emotes;
                }
            }
        }

        public string VictoryPoses
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.VictoryPoses;
                }
                else
                {
                    return EN.VictoryPoses;
                }
            }
        }

        public string VoiceLines
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.VoiceLines;
                }
                else
                {
                    return EN.VoiceLines;
                }
            }
        }

        public string Sprays
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sprays;
                }
                else
                {
                    return EN.Sprays;
                }
            }
        }

        public string HighlightIntros
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.HighlightIntros;
                }
                else
                {
                    return EN.HighlightIntros;
                }
            }
        }

        public string Weapons
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Weapons;
                }
                else
                {
                    return EN.Weapons;
                }
            }
        }

        public string PlayerIcons
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.PlayerIcons;
                }
                else
                {
                    return EN.PlayerIcons;
                }
            }
        }



        //Remaining Text

        public string Remaining
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.remaining1 + " " + (Cost.KostenNormal + Cost.KostenFest) + " " + DE.remaining2 + " " + GoldWeapon.KostenGes + " SR";
                }
                else
                {
                    return EN.remaining1 + " " + (Cost.KostenNormal + Cost.KostenFest) + " " + EN.remaining2 + " " + GoldWeapon.KostenGes + " SR";
                }
            }
        }
        //For "More Infos about remaining Costs"
        public string RemMoreInfo1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.remAll + "\n\n" + DE.remNonEvent + "\n\n" + DE.remEvent + "\n\n" + DE.remWeapons;
                }
                else
                {
                    return EN.remAll + "\n\n" + EN.remNonEvent + "\n\n" + EN.remEvent + "\n\n" + EN.remWeapons;
                }
            }
        }

        public string RemMoreInfo2
        {
            get
            {
                if (myLang == "DE")
                {
                    return (Cost.KostenNormal + Cost.KostenFest) + " " + DE.Credits + "\n\n" + Cost.KostenNormal + " " + DE.Credits + "\n\n" + Cost.KostenFest + " " + DE.Credits + "\n\n" + GoldWeapon.KostenGes + " SR";
                }
                else
                {
                    return (Cost.KostenNormal + Cost.KostenFest) + " " + EN.Credits + "\n\n" + Cost.KostenNormal + " " + EN.Credits + "\n\n" + Cost.KostenFest + " " + EN.Credits + "\n\n" + GoldWeapon.KostenGes + " SR";
                }
            }
        }


        //Skins

        public string S1
        {
            get
            {
                if (myLang == "DE")
                {
                    return "";
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
