using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Languages.German.Heroes
{
    class Brigitte
    {
        public Brigitte()
        {
            //You're able to edit here everything in between all " Symbols

            Name = "Brigitte";

            #region Skins
            //Rare
            Blå_SK = "BLÅ";
            Grön_SK = "GRÖN";
            Plommon_SK = "PLOMMON";
            Röd_SK = "RÖD";
            //Epic
            Carbon_Fiber_SK = "CARBON FIBER";
            Ironclad_SK = "IRONCLAD";
            //Legendary
            Máni_SK = "MÁNI";
            Sól_SK = "SÓL";
            Engineer_SK = "ENGINEER";
            Mechanic_SK = "MECHANIC";
            #endregion
            #region Emotes
            //Epic
            Cheer_EM = "CHEER";
            Hilarious_EM = "HILARIOUS";
            Recalibrate_EM = "RECALIBRATE";
            Taunt_EM = "TAUNT";
            #endregion
            #region Victory Poses
            //Rare
            Confident_VL = "CONFIDENT";
            Rally_VL = "RALLY";
            Relaxed_VL = "RELAXED";
            #endregion
        }

        #region Variablen

        public string Name { get; }

        #region Skins

        public string Blå_SK { get; }//Rare
        public string Grön_SK { get; }
        public string Plommon_SK { get; }
        public string Röd_SK { get; }

        public string Carbon_Fiber_SK { get; }//Epic
        public string Ironclad_SK { get; }

        public string Máni_SK { get; }//Legendary
        public string Sól_SK { get; }
        public string Engineer_SK { get; }
        public string Mechanic_SK { get; }
        #endregion
        #region Emotes

        public string Cheer_EM { get; }//Epic
        public string Hilarious_EM { get; }
        public string Recalibrate_EM { get; }
        public string Taunt_EM { get; }
        #endregion
        #region Victory Poses

        public string Confident_VL { get; }//Rare
        public string Rally_VL { get; }
        public string Relaxed_VL { get; }
        #endregion

        #endregion
    }
}
