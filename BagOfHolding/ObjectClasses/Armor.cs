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
        Image armorImage;

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
            return getName() + "|" + getWeight() + "|" + getCost() + "|" + getEquipped() + "|" + size + "|" + speed + "|" + acBonus + "|" + maxDex + "|" + armorCheckPenalty + "|" + spellFail + "|" + getForeColor().ToArgb() + "|" + getBackColor().ToArgb() + notesToString();
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
                setForeColor(Color.FromArgb(fC));
            else
                setForeColor(Color.Black);
            if(int.TryParse(sLine[11], out bC))
                setBackColor(Color.FromArgb(bC));
            else
                setBackColor(Color.Gainsboro);

            foreach(string n in sLine.Skip(12)) {
                getNotes().Add(n);
            }
        }
#endregion

        #region Get & Set methods
        public string getSize() {
            return size;
        }

        public string getSpeed() {
            return speed;
        }

        public int getACBonus() {
            return acBonus;
        }

        public int getMaxDex() {
            return maxDex;
        }

        public int getPenalty() {
            return armorCheckPenalty;
        }

        public int getSpellFail() {
            return spellFail;
        }

        public Image getImage() {
            return armorImage;
        }

        public void setSize(string s) {
            size = s;
        }

        public void setSpeed(string s) {
            speed = s;
        }

        public void setACBonus(int a) {
            acBonus = a;
        }

        public void setMaxDex(int d) {
            maxDex = d;
        }

        public void setPenalty(int p) {
            armorCheckPenalty = p;
        }

        public void setSpellFail(int s) {
            spellFail = s;
        }

        public void setImage(Image i) {
            armorImage = i;
        }

#endregion
    }
}
