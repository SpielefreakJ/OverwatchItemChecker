using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Translate
    {
        string myLang;
        CCost Cost;

        //Langs
        Lang.L_DE DE;
        Lang.L_EN EN;

        public L_Translate(string Lang)
        {
            myLang = Lang;
            Cost = new CCost();

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


        //Welcome Screen

        public string Welcome
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Welcome;
                }
                else
                {
                    return EN.Welcome;
                }
            }
        }

        public string ChangesText
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.ChangesTitle + EN.ChangesText;
                }
                else
                {
                    return EN.ChangesTitle + EN.ChangesText;
                }
            }
        }

        public string CopyrightVersion
        {
            get
            {
                //if (myLang == "DE")
                //{
                //    return DE.ChangesTitle + EN.ChangesText;
                //}
                //else
                {
                    return "© 2017 SpielefreakJ | OWLootboxTracker Version: 0.1.2.1 Alpha | Overwatch Version: 1.16.0.2B";
                }
            }
        }



        //All Settings


        public string Settings
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Settings;
                }
                else
                {
                    return EN.Settings;
                }
            }
        }

        public string LangChange
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.LangSettings;
                }
                else
                {
                    return EN.LangSettings;
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


        public string Back
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Back;
                }
                else
                {
                    return EN.Back;
                }
            }
        }

        public string DeleteSaves
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.DeleteSaves;
                }
                else
                {
                    return EN.DeleteSaves;
                }
            }
        }

        public string DeleteSavesS
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.DeleteSavesS;
                }
                else
                {
                    return EN.DeleteSavesS;
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
        //Events
        public string Summer
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Summer;
                }
                else
                {
                    return EN.Summer;
                }
            }
        }

        public string Halloween
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Halloween;
                }
                else
                {
                    return EN.Halloween;
                }
            }
        }

        public string Winter
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Winter;
                }
                else
                {
                    return EN.Winter;
                }
            }
        }

        public string Rooster
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Rooster;
                }
                else
                {
                    return EN.Rooster;
                }
            }
        }

        public string Uprising
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Uprising;
                }
                else
                {
                    return EN.Uprising;
                }
            }
        }

        public string Annyver
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Annyver;
                }
                else
                {
                    return EN.Annyver;
                }
            }
        }


        //Not Obtainable Skins

        public string Unknown
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Unknown;
                }
                else
                {
                    return EN.Unknown;
                }
            }
        }

        public string OriginGotY
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.OriginGotY;
                }
                else
                {
                    return EN.OriginGotY;
                }
            }
        }

        public string BlizzCon
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.BlizzCon;
                }
                else
                {
                    return EN.BlizzCon;
                }
            }
        }

        public string Prepurchase
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Prepurchase;
                }
                else
                {
                    return EN.Prepurchase;
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
                    return DE.remaining1 + " " + (Cost.CostsNonEvent + Cost.CostsEvent) + " " + DE.remaining2 + " " + Cost.CostsGoldWeapon + " SR";
                }
                else
                {
                    return EN.remaining1 + " " + (Cost.CostsNonEvent + Cost.CostsEvent) + " " + EN.remaining2 + " " + Cost.CostsGoldWeapon + " SR";
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
                    return (Cost.CostsNonEvent + Cost.CostsEvent) + " " + DE.Credits + "\n\n" + Cost.CostsNonEvent + " " + DE.Credits + "\n\n" + Cost.CostsEvent + " " + DE.Credits + "\n\n" + Cost.CostsGoldWeapon + " SR";
                }
                else
                {
                    return (Cost.CostsNonEvent + Cost.CostsEvent) + " " + EN.Credits + "\n\n" + Cost.CostsNonEvent + " " + EN.Credits + "\n\n" + Cost.CostsEvent + " " + EN.Credits + "\n\n" + Cost.CostsGoldWeapon + " SR";
                }
            }
        }
    }
}
