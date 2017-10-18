using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverwatchLootBoxTracker
{
    public class CEmote
    {
        private int myEmoteRare = 75;
        private int myEmote = 250;
        private int myEmoteEvent = 750;
        private int myEmoteLegendary = 1000;

        public CEmote()
        {
            throw new System.NotImplementedException();
        }

        public int Rare
        {
            get
            {
                return myEmoteRare;
            }
        }

        public int Epic
        {
            get
            {
                return myEmote;
            }
        }

        public int Legendary
        {
            get
            {
                return myEmoteLegendary;
            }
        }

        public int Event
        {
            get
            {
                return myEmoteEvent;
            }
        }

        public int KostenGes
        {
            get
            {
                return (1 * myEmote);
            }
        }
    }
}