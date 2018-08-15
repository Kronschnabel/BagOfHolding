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
    public partial class PartyWindow : UserControl
    {
        bool initialized;
        List<Character> party;

        bool ctrlDown;

        public PartyWindow() {
            Dock = DockStyle.Fill;
            party = new List<Character>();
        }

        public PartyWindow(ref List<Character> p) {
            Dock = DockStyle.Fill;
            party = p;
        }

        public void open() {
            if(!initialized)
                startup();

            updateUIData();
            Show();
            Visible = true;
            BringToFront();
            IsAccessible = true;
            Width += 1;
        }

        private void startup() {
            initialized = true;
            InitializeComponent();
        }

        private void saveParty() {
            foreach(Character c in party) {
                c.saveChar();
            }
        }

        public void updateUIData() {
            party_panel.Controls.Clear();

            foreach(Character c in party) {
                CharacterBox charBox = new CharacterBox(c);
                party_panel.Controls.Add(charBox);
                charBox.createWindows();
            }
        }

        private void updatePartyData() {
            party.Clear();

            foreach(CharacterBox c in party_panel.Controls) {
                party.Add(c.getChar());
            }
        }

        #region Get & Set methods
        public List<Character> getParty() {
            return party;
        }

        public void setParty(ref List<Character> p) {
            party = p;
        }
        #endregion

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            updatePartyData();
            party.Add(new Character());
            updateUIData();
        }

        private void loadCharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            updatePartyData();

            OpenFileDialog loadWindow = new OpenFileDialog();
            loadWindow.Multiselect = true;
            loadWindow.Filter = "Character Files ('*.char') | *.char";
            loadWindow.DefaultExt = "char";

            if(loadWindow.ShowDialog() == DialogResult.OK) {
                foreach(string f in loadWindow.FileNames) {
                    Character c = new Character();
                    c.loadChar(f);
                    party.Add(c);
                }

                updateUIData();
            }
        }

        private void savePartyAsToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void savePartyToolStripMenuItem_Click(object sender, EventArgs e) {
            saveParty();
        }

        private void PartyWindow_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Control)
                ctrlDown = true;

            if(ctrlDown && (e.KeyCode == Keys.S)) {
                saveParty();
                
            }
        }

        private void PartyWindow_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Control)
                ctrlDown = false;
        }

        private void PartyWindow_KeyPress(object sender, KeyPressEventArgs e) {
            
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            updatePartyData();
        }

        private void clearWithoutSavingToolStripMenuItem_Click(object sender, EventArgs e) {
            party.Clear();
            updateUIData();
        }

        private void clearAndSaveToolStripMenuItem_Click(object sender, EventArgs e) {
            saveParty();
            party.Clear();
            updateUIData();
        }

    }
}
