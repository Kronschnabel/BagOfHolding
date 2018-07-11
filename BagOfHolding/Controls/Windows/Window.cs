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
    public partial class Window : UserControl
    {
        string type;
        bool initialized;
        List<UserControl> pendingControls;

        Point dragStartPos;

        bool windowDrag;
        bool resizeDrag;
        bool mRightEdge;
        bool mLeftEdge;
        bool mBottomEdge;

        bool resizeControlsActive = true;

        public Window(string t) {
            type = t;
            pendingControls = new List<UserControl>();
        }

        public void open() {
            if(!initialized)
                startup();

            Show();
            Visible = true;
            BringToFront();
            IsAccessible = true;
        }

        private void startup() {
            initialized = true;
            InitializeComponent();

            foreach(UserControl c in pendingControls)
                addControl(c);
            pendingControls.Clear();

            if(type.Equals("char")) {
                Location = new Point(100, 100);
                Size = new Size(new Point(800, 580));
                resizeControlsActive = false;
            }
            else if(type.Equals("inv")) {
                Location = new Point(30, 30);
                Size = new Size(new Point(1250, 680));
                resizeControlsActive = false;
            }
            else if(type.Equals("spellbook")) {
                Location = new Point(50, 50);
                Size = new Size(new Point(950, 700));
                resizeControlsActive = false;
            }
            else if(type.Equals("party")) {
                Location = new Point(20, 20);
                Size = new Size(new Point(1200, 633));
                resizeControlsActive = false;
            }
        }

        public void addControl(UserControl cont) {
            if(initialized)
                main_panel.Controls.Add(cont);
            else
                pendingControls.Add(cont);
        }

        private void dragWindow(Point m) {
            Point newLocation;

            if(resizeDrag) {
                newLocation = new Point(Location.X + (m.X - dragStartPos.X), Location.Y);
            }
            else {
                newLocation = new Point(Location.X + (m.X - dragStartPos.X), Location.Y + (m.Y - dragStartPos.Y));
            }

            Location = newLocation;
        }

        private void dragEdge(Point m) {
            if(resizeControlsActive) {
                if(mRightEdge) {
                    Width = m.X;
                }
                else if(mLeftEdge) {
                    dragWindow(m);
                    Width -= m.X - dragStartPos.X;
                }

                if(mBottomEdge) {
                    Height = m.Y;
                }
            }
        }

        private void checkEdges(Point m) {
            if(m.X < 5) {
                mLeftEdge = true;
                mRightEdge = false;
            }
            else if(m.X > Width - 5) {
                mLeftEdge = false;
                mRightEdge = true;
            }
            else {
                mLeftEdge = false;
                mRightEdge = false;
            }

            if(m.Y > Height - 5) {
                mBottomEdge = true;
            }
            else {
                mBottomEdge = false;
            }
                 
        }

        #region Event Handlers

        private void back_panel_MouseDown(object sender, MouseEventArgs eArgs) {
            checkEdges(eArgs.Location);
            
            if(mRightEdge || mLeftEdge || mBottomEdge) {
                resizeDrag = true;
                dragStartPos = eArgs.Location;
            }
            else {
                BringToFront();
                windowDrag = true;
                dragStartPos = eArgs.Location;
            }
        }

        private void back_panel_MouseUp(object sender, MouseEventArgs eArgs) {
            windowDrag = false;
            resizeDrag = false;
        }

        private void back_panel_MouseMove(object sender, MouseEventArgs eArgs) {
            if(windowDrag) {
                dragWindow(eArgs.Location);
            }
            else if(resizeDrag) {
                dragEdge(eArgs.Location);
            }
            else
                checkEdges(eArgs.Location);
        }

        private void back_panel_MouseEnter(object sender, EventArgs eArgs) {

        }

        private void back_panel_MouseLeave(object sender, EventArgs eArgs) {
            if(windowDrag) {
                dragWindow(back_panel.PointToClient(MousePosition));
            }
            
            if(resizeDrag) {
                dragEdge(back_panel.PointToClient(MousePosition));
            }
        }

        private void closeB_Click(object sender, EventArgs eArgs) {
            Visible = false;
        }

        private void back_panel_MouseDoubleClick(object sender, MouseEventArgs e) {
            BringToFront();
        }
        #endregion
    }
}
