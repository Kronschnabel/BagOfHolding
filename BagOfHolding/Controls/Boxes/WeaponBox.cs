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
    public partial class WeaponBox : UserControl
    {
        Weapon weapon;

        public WeaponBox() {
            weapon = new Weapon();
            InitializeComponent();
            updateUIData();
        }

        public WeaponBox(Weapon w) {
            weapon = w;
            InitializeComponent();
            updateUIData();
        }

        private void updateUIData() {
            item_name_box.Text = weapon.Name;
            weight_box.Text = weapon.Weight;
            cost_box.Text = weapon.Cost;
            notes_box.Lines = weapon.Notes.ToArray();
            if(weapon.Equipped)
                equipped_box.CheckState = CheckState.Checked;
            else
                equipped_box.CheckState = CheckState.Unchecked;
            damage_box.Text = weapon.Dmg;
            crit_range_box.Text = weapon.CritRange;
            category_box.Text = weapon.Category;
            range_box.Text = weapon.Range;
            type_box.Text = weapon.DmgType;
            size_box.Text = weapon.Size;
            setForeColor(weapon.ForeColor);
            setBackColor(weapon.BackColor);
        }

        #region Utility methods

        private void setForeColor(Color f) {
            item_name_box.ForeColor = f;
            weight_box.ForeColor = f;
            cost_box.ForeColor = f;
            notes_box.ForeColor = f;
            damage_box.ForeColor = f;
            crit_range_box.ForeColor = f;
            category_box.ForeColor = f;
            range_box.ForeColor = f;
            type_box.ForeColor = f;
            size_box.ForeColor = f;
            damage_label.ForeColor = f;
            crit_range_label.ForeColor = f;
            category_label.ForeColor = f;
            range_label.ForeColor = f;
            type_label.ForeColor = f;
            size_label.ForeColor = f;
        }

        private void setBackColor(Color b) {
            weapon_table.BackColor = b;
            item_name_box.BackColor = b;
            weight_box.BackColor = b;
            cost_box.BackColor = b;
            notes_box.BackColor = b;
            damage_box.BackColor = b;
            crit_range_box.BackColor = b;
            category_box.BackColor = b;
            range_box.BackColor = b;
            type_box.BackColor = b;
            size_box.BackColor = b;
        }

        private bool checkHover(Point p) {
            Rectangle hoverArea = RectangleToScreen(this.DisplayRectangle);
            hoverArea.Inflate(-8, -8);

            return hoverArea.Contains(p);
        }

        #endregion

        #region Get & Set methods

        public Weapon getWeapon() {
            return weapon;
        }

        public void setWeapon(Weapon w) {
            weapon = w;
        }

        #endregion

        #region Event Handlers

        private void weapon_table_MouseMove(object sender, MouseEventArgs e) {
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
                weapon.ForeColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void weapon_table_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                weapon.BackColor = colorPicker.Color;
                updateUIData();
            }
        }
        
        #region ValueChanged events

        private void item_name_box_TextChanged(object sender, EventArgs e) {
            weapon.Name = item_name_box.Text;
        }

        private void weight_box_TextChanged(object sender, EventArgs e) {
            weapon.Weight = weight_box.Text;
        }

        private void cost_box_TextChanged(object sender, EventArgs e) {
            weapon.Cost = cost_box.Text;
        }

        private void notes_box_TextChanged(object sender, EventArgs e) {
            weapon.Notes = notes_box.Lines.ToList();
        }

        private void equipped_box_CheckedChanged(object sender, EventArgs e) {
            weapon.Equipped = equipped_box.Checked;
        }

        private void damage_box_TextChanged(object sender, EventArgs e) {
            weapon.Dmg = damage_box.Text;
        }

        private void crit_range_box_TextChanged(object sender, EventArgs e) {
            weapon.CritRange = crit_range_box.Text;
        }

        private void category_box_TextChanged(object sender, EventArgs e) {
            weapon.Category = category_box.Text;
        }

        private void range_box_TextChanged(object sender, EventArgs e) {
            weapon.Range = range_box.Text;
        }

        private void type_box_TextChanged(object sender, EventArgs e) {
            weapon.DmgType = type_box.Text;
        }

        private void size_box_TextChanged(object sender, EventArgs e) {
            weapon.Size = size_box.Text;
        }

        #endregion

        #endregion
    }
}
