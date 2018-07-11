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
    public partial class ItemBox : UserControl
    {
        Item item;

        public ItemBox() {
            item = new Item();
            InitializeComponent();
            updateUIData();
        }

        public ItemBox(Item i) {
            item = i;
            InitializeComponent();
            updateUIData();
        }

        private void updateUIData() {
            item_name_box.Text = item.getName();
            weight_box.Text = item.getWeight();
            cost_box.Text = item.getCost();
            notes_box.Lines = item.getNotes().ToArray();
            if(item.getEquipped())
                equipped_box.CheckState = CheckState.Checked;
            else
                equipped_box.CheckState = CheckState.Unchecked;
            setForeColor(item.getForeColor());
            setBackColor(item.getBackColor());
        }

        private void setForeColor(Color f) {
            item_name_box.ForeColor = f;
            weight_box.ForeColor = f;
            cost_box.ForeColor = f;
            notes_box.ForeColor = f;
        }

        private void setBackColor(Color b) {
            item_table.BackColor = b;
            item_name_box.BackColor = b;
            weight_box.BackColor = b;
            cost_box.BackColor = b;
            notes_box.BackColor = b;
        }

        #region Event Handlers
        private void item_name_box_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                item.setForeColor(colorPicker.Color);
                updateUIData();
            }
        }

        private void item_table_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                item.setBackColor(colorPicker.Color);
                updateUIData();
            }
        }

        private void item_name_box_TextChanged(object sender, EventArgs e) {
            item.setName(item_name_box.Text);
        }

        private void weight_box_TextChanged(object sender, EventArgs e) {
            item.setWeight(weight_box.Text);
        }

        private void cost_box_TextChanged(object sender, EventArgs e) {
            item.setCost(cost_box.Text);
        }

        private void notes_box_TextChanged(object sender, EventArgs e) {
            item.setNotes(notes_box.Lines.ToList());
        }

        private void equipped_box_CheckedChanged(object sender, EventArgs e) {
            item.setEquipped(equipped_box.Checked);
        }
        #endregion

        #region Get & Set methods
        public Item getItem() {
            return item;
        }

        public void setItem(Item i) {
            item = i;
        }
#endregion
    }
}
