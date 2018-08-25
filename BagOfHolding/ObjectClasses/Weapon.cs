using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BagOfHolding
{
    public class Weapon : Item
    {
        string category;
        string size;
        string critRange;
        string range;
        string dmg;
        string dmgType;
        Image weaponImage;

        public Weapon() {
            new Item();
            setBlankWeapon();
        }

        public void setBlankWeapon() {
            category = "";
            size = "";
            critRange = "";
            range = "";
            dmg = "";
            dmgType = "";
        }

        #region To\From string

        public new string toString() {
            return getName() + "|" + getWeight() + "|" + getCost() + "|" + getEquipped() + "|" + category + "|" + size + "|" + critRange + "|" + range + "|" + dmg + "|" + dmgType + "|" + getForeColor().ToArgb() + "|" + getBackColor().ToArgb() + notesToString();
        }

        public new void fromString(string l) {
            string[] sLine = l.Split('|');
            bool e;
            int fC;
            int bC;

            setName(sLine[0]);
            setWeight(sLine[1]);
            setCost(sLine[2]);
            if(bool.TryParse(sLine[3], out e))
                setEquipped(e);
            else
                setEquipped(false);
            category = sLine[4];
            size = sLine[5];
            critRange = sLine[6];
            range = sLine[7];
            dmg = sLine[8];
            dmgType = sLine[9];
            if(int.TryParse(sLine[10], out fC))
                setForeColor(Color.FromArgb(fC));
            else
                setForeColor(Color.Black);
            if(int.TryParse(sLine[11], out bC))
                setBackColor(Color.FromArgb(bC));
            else
                setBackColor(Color.Gainsboro);

            List<string> tempNotes = new List<string>();
            foreach(string n in sLine.Skip(12)) {
                tempNotes.Add(n);
            }
            setNotes(tempNotes);
        }

        #endregion

        #region Get & Set methods

        public string getCategory() {
            return category;
        }

        public string getSize() {
            return size;
        }

        public string getCritRange() {
            return critRange;
        }

        public string getRange() {
            return range;
        }

        public string getDmg() {
            return dmg;
        }

        public string getDmgType() {
            return dmgType;
        }

        public Image getImage() {
            return weaponImage;
        }

        public void setCategory(string c) {
            category = c;
        }

        public void setSize(string s) {
            size = s;
        }

        public void setCritRange(string c) {
            critRange = c;
        }

        public void setRange(string r) {
            range = r;
        }

        public void setDmg(string d) {
            dmg = d;
        }

        public void setDmgType(string t) {
            dmgType = t;
        }

        public void setImage(Image i) {
            weaponImage = i;
        }

#endregion
    }
}
