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
    public partial class SettingsWindow : UserControl
    {
        bool initialized;

        public SettingsWindow() {

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
            console_back_butt.BackColor = Properties.Settings.Default.consoleBackColor;
            console_text_butt.BackColor = Properties.Settings.Default.consoleForeColor;
            window_cont_butt.BackColor = Properties.Settings.Default.windowContColor;
            window_butt_butt.BackColor = Properties.Settings.Default.windowButtColor;
            window_strip_butt.BackColor = Properties.Settings.Default.windowToolColor;
        }

        private void setColors() {
            menu_strip.BackColor = Properties.Settings.Default.windowToolColor;
        }

        private void settingsChanged(object sender, PropertyChangedEventArgs e) {
            setColors();
        }

        private void console_back_butt_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.consoleBackColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void console_text_butt_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.consoleForeColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void window_cont_butt_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.windowContColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void window_butt_butt_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.windowButtColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void window_strip_butt_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.windowToolColor = colorPicker.Color;
                updateUIData();
            }
        }
    }
}
