using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagOfHolding.Combat
{
    public partial class CombatWindow : Form
    {
        float windowWidth;
        float windowHeight;
        float MIN_TILE_WIDTH = 40;
        float MAX_TILE_WIDTH = 300;
        bool camDrag = false;
        bool distDrag = false;
        int xStartI;    //X render start index
        int xEndI;      //X render end index
        int yStartI;    //Y render start index
        int yEndI;      //Y render end index
        int gridWidth;
        int gridHeight;
        List<List<Tile>> tileMap;
        float tileWidth = 40;
        Tile selectedTile;
        Tile hoverTile;

        Point mousePosition;
        Camera cam;
        float camX;
        float camY;
        Point camDragStart;
        Point camCurrentPos;

        Graphics viewPort;
        Pen linePen;
        Brush fillBrush;

        public CombatWindow() {
            gridWidth = 200;
            gridHeight = 200;

            cam = new Camera(MAX_TILE_WIDTH, gridWidth, gridHeight);
            camCurrentPos = new Point((int)cam.x, (int)cam.y);

            tileMap = new List<List<Tile>>(gridWidth);
            for(int x = 0; x < gridWidth; x++) {
                tileMap.Add(new List<Tile>(gridHeight));
                for(int y = 0; y < gridHeight; y++) {
                    tileMap[x].Add(new Tile(x * (int)MAX_TILE_WIDTH, y * (int)MAX_TILE_WIDTH, x, y));
                }
            }
        }

        public void open() {
            InitializeComponent();
            Show();
            BringToFront();
            IsAccessible = true;

            combatPanel.Paint += new PaintEventHandler(paint);
            combatPanel.MouseMove += new MouseEventHandler(mouseMove);
            combatPanel.MouseUp += new MouseEventHandler(mouseUp);
            combatPanel.MouseDown += new MouseEventHandler(mouseDown);
            combatPanel.MouseWheel += new MouseEventHandler(mouseWheel);
        }

        public void paint(object sender, PaintEventArgs e) {
            render(e);
        }

        public void update() {

        }

        public Tile checkHover(Tile t) {
            if(t.render.Contains(mousePosition)) {
                t.setHover(true);
                hoverTile = t;
            }
            else {
                t.setHover(false);
            }
            return t;
        }

        public void render(PaintEventArgs e) {
            viewPort = e.Graphics;
            setRenderBounds();
            update();

            for(int x = xStartI; x <= xEndI; x++) {
                for(int y = yStartI; y <= yEndI; y++) {
                    tileMap[x][y] = checkHover(tileMap[x][y]);
                    drawTile(tileMap[x][y], viewPort);
                }
            }
        }

        public void drawTile(Tile t, Graphics viewPort) {
            t = setRenderRect(t);
            fillBrush = new SolidBrush(t.c);
            linePen = new Pen(Color.Gray);
            viewPort.FillRectangle(fillBrush, t.render);
            viewPort.DrawRectangle(linePen, t.render);
        }

        public Tile setRenderRect(Tile t) {
            float rX = camX - ((tileWidth * (cam.x - t.x)) / MAX_TILE_WIDTH);
            float rY = camY - ((tileWidth * (cam.y - t.y)) / MAX_TILE_WIDTH);

            t.render = new Rectangle((int)rX, (int)rY, (int)tileWidth, (int)tileWidth);

            return t;
        }

        public void setRenderBounds() {
            xStartI = (cam.xTile - (int)(camX / tileWidth)) - 1;
            xEndI = (cam.xTile + (int)(camX / tileWidth)) + 1;
            yStartI = (cam.yTile - (int)(camY / tileWidth)) - 1;
            yEndI = (cam.yTile + (int)(camY / tileWidth)) + 1;

            if(xStartI < 0)
                xStartI = 0;

            if(xEndI >= gridWidth)
                xEndI = gridWidth - 1;

            if(yStartI < 0)
                yStartI = 0;

            if(yEndI >= gridHeight)
                yEndI = gridHeight - 1;
        }

        public void setWindowSize(int x, int y) {
            windowWidth = x;
            windowHeight = y;
            camX = x / 2;
            camY = y / 2;
        }

        public void dragCamera(int x, int y) {
            int scaleFactor = (int)(MAX_TILE_WIDTH / tileWidth);
            int xDisplacement = (camDragStart.X - x) * scaleFactor;
            int yDisplacement = (camDragStart.Y - y) * scaleFactor;
            camDragStart = new Point(x, y);
            camCurrentPos = new Point(camCurrentPos.X + xDisplacement, camCurrentPos.Y + yDisplacement);
            cam.setPos(camCurrentPos);
        }

        public void mouseMove(object sender, MouseEventArgs e) {
            mousePosition = e.Location;

            if(camDrag) {
                dragCamera(e.X, e.Y);
            }
            update();
            Refresh();
        }

        public void mouseWheel(object sender, MouseEventArgs e) {
            int delta = e.Delta;

            if(delta > 0 && tileWidth < MAX_TILE_WIDTH) {
                tileWidth += (delta / 10);
            }
            else if(delta < 0 && tileWidth > MIN_TILE_WIDTH) {
                tileWidth += (delta / 10);
            }

            Refresh();
        }

        public void mouseDown(object sender, MouseEventArgs e) {
            if(e.Button.Equals(MouseButtons.Right)) {
                camDragStart = e.Location;
                camDrag = true;
            }
            else if(e.Button.Equals(MouseButtons.Left)) {

            }
        }

        public void mouseUp(object sender, MouseEventArgs e) {
            if(e.Button.Equals(MouseButtons.Right)) {
                camDrag = false;
            }
            else if(e.Button.Equals(MouseButtons.Left)) {

            }
        }
    }
}
