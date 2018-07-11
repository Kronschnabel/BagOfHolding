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
            spell_name_box.Text = spell.getName();
            school_box.Text = spell.getSchool();
            level_box.Text = spell.getLevel();
            notes_box.Lines = spell.getNotes().ToArray();
            prepared_box.Checked = spell.getPrepared();
            setForeColor(spell.getForeColor());
            setBackColor(spell.getBackColor());
        }

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
                spell.setForeColor(colorPicker.Color);
                updateUIData();
            }
        }

        private void spell_table_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                spell.setBackColor(colorPicker.Color);
                updateUIData();
            }
        }


        private void spell_image_DoubleClick(object sender, EventArgs e) {
            OpenFileDialog imageSelect = new OpenFileDialog();
            imageSelect.Filter = "Image Files ('*.jpg') | *.jpg";

            if(imageSelect.ShowDialog() == DialogResult.OK) {
                spell.setImage(Image.FromFile(imageSelect.FileName));
                updateUIData();
            }
        }

        private void spell_name_box_TextChanged(object sender, EventArgs e) {
            spell.setName(spell_name_box.Text);
        }

        private void school_box_TextChanged(object sender, EventArgs e) {
            spell.setSchool(school_box.Text);
        }

        private void level_box_TextChanged(object sender, EventArgs e) {
            spell.setLevel(level_box.Text);
        }

        private void notes_box_TextChanged(object sender, EventArgs e) {
            spell.setNotes(notes_box.Lines.ToList());
        }

        private void prepared_box_CheckedChanged(object sender, EventArgs e) {
            spell.setPrepared(prepared_box.Checked);
        }
        #endregion
    }
}
