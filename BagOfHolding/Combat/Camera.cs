using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BagOfHolding.Combat
{
    public class Camera
    {
        public float MAX_TILE_WIDTH;

        public float x;
        public float y;
        public int xTile;
        public int yTile;
        public int xMax;
        public int yMax;
        public Point center;

        public Camera(float maxWidth, int gridWidth, int gridHeight) {
            MAX_TILE_WIDTH = maxWidth;
            setBounds(gridWidth, gridHeight);
            setPos(center);
        }

        public void setBounds(int l, int w) {
            xMax = l * (int)MAX_TILE_WIDTH;
            yMax = w * (int)MAX_TILE_WIDTH;
            center = new Point(xMax / 2, yMax / 2);
        }

        public void setPos(float x, float y) {
            this.x = x;
            this.y = y;
            xTile = (int)(x / MAX_TILE_WIDTH);
            yTile = (int)(y / MAX_TILE_WIDTH);
        }

        public void setPos(Point p) {
            x = p.X;
            y = p.Y;
            xTile = (int)(p.X / MAX_TILE_WIDTH);
            yTile = (int)(p.Y / MAX_TILE_WIDTH);
        }
    }
}
