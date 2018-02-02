using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Mei
    {
        public Mei()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "MEI";

            #region Skin
            //Rare
            Chrysanthemum_SK = "CHRYSANTHEME";
            Heliotrope_SK = "HELIOTROP";
            Jade_SK = "JADE";
            Persimmon_SK = "KAKI";
            //Epic
            Earthen_SK = "IRDEN";
            Snow_Plum_SK = "SCHNEEPFLAUME";
            //Legendary
            Ecopoint_Antarctica_SK = "ECOPOINT: ANTARKTIS";
            Firefighter_SK = "FEUERWEHRFRAU";
            Rescue_Mei_SK = "RETTERIN MEI";
            Abominable_SK = "SCHNEEMENSCH";
            Yeti_Hunter_SK = "YETIJÄGER";
            Jiangshi_SK = "JIANG`SHI";//Halloween 17
            Mei_rry_SK = "FESTTAGSKOSTÜM";//Winter 16
            Chang_e_SK = "CHANG'E";//Rooster 17
            Luna_SK = "LUNA";//Rooster 17
            Beekeeper_SK = "IMKERIN";//Annyver 17
            #endregion
            #region Emotes
            //Epic
            Companion_EM = "WEGGEFÄHRTE";
            Gigle_EM = "KICHERND";
            Kneel_EM = "KNIEND";
            Spray_EM = "WINTERHAUCH";
            Yaaaaaaaaay_EM = "YIPPIE!";
            Hopping_EM = "HÜPFEN";//Halloween 17
            Snowman_EM = "SCHNEEMANN";//Winter 16
            So_excited_EM = "SOOO AUFGEREGT";//Rooster 17
            Sunny_Dance_EM = "FRÖHLICHER TANZ";//Annyver 17
            #endregion
            #region Victory Poses
            //Rare
            Casual_VP = "LÄSSIG";
            Hands_on_hips_VP = "HÄNDE IN DEN HÜFTEN";
            Kneeling_VP = "KNIEND";
            Medal_VP = "MEDAILLE";//Summer 16
            RIP_VP = "R.I.P.";//Halloween 16
            Lucky_VP = "GLÜCK GEHABT!";//Rooster 17
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skin

        public string Chrysanthemum_SK { get; }//Rare
        public string Heliotrope_SK { get; }
        public string Jade_SK { get; }
        public string Persimmon_SK { get; }

        public string Earthen_SK { get; }//Epic
        public string Snow_Plum_SK { get; }

        public string Ecopoint_Antarctica_SK { get; }//Legendary
        public string Firefighter_SK { get; }
        public string Rescue_Mei_SK { get; }
        public string Abominable_SK { get; }
        public string Yeti_Hunter_SK { get; }
        public string Jiangshi_SK { get; }//Halloween 17
        public string Mei_rry_SK { get; }//Winter 16
        public string Chang_e_SK { get; }//Rooster 17
        public string Luna_SK { get; }//Rooster 17
        public string Beekeeper_SK { get; }//Annyver 17
        #endregion
        #region Emotes

        public string Companion_EM { get; }//Epic
        public string Gigle_EM { get; }
        public string Kneel_EM { get; }
        public string Spray_EM { get; }
        public string Yaaaaaaaaay_EM { get; }
        public string Hopping_EM { get; }//Halloween 17
        public string Snowman_EM { get; }//Winter 16
        public string So_excited_EM { get; }//Rooster 17
        public string Sunny_Dance_EM { get; }//Annyver 17
        #endregion
        #region Victory Poses

        public string Casual_VP { get; }//Rare
        public string Hands_on_hips_VP { get; }
        public string Kneeling_VP { get; }
        public string Medal_VP { get; }//Summer 16
        public string RIP_VP { get; }//Halloween 16
        public string Lucky_VP { get; }//Rooster 17
        #endregion

        #endregion
    }
}
