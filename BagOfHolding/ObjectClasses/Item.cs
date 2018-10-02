using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BagOfHolding
{
    public class Item
    {
        string name;
        string weight;
        string cost;
        List<string> notes;
        bool equipped;
        Color foreColor;
        Color backColor;

        public Item() {
            setBlankItem();
        }

        public void setBlankItem() {
            name = "New Item";
            weight = "weight";
            cost = "cost";
            notes = new List<string>();
            equipped = false;
            foreColor = Color.Black;
            backColor = Color.Gainsboro;
        }

        #region To\From string

        public string toString() {
            return name + "|" + weight + "|" + cost + "|" + equipped + "|" + foreColor.ToArgb() + "|" + backColor.ToArgb() + notesToString();
        }

        public void fromString(string l) {
            string[] sLine = l.Split('|');
            int fC;
            int bC;

            name = sLine[0];
            weight = sLine[1];
            cost = sLine[2];
            if(!bool.TryParse(sLine[3], out equipped))
                equipped = false;
            if(int.TryParse(sLine[4], out fC))
                foreColor = Color.FromArgb(fC);
            else
                foreColor = Color.Black;
            if(int.TryParse(sLine[5], out bC))
                backColor = Color.FromArgb(bC);
            else
                backColor = Color.Gainsboro;

            notes.Clear();
            foreach(string n in sLine.Skip(6)) {
                notes.Add(n);
            }

        }

        public string notesToString() {
            string retString = "";
            
            foreach(string n in notes) {
                retString += "|" + n;
            }

            return retString;
        }

        #endregion

        #region Get & Set methods

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public string Weight {
            get {
                return weight;
            }
            set {
                weight = value;
            }
        }

        public string Cost {
            get {
                return cost;
            }
            set {
                cost = value;
            }
        }

        public List<string> Notes {
            get {
                return notes;
            }
            set {
                notes = value;
            }
        }

        public bool Equipped {
            get {
                return equipped;
            }
            set {
                equipped = value;
            }
        }

        public Color ForeColor {
            get {
                return foreColor;
            }
            set {
                foreColor = value;
            }
        }

        public Color BackColor {
            get {
                return backColor;
            }
            set {
                backColor = value;
            }
        }
        
#endregion
    }
}
