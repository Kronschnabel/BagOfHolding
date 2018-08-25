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
                setForeColor(Color.FromArgb(fC));
            else
                setForeColor(Color.Black);
            if(int.TryParse(sLine[5], out bC))
                setBackColor(Color.FromArgb(bC));
            else
                setBackColor(Color.Gainsboro);

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

        public string getName() {
            return name;
        }

        public string getWeight() {
            return weight;
        }

        public string getCost() {
            return cost;
        }

        public List<string> getNotes() {
            return notes;
        }

        public bool getEquipped() {
            return equipped;
        }

        public Color getForeColor() {
            return foreColor;
        }

        public Color getBackColor() {
            return backColor;
        }

        public void setName(string n) {
            name = n;
        }

        public void setWeight(string w) {
            weight = w;
        }

        public void setCost(string c) {
            cost = c;
        }

        public void setNotes(List<string> n) {
            notes = n;
        }

        public void setEquipped(bool e) {
            equipped = e;
        }

        public void setForeColor(Color f) {
            foreColor = f;
        }

        public void setBackColor(Color b) {
            backColor = b;
        }

#endregion
    }
}
