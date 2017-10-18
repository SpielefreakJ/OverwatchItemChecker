using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverwatchLootBoxTracker
{
    public class CSpray
    {
        private int mySpray = 25;
        private int myEventSpray = 0;

        public CSpray()
        {
            //throw new System.NotImplementedException();
        }

        public int Common
        {
            get
            {
                return mySpray;
            }
        }

        public int Event
        {
            get
            {
                return myEventSpray;
            }
        }

        public int KostenGes
        {
            get
            {
                return (1 * mySpray);
            }
        }
    }
}