using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagOfHolding
{
    public partial class InventoryWindow : UserControl
    {
        bool initialized;
        Character character;
        char mode = 'i';

        public InventoryWindow() {
            character = new Character();
        }

        public void open() {
            if(!initialized)
                startup();

            setColors();
            updateUIData();
            Show();
            Visible = true;
            BringToFront();
            IsAccessible = true;
        }

        private void startup() {
            initialized = true;
            InitializeComponent();
            Properties.Settings.Default.PropertyChanged += new PropertyChangedEventHandler(settingsChanged);
            Dock = DockStyle.Fill;
        }

        private void updateUIData() {
            inventory_label.Text = character.Name + "'s Inventory";
            item_panel.Controls.Clear();

            if(mode == 'i') {
                item_butt.BackColor = Color.Pink;
                weapon_butt.BackColor = Color.Gainsboro;
                armor_butt.BackColor = Color.Gainsboro;

                foreach(Item i in character.Inv) {
                    item_panel.Controls.Add(new ItemBox(i));
                }
            }
            else if(mode == 'w') {
                item_butt.BackColor = Color.Gainsboro;
                weapon_butt.BackColor = Color.LightGreen;
                armor_butt.BackColor = Color.Gainsboro;

                foreach(Weapon w in character.Weapons) {
                    item_panel.Controls.Add(new WeaponBox(w));
                }
            }
            else if(mode == 'a') {
                item_butt.BackColor = Color.Gainsboro;
                weapon_butt.BackColor = Color.Gainsboro;
                armor_butt.BackColor = Color.LightBlue;

                foreach(Armor a in character.Armor) {
                    item_panel.Controls.Add(new ArmorBox(a));
                }
            }
        }

        private void updateCharData() {
            if(mode == 'i') {
                character.Inv.Clear();
                foreach(ItemBox i in item_panel.Controls) {
                    character.Inv.Add(i.getItem());
                }
            }
            else if(mode == 'w') {
                character.Weapons.Clear();
                foreach(WeaponBox w in item_panel.Controls) {
                    character.Weapons.Add(w.getWeapon());
                }
            }
            else if(mode == 'a') {
                character.Armor.Clear();
                foreach(ArmorBox a in item_panel.Controls) {
                    character.Armor.Add(a.getArmor());
                }
            }
        }

        #region Utility methods

        private void addNewItem() {
            if(mode == 'i') {
                character.Inv.Add(new Item());
            }
            else if(mode == 'w') {
                character.Weapons.Add(new Weapon());
            }
            else if(mode == 'a') {
                character.Armor.Add(new Armor());
            }
        }

        private void setColors() {
            menu_strip.BackColor = Properties.Settings.Default.windowToolColor;
        }

        #endregion

        #region Get & Set methods

        public Character getChar() {
            return character;
        }

        public void setChar(ref Character c) {
            character = c;
        }

        #endregion

        #region Event Handlers
        private void settingsChanged(object sender, PropertyChangedEventArgs e) {
            setColors();
        }

        private void item_butt_Click(object sender, EventArgs e) {
            updateCharData();
            mode = 'i';
            updateUIData();
        }

        private void weapon_butt_Click(object sender, EventArgs e) {
            updateCharData();
            mode = 'w';
            updateUIData();
        }

        private void armor_butt_Click(object sender, EventArgs e) {
            updateCharData();
            mode = 'a';
            updateUIData();
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e) {
            addNewItem();
            updateUIData();
        }

        private void saveCharacterAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "Character Files ('*.char') | *.char";
            saveWindow.DefaultExt = "char";

            if(saveWindow.ShowDialog() == DialogResult.OK) {
                character.saveChar(saveWindow.FileName);
            }
        }

        private void saveInventoryAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "Inventory Files ('*.inv') | *.inv";
            saveWindow.DefaultExt = "inv";

            if(saveWindow.ShowDialog() == DialogResult.OK) {
                character.saveInv(saveWindow.FileName);
            }
        }

        private void loadCharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog loadWindow = new OpenFileDialog();
            loadWindow.Filter = "Character Files ('*.char') | *.char";
            loadWindow.DefaultExt = "char";

            if(loadWindow.ShowDialog() == DialogResult.OK) {
                character.loadChar(loadWindow.FileName);
                updateUIData();
            }
        }

        private void overwriteInventoryToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog loadWindow = new OpenFileDialog();
            loadWindow.Filter = "Inventory Files ('*.inv') | *.inv";
            loadWindow.DefaultExt = "inv";

            if(loadWindow.ShowDialog() == DialogResult.OK) {
                character.loadInv(loadWindow.FileName, true);
                updateUIData();
            }
        }

        private void appendInventoryToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog loadWindow = new OpenFileDialog();
            loadWindow.Filter = "Inventory Files ('*.inv') | *.inv";
            loadWindow.DefaultExt = "inv";

            if(loadWindow.ShowDialog() == DialogResult.OK) {
                character.loadInv(loadWindow.FileName, false);
                updateUIData();
            }
        }

        private void saveCharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            character.saveChar();
        }

        private void main_panel_MouseEnter(object sender, EventArgs e) {
            updateCharData();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            updateCharData();
            updateUIData();
        }

        #endregion
    }
}
