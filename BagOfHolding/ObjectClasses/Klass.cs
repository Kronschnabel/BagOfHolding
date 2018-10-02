using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfHolding
{
    public class Klass
    {
        string name;
        int level;
        string hitDie;
        int skillRanks;
        bool favored;
        
        public Klass() {
            setBlankClass();
        }

        public void setBlankClass() {
            name = "";
            level = 0;
            hitDie = "D*";
            skillRanks = 0;
            favored = false;
        }

        #region To\From string

        public string toString() {
            return name + "|" + level + "|" + hitDie + "|" + skillRanks + "|" + favored;
        }

        public void fromString(string l) {
            string[] sLine = l.Split('|');

            name = sLine[0];
            if(!int.TryParse(sLine[1], out level))
                level = 0;
            hitDie = sLine[2];
            if(!int.TryParse(sLine[3], out skillRanks))
                skillRanks = 0;
            if(!bool.TryParse(sLine[4], out favored))
                favored = false;
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

        public int Level {
            get {
                return level;
            }
            set {
                level = value;
            }
        }

        public string HitDie {
            get {
                return hitDie;
            }
            set {
                hitDie = value;
            }
        }

        public int SkillRanks {
            get {
                return skillRanks;
            }
            set {
                skillRanks = value;
            }
        }

        public bool Favored {
            get {
                return favored;
            }
            set {
                favored = value;
            }
        }
        
#endregion
    }
}
