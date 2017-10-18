using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class CSkin
    {
        private int myClassic = 0;
        private int myRare=75;
        private int myEpic=250;
        private int myLegendary=1000;
        private int myEpicEvent=750;
        private int myLegendaryEvent=3000;
        private int myBlizzCon=0;
        private int myUnknown=0;
        private int myOriginGotY=0;

        public CSkin()
        {
            //throw new System.NotImplementedException();
        }
        // All
        public int Classic
        {//Default
            get
            {
                return myClassic;
            }
        }

        public int Rare
        {//Blue
            get
            {
                return myRare;
            }
        }

        public int Epic
        {//Purple (Normal and 2016 Summer/Halloween)
            get
            {
                return myEpic;
            }
        }

        public int EpicEvent
        {//Purple Event (Winter and later)
            get
            {
                return myEpicEvent;
            }
        }

        public int Legendary
        {//Gold (Normal and 2016 Summer/Halloween)
            get
            {
                return myLegendary;
            }
        }

        public int LegendaryEvent
        {//Gold Event (Winter and later)
            get
            {
                return myLegendaryEvent;
            }
        }

        public int OriginGotY
        {//Only in Origin / Game of the Year
            get
            {
                return myOriginGotY;
            }
        }

        public int BlizzCon
        {//Only with BlizzCon Ticket
            get
            {
                return myBlizzCon;
            }
        }

        public int Unknown
        {//Not Known Credit
            get
            {
                return myUnknown;
            }
        }

        public int KostenNormal
        {
            get
            {
                int Kosten = (25 * myClassic) + (100 * myRare) + (50 * myEpic) + (104 * myLegendary);
                return Kosten;
            }
        }

        public int KostenFest
        {
            get
            {
                int Kosten = 0;
                return Kosten;
            }
        }
    }
}
