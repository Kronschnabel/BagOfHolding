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
    public partial class SpellBox : UserControl
    {
        Spell spell;

        public SpellBox() {
            spell = new Spell();
            InitializeComponent();
            updateUIData();
        }

        public SpellBox(Spell s) {
            spell = s;
            InitializeComponent();
            updateUIData();
        }

        private void updateUIData() {
            spell_name_box.Text = spell.Name;
            school_box.Text = spell.School;
            level_box.Text = spell.Level;
            notes_box.Lines = spell.Notes.ToArray();
            prepared_box.Checked = spell.Prepared;
            setForeColor(spell.ForeColor);
            setBackColor(spell.BackColor);
        }

        #region Utility methods

        private void setForeColor(Color f) {
            spell_name_box.ForeColor = f;
            school_box.ForeColor = f;
            level_box.ForeColor = f;
            notes_box.ForeColor = f;
        }

        private void setBackColor(Color b) {
            spell_table.BackColor = b;
            spell_name_box.BackColor = b;
            school_box.BackColor = b;
            level_box.BackColor = b;
            notes_box.BackColor = b;
        }

        private bool checkHover(Point p) {
            Rectangle hoverArea = RectangleToScreen(DisplayRectangle);
            hoverArea.Inflate(-8, -8);

            return hoverArea.Contains(p);
        }

        #endregion

        #region Get & Set methods
        public Spell getSpell() {
            return spell;
        }

        public void setSpell(Spell s) {
            spell = s;
        }
        #endregion

        #region Event Handlers

        private void spell_name_box_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                spell.ForeColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void spell_table_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                spell.BackColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void spell_table_MouseMove(object sender, MouseEventArgs e) {
            if(checkHover(MousePosition))
                del_butt.Visible = true;
            else
                del_butt.Visible = false;
        }

        private void del_butt_Click(object sender, EventArgs e) {
            Dispose();
        }

        #region ValueChanged events

        private void spell_name_box_TextChanged(object sender, EventArgs e) {
            spell.Name = spell_name_box.Text;
        }

        private void school_box_TextChanged(object sender, EventArgs e) {
            spell.School = school_box.Text;
        }

        private void level_box_TextChanged(object sender, EventArgs e) {
            spell.Level = level_box.Text;
        }

        private void notes_box_TextChanged(object sender, EventArgs e) {
            spell.Notes = notes_box.Lines.ToList();
        }

        private void prepared_box_CheckedChanged(object sender, EventArgs e) {
            spell.Prepared = prepared_box.Checked;
        }

        #endregion

        #endregion
    }
}
