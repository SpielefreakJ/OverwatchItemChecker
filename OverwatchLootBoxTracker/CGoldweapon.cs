using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverwatchLootBoxTracker
{
    public class CGoldweapon
    {
        private int myGoldWeapon = 3000;

        public CGoldweapon()
        {

        }

        public int GoldWeapon
        {
            get
            {
                return myGoldWeapon;
            }
        }

        public int KostenGes
        {
            get
            {
                return (25 * myGoldWeapon);
            }
        }
    }
}