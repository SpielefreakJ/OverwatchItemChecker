using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Zarya
    {
        public Zarya()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "ZARYA";

            #region Skin
            //Rare
            Brick_SK = "ZIEGELSTEIN";
            Goldenrod_SK = "GOLDRUTE";
            Taiga_SK = "TAIGA";
            Violet_SK = "VIOLETT";
            //Epic
            Dawn_SK = "MORGENGRAUEN";
            Midnight_SK = "MITTERNACHT";
            Frosted_SK = "BEREIFT";//Winter 16
            //Legendary
            Barbarian_SK = "BARBARIN";
            Arctic_SK = "ARKTIS";
            Siberian_Front_SK = "SIBIRISCHE FRONT";
            Cybergoth_SK = "CYBERGOTH";
            Industrial_SK = "INDUSTRIAL";
            Champion_SK = "CHAMPION";//Summer 16
            Weightlifter_SK = "GEWICHTHEBERIN";//Summer 16
            Totally_80s_SK = "ACHZIGER";//Halloween 17
            Cyberian_SK = "CYBIRISCH";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Bring_it_on_EM = "AUFSTACHELN";
            Comedy_Gold_EM = "KOMIKERGOLD";
            Crush_you_EM = "ZERMATSCHEN";
            Punping_Iron_EM = "GEWEHR STEMMEN";
            Take_a_knee_EM = "KNIEND";
            Dance_EM = "TANZEN";//Annyver 17
            //Legendary
            Mystery_Gift_EM = "GEHEIMNISVOLLES GESCHENK";//Winter 16
            #endregion
            #region Victory Poses
            //Rare
            Casual_VP = "LÄSSIG";
            Check_out_this_gun_VP = "DAS IST EINE WAFFE";
            Flexing_VP = "MUSKELSPIEL";
            RIP_VP = "R.I.P.";//Halloween 16
            Toast_VP = "PROST";//Winter 17
            This_is_strength_VP = "DAS IST STÄRKE";//Uprising 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Brick_SK { get; }//Rare
        public string Goldenrod_SK { get; }
        public string Taiga_SK { get; }
        public string Violet_SK { get; }

        public string Dawn_SK { get; }//Epic
        public string Midnight_SK { get; }
        public string Frosted_SK { get; }//Winter 16

        public string Barbarian_SK { get; }//Legendary
        public string Arctic_SK { get; }
        public string Siberian_Front_SK { get; }
        public string Cybergoth_SK { get; }
        public string Industrial_SK { get; }
        public string Champion_SK { get; }//Summer 16
        public string Weightlifter_SK { get; }//Summer 16
        public string Totally_80s_SK { get; }//Halloween 17
        public string Cyberian_SK { get; }//Annyver 17
        #endregion
        #region Emotes

        public string Bring_it_on_EM { get; }//Epic
        public string Comedy_Gold_EM { get; }
        public string Crush_you_EM { get; }
        public string Punping_Iron_EM { get; }
        public string Take_a_knee_EM { get; }
        public string Dance_EM { get; }//Annyver 17

        public string Mystery_Gift_EM { get; }//Legendary //Winter 16
        #endregion
        #region Victory Poses

        public string Casual_VP { get; }//Rare
        public string Check_out_this_gun_VP { get; }
        public string Flexing_VP { get; }
        public string RIP_VP { get; }//Halloween 16
        public string Toast_VP { get; }//Winter 17
        public string This_is_strength_VP { get; }//Uprising 17
        #endregion

        #endregion
    }
}
