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
    public partial class ArmorBox : UserControl
    {
        Armor armor;

        public ArmorBox() {
            armor = new Armor();
            InitializeComponent();
            updateUIData();
        }

        public ArmorBox(Armor a) {
            armor = a;
            InitializeComponent();
            updateUIData();
        }

        private void updateUIData() {
            item_name_box.Text = armor.getName();
            weight_box.Text = armor.getWeight();
            cost_box.Text = armor.getCost();
            notes_box.Lines = armor.getNotes().ToArray();
            if(armor.getEquipped())
                equipped_box.CheckState = CheckState.Checked;
            else
                equipped_box.CheckState = CheckState.Unchecked;
            size_box.Text = armor.getSize();
            speed_box.Text = armor.getSpeed();
            if(armor.getACBonus() >= 0)
                ac_box.Text = "+" + armor.getACBonus().ToString();
            else
                ac_box.Text = armor.getACBonus().ToString();
            if(armor.getMaxDex() >= 0)
                max_dex_box.Text = "+" + armor.getMaxDex().ToString();
            else
                max_dex_box.Text = armor.getMaxDex().ToString();
            if(armor.getPenalty() >= 0)
                penalty_box.Text = "+" + armor.getPenalty().ToString();
            else
                penalty_box.Text = armor.getPenalty().ToString();
            spell_fail_box.Text = armor.getSpellFail().ToString() + "%";
            setForeColor(armor.getForeColor());
            setBackColor(armor.getBackColor());
        }

        #region Utility methods

        private void setForeColor(Color f) {
            item_name_box.ForeColor = f;
            weight_box.ForeColor = f;
            cost_box.ForeColor = f;
            notes_box.ForeColor = f;
            size_box.ForeColor = f;
            speed_box.ForeColor = f;
            ac_box.ForeColor = f;
            max_dex_box.ForeColor = f;
            penalty_box.ForeColor = f;
            spell_fail_box.ForeColor = f;
            size_label.ForeColor = f;
            speed_label.ForeColor = f;
            ac_label.ForeColor = f;
            max_dex_label.ForeColor = f;
            penalty_label.ForeColor = f;
            spell_fail_label.ForeColor = f;
        }

        private void setBackColor(Color b) {
            armor_table.BackColor = b;
            item_name_box.BackColor = b;
            weight_box.BackColor = b;
            cost_box.BackColor = b;
            notes_box.BackColor = b;
            size_box.BackColor = b;
            speed_box.BackColor = b;
            ac_box.BackColor = b;
            max_dex_box.BackColor = b;
            penalty_box.BackColor = b;
            spell_fail_box.BackColor = b;
        }

        private bool checkHover(Point p) {
            Rectangle hoverArea = RectangleToScreen(this.DisplayRectangle);
            hoverArea.Inflate(-8, -8);

            return hoverArea.Contains(p);
        }

        #endregion

        #region Get & Set methods

        public Armor getArmor() {
            return armor;
        }

        public void setArmor(Armor a) {
            armor = a;
        }

        #endregion

        #region Event Handlers

        private void armor_table_MouseMove(object sender, MouseEventArgs e) {
            if(checkHover(MousePosition))
                del_butt.Visible = true;
            else
                del_butt.Visible = false;
        }

        private void del_butt_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void item_name_box_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                armor.setForeColor(colorPicker.Color);
                updateUIData();
            }
        }

        private void armor_table_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                armor.setBackColor(colorPicker.Color);
                updateUIData();
            }
        }

        private void armor_image_DoubleClick(object sender, EventArgs e) {
            OpenFileDialog imageSelect = new OpenFileDialog();
            imageSelect.Filter = "Image Files ('*.jpg') | *.jpg";

            if(imageSelect.ShowDialog() == DialogResult.OK) {
                armor.setImage(Image.FromFile(imageSelect.FileName));
                updateUIData();
            }
        }

        #region TextChanged events

        private void item_name_box_TextChanged(object sender, EventArgs e) {
            armor.setName(item_name_box.Text);
        }

        private void weight_box_TextChanged(object sender, EventArgs e) {
            armor.setWeight(weight_box.Text);
        }

        private void cost_box_TextChanged(object sender, EventArgs e) {
            armor.setCost(cost_box.Text);
        }

        private void equipped_box_CheckedChanged(object sender, EventArgs e) {
            armor.setEquipped(equipped_box.Checked);
        }

        private void notes_box_TextChanged(object sender, EventArgs e) {
            armor.setNotes(notes_box.Lines.ToList());
        }

        private void size_box_TextChanged(object sender, EventArgs e) {
            armor.setSize(size_box.Text);
        }

        private void speed_box_TextChanged(object sender, EventArgs e) {
            armor.setSpeed(speed_box.Text);
        }

        private void ac_box_TextChanged(object sender, EventArgs e) {
            int ac;
            if(int.TryParse(ac_box.Text, out ac))
                armor.setACBonus(ac);
            else
                armor.setACBonus(0);
        }

        private void max_dex_box_TextChanged(object sender, EventArgs e) {
            int dex;
            if(int.TryParse(max_dex_box.Text, out dex))
                armor.setMaxDex(dex);
            else
                armor.setMaxDex(0);
        }

        private void penalty_box_TextChanged(object sender, EventArgs e) {
            int pen;
            if(int.TryParse(penalty_box.Text, out pen))
                armor.setPenalty(pen);
            else
                armor.setPenalty(0);
        }

        private void spell_fail_box_TextChanged(object sender, EventArgs e) {
            int sf;
            if(int.TryParse(spell_fail_box.Text.TrimEnd('%'), out sf))
                armor.setSpellFail(sf);
            else
                armor.setSpellFail(0);
        }

        #endregion

        #endregion
    }
}
