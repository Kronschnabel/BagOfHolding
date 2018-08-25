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

        public string getName() {
            return name;
        }

        public int getLevel() {
            return level;
        }

        public string getHitDie() {
            return hitDie;
        }

        public int getSkillRanks() {
            return skillRanks;
        }

        public bool getFavored() {
            return favored;
        }

        public void setName(string n) {
            name = n;
        }

        public void setLevel(int l) {
            level = l;
        }

        public void setHitDie(string h) {
            hitDie = h;
        }

        public void setSkillRanks(int s) {
            skillRanks = s;
        }

        public void setFavored(bool f) {
            favored = f;
        }

#endregion
    }
}
