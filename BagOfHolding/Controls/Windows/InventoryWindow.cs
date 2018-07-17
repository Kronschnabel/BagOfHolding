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
            Dock = DockStyle.Fill;
            character = new Character();
        }

        public void open() {
            if(!initialized)
                startup();

            updateUIData();
            Show();
            Visible = true;
            BringToFront();
            IsAccessible = true;
        }

        private void startup() {
            initialized = true;
            InitializeComponent();
        }

        private void updateUIData() {
            inventory_label.Text = character.getName() + "'s Inventory";
            item_panel.Controls.Clear();

            if(mode == 'i') {
                foreach(Item i in character.getInv()) {
                    item_panel.Controls.Add(new ItemBox(i));
                }
            }
            else if(mode == 'w') {
                foreach(Weapon w in character.getWeapons()) {
                    item_panel.Controls.Add(new WeaponBox(w));
                }
            }
            else if(mode == 'a') {
                foreach(Armor a in character.getArmor()) {
                    item_panel.Controls.Add(new ArmorBox(a));
                }
            }
        }

        private void updateCharData() {
            if(mode == 'i') {
                character.getInv().Clear();
                foreach(ItemBox i in item_panel.Controls) {
                    character.getInv().Add(i.getItem());
                }
            }
            else if(mode == 'w') {
                character.getWeapons().Clear();
                foreach(WeaponBox w in item_panel.Controls) {
                    character.getWeapons().Add(w.getWeapon());
                }
            }
            else if(mode == 'a') {
                character.getArmor().Clear();
                foreach(ArmorBox a in item_panel.Controls) {
                    character.getArmor().Add(a.getArmor());
                }
            }
        }

        private void addNewItem() {
            if(mode == 'i') {
                character.getInv().Add(new Item());
            }
            else if(mode == 'w') {
                character.getWeapons().Add(new Weapon());
            }
            else if(mode == 'a') {
                character.getArmor().Add(new Armor());
            }

            updateUIData();
        }

        #region Get & Set methods
        public Character getChar() {
            return character;
        }

        public void setChar(ref Character c) {
            character = c;
        }
#endregion

        #region Event Handlers
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
        }

        private void saveInventoryAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "Inventory Files ('*.inv') | *.inv";
            saveWindow.DefaultExt = "inv";

            if(saveWindow.ShowDialog() == DialogResult.OK) {
                character.saveInv(saveWindow.FileName);
            }
        }
        #endregion

        private void overwriteInventoryToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog loadWindow = new OpenFileDialog();
            loadWindow.Filter = "Inventory Files ('*.inv') | *.inv";
            loadWindow.DefaultExt = "char";

            if(loadWindow.ShowDialog() == DialogResult.OK) {
                character.loadChar(loadWindow.FileName);
                updateUIData();
                updateSkillUI();
            }
        }
    }
}
