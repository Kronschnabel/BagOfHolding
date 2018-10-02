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
            item_name_box.Text = item.Name;
            weight_box.Text = item.Weight;
            cost_box.Text = item.Cost;
            notes_box.Lines = item.Notes.ToArray();
            if(item.Equipped)
                equipped_box.CheckState = CheckState.Checked;
            else
                equipped_box.CheckState = CheckState.Unchecked;
            setForeColor(item.ForeColor);
            setBackColor(item.BackColor);
        }

        #region Utility methods

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

        private bool checkHover(Point p) {
            Rectangle hoverArea = RectangleToScreen(DisplayRectangle);
            hoverArea.Inflate(-8, -8);

            return hoverArea.Contains(p);
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

        #region Event Handlers

        private void item_name_box_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                item.ForeColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void item_table_DoubleClick(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                item.BackColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void equipped_box_CheckedChanged(object sender, EventArgs e) {
            item.Equipped = equipped_box.Checked;
        }

        private void item_table_MouseMove(object sender, MouseEventArgs e) {
            if(checkHover(MousePosition))
                del_butt.Visible = true;
            else
                del_butt.Visible = false;
        }

        private void del_butt_Click(object sender, EventArgs e) {
            Dispose();
        }

        #region TextChanged events

        private void item_name_box_TextChanged(object sender, EventArgs e) {
            item.Name = item_name_box.Text;
        }

        private void weight_box_TextChanged(object sender, EventArgs e) {
            item.Weight = weight_box.Text;
        }

        private void cost_box_TextChanged(object sender, EventArgs e) {
            item.Cost = cost_box.Text;
        }

        private void notes_box_TextChanged(object sender, EventArgs e) {
            item.Notes = notes_box.Lines.ToList();
        }

        #endregion

        #endregion

    }
}
