using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static SkinParserForm.SkinJson;

namespace SkinParserForm {
    public partial class MainForm : Form {
        private readonly string savedInventoryPath = "Saved.txt";

        public static bool UnlockNewCharacters { get; private set; }
        public static bool UnlockTitles { get; private set; }
        public static bool UnlockUnreleased { get; private set; }

        public MainForm() {
            InitializeComponent();

            UnlockNewCharacters = CheckPlayerTitles.Checked;
            UnlockTitles = CheckPlayerTitles.Checked;
            UnlockUnreleased = CheckUnreleased.Checked;
        }

        private string Parse() {
            if (TxtInput.Text == "") {
                MessageBox.Show("Your input box can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            Example items = null;

            try {
                items = JsonConvert.DeserializeObject<Example>(TxtInput.Text);
            }
            catch (JsonException e) {
                throw e;
            }
            
            // Remove all userItems since we will manually be adding everything back.
            items.userItems.Clear();

            IList<UserItem> userItems = items.userItems;
            IList<Character> characters = items.storeItems.characters;
            IList<Weapon> weapons = items.storeItems.weapons;
            IList<Playertitle> playerTitles = items.storeItems.playertitles;

            Utils.AddDefaultItems(ref userItems);

            if (CheckStoreItems.Checked) {
                Utils.AddAllStoreItems(ref userItems, items.storeItems);
            }

            if (UnlockUnreleased) {
                // Add all characters & styles.
                foreach (string charName in Enum.GetNames(typeof(Characters))) {
                    Character character = new Character
                    {
                        item = new Item
                        {
                            sku = "timewatch.items.char." + charName.ToLower()
                        },
                        styles = Utils.CreateStyles(userItems, (Characters)Enum.Parse(typeof(Characters), charName))
                    };

                    characters.Add(character);
                }

                // Add all weapons & styles.
                foreach (string weaponName in Enum.GetNames(typeof(Weapons))) {
                    Weapon weapon = new Weapon
                    {
                        item = new Item
                        {
                            sku = "timewatch.items.weapon." + weaponName.ToLower()
                        },
                        styles = Utils.CreateStyles(userItems, (Weapons)Enum.Parse(typeof(Weapons), weaponName))
                    };

                    weapons.Add(weapon);
                }

                // Add all player titles.
                Playertitle title = new Playertitle
                {
                    item = new Item
                    {
                        sku = "timewatch.items.playertitle"
                    },
                    styles = Utils.CreateTitleStyles()
                };

                playerTitles.Add(title);
            }
            
            return JsonConvert.SerializeObject(items);
        }

        private void BtnParse_Click(object sender, EventArgs e) {
            TxtOutput.Text = Parse();
        }

        private void TxtOutput_TextChanged(object sender, EventArgs e) {
            BtnSave.Enabled = TxtOutput.Text.Length > 0;
        }

        private void BtnDisguise_Click(object sender, EventArgs e) {
            Fiddler.Disguise();
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            if (!File.Exists(savedInventoryPath)) {
                File.Create(savedInventoryPath).Close();
            }

            using (StreamWriter sw = new StreamWriter(savedInventoryPath)) {
                sw.WriteLine(TxtOutput.Text);
                sw.Close();
            }

            MessageBox.Show($"Saved to: {savedInventoryPath}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckAddNewCharacters_CheckedChanged(object sender, EventArgs e) {
            UnlockNewCharacters = CheckAddNewCharacters.Checked;
        }

        private void CheckPlayerTitles_CheckedChanged(object sender, EventArgs e) {
            UnlockTitles = CheckPlayerTitles.Checked;
        }

        private void CheckUnreleased_CheckedChanged(object sender, EventArgs e) {
            UnlockUnreleased = CheckUnreleased.Checked;
        }
    }
}