using System.Collections.Generic;

namespace SkinParserForm {
    public class SkinJson {
        public enum Characters {
            BJARNE,
            VIOLET,
            LEVKA,
            JUSTIN,
            JACKIE,
            HEL,
            AXEL,
            TOURE
        }

        public enum Weapons {
            SMG,
            RIFLE,
            BLASTER,
            SHOTGUN,
            LASER,
            GRENADE
        }

        public class UserItem {
            public string sku { get; set; }
        }

        public class Requirement {
            public string type { get; set; }
            public int value { get; set; }
        }

        public class Item {
            public IList<Requirement> requirements { get; set; }
            public object serial { get; set; }
            public string sku { get; set; }
            public int availability { get; set; }
            public int rarity { get; set; }
        }

        public class Style {
            public IList<Requirement> requirements { get; set; }
            public object serial { get; set; }
            public string sku { get; set; }
            public int availability { get; set; }
            public int rarity { get; set; }
        }

        public class Character {
            public Item item { get; set; }
            public IList<Style> styles { get; set; }
        }

        public class Weapon {
            public Item item { get; set; }
            public IList<Style> styles { get; set; }
        }

        public class Playertitle {
            public Item item { get; set; }
            public IList<Style> styles { get; set; }
        }

        public class StoreItems {
            public IList<Character> characters { get; set; }
            public IList<Weapon> weapons { get; set; }
            public IList<Playertitle> playertitles { get; set; }
        }

        public class Example {
            public IList<UserItem> userItems { get; set; }
            public StoreItems storeItems { get; set; }
        }
    }
}
