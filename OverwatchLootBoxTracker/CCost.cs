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

        private int myMaxItems = 24;


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


        #region OldCalc
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
                return (26 * myGoldWeapon);
            }
        }

        public int CostsOWLSkin
        {
            get
            {
                return (100);
            }
        }
        #endregion


        //Calculate all Costs

        IniStream inisHeroes = null;

        int[] myCosts = new int[28];
        int[] myCostsEvent = new int[28];
        int[] myCostsWeapon = new int[28];
        string ii = "01";
        string SaveFolder = null;


        //Remaining costs of nonevent/event items
        public int RemCostsNonEvent
        {
            get
            {
                myCosts[0] = 0;

                for (int i = 1; i <= myCosts.Length-1; i++)
                {
                    myCosts[0] += myCosts[i];
                }

                return myCosts[0];
            }
        }

        public int RemCostsEvent
        {
            get
            {
                myCostsEvent[0] = 0;

                for (int i = 1; i <= myCostsEvent.Length - 1; i++)
                {
                    myCostsEvent[0] += myCostsEvent[i];
                }

                return myCostsEvent[0];
            }
        }

        public int RemCostsWeapon
        {
            get
            {
                myCostsWeapon[0] = 0;

                for (int i = 1; i <= myCostsWeapon.Length - 1; i++)
                {
                    myCostsWeapon[0] += myCostsWeapon[i];
                }

                return myCostsWeapon[0];
            }
        }

        //Reste Ausrechnen

        public void Calculate(string Folder, string Heroe)
        {
            SaveFolder = Folder;

            #region Heroes
            if (Heroe == "Ana")
                Ana();
            if (Heroe == "Bastion")
                Bastion();
            if (Heroe == "Brigitte")
                Brigitte();
            if (Heroe == "D.Va")
                DVa();
            if (Heroe == "Doomfist")
                Doomfist();
            if (Heroe == "Genji")
                Genji();
            if (Heroe == "Hanzo")
                Hanzo();
            if (Heroe == "Junkrat")
                Junkrat();
            if (Heroe == "Lúcio")
                Lúcio();
            if (Heroe == "McCree")
                McCree();
            if (Heroe == "Mei")
                Mei();
            //
            if (Heroe == "Mercy")
                Mercy();
            if (Heroe == "Moira")
                Moira();
            if (Heroe == "Orisa")
                Orisa();
            if (Heroe == "Pharah")
                Pharah();
            if (Heroe == "Reaper")
                Reaper();
            if (Heroe == "Reinhardt")
                Reinhardt();
            if (Heroe == "Roadhog")
                Roadhog();
            if (Heroe == "Soldier 76")
                Soldier_76();
            if (Heroe == "Sombra")
                Sombra();
            if (Heroe == "Symmetra")
                Symmetra();
            //
            if (Heroe == "Torbjörn")
                Torbjörn();
            if (Heroe == "Tracer")
                Tracer();
            if (Heroe == "Widowmaker")
                Widowmaker();
            if (Heroe == "Winston")
                Winston();
            if (Heroe == "Zarya")
                Zarya();
            if (Heroe == "Zenyatta")
                Zenyatta();

            if (Heroe == "All")
            {
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
                Moira();
                Orisa();
                Pharah();
                Reaper();
                Reinhardt();
                Roadhog();
                Soldier_76();
                Sombra();
                Symmetra();
                Torbjörn();
                Tracer();
                Widowmaker();
                Winston();
                Zarya();
                Zenyatta();
            }

            #endregion
        }

        private void Ana()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Ana.ini");

            myCosts[1] = 0;
            myCostsEvent[1] = 0;
            myCostsWeapon[1] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[1] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[1] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[1] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[1] += myEpic;
                    if (i == 8)//Epic Event
                        myCostsEvent[1] += myEpicEvent;
                    if (i >= 9 && i <= 12)//Legendary
                        myCosts[1] += myLegendary;
                    if (i >= 13 && i <= 14)//Legendary Event
                        myCostsEvent[1] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[1] += myEpic;
                    if (i == 6 || i == 8)//Epic Event
                        myCostsEvent[1] += myEpicEvent;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[1] += myEpic;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[1] += myRare;
                    if (i >= 4 && i <= 5)//Rare Old Event
                        myCostsEvent[1] += myRare;
                    if (i == 6)//Rare Event
                        myCostsEvent[1] += myRareEvent;
                }
            }
        }

        private void Bastion()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Bastion.ini");

            myCosts[2] = 0;
            myCostsEvent[2] = 0;
            myCostsWeapon[2] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[2] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[2] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[2] += myEpic;
                    if (i == 7)//Epic BlizzCon 16
                        myCosts[2] += myBlizzCon;
                    if (i == 8)//Epic Old Event
                        myCostsEvent[2] += myEpic;
                    if (i >= 9 && i <= 10)//Epic Event
                        myCostsEvent[2] += myEpicEvent;
                    if (i >= 11 && i <= 14)//Legendary
                        myCosts[2] += myLegendary;
                    if (i == 15)//Origin/GotY
                        myCosts[2] += myOriginGotY;
                    if (i >= 16 && i <= 17)//Legendary Event
                        myCostsEvent[2] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[2] += myEpic;
                    if (i == 6)//Epic Old Event
                        myCostsEvent[2] += myEpic;
                    if (i == 7)//Epic Event
                        myCostsEvent[2] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[2] += myRare;
                    if (i == 4 || i == 6 || i == 7)//Rare Event
                        myCostsEvent[2] += myRareEvent;
                    if (i == 5)//Ra2re Old Event
                        myCostsEvent[2] += myRare;
                }
            }
        }

        private void Brigitte()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Brigitte.ini");

            myCosts[27] = 0;
            myCostsEvent[27] = 0;
            myCostsWeapon[27] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[27] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[27] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[27] += myEpic;
                    if (i >= 7 && i <= 10)//Legendary
                        myCosts[27] += myLegendary;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Epic
                        myCosts[27] += myEpic;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[27] += myRare;
                }
            }
        }

        private void DVa()
        {
            inisHeroes = new IniStream(SaveFolder + "\\D.Va.ini");

            myCosts[3] = 0;
            myCostsEvent[3] = 0;
            myCostsWeapon[3] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[3] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[3] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[3] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[3] += myEpic;
                    if (i >= 8 && i <= 12)//Legendary
                        myCosts[3] += myLegendary;
                    if (i >= 13 && i <= 14)//Legendary Event
                        myCostsEvent[3] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Epic
                        myCosts[3] += myEpic;
                    if (i == 5)//Epic Old Event
                        myCostsEvent[3] += myEpicEvent;
                    if (i == 6)//Epic Event
                        myCostsEvent[3] += myEpicEvent;
                    if (i == 7)//Legendary
                        myCosts[3] += myLegendary;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[3] += myRare;
                    if (i >= 4 && i <= 5)//Rare Old Event
                        myCostsEvent[3] += myRare;
                    if (i == 6)//Rare Event
                        myCostsEvent[3] += myRareEvent;
                }
            }
        }

        private void Doomfist()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Doomfist.ini");

            myCosts[4] = 0;
            myCostsEvent[4] = 0;
            myCostsWeapon[4] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[4] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[4] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[4] += myEpic;
                    if (i >= 7 && i <= 11)//Legendary
                        myCosts[4] += myLegendary;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[4] += myEpic;
                    if (i == 6)//Epic Event
                        myCostsEvent[4] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[4] += myRare;
                }
            }
        }

        private void Genji()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Genji.ini");

            myCosts[5] = 0;
            myCostsEvent[5] = 0;
            myCostsWeapon[5] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[5] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[5] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[5] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[5] += myEpic;
                    if (i >= 8 && i <= 12)//Legendary
                        myCosts[5] += myLegendary;
                    if (i >= 13 && i <= 15)//Legendary Event
                        myCostsEvent[5] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[5] += myEpic;
                    if (i == 6)//Epic Event
                        myCostsEvent[5] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[5] += myRare;
                    if (i == 4)//Rare Old Event
                        myCostsEvent[5] += myRare;
                    if (i >= 5 && i <= 6)//Rare Event
                        myCostsEvent[5] += myRareEvent;
                }
            }
        }

        private void Hanzo()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Hanzo.ini");

            myCosts[6] = 0;
            myCostsEvent[6] = 0;
            myCostsWeapon[6] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[6] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[6] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[6] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[6] += myEpic;
                    if (i >= 8 && i <= 11 || i == 14)//Legendary
                        myCosts[6] += myLegendary;
                    if (i >= 12 && i <= 13)//Legendary Event
                        myCostsEvent[6] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[6] += myEpic;
                    if (i >= 6 && i <= 7)//Epic Event
                        myCostsEvent[6] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[6] += myRare;
                    if (i == 4 || i == 6)//Rare Event
                        myCostsEvent[6] += myRareEvent;
                    if (i == 5)//Rare Old Event
                        myCostsEvent[6] += myRare;
                }
            }
        }

        private void Junkrat()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Junkrat.ini");

            myCosts[7] = 0;
            myCostsEvent[7] = 0;
            myCostsWeapon[7] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[7] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[7] += myRare;
                    if (i >= 5 && i <= 6 || i == 15)//Epic
                        myCosts[7] += myEpic;
                    if (i == 7)//Epic Event
                        myCostsEvent[7] += myEpicEvent;
                    if (i >= 8 && i <= 11)//Legendary
                        myCosts[7] += myLegendary;
                    if (i == 12 || i == 14)//Legendary Event
                        myCostsEvent[7] += myLegendaryEvent;
                    if (i == 13)//Legendary Old Event
                        myCostsEvent[7] += myLegendary;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[7] += myEpic;
                    if (i >= 6 && i <= 7)//Epic Event
                        myCostsEvent[7] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[7] += myRare;
                    if (i >= 4 && i <= 5)//Rare Event
                        myCostsEvent[7] += myRareEvent;
                    if (i >= 6 && i <= 7)//Rare Old Event
                        myCostsEvent[7] += myRare;
                }
            }
        }

        private void Lúcio()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Lúcio.ini");

            myCosts[8] = 0;
            myCostsEvent[8] = 0;
            myCostsWeapon[8] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[8] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[8] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[8] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[8] += myEpic;
                    if (i >= 8 && i <= 11 || i == 15)//Legendary
                        myCosts[8] += myLegendary;
                    if (i >= 12 && i <= 13)//Legendary Old Event
                        myCostsEvent[8] += myLegendary;
                    if (i == 14)//Legendary Event
                        myCostsEvent[8] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[8] += myEpic;
                    if (i == 6)//Epic Old Event
                        myCostsEvent[8] += myEpic;
                    if (i == 7)//Epic Event
                        myCostsEvent[8] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[8] += myRare;
                    if (i == 4 || i == 6)//Rare Event
                        myCostsEvent[8] += myRareEvent;
                    if (i == 5)//Rare Old Event
                        myCostsEvent[8] += myRare;
                }
            }
        }

        private void McCree()
        {
            inisHeroes = new IniStream(SaveFolder + "\\McCree.ini");

            myCosts[9] = 0;
            myCostsEvent[9] = 0;
            myCostsWeapon[9] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[9] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[9] += myRare;
                    if (i >= 5 && i <= 6 || i == 16)//Epic
                        myCosts[9] += myEpic;
                    if (i >= 7 && i <= 8)//Epic Old Event
                        myCostsEvent[9] += myEpic;
                    if (i >= 9 && i <= 12)//Legendary
                        myCosts[9] += myLegendary;
                    if (i >= 13 && i <= 15 || i == 17)//Legendary Event
                        myCostsEvent[9] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[9] += myEpic;
                    if (i == 6)//Epic Winter 16
                        myCostsEvent[9] += myEpic;
                    if (i == 7)//Epic Event
                        myCostsEvent[9] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[9] += myRare;
                    if (i == 4)//Rare Old Event
                        myCostsEvent[9] += myRare;
                    if (i >= 5 && i <= 6)//Rare Event
                        myCostsEvent[9] += myRareEvent;
                }
            }
        }
        //
        private void Mei()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Mei.ini");

            myCosts[10] = 0;
            myCostsEvent[10] = 0;
            myCostsWeapon[10] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[10] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[10] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[10] += myEpic;
                    if (i >= 7 && i <= 10 || i == 16)//Legendary
                        myCosts[10] += myLegendary;
                    if (i == 11 || i == 15)//Legendary Event
                        myCostsEvent[10] += myLegendaryEvent;
                    if (i >= 12 && i <= 14)//Legendary Old Event
                        myCostsEvent[10] += myLegendary;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[10] += myEpic;
                    if (i == 6 || i == 9)//Epic Event
                        myCostsEvent[10] += myEpicEvent;
                    if (i == 7 || i == 8)//Epic Old Event
                        myCostsEvent[10] += myEpic;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[10] += myRare;
                    if (i >= 4 && i <= 6)//Rare Old Event
                        myCostsEvent[10] += myRare;
                }
            }
        }

        private void Mercy()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Mercy.ini");

            myCosts[11] = 0;
            myCostsEvent[11] = 0;
            myCostsWeapon[11] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[11] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[11] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[11] += myEpic;
                    if (i >= 7 && i <= 8)//Epic Old Event
                        myCostsEvent[11] += myEpic;
                    if (i >= 9 && i <= 12)//Legendary
                        myCosts[11] += myLegendary;
                    if (i == 13 || i >= 15 && i <= 16)//Legendary Event
                        myCostsEvent[11] += myLegendaryEvent;
                    if (i == 14)//Legendary Old Event
                        myCostsEvent[11] += myLegendary;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5 || i == 7)//Epic
                        myCosts[11] += myEpic;
                    if (i == 6)//Epic Event
                        myCostsEvent[11] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[11] += myRare;
                    if (i == 4 || i == 7)//Rare Event
                        myCostsEvent[11] += myRareEvent;
                    if (i >= 5 && i <= 6)//Rare Old Event
                        myCostsEvent[11] += myRare;
                }
            }
        }

        private void Moira()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Moira.ini");

            myCosts[12] = 0;
            myCostsEvent[12] = 0;
            myCostsWeapon[12] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[12] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[12] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[12] += myEpic;
                    if (i >= 7 && i <= 10)//Legendary
                        myCosts[12] += myLegendary;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 6)//Epic
                        myCosts[12] += myEpic;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[12] += myRare;
                }
            }
        }

        private void Orisa()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Orisa.ini");

            myCosts[13] = 0;
            myCostsEvent[13] = 0;
            myCostsWeapon[13] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[13] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[13] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[13] += myEpic;
                    if (i >= 7 && i <= 10 || i == 12)//Legendary
                        myCosts[13] += myLegendary;
                    if (i == 11)//Legendary Event
                        myCostsEvent[13] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[13] += myEpic;
                    if (i == 6)//Epic Event
                        myCostsEvent[13] += myEpicEvent;
                    if (i == 7)//Legendary Event
                        myCostsEvent[13] += myLegendaryEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[13] += myRare;
                    if (i == 4)//Rare Event
                        myCostsEvent[13] += myRareEvent;
                }
            }
        }

        private void Pharah()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Pharah.ini");

            myCosts[14] = 0;
            myCostsEvent[14] = 0;
            myCostsWeapon[14] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[14] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[14] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[14] += myEpic;
                    if (i >= 7 && i <= 8)//Epic Old Event
                        myCostsEvent[14] += myEpic;
                    if (i >= 9 && i <= 12 || i == 15)//Legendary
                        myCosts[14] += myLegendary;
                    if (i == 13)//Origin/GotY
                        myCosts[14] += myOriginGotY;
                    if (i == 14 || i == 16)//Legendary Event
                        myCostsEvent[14] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[14] += myEpic;
                    if (i >= 6 && i <= 7)//Epic Event
                        myCostsEvent[14] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[14] += myRare;
                    if (i >= 4 && i <= 6)//Rare Old Event
                        myCostsEvent[14] += myRare;
                }
            }
        }

        private void Reaper()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Reaper.ini");

            myCosts[15] = 0;
            myCostsEvent[15] = 0;
            myCostsWeapon[15] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[15] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[15] += myRare;
                    if (i >= 5 && i <= 6 || i == 16)//Epic
                        myCosts[15] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[15] += myEpic;
                    if (i >= 8 && i <= 11)//Legendary
                        myCosts[15] += myLegendary;
                    if (i == 12)//Legendary Origin/GotY
                        myCosts[15] += myOriginGotY;
                    if (i >= 13 && i <= 14)//Legendary Event
                        myCostsEvent[15] += myLegendaryEvent;
                    if (i == 15)//Legendary Old Event
                        myCostsEvent[15] += myLegendary;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 6)//Epic
                        myCosts[15] += myEpic;
                    if (i == 7)//Epic Event
                        myCostsEvent[15] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[15] += myRare;
                    if (i >= 5 && i <= 6)//Rare Old Event
                        myCostsEvent[15] += myRare;
                }
            }
        }

        private void Reinhardt()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Reinhardt.ini");

            myCosts[16] = 0;
            myCostsEvent[16] = 0;
            myCostsWeapon[16] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[16] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[16] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[16] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[16] += myEpic;
                    if (i == 8)//Epic Event
                        myCostsEvent[16] += myEpicEvent;
                    if (i >= 9 && i <= 14 || i == 16)//Legendary
                        myCosts[16] += myLegendary;
                    if (i == 15)//Legendary Old Event
                        myCostsEvent[16] += myLegendary;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[16] += myEpic;
                    if (i == 6)//Epic Old Event
                        myCostsEvent[16] += myEpic;
                    if (i == 7)//Epic Event
                        myCostsEvent[16] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[16] += myRare;
                    if (i >= 4 && i <= 5)//Rare Old Event
                        myCostsEvent[16] += myRare;
                }
            }
        }

        private void Roadhog()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Roadhog.ini");

            myCosts[17] = 0;
            myCostsEvent[17] = 0;
            myCostsWeapon[17] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[17] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[17] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[17] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[17] += myEpic;
                    if (i >= 8 && i <= 11 || i == 15)//Legendary
                        myCosts[17] += myLegendary;
                    if (i >= 12 && i <= 13)//Legendary Old Event
                        myCostsEvent[17] += myLegendary;
                    if (i == 14)//Legendary Event
                        myCostsEvent[17] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[17] += myEpic;
                    if (i >= 6 && i <= 7)//Epic Event
                        myCostsEvent[17] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[17] += myRare;
                    if (i >= 4 && i <= 6)//Rare Old Event
                        myCostsEvent[17] += myRare;
                    if (i == 7)//Rare Event
                        myCostsEvent[17] += myRareEvent;
                }
            }
        }

        private void Soldier_76()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Soldier_76.ini");

            myCosts[18] = 0;
            myCostsEvent[18] = 0;
            myCostsWeapon[18] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[18] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[18] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[18] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[18] += myEpic;
                    if (i >= 8 && i <= 11)//Legendary
                        myCosts[18] += myLegendary;
                    if (i == 12)//Legendary Origin/GotY
                        myCosts[18] += myOriginGotY;
                    if (i >= 13 && i <= 15)//Legendary Event
                        myCostsEvent[18] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[18] += myEpic;
                    if (i >= 6 && i <= 7)//Epic Event
                        myCostsEvent[18] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[18] += myRare;
                    if (i >= 4 && i <= 6)//Rare Old Event
                        myCostsEvent[18] += myRare;
                }
            }
        }

        private void Sombra()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Sombra.ini");

            myCosts[19] = 0;
            myCostsEvent[19] = 0;
            myCostsWeapon[19] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[19] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[19] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[19] += myEpic;
                    if (i == 7)//Epic Winter 16
                        myCostsEvent[19] += myEpic;
                    if (i >= 8 && i <= 11)//Legendary
                        myCosts[19] += myLegendary;
                    if (i >= 12 && i <= 13)//Legendary Event
                        myCostsEvent[19] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5 || i == 7)//Epic
                        myCosts[19] += myEpic;
                    if (i == 6)//Epic Event
                        myCostsEvent[19] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[19] += myRare;
                    if (i >= 4 && i <= 5 || i == 7)//Rare Event
                        myCostsEvent[19] += myRareEvent;
                    if (i == 6)//Rare Old Event
                        myCostsEvent[19] += myRare;
                }
            }
        }
        //
        private void Symmetra()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Symmetra.ini");

            myCosts[20] = 0;
            myCostsEvent[20] = 0;
            myCostsWeapon[20] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[20] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[20] += myRare;
                    if (i >= 5 && i <= 6 || i == 15)//Epic
                        myCosts[20] += myEpic;
                    if (i >= 7 && i <= 8)//Epic Old Event
                        myCostsEvent[20] += myEpic;
                    if (i >= 9 && i <= 12)//Legendary
                        myCosts[20] += myLegendary;
                    if (i >= 13 && i <= 14)//Legendary Event
                        myCostsEvent[20] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[20] += myEpic;
                    if (i == 6)//Epic Old Event
                        myCostsEvent[20] += myEpic;
                    if (i == 7)//Epic Event
                        myCostsEvent[20] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[20] += myRare;
                    if (i == 4 || i == 6 || i == 7)//Rare Event
                        myCostsEvent[20] += myRareEvent;
                    if (i == 5)//Rare Old Event
                        myCostsEvent[20] += myRare;
                }
            }
        }

        private void Torbjörn()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Torbjörn.ini");

            myCosts[21] = 0;
            myCostsEvent[21] = 0;
            myCostsWeapon[21] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[21] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[21] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[21] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[21] += myEpic;
                    if (i >= 8 && i <= 11 || i == 16)//Legendary
                        myCosts[21] += myLegendary;
                    if (i == 12 || i == 14 || i == 15)//Legendary Event
                        myCostsEvent[21] += myLegendaryEvent;
                    if (i == 13)//Legendary Old Event
                        myCostsEvent[21] += myLegendary;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[21] += myEpic;
                    if (i >= 6 && i <= 7)//Epic Event
                        myCostsEvent[21] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[21] += myRare;
                    if (i >= 4 && i <= 6)//Rare Old Event
                        myCostsEvent[21] += myRare;
                }
            }
        }

        private void Tracer()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Tracer.ini");

            myCosts[22] = 0;
            myCostsEvent[22] = 0;
            myCostsWeapon[22] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[22] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[22] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[22] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[22] += myEpic;
                    if (i >= 8 && i <= 11)//Legendary
                        myCosts[22] += myLegendary;
                    if (i == 12)//Legendary Origin/GotY
                        myCosts[22] += myOriginGotY;
                    if (i >= 13 && i <= 15)//Legendary Old Event
                        myCostsEvent[22] += myLegendary;
                    if (i >= 16 && i <= 17)//Legendary Event
                        myCostsEvent[22] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5 || i == 7)//Epic
                        myCosts[22] += myEpic;
                    if (i == 6)//Epic Event
                        myCostsEvent[22] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[22] += myRare;
                    if (i >= 4 && i <= 5 || i == 7)//Rare Event
                        myCostsEvent[22] += myRareEvent;
                    if (i == 6)//Rare Old Event
                        myCostsEvent[22] += myRare;
                }
            }
        }

        private void Widowmaker()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Widowmaker.ini");

            myCosts[23] = 0;
            myCostsEvent[23] = 0;
            myCostsWeapon[23] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[23] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[23] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[23] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[23] += myEpic;
                    if (i >= 8 && i <= 11 || i == 15)//Legendary
                        myCosts[23] += myLegendary;
                    if (i == 12)//Legendary Prepurchase
                        myCosts[23] += myUnknown;
                    if (i == 17)//Legendary Starcraft 20th Annyver
                        myCosts[23] += myUnknown;
                    if (i >= 13 && i <= 14 || i == 16)//Legendary Event
                        myCostsEvent[23] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[23] += myEpic;
                    if (i == 6)//Epic Event
                        myCostsEvent[23] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[23] += myRare;
                    if (i >= 4 && i <= 5)//Rare Old Event
                        myCostsEvent[23] += myRare;
                    if (i >= 6 && i <= 7)//Rare Event
                        myCostsEvent[23] += myRareEvent;
                }
            }
        }

        private void Winston()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Winston.ini");

            myCosts[24] = 0;
            myCostsEvent[24] = 0;
            myCostsWeapon[24] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[24] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[24] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[24] += myEpic;
                    if (i == 7)//Epic BlizzCon
                        myCosts[24] += myBlizzCon;
                    if (i >= 8 && i <= 11)//Legendary
                        myCosts[24] += myLegendary;
                    if (i >= 12 && i <= 13)//Legendary Old Event
                        myCostsEvent[24] += myLegendary;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[24] += myEpic;
                    if (i == 6)//Epic Old Event
                        myCostsEvent[24] += myEpic;
                    if (i == 7)//Epic Event
                        myCostsEvent[24] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[24] += myRare;
                    if (i >= 4 && i <= 5)//Rare Old Event
                        myCostsEvent[24] += myRare;
                    if (i >= 6 && i <= 7)//Rare Event
                        myCostsEvent[24] += myRareEvent;
                }
            }
        }

        private void Zarya()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Zarya.ini");

            myCosts[25] = 0;
            myCostsEvent[25] = 0;
            myCostsWeapon[25] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[25] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[25] += myRare;
                    if (i >= 5 && i <= 6)//Epic
                        myCosts[25] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[25] += myEpic;
                    if (i >= 8 && i == 16)//Legendary
                        myCosts[25] += myLegendary;
                    if (i >= 12 && i <= 13)//Legendary Old Event
                        myCostsEvent[25] += myLegendary;
                    if (i >= 14 && i <= 15 || i == 17)//Legendary Event
                        myCostsEvent[25] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EN" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[25] += myEpic;
                    if (i == 6)//Epic Event
                        myCostsEvent[25] += myEpicEvent;
                    if (i == 6)//Legendary Old Event
                        myCostsEvent[25] += myLegendary;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[25] += myRare;
                    if (i == 4)//Rare Old Event
                        myCostsEvent[25] += myRare;
                    if (i >= 5 && i <= 7)//Rare Event
                        myCostsEvent[25] += myRareEvent;
                }
            }
        }

        private void Zenyatta()
        {
            inisHeroes = new IniStream(SaveFolder + "\\Zenyatta.ini");

            myCosts[26] = 0;
            myCostsEvent[26] = 0;
            myCostsWeapon[26] = 0;

            for (int i = 1; i <= myMaxItems; i++)
            {
                if (i < 10)
                    ii = "0" + i.ToString();
                else
                    ii = i.ToString();
                //Weapons
                if (inisHeroes.Read("GW" + ii) != "True" && inisHeroes.Read("GW" + ii) != "true")
                {
                    if (i == 1)//Goldweapon
                        myCostsWeapon[26] += 3000;
                }
                //Skins
                if (inisHeroes.Read("SK" + ii) != "True" && inisHeroes.Read("SK" + ii) != "true")
                {
                    if (i >= 1 && i <= 4)//Rare
                        myCosts[26] += myRare;
                    if (i >= 5 && i <= 6 || i == 15)//Epic
                        myCosts[26] += myEpic;
                    if (i == 7)//Epic Old Event
                        myCostsEvent[26] += myEpic;
                    if (i >= 8 && i <= 11)//Legendary
                        myCosts[26] += myLegendary;
                    if (i == 12)//Legendary Event
                        myCostsEvent[26] += myLegendaryEvent;
                    if (i >= 13 && i <= 14)//Legendary Old Event
                        myCostsEvent[26] += myLegendaryEvent;
                }
                //Emotes
                if (inisHeroes.Read("EM" + ii) != "True" && inisHeroes.Read("EM" + ii) != "true")
                {
                    if (i >= 1 && i <= 5)//Epic
                        myCosts[26] += myEpic;
                    if (i >= 6 && i <= 7)//Epic Event
                        myCostsEvent[26] += myEpicEvent;
                }
                //Victory Poses
                if (inisHeroes.Read("VP" + ii) != "True" && inisHeroes.Read("VP" + ii) != "true")
                {
                    if (i >= 1 && i <= 3)//Rare
                        myCosts[26] += myRare;
                    if (i >= 4 && i <= 5)//Rare Old Event
                        myCostsEvent[26] += myRare;
                    if (i == 6)//Rare Event
                        myCostsEvent[26] += myRareEvent;
                }
            }
        }
    }
}
