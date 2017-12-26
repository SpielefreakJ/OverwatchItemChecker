using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Lang
{
    class L_DE
    {
        public L_DE()
        {
            //환영
        }


        //Welcome Screen

        public string Welcome
        {
            get
            {
                return "Willkommen";
            }
        }

        public string ChangesTitle
        {
            get
            {
                return "Änderrungen";
            }
        }


        //Alle Einstellungen

        public string Settings
        {
            get
            {
                return "Einstellungen";
            }
        }

        public string LangSettings
        {
            get
            {
                return "Sprache Ändern";
            }
        }

        public string MoreCost
        {
            get
            {
                return "Genauere Kostenangaben";
            }
        }

        public string Back
        {
            get
            {
                return "Zurück";
            }
        }

        public string DeleteSaves
        {
            get
            {
                return "Die Speicherfunktion wurde geändert.\n befor die App gestartet weden kann\nmüssel alle gespeicherten sachen gelöscht werden.\nOrdner: C:\\Benutzer\\BENUTZERNAME\\AppData\\Local\\OWItemTracker\n\nOK zum Löschen\nAbbrechen zum beenden (für kopieren und checken der alten Dateien)";
            }
        }

        public string DeleteSavesS
        {
            get
            {
                return "Alles erfolgreich Gelöscht";
            }
        }


        //Beim Beenden

        public string Close
        {
            get
            {
                return "Schließen";
            }
        }

        public string AppClose
        {
            get
            {
                return "Test";
            }
        }


        //Overlay Text

        public string Skin
        {
            get
            {
                return "Skins";
            }
        }

        public string Emotes
        {
            get
            {
                return "Emotes";
            }
        }

        public string VictoryPoses
        {
            get
            {
                return "Siegerposen";
            }
        }

        public string VoiceLines
        {
            get
            {
                return "Sprüche";
            }
        }

        public string Sprays
        {
            get
            {
                return "Sprays";
            }
        }

        public string HighlightIntros
        {
            get
            {
                return "Highlight-Intros";
            }
        }

        public string Weapons
        {
            get
            {
                return "Waffen";
            }
        }

        public string PlayerIcons
        {
            get
            {
                return "Spieler-Icons";
            }
        }
        //Events
        public string Summer
        {
            get
            {
                return "Sommerspiele";
            }
        }

        public string Halloween
        {
            get
            {
                return "Halloween-Horror";
            }
        }

        public string Winter
        {
            get
            {
                return "Winterwunderland";
            }
        }

        public string Rooster
        {
            get
            {
                return "Das Jahr des Hahns";
            }
        }

        public string Uprising
        {
            get
            {
                return "Overwatch Aufstand";
            }
        }

        public string Annyver
        {
            get
            {
                return "Jubiläum";
            }
        }


        //Not Obtainable Skins

        public string Unknown
        {
            get
            {
                return "?";
            }
        }

        public string OriginGotY
        {
            get
            {
                return "Origin/GotY";
            }
        }
        public string OriginGotY2
        {
            get
            {
                return "Nur mit Origin or GotY Game-Edition";
            }
        }

        public string BlizzCon
        {
            get
            {
                return "BlizzCon";
            }
        }
        string Year = "2016";
        public string BlizzCon2
        {
            get
            {
                return "Nur mit BlizzCon " + Year + " Ticket";
            }
            set
            {
                Year = value;
            }
        }

        public string Prepurchase
        {
            get
            {
                return "Vorbesteller";
            }
        }
        public string Prepurchase2
        {
            get
            {
                return "Nur durch Vorbestellung";
            }
        }



        //Remainint Text

        public string remaining1
        {
            get
            {
                return "Kosten für alle übrigen Items:";
                //return "Kosten für restliche Items:";
            }
        }

        public string remaining2
        {
            get
            {
                return "Credits und";
            }
        }

        public string Credits
        {
            get
            {
                return "Credits";
            }
        }
        //For "More Infos about remaining Costs"
        public string remAll
        {
            get
            {
                return "Kosten für alle übrigen Items:";
                //return "Kosten für alle restliche Items:";
            }
        }
        public string remNonEvent
        {
            get
            {
                return "Kosten für alle übrigen nicht-Event-Items:";
                //return "Kosten für alle restliche nicht-Event-Items:";
            }
        }

        public string remEvent
        {
            get
            {
                return "Kosten für alle übrigen Event Items:";
                //return "Kosten für alle restliche Event Items:";
            }
        }

        public string remWeapons
        {
            get
            {
                return "Kosten für alle übrigen Waffen:";
                //return "Kosten für alle restliche Waffen:";
            }
        }


        //Default Items
        public string Classic
        {//Skin
            get
            {
                return "Classic";
            }
        }

        public string Heroic
        {//Emote, Victory Pose, Highlight Intro
            get
            {
                return "Heroic";
            }
        }

        public string Default
        {//Weapon
            get
            {
                return "Default";
            }
        }
    }
}
