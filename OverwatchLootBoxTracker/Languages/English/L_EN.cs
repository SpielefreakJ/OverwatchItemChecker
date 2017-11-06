using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Lang
{
    class L_EN
    {
        string Changes;

        public L_EN()
        {
            ChangesT();
        }

        private void ChangesT()
        {
            Changes = "\n\n\nAlpha Version!\n\nFeatures:\n - Save Skins\n - Save Emotes\n - Save Victory Poses\n\nLanguages:\n- German\n- English";
        }


        //Welcome Screen

        public string Welcome
        {
            get
            {
                return "Welcome";
            }
        }

        public string ChangesTitle
        {
            get
            {
                return "Changes";
            }
        }

        public string ChangesText
        {
            get
            {
                return Changes;
            }
        }


        
        //All Settings

        public string Settings
        {
            get
            {
                return "Settings";
            }
        }

        public string LangSettings
        {
            get
            {
                return "Change Language";
            }
        }

        public string MoreCost
        {
            get
            {
                return "More Info about Costs";
            }
        }

        public string Back
        {
            get
            {
                return "Back";
            }
        }

        public string DeleteSaves
        {
            get
            {
                return "Because of changed Saves we have to delete all saves.\nDirectory: C:\\USER\\USERNAME\\AppData\\Local\\OWItemTracker\n\nOK for Delete\nCancel to Close the App (to backup and check all old files)";
            }
        }

        public string DeleteSavesS
        {
            get
            {
                return "Successfully Deleted!";
            }
        }


        //On Close

        public string Close
        {
            get
            {
                return "Close";
            }
        }

        public string AppClose
        {
            get
            {
                return "Test_EN";
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
                return "Victory Poses";
            }
        }

        public string VoiceLines
        {
            get
            {
                return "Voice Lines";
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
                return "Highlight Intros";
            }
        }

        public string Weapons
        {
            get
            {
                return "Weapons";
            }
        }

        public string PlayerIcons
        {
            get
            {
                return "Player Icons";
            }
        }
        //Events
        public string Summer
        {
            get
            {
                return "Summer Games";
            }
        }

        public string Halloween
        {
            get
            {
                return "Halloween Terror";
            }
        }

        public string Winter
        {
            get
            {
                return "Winter Wonderland";
            }
        }

        public string Rooster
        {
            get
            {
                return "Year of the Rooster";
            }
        }

        public string Uprising
        {
            get
            {
                return "Overwatch Uprising";
            }
        }

        public string Annyver
        {
            get
            {
                return "Annyversary";
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
                return "Only in Origin or GotY";
            }
        }

        public string BlizzCon
        {
            get
            {
                return "Only w/ BlizzCon Ticket";
            }
        }

        public string Prepurchase
        {
            get
            {
                return "Prepurchase of Overwatch";
            }
        }



        //Remainint Text

        public string remaining1
        {
            get
            {
                return "Remaining costs of all items:";
                //return "Cost of remaining items:";
            }
        }

        public string remaining2
        {
            get
            {
                return "Credits and";
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
                return "Remaining costs of all Items:";
                //return "Costs of all remaining Items:";
            }
        }
        public string remNonEvent
        {
            get
            {
                return "Remaining costs of all non-event Items:";
                //return "Costs of remaining non-event Items:";
            }
        }

        public string remEvent
        {
            get
            {
                return "Remaining costs of all event Items:";
                //return "Costs of remaining event Items:";
            }
        }

        public string remWeapons
        {
            get
            {
                return "Remaining costs of all Weapon Items:";
                //return "Costs of remaining Weapon Items:";
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
