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
            item_name_box.Text = weapon.getName();
            weight_box.Text = weapon.getWeight();
            cost_box.Text = weapon.getCost();
            notes_box.Lines = weapon.getNotes().ToArray();
            if(weapon.getEquipped())
                equipped_box.CheckState = CheckState.Checked;
            else
                equipped_box.CheckState = CheckState.Unchecked;
            damage_box.Text = weapon.getDmg();
            crit_range_box.Text = weapon.getCritRange();
            category_box.Text = weapon.getCategory();
            range_box.Text = weapon.getRange();
            type_box.Text = weapon.getDmgType();
            size_box.Text = weapon.getSize();
            setForeColor(weapon.getForeColor());
            setBackColor(weapon.getBackColor());
        }

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

        #region Get & Set methods
        public Weapon getWeapon() {
            return weapon;
        }

        public void setWeapon(Weapon w) {
            weapon = w;
        }
        #endregion

        #region Event Handlers
        private void item_name_box_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                weapon.setForeColor(colorPicker.Color);
                updateUIData();
            }
        }

        private void weapon_table_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                weapon.setBackColor(colorPicker.Color);
                updateUIData();
            }
        }

        private void weapon_image_DoubleClick(object sender, EventArgs e) {
            OpenFileDialog imageSelect = new OpenFileDialog();
            imageSelect.Filter = "Image Files ('*.jpg') | *.jpg";

            if(imageSelect.ShowDialog() == DialogResult.OK) {
                weapon.setImage(Image.FromFile(imageSelect.FileName));
                updateUIData();
            }
        }

        private void item_name_box_TextChanged(object sender, EventArgs e) {
            weapon.setName(item_name_box.Text);
        }

        private void weight_box_TextChanged(object sender, EventArgs e) {
            weapon.setWeight(weight_box.Text);
        }

        private void cost_box_TextChanged(object sender, EventArgs e) {
            weapon.setCost(cost_box.Text);
        }

        private void notes_box_TextChanged(object sender, EventArgs e) {
            weapon.setNotes(notes_box.Lines.ToList());
        }

        private void equipped_box_CheckedChanged(object sender, EventArgs e) {
            weapon.setEquipped(equipped_box.Checked);
        }

        private void damage_box_TextChanged(object sender, EventArgs e) {
            weapon.setDmg(damage_box.Text);
        }

        private void crit_range_box_TextChanged(object sender, EventArgs e) {
            weapon.setCritRange(crit_range_box.Text);
        }

        private void category_box_TextChanged(object sender, EventArgs e) {
            weapon.setCategory(category_box.Text);
        }

        private void range_box_TextChanged(object sender, EventArgs e) {
            weapon.setRange(range_box.Text);
        }

        private void type_box_TextChanged(object sender, EventArgs e) {
            weapon.setDmgType(type_box.Text);
        }

        private void size_box_TextChanged(object sender, EventArgs e) {
            weapon.setSize(size_box.Text);
        }
#endregion
    }
}
