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
            return Name + "|" + Weight + "|" + Cost + "|" + Equipped + "|" + category + "|" + size + "|" + critRange + "|" + range + "|" + dmg + "|" + dmgType + "|" + ForeColor.ToArgb() + "|" + BackColor.ToArgb() + notesToString();
        }

        public new void fromString(string l) {
            string[] sLine = l.Split('|');
            bool e;
            int fC;
            int bC;

            Name = sLine[0];
            Weight = sLine[1];
            Cost = sLine[2];
            if(bool.TryParse(sLine[3], out e))
                Equipped = e;
            else
                Equipped = false;
            category = sLine[4];
            size = sLine[5];
            critRange = sLine[6];
            range = sLine[7];
            dmg = sLine[8];
            dmgType = sLine[9];
            if(int.TryParse(sLine[10], out fC))
                ForeColor = Color.FromArgb(fC);
            else
                ForeColor = Color.Black;
            if(int.TryParse(sLine[11], out bC))
                BackColor = Color.FromArgb(bC);
            else
                BackColor = Color.Gainsboro;

            List<string> tempNotes = new List<string>();
            foreach(string n in sLine.Skip(12)) {
                tempNotes.Add(n);
            }
            Notes = tempNotes;
        }

        #endregion

        #region Get & Set methods

        public string Category {
            get {
                return category;
            }
            set {
                category = value;
            }
        }

        public string Size {
            get {
                return size;
            }
            set {
                size = value;
            }
        }

        public string CritRange {
            get {
                return critRange;
            }
            set {
                critRange = value;
            }
        }
        
        public string Range {
            get {
                return range;
            }
            set {
                range = value;
            }
        }

        public string Dmg {
            get {
                return dmg;
            }
            set {
                dmg = value;
            }
        }

        public string DmgType {
            get {
                return dmgType;
            }
            set {
                dmgType = value;
            }
        }

#endregion
    }
}
