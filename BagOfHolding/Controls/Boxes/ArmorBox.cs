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
            item_name_box.Text = armor.Name;
            weight_box.Text = armor.Weight;
            cost_box.Text = armor.Cost;
            notes_box.Lines = armor.Notes.ToArray();
            if(armor.Equipped)
                equipped_box.CheckState = CheckState.Checked;
            else
                equipped_box.CheckState = CheckState.Unchecked;
            size_box.Text = armor.Size;
            speed_box.Text = armor.Speed;
            if(armor.ACBonus >= 0)
                ac_box.Text = "+" + armor.ACBonus.ToString();
            else
                ac_box.Text = armor.ACBonus.ToString();
            if(armor.MaxDex >= 0)
                max_dex_box.Text = "+" + armor.MaxDex.ToString();
            else
                max_dex_box.Text = armor.MaxDex.ToString();
            if(armor.ACP >= 0)
                penalty_box.Text = "+" + armor.ACP.ToString();
            else
                penalty_box.Text = armor.ACP.ToString();
            spell_fail_box.Text = armor.SpellFail.ToString() + "%";
            setForeColor(armor.ForeColor);
            setBackColor(armor.BackColor);
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
                armor.ForeColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void armor_table_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                armor.BackColor = colorPicker.Color;
                updateUIData();
            }
        }

        #region TextChanged events

        private void item_name_box_TextChanged(object sender, EventArgs e) {
            armor.Name = item_name_box.Text;
        }

        private void weight_box_TextChanged(object sender, EventArgs e) {
            armor.Weight = weight_box.Text;
        }

        private void cost_box_TextChanged(object sender, EventArgs e) {
            armor.Cost = cost_box.Text;
        }

        private void equipped_box_CheckedChanged(object sender, EventArgs e) {
            armor.Equipped = equipped_box.Checked;
        }

        private void notes_box_TextChanged(object sender, EventArgs e) {
            armor.Notes = notes_box.Lines.ToList();
        }

        private void size_box_TextChanged(object sender, EventArgs e) {
            armor.Size = size_box.Text;
        }

        private void speed_box_TextChanged(object sender, EventArgs e) {
            armor.Speed = speed_box.Text ;
        }

        private void ac_box_TextChanged(object sender, EventArgs e) {
            int ac;
            if(int.TryParse(ac_box.Text, out ac))
                armor.ACBonus = ac;
            else
                armor.ACBonus = 0;
        }

        private void max_dex_box_TextChanged(object sender, EventArgs e) {
            int dex;
            if(int.TryParse(max_dex_box.Text, out dex))
                armor.MaxDex = dex;
            else
                armor.MaxDex = 0;
        }

        private void penalty_box_TextChanged(object sender, EventArgs e) {
            int pen;
            if(int.TryParse(penalty_box.Text, out pen))
                armor.ACP = pen;
            else
                armor.ACP = 0;
        }

        private void spell_fail_box_TextChanged(object sender, EventArgs e) {
            int sf;
            if(int.TryParse(spell_fail_box.Text.TrimEnd('%'), out sf))
                armor.SpellFail = sf;
            else
                armor.SpellFail = 0;
        }

        #endregion

        #endregion
    }
}
