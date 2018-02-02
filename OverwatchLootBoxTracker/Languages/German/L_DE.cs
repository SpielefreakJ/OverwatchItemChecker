using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Lang
{
    class L_DE
    {
        string Year = "2016"; //Pls do NOT Change this!

        public L_DE()
        {
            //You're able to edit here everything in between all " Symbols

            ChangesText = "\n\n\nBeta Version!\n\nFeatures:\n - Save Skins\n - Save Emotes\n - Save Victory Poses\n\nNewest Addings:\nNew Menu!\nHero items can now be displayed.\nAdded Overwatch League Skins and Blizzardworld Items\nLess lag when changing status of an item\n\nLanguages:\n- English";

            #region Welcome Screen
            Welcome = "Willkommen";
            ChangesTitle = "Änderrungen";
            #endregion
            #region All Settings
            Settings = "Einstellungen";
            LangSettings = "Sprache Ändern";
            MoreCost = "Genauere Kostenangaben";
            Back = "Zurück";
            DeleteSaves = "Die Speicherfunktion wurde geändert.\n befor die App gestartet weden kann\nmüssel alle gespeicherten sachen gelöscht werden.\nOrdner: C:\\Benutzer\\BENUTZERNAME\\AppData\\Local\\OWItemTracker\n\nOK zum Löschen\nAbbrechen zum beenden (für kopieren und checken der alten Dateien)";
            DeleteSavesS = "Alles erfolgreich Gelöscht!";
            #endregion

            //On Close
            Close = "Schließen";
            AppClose = "Test";

            #region Overlay Text
            Skin = "Skins";
            Emotes = "Emotes";
            VictoryPoses = "Siegerposen";
            VoiceLines = "Sprüche";
            Sprays = "Sprays";
            HighlightIntros = "Highlight-Intros";
            Weapons = "Waffen";
            PlayerIcons = "Spieler-Icons";
            // Overwatch League
            OWLeague = "Overwatch League";
            #endregion
            #region Events
            Summer = "Sommerspiele";
            Halloween = "Halloween-Horror";
            Winter = "Winterwunderland";
            Rooster = "Das Jahr des Hahns";
            Dog = "Das Jahr des Hundes";
            Uprising = "Overwatch Aufstand";
            Annyver = "Jubiläum";
            #endregion
            #region OWLeague
            OWL_Boston_Uprising = "Boston Uprising";
            OWL_Dallas_Fuel = "Dallas Fuel";
            OWL_Florida_Mayhem = "Florida Mayhem";
            OWL_Houston_Outlaws = "Houston Outlaws";
            OWL_London_Spitfire = "London Spitfire";
            OWL_Los_Angeles_Gladiators = "Los Angeles Gladiators";
            OWL_Los_Angeles_Valiant = "Los Angeles Valiant";
            OWL_New_York_Excelsior = "New York Excelsior";
            OWL_Philadelphia_Fusion = "Philadelphia Fusion";
            OWL_San_Francisco_Shock = "San Francisco Shock";
            OWL_Seoul_Dynasty = "Seoul Dynasty";
            OWL_Shanghai_Dragons = "Shanghai Dragons";
            #endregion
            #region Non Obtainable Skins
            Unknown = "?";
            OriginGotY = "Origin/GotY";
            OriginGotY2 = "Nur mit Origin or GotY Game-Edition";
            BlizzCon = "BlizzCon";
            Prepurchase = "Vorbesteller";
            Prepurchase2 = "Nur durch Vorbestellung";
            #endregion
            #region Remainint Text
            remaining1 = "Kosten für alle übrigen Items:";
            remaining2 = "Credits und";
            Credits = "Credits";

            //For "More Infos about remaining Costs"
            remAll = "Kosten für alle übrigen Items:";
            remNonEvent = "Kosten für alle übrigen nicht-Event-Items:";
            remEvent = "Kosten für alle übrigen Event Items:";
            remWeapons = "Kosten für alle übrigen Waffen:";
            #endregion
            #region Default Items
            Classic = "KLASSISCH";//Skin
            Heroic = "HEROISCH";//Emote, Victory Pose, Highlight Intro
            Default = "STANDARD";//Weapon
            #endregion


        }

        public string BlizzCon2
        {
            //Because of the changeable Year, Blizzcon needs a special 
            get
            {
                return "Nur mit BlizzCon " + Year + " Ticket";
            }
            set
            {
                Year = value;
            }
        }

        #region Variablen

        #region Welcome Screen

        public string Welcome { get; }
        public string ChangesTitle { get; }
        public string ChangesText { get; set; }
        #endregion
        #region All Settings

        public string Settings { get; }
        public string LangSettings { get; }
        public string MoreCost { get; }
        public string Back { get; }
        public string DeleteSaves { get; }
        public string DeleteSavesS { get; }
        #endregion

        //On Close
        public string Close { get; }
        public string AppClose { get; }

        #region Overlay Text

        public string Skin { get; }
        public string Emotes { get; }
        public string VictoryPoses { get; }
        public string VoiceLines { get; }
        public string Sprays { get; }
        public string HighlightIntros { get; }
        public string Weapons { get; }
        public string PlayerIcons { get; }

        public string Summer { get; }//Events
        public string Halloween { get; }
        public string Winter { get; }
        public string Rooster { get; }
        public string Dog { get; }
        public string Uprising { get; }
        public string Annyver { get; }

        public string OWLeague { get; }//Overwatch League
        #endregion
        #region OWLeague

        public string OWL_Boston_Uprising { get; }
        public string OWL_Dallas_Fuel { get; }
        public string OWL_Florida_Mayhem { get; }
        public string OWL_Houston_Outlaws { get; }
        public string OWL_London_Spitfire { get; }
        public string OWL_Los_Angeles_Gladiators { get; }
        public string OWL_Los_Angeles_Valiant { get; }
        public string OWL_New_York_Excelsior { get; }
        public string OWL_Philadelphia_Fusion { get; }
        public string OWL_San_Francisco_Shock { get; }
        public string OWL_Seoul_Dynasty { get; }
        public string OWL_Shanghai_Dragons { get; }
        #endregion
        #region Non Obtainable Skins

        public string Unknown { get; }
        public string OriginGotY { get; }
        public string OriginGotY2 { get; }
        public string BlizzCon { get; }
        public string Prepurchase { get; }
        public string Prepurchase2 { get; }
        #endregion
        #region Remainint Text

        public string remaining1 { get; }
        public string remaining2 { get; }
        public string Credits { get; }

        public string remAll { get; }//For "More Infos about remaining Costs"
        public string remNonEvent { get; }
        public string remEvent { get; }
        public string remWeapons { get; }
        #endregion
        #region Default Items

        public string Classic { get; }//Skin
        public string Heroic { get; }//Emote, Victory Pose, Highlight Intro
        public string Default { get; }//Weapon
        #endregion

        #endregion
    }
}
