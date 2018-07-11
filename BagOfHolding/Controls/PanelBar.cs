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
    public partial class PanelBar : UserControl
    {
        float baseWidth;
        float current;
        float max;

        public PanelBar() {
            InitializeComponent();
        }

        public void updateBar() {
            Size backSize = back_bar.Size;
            backSize.Width = Width;
            back_bar.Size = backSize;
            Size frontSize = front_bar.Size;
            frontSize.Width = (int) ((current / max) * (Width - baseWidth));
            frontSize.Width += (int) baseWidth;
            front_bar.Size = frontSize;
        }

        public void setColors(Color front, Color back) {
            front_bar.BackColor = front;
            back_bar.BackColor = back;
        }

        #region Get & Set methods
        public float getBaseWidth() {
            return baseWidth;
        }

        public float getCurrent() {
            return current;
        }

        public float getMax() {
            return max;
        }

        public void setBaseWidth(float b) {
            baseWidth = b;
        }

        public void setCurrent(float c) {
            current = c;
        }

        public void setMax(float m) {
            max = m;
        }
#endregion
    }
}
