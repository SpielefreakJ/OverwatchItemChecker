using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Lang
{
    class L_EN
    {
        string Year = "2016"; //Pls do NOT Change this!

        public L_EN()
        {
            //You're able to edit here everything in between all " Symbols

            ChangesText = "\n\n\nBeta Version!\n\nFeatures:\n - Save Skins\n - Save Emotes\n - Save Victory Poses\n\nNewest Addings:\nNew Menu!\nNew Hero: Brigitte\nHero items can now be displayed.\nAdded Overwatch League Skins as well as Winter, Lunar and Blizzardworld Items\nLess lag when changing status of an item\n\nLanguages:\n- English\n- German";

            #region Welcome Screen
            Welcome = "Welcome";
            ChangesTitle = "Changes";
            #endregion
            #region All Settings
            Settings = "Settings";
            LangSettings = "Change Language";
            MoreCost = "More info about costs";
            Back = "Back";
            DeleteSaves = "Because of changed Saves we have to delete all saves.\nDirectory: C:\\USER\\USERNAME\\AppData\\Local\\OWItemTracker\n\nOK for Delete\nCancel to Close the App (to backup and check all old files)";
            DeleteSavesS = "Successfully deleted!";
            #endregion

            //On Close
            Close = "Close";
            AppClose = "Saved.";

            #region Categories
            Skin = "Skins";
            Emotes = "Emotes";
            VictoryPoses = "Victory Poses";
            VoiceLines = "Voice Lines";
            Sprays = "Sprays";
            HighlightIntros = "Highlight Intros";
            Weapons = "Weapons";
            PlayerIcons = "Player Icons";
            // Overwatch League
            OWLeague = "Overwatch League";
            #endregion
            #region Events
            Summer = "Summer Games";
            Halloween = "Halloween Terror";
            Winter = "Winter Wonderland";
            Rooster = "Year of the Rooster";
            Dog = "Year of the Dog";
            Uprising = "Overwatch Uprising";
            Annyver = "Annyversary";
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
            OriginGotY2 = "Only /w Origin or GotY Edition";
            BlizzCon = "BlizzCon";
            Prepurchase = "Prepurchase";
            Prepurchase2 = "Only /w Prepurchase";
            #endregion
            #region Remainint Text
            remaining1 = "Remaining costs of all items:";
            remaining2 = "Credits and";
            Credits = "Credits";

            //For "More Infos about remaining Costs"
            remAll = "Remaining costs of all items:";
            remNonEvent = "Remaining costs of all non-event items:";
            remEvent = "Remaining costs of all event items:";
            //return "Costs of remaining event Items:";
            remWeapons = "Remaining costs of all weapon items:";
            #endregion
            #region Default Items
            Classic = "Classic";//Skin
            Heroic = "Heroic";//Emote, Victory Pose, Highlight Intro
            Default = "Default";//Weapon
            GoldWeapon = "GoldWeapon";//GoldWeapon
            #endregion


        }

        public string BlizzCon2
        {
            //Because of the changeable Year, Blizzcon needs a special 
            get
            {
                return "Only /w BlizzCon " + Year + " Ticket";
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
        public string GoldWeapon { get; }//GoldWeapon
        #endregion

        #endregion
    }
}
