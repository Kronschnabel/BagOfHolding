using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BagOfHolding.Combat
{
    public class Tile
    {
        public int x;
        public int y;
        public int xIndex;
        public int yIndex;
        public Rectangle render;
        public float xRender;
        public float yRender;
        public Color c;
        public Color baseColor;
        public Color dimColor;
        public Image i;
        public bool hover;

        public Tile(int x, int y, int xIndex, int yIndex) {
            this.x = x;
            this.y = y;
            this.xIndex = xIndex;
            this.yIndex = yIndex;
            setColor();
        }

        public Tile(int x, int y, Color c) {
            this.x = x;
            this.y = y;
            setColor(c);
        }

        public Tile(int x, int y, Image i) {
            this.x = x;
            this.y = y;
            this.i = i;
            setColor();
        }

        public Tile(int x, int y, Color c, Image i) {
            this.x = x;
            this.y = y;
            this.i = i;
            setColor(c);
        }

        public void setColor() {
            c = Color.LightGray;
            baseColor = c;
            dimColor = Color.FromArgb(3, c.R, c.G, c.B);
        }

        public void setColor(Color c) {
            this.c = c;
            baseColor = c;
            dimColor = Color.FromArgb(3, c.R, c.G, c.B);
        }

        public void setHover(bool isHoverTile) {
            hover = isHoverTile;
            updateColor();
        }

        public void updateColor() {
            if(hover) {
                c = dimColor;
            }
            else {
                c = baseColor;
            }
        }
    }
}
