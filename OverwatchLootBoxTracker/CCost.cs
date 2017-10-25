﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker
{
    class CCost
    {
        private int myClassic = 0;
        private int myCommon = 25;
        private int myCommonEvent = 75;
        private int myRare = 75;
        private int myRareEvent = 225;
        private int myEpic = 250;
        private int myLegendary = 1000;
        private int myEpicEvent = 750;
        private int myLegendaryEvent = 3000;
        private int myOriginGotY = 0;
        private int myPrepushcase = 0;
        private int myBlizzCon = 0;
        private int myUnknown = 0;
        private string myPrepurchase = "";

        private int myKostenNormal;
        private int myKostenFest;


        public CCost()
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

        public int Common
        {//Silver (Normal and 2016 Summer/Halloween)
            get
            {
                return myCommon;
            }
        }

        public int CommonEvent
        {//Silver Event (Winter and later)
            get
            {
                return myCommonEvent;
            }
        }

        public int Rare
        {//Blue (Normal and 2016 Summer/Halloween)
            get
            {
                return myRare;
            }
        }

        public int RareEvent
        {//Blue Event (Winter and later)
            get
            {
                return myRareEvent;
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

        public string Prepurchase
        {//Prepurchase only
            get
            {
                return myPrepurchase;
            }
        }

        public int KostenNormal
        {
            get
            {
                //Skins Non-Event
                myKostenNormal = (25 * myClassic) + (100 * myRare) + (50 * myEpic) + (104 * myLegendary);
                
                return myKostenNormal;
            }
        }

        public int KostenFest
        {
            get
            {
                //Skins Event Old
                myKostenFest = (16 * myEpic) + (6 * myLegendary);
                //Skin Event New
                myKostenFest += (15 * myEpicEvent) + (56 * myLegendaryEvent);

                //Origin/GotY, Prepushcase and BlizzCon
                myKostenFest += (5 * OriginGotY) + (1 * myPrepushcase) + (2 * myBlizzCon);

                return myKostenFest;
            }
        }
    }
}
