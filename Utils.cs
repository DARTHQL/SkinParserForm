using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SkinParserForm.SkinJson;

namespace SkinParserForm {
    static class Utils {

        public static bool OwnsItem(IList<UserItem> userItems, string sku) {
            return userItems.FirstOrDefault(x => x.sku == sku) == null;
        }

        public static List<Style> CreateStyles(IList<UserItem> userItems, Enum item) {
            List<Style> result = new List<Style>();

            string folder = item.GetType().Name;
            string fileName = $"{folder}\\{item.ToString().ToLower()}skins.txt";

            if (!File.Exists(fileName)) {
                MessageBox.Show($"Missing file: {fileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FileNotFoundException(fileName);
            }
            
            using (StreamReader sr = new StreamReader(fileName)) {
                while (!sr.EndOfStream) {
                    result.Add(
                        new Style
                        {
                            sku = sr.ReadLine()
                        }
                    );
                }

                sr.Close();
            }

            return result;
        }

        public static List<Style> CreateTitleStyles() {
            List<Style> result = new List<Style>();

            string fileName = "Playertitles\\titles.txt";

            if (!File.Exists(fileName)) {
                MessageBox.Show($"Missing file: {fileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FileNotFoundException(fileName);
            }

            using (StreamReader sr = new StreamReader(fileName)) {
                while (!sr.EndOfStream) {
                    result.Add(
                        new Style {
                            sku = sr.ReadLine()
                        }
                    );
                }

                sr.Close();
            }

            return result;
        }

        public static void AddItem(ref IList<UserItem> userItems, string sku) {
            UserItem newItem = new UserItem
            {
                sku = sku
            };

            userItems.Add(newItem);
        }

        public static void AddDefaultItems(ref IList<UserItem> userItems) {
            // Default characters.
            AddItem(ref userItems, "timewatch.items.char.bjarne");
            AddItem(ref userItems, "timewatch.items.char.violet");
            AddItem(ref userItems, "timewatch.items.char.toure");
            AddItem(ref userItems, "timewatch.items.char.jackie");
            AddItem(ref userItems, "timewatch.items.char.justin");
            AddItem(ref userItems, "timewatch.items.char.levka");

            // New characters.
            if (MainForm.UnlockNewCharacters) {
                AddItem(ref userItems, "timewatch.items.char.axel");
                AddItem(ref userItems, "timewatch.items.char.hel");
            }

            // Default weapons.
            AddItem(ref userItems, "timewatch.items.weapon.smg");
            AddItem(ref userItems, "timewatch.items.weapon.blaster");
            AddItem(ref userItems, "timewatch.items.weapon.laser");
            AddItem(ref userItems, "timewatch.items.weapon.grenade");
            AddItem(ref userItems, "timewatch.items.weapon.shotgun");
            AddItem(ref userItems, "timewatch.items.weapon.sniper");

            // Default playerTitle.
            AddItem(ref userItems, "timewatch.items.playertitle");
        }

        public static void AddAllStoreItems(ref IList<UserItem> userItems, StoreItems storeItems) {
            foreach (Character item in storeItems.characters)
                foreach (Style style in item.styles) {
                    UserItem newItem = new UserItem
                    {
                        sku = style.sku
                    };

                    userItems.Add(newItem);
                }

            foreach (Weapon item in storeItems.weapons)
                foreach (Style style in item.styles) {
                    UserItem newItem = new UserItem
                    {
                        sku = style.sku
                    };

                    userItems.Add(newItem);
                }

            if (MainForm.UnlockTitles) {
                foreach (Playertitle item in storeItems.playertitles)
                    foreach (Style style in item.styles) {
                        UserItem newItem = new UserItem
                        {
                            sku = style.sku
                        };

                        userItems.Add(newItem);
                    }
            }
        }
    }
}
