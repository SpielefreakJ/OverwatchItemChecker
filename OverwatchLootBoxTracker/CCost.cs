using System;
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
        private int myGoldWeapon = 3000;

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

        public int GoldWeapon
        {
            get
            {
                return myGoldWeapon;
            }
        }



        public int CostsNonEvent
        {
            get
            {
                //Skins Non-Event
                myKostenNormal = (25 * myClassic) + (100 * myRare) + (50 * myEpic) + (104 * myLegendary);

                return myKostenNormal;
            }
        }

        public int CostsEvent
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

        public int CostsGoldWeapon
        {
            get
            {
                return (25 * myGoldWeapon);
            }
        }


        //Calculate all Costs

        IniStream inisHeroes = null;
        int myCostsNonEvent = 0;
        int myCostsEvent = 0;
        string ii = "01";
        string SaveFolder=null;

        private void Calculate(string Folder)
        {
            SaveFolder = Folder;
            Ana();
        }

        private void Ana()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Ana.ini");

            for (int i = 1; i <= 40; i++)
            {
                if (i < 10)
                {
                    ii = "0" + i.ToString();
                }
                else
                {
                    ii = i.ToString();
                }
                try
                {//Skins
                    if (inisHeroes.Read("SK" + ii) == "false")
                    {
                        if (i >= 1 && i <= 4)
                        {//Rare
                            myCostsNonEvent += myRare;
                        }
                        if (i >= 5 && i <= 6)
                        {//Epic
                            myCostsNonEvent += myEpic;
                        }
                        if (i == 7)
                        {//Epic Halloween 16
                            myCostsEvent += myEpic;
                        }
                        if (i == 8)
                        {//Epic Event
                            myCostsEvent += myEpicEvent;
                        }
                        if (i >= 9 && i <= 12)
                        {//Legendary
                            myCostsNonEvent += myLegendary;
                        }
                        if (i >= 13)
                        {//Legendary Event
                            myCostsEvent += myLegendaryEvent;
                        }
                    }
                }
                catch { }
                try
                {//Emotes
                    if (inisHeroes.Read("EM" + ii) == "false")
                    {
                        if (i >= 1 && i <= 5)
                        {//Epic
                            myCostsNonEvent += myEpic;
                        }
                        if (i == 7)
                        {//Epic Halloween 16
                            myCostsEvent += myEpic;
                        }
                        if (i == 6 && i == 8)
                        {//Epic Event
                            myCostsEvent += myEpicEvent;
                        }
                    }
                }
                catch { }
                try
                {//Victory Poses
                    if (inisHeroes.Read("VP" + ii) == "false")
                    {
                        if (i >= 1 && i <= 3)
                        {//Epic
                            myCostsNonEvent += myRare;
                        }
                        if (i == 4)
                        {//Epic Halloween 16
                            myCostsEvent += myRare;
                        }
                        if (i >= 5 && i <= 6)
                        {//Epic Event
                            myCostsEvent += myRare;
                        }
                    }
                }
                catch { }
            }
        }

        private void Bastion()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Bastion.ini");

            for (int i = 1; i <= 40; i++)
            {
                if (i < 10)
                {
                    ii = "0" + i.ToString();
                }
                else
                {
                    ii = i.ToString();
                }
                try
                {//Skins
                    if (inisHeroes.Read("SK" + ii) == "false")
                    {
                        if (i >= 1 && i <= 4)
                        {//Rare
                            myCostsNonEvent += myRare;
                        }
                        if (i >= 5 && i <= 6)
                        {//Epic
                            myCostsNonEvent += myEpic;
                        }
                        if (i == 7)
                        {//Epic BlizzCon 16
                            
                        }
                        if (i == 8)
                        {//EpicEvent
                            myCostsEvent += myEpicEvent;
                        }
                        if (i >= 9 && i <= 12)
                        {//Legendary
                            myCostsNonEvent += myLegendary;
                        }
                        if (i >= 13)
                        {//LegendaryEvent
                            myCostsEvent += myLegendaryEvent;
                        }
                    }
                }
                catch { }
                try
                {//Emotes
                    if (inisHeroes.Read("EM" + ii) == "false")
                    {
                        if (i >= 1 && i <= 5)
                        {//Epic
                            myCostsNonEvent += myEpic;
                        }
                        if (i == 7)
                        {//EpicHalloween 16
                            myCostsEvent += myEpic;
                        }
                        if (i == 6 && i == 8)
                        {//EpicEvent
                            myCostsEvent += myEpicEvent;
                        }
                    }
                }
                catch { }
                try
                {//Victory Poses
                    if (inisHeroes.Read("VP" + ii) == "false")
                    {
                        if (i >= 1 && i <= 3)
                        {//Epic
                            myCostsNonEvent += myRare;
                        }
                        if (i == 4)
                        {//EpicHalloween 16
                            myCostsEvent += myRare;
                        }
                        if (i >= 5 && i <= 6)
                        {//EpicEvent
                            myCostsEvent += myRare;
                        }
                    }
                }
                catch { }
            }
        }
    }
}
