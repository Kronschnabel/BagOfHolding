using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BagOfHolding
{
    public class Spell
    {
        string name;
        string school;
        string level;
        List<string> notes;
        bool prepared;
        Color foreColor;
        Color backColor;
        Image spellImage;

        public Spell() {
            setBlankSpell();
        }

        public void setBlankSpell() {
            name = "New Spell";
            school = "school";
            level = "level";
            notes = new List<string>();
            prepared = false;
            foreColor = Color.Black;
            backColor = Color.Gainsboro;
        }

        #region To\From string
        public string toString() {
            return name + "|" + school + "|" + level  + "|" + prepared + "|" + foreColor.ToArgb() + "|" + backColor.ToArgb() + notesToString();
        }

        public void fromString(string l) {
            string[] sLine = l.Split('|');
            int fC;
            int bC;

            name = sLine[0];
            school = sLine[1];
            level = sLine[2];
            if(!bool.TryParse(sLine[3], out prepared))
                prepared = false;
            if(int.TryParse(sLine[4], out fC))
                foreColor = Color.FromArgb(fC);
            else
                foreColor = Color.Black;
            if(int.TryParse(sLine[5], out bC))
                backColor = Color.FromArgb(bC);
            else
                backColor = Color.Gainsboro;

            foreach(string n in sLine.Skip(6)) {
                notes.Add(n);
            }
        }

        private string notesToString() {
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

        public string getSchool() {
            return school;
        }

        public string getLevel() {
            return level;
        }

        public List<string> getNotes() {
            return notes;
        }

        public bool getPrepared() {
            return prepared;
        }

        public Color getForeColor() {
            return foreColor;
        }

        public Color getBackColor() {
            return backColor;
        }

        public Image getImage() {
            return spellImage;
        }

        public void setName(string n) {
            name = n;
        }

        public void setSchool(string s) {
            school = s;
        }

        public void setLevel(string l) {
            level = l;
        }

        public void setNotes(List<string> n) {
            notes = n;
        }

        public void setPrepared(bool p) {
            prepared = p;
        }

        public void setForeColor(Color f) {
            foreColor = f;
        }

        public void setBackColor(Color b) {
            backColor = b;
        }

        public void setImage(Image i) {
            spellImage = i;
        }
        #endregion
    }
}
