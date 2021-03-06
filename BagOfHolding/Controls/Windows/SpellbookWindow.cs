﻿using System;
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
    public partial class SpellbookWindow : UserControl
    {
        bool initialized;
        Character character;

        public SpellbookWindow() {
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
            spell_book_label.Text = character.Name + "'s Spellbook";
            spell_panel.Controls.Clear();

            foreach(Spell s in character.Spellbook) {
                spell_panel.Controls.Add(new SpellBox(s));
            }

            int[] spellsLeft = character.SpellsLeft;
            lvl0_box.Value = spellsLeft[0];
            lvl1_box.Value = spellsLeft[1];
            lvl2_box.Value = spellsLeft[2];
            lvl3_box.Value = spellsLeft[3];
            lvl4_box.Value = spellsLeft[4];
            lvl5_box.Value = spellsLeft[5];
            lvl6_box.Value = spellsLeft[6];
            lvl7_box.Value = spellsLeft[7];
            lvl8_box.Value = spellsLeft[8];
            lvl9_box.Value = spellsLeft[9];
        }

        private void updateCharData() {
            character.Spellbook.Clear();

            foreach(SpellBox s in spell_panel.Controls) {
                character.Spellbook.Add(s.getSpell());
            }

            character.SpellsLeft = getSpellsLeftValues();
        }

        #region Utility methods

        private int[] getSpellsLeftValues() {
            int[] spellsLeft = new int[10];

            spellsLeft[0] = (int)lvl0_box.Value;
            spellsLeft[1] = (int)lvl1_box.Value;
            spellsLeft[2] = (int)lvl2_box.Value;
            spellsLeft[3] = (int)lvl3_box.Value;
            spellsLeft[4] = (int)lvl4_box.Value;
            spellsLeft[5] = (int)lvl5_box.Value;
            spellsLeft[6] = (int)lvl6_box.Value;
            spellsLeft[7] = (int)lvl7_box.Value;
            spellsLeft[8] = (int)lvl8_box.Value;
            spellsLeft[9] = (int)lvl9_box.Value;

            return spellsLeft;
        }

        private void addNewSpell() {
            character.Spellbook.Add(new Spell());
            updateUIData();
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

        private void spells_left_ValueChanged(object sender, EventArgs e) {
            character.SpellsLeft = getSpellsLeftValues();
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e) {
            addNewSpell();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            updateCharData();
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

        private void saveSpellbookAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "Spell Files ('*.spl') | *.spl";
            saveWindow.DefaultExt = "spl";

            if(saveWindow.ShowDialog() == DialogResult.OK) {
                character.saveSpellbook(saveWindow.FileName);
            }
        }

        private void saveCharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            character.saveChar();
        }

        private void appendSpellbookToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog loadWindow = new OpenFileDialog();
            loadWindow.Filter = "Spell Files ('*.spl') | *.spl";
            loadWindow.DefaultExt = "spl";

            if(loadWindow.ShowDialog() == DialogResult.OK) {
                character.loadSpellbook(loadWindow.FileName, false);
                updateUIData();
            }
        }

        private void overwriteSpellbookToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog loadWindow = new OpenFileDialog();
            loadWindow.Filter = "Spell Files ('*.spl') | *.spl";
            loadWindow.DefaultExt = "spl";

            if(loadWindow.ShowDialog() == DialogResult.OK) {
                character.loadSpellbook(loadWindow.FileName, true);
                updateUIData();
            }
        }

        #endregion
    }
}
