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

        //Skins
        Languages.English.Heroes.EN_Ana EN_Ana;
        Languages.English.Heroes.EN_Bastion EN_Bastion;
        Languages.English.Heroes.EN_DVa EN_DVa;
        Languages.English.Heroes.EN_Doomfist EN_Doomfist;
        Languages.English.Heroes.EN_Genji EN_Genji;
        Languages.English.Heroes.EN_Hanzo EN_Hanzo;
        Languages.English.Heroes.EN_Junkrat EN_Junkrat;
        Languages.English.Heroes.EN_Lúcio EN_Lúcio;
        Languages.English.Heroes.EN_McCree EN_McCree;
        Languages.English.Heroes.EN_Mei EN_Mei;
        Languages.English.Heroes.EN_Mercy EN_Mercy;
        Languages.English.Heroes.EN_Orisa EN_Orisa;
        Languages.English.Heroes.EN_Pharah EN_Pharah;
        Languages.English.Heroes.EN_Reaper EN_Reaper;
        Languages.English.Heroes.EN_Reinhardt EN_Reinhardt;
        Languages.English.Heroes.EN_Roadhog EN_Roadhog;
        Languages.English.Heroes.EN_Soldier_76 EN_Soldier_76;
        Languages.English.Heroes.EN_Sombra EN_Sombra;
        Languages.English.Heroes.EN_Symmetra EN_Symmetra;
        Languages.English.Heroes.EN_Torbjörn EN_Torbjörn;
        Languages.English.Heroes.EN_Tracer EN_Tracer;
        Languages.English.Heroes.EN_Widowmaker EN_Widowmaker;
        Languages.English.Heroes.EN_Winston EN_Winston;
        Languages.English.Heroes.EN_Zarya EN_Zarya;
        Languages.English.Heroes.EN_Zenyatta EN_Zenjatta;

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

            // Ana
        public string Citrine
        {
            get
            {
                //else
                {
                    return EN_Ana.Citrine;
                }
            }
        }

        public string Garnet
        {
            get
            {
                //else
                {
                    return EN_Ana.Garnet;
                }
            }
        }

        public string Peridot
        {
            get
            {
                //else
                {
                    return EN_Ana.Peridot;
                }
            }
        }

        public string Turquoise
        {
            get
            {
                //else
                {
                    return EN_Ana.Turquoise;
                }
            }
        }

        //Epic
        public string Merciful
        {
            get
            {
                //else
                {
                    return EN_Ana.Merciful;
                }
            }
        }

        public string Shrike
        {
            get
            {
                //else
                {
                    return EN_Ana.Shrike;
                }
            }
        }

        public string Ghoul
        {//Halloween 2016
            get
            {
                //else
                {
                    return EN_Ana.Ghoul;
                }
            }
        }

        public string Tal
        {//Rooster 2017
            get
            {
                //else
                {
                    return EN_Ana.Tal;
                }
            }
        }

        //Legendary
        public string Wadjet
        {
            get
            {
                //else
                {
                    return EN_Ana.Wadjet;
                }
            }
        }

        public string Wasteland
        {
            get
            {
                //else
                {
                    return EN_Ana.Wasteland;
                }
            }
        }

        public string Captain_Amari
        {
            get
            {
                //else
                {
                    return EN_Ana.Captain_Amari;
                }
            }
        }

        public string Horus
        {
            get
            {
                //else
                {
                    return EN_Ana.Horus;
                }
            }
        }

        public string Corsair
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN_Ana.Corsair;
                }
            }
        }
    }
}
