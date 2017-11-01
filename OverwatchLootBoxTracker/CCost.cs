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
        private int myEpicEvent = 750;
        private int myLegendary = 1000;
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
        int myCostsWeapon = 0;
        string ii = "01";
        string SaveFolder = null;


        //Remaining costs of nonevent/event items
        public int RemCostsNonEvent
        {
            get
            {
                return myCostsNonEvent;
            }
        }

        public int RemCostsEvent
        {
            get
            {
                return myCostsEvent;
            }
        }

        public int RemCostsWeapon
        {
            get
            {
                myCostsWeapon = 75000;
                return myCostsWeapon;
            }
        }

        public void Calculate(string Folder)
        {
            SaveFolder = Folder;

            myCostsNonEvent = 0;
            myCostsEvent = 0;
            //myCostsWeapon = 0;

            Ana();
            Bastion();
            DVa();
            Doomfist();
            Genji();
            Hanzo();
            Junkrat();
            Lúcio();
            McCree();
            Mei();
            Mercy();
            Orisa();
            Pharah();
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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
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
                    if (i >= 9 || i <= 12)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                    if (i == 13)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i == 6 && i == 8)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                    if (i == 7)
                    {//Epic Halloween 16
                        myCostsEvent += myEpic;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i == 4)
                    {//Rare Halloween 16
                        myCostsEvent += myRare;
                    }
                    if (i >= 5 && i <= 6)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                }
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
                //Skins
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
                    {//Epic Halloween 16
                        myCostsEvent += myEpic;
                    }
                    if (i >= 9 && i <= 10)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                    if (i >= 11 && i <= 14)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                    if (i == 15)
                    {//Origin/GotY
                        
                    }
                    if (i == 16)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) == "false")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i == 6)
                    {//Epic Summer 16
                        myCostsEvent += myEpic;
                    }
                    if (i == 7)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) == "false")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i == 4 || i == 6)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                    if (i == 5)
                    {//Rare Halloween 16
                        myCostsEvent += myRare;
                    }
                }
            }
        }

        private void DVa()
        {
            inisHeroes = new IniStream(SaveFolder + "\\D.Va.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
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
                    {//Epic Summer 16
                        myCostsEvent += myEpic;
                    }
                    if (i >= 8 && i <= 12)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                    if (i >= 13 && i <= 14)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i >= 5 && i <= 6)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                    if (i == 7)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i == 4)
                    {//Rare Halloween 16
                        myCostsEvent += myRare;
                    }
                    if (i >= 5 && i <= 6)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                }
            }
        }

        private void Doomfist()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Doomfist.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i >= 5 && i <= 6)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i >= 7 && i <= 10)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                }
            }
        }

        private void Genji()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Genji.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
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
                    {//Epic Summer 16
                        myCostsEvent += myEpic;
                    }
                    if (i >= 8 && i <= 12)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                    if (i >= 13 && i <= 14)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i == 6)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i == 4)
                    {//Rare Halloween 16
                        myCostsEvent += myRare;
                    }
                    if (i == 5)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                }
            }
        }

        private void Hanzo()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Hanzo.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
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
                    if (i >= 8 && i <= 11)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                    if (i == 12)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i >= 6 && i <= 7)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i == 4 || i == 6)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                    if (i == 5)
                    {//Rare Halloween 16
                        myCostsEvent += myRare;
                    }
                }
            }
        }

        private void Junkrat()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Junkrat.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
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
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                    if (i >= 8 && i <= 11)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                    if (i == 12)
                    {//Legendary Halloween 16
                        myCostsEvent += myLegendary;
                    }
                    if (i == 13)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i >= 6 && i <= 7)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i >= 4 && i <= 5 || i == 7)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                    if (i == 6)
                    {//Rare Halloween 16
                        myCostsEvent += myRare;
                    }
                }
            }
        }

        private void Lúcio()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Lúcio.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
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
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                    if (i >= 8 && i <= 11)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                    if (i >= 12 && i <= 13)
                    {//Legendary Summer 16
                        myCostsEvent += myLegendary;
                    }
                    if (i == 14)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i == 6)
                    {//Epic Summer 16
                        myCostsEvent += myEpic;
                    }
                    if (i == 7)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i == 4 || i == 6)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                    if (i == 5)
                    {//Rare Halloween 16
                        myCostsEvent += myRare;
                    }
                }
            }
        }

        private void McCree()
        {
            inisHeroes = new IniStream(SaveFolder + "\\McCree.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
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
                    {//Epic Summer 16
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
                    if (i >= 13 && i <= 15)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i >= 6 && i <= 7)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i == 4)
                    {//Rare Halloween 16
                        myCostsEvent += myRare;
                    }
                    if (i == 5)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                }
            }
        }

        private void Mei()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Mei.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i >= 5 && i <= 6)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i >= 7 && i <= 10)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                    if (i >= 11 && i <= 15)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i >= 6 && i <= 9)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i >= 4 && i <= 5)
                    {//Rare Summer/Halloween 16
                        myCostsEvent += myRare;
                    }
                    if (i == 6)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                }
            }
        }

        private void Mercy()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Mercy.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
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
                    {//Epic Summer 16
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
                    if (i == 13 || i == 15)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                    if (i == 14)
                    {//Legendary Halloween 16
                        myCostsEvent += myLegendary;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i == 6)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i == 4 || i == 6)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                    if (i == 5)
                    {//Rare Halloween 16
                        myCostsEvent += myRare;
                    }
                }
            }
        }

        private void Orisa()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Orisa.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i >= 5 && i <= 6)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i >= 7 && i <= 10)
                    {//Legendary
                        myCostsNonEvent += myLegendary;
                    }
                    if (i == 11)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i == 6)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i == 4)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                }
            }
        }

        private void Pharah()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Pharah.ini");

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
                //Skins
                if (inisHeroes.Read("SK" + ii) != "true")
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
                    if (i == 13)
                    {//Origin/GotY

                    }
                    if (i == 14)
                    {//Legendary Event
                        myCostsEvent += myLegendaryEvent;
                    }
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)
                    {//Epic
                        myCostsNonEvent += myEpic;
                    }
                    if (i >= 6 && i <= 7)
                    {//Epic Event
                        myCostsEvent += myEpicEvent;
                    }
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)
                    {//Rare
                        myCostsNonEvent += myRare;
                    }
                    if (i >= 4 && i <= 5)
                    {//Rare Summer/Halloween 16
                        myCostsEvent += myRare;
                    }
                    if (i == 6)
                    {//Rare Event
                        myCostsEvent += myRareEvent;
                    }
                }
            }
        }
    }
}
