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

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public string School {
            get {
                return school;
            }
            set {
                school = value;
            }
        }

        public string Level {
            get {
                return level;
            }
            set {
                level = value;
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

        public bool Prepared {
            get {
                return prepared;
            }
            set {
                prepared = value;
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
