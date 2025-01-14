﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunicRandomizer {
    public class HeroRelic {

        public string Flag {
            get;
            set;
        }

        public string ItemPresentedOnCollection {
            get;
            set;
        }

        public string CollectionMessage {
            get;
            set;
        }

        public string OriginalPickupLocation {
            get;
            set;
        }

        public string CorrespondingStat {
            get;
            set;
        }

        public HeroRelic() { }

        public HeroRelic(string flag, string itemPresentedOnCollection, string collectionMessage) {
            Flag = flag;
            ItemPresentedOnCollection = itemPresentedOnCollection;
            CollectionMessage = collectionMessage;
        }

        public HeroRelic(string flag, string itemPresentedOnCollection, string collectionMessage, string originalPickupLocation, string correspondingStat) {
            Flag = flag;
            ItemPresentedOnCollection = itemPresentedOnCollection;
            CollectionMessage = collectionMessage;
            OriginalPickupLocation = originalPickupLocation;
            CorrespondingStat = correspondingStat;
        }
    }
}
