using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BagOfHolding
{
    public class Armor : Item
    {
        string size;
        string speed;
        int acBonus;
        int maxDex;
        int armorCheckPenalty;
        int spellFail;

        public Armor() {
            new Item();
            setBlankArmor();
        }

        public void setBlankArmor() {
            size = "";
            speed = "";
            acBonus = 0;
            maxDex = 0;
            armorCheckPenalty = 0;
            spellFail = 0;
        }

        #region To\From string

        public new string toString() {
            return Name + "|" + Weight + "|" + Cost + "|" + Equipped + "|" + size + "|" + speed + "|" + acBonus + "|" + maxDex + "|" + armorCheckPenalty + "|" + spellFail + "|" + ForeColor.ToArgb() + "|" + BackColor.ToArgb() + notesToString();
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
            size = sLine[4];
            speed = sLine[5];
            if(!int.TryParse(sLine[6], out acBonus))
                acBonus = 0;
            if(!int.TryParse(sLine[7], out maxDex))
                maxDex = 0;
            if(!int.TryParse(sLine[8], out armorCheckPenalty))
                armorCheckPenalty = 0;
            if(!int.TryParse(sLine[9], out spellFail))
                spellFail = 0;
            if(int.TryParse(sLine[10], out fC))
                ForeColor = Color.FromArgb(fC);
            else
                ForeColor = Color.Black;
            if(int.TryParse(sLine[11], out bC))
                BackColor = Color.FromArgb(bC);
            else
                BackColor = Color.Gainsboro;

            foreach(string n in sLine.Skip(12)) {
                Notes.Add(n);
            }
        }

        #endregion

        #region Get & Set methods

        public string Size {
            get {
                return size;
            }
            set {
                size = value;
            }
        }

        public string Speed {
            get {
                return speed;
            }
            set {
                speed = value;
            }
        }

        public int ACBonus {
            get {
                return acBonus;
            }
            set {
                acBonus = value;
            }
        }
    
        public int MaxDex {
            get {
                return maxDex;
            }
            set {
                maxDex = value;
            }
        }

        public int ACP {
            get {
                return armorCheckPenalty;
            }
            set {
                armorCheckPenalty = value;
            }
        }

        public int SpellFail {
            get {
                return spellFail;
            }
            set {
                spellFail = value;
            }
        }

#endregion
    }
}
