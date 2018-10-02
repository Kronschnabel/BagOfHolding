using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfHolding
{
    public class Skill
    {
        string name;

        int total;
        int abilityType;
        int abilityMod;
        int ranks;
        int miscMod1;
        int miscMod2;
        bool classSkill;
        bool trained;

        public Skill() {
            setBlankSkill();
        }

        public void setBlankSkill() {
            name = "New Skill";
            total = 0;
            abilityType = 1;
            abilityMod = 0;
            ranks = 0;
            miscMod1 = 0;
            miscMod2 = 0;
            classSkill = false;
            trained = false;
        }

        private void resetTotal() {
            total = abilityMod + ranks + miscMod1 + miscMod2;

            if(classSkill && ranks > 0)
                trained = true;
            else
                trained = false;

            if(trained)
                total += 3;
        }

        #region To\From string

        public string toString() {
            return name + "|" + total + "|" + abilityType + "|" + abilityMod + "|" + ranks + "|" + miscMod1 + "|" + miscMod2 + "|" + classSkill + "|" + trained;
        }

        public void fromString(string l) {
            string[] sLine = l.Split('|');

            name = sLine[0];
            if(!int.TryParse(sLine[1], out total))
                total = 0;
            if(!int.TryParse(sLine[2], out abilityType))
                abilityType = 0;
            if(!int.TryParse(sLine[3], out abilityMod))
                abilityMod = 0;
            if(!int.TryParse(sLine[4], out ranks))
                ranks = 0;
            if(!int.TryParse(sLine[5], out miscMod1))
                miscMod1 = 0;
            if(!int.TryParse(sLine[6], out miscMod2))
                miscMod2 = 0;
            if(!bool.TryParse(sLine[7], out classSkill))
                classSkill = false;
            if(!bool.TryParse(sLine[8], out trained))
                trained = false;
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

        public int Total {
            get {
                return total;
            }
            set {
                total = value;
            }
        }

        public int AbilityType {
            get {
                return abilityType;
            }
            set {
                abilityType = value;
            }
        }

        public int AbilityMod {
            get {
                return abilityMod;
            }
            set {
                abilityMod = value;
                resetTotal();
            }
        }

        public int Ranks {
            get {
                return ranks;
            }
            set {
                ranks = value;
                resetTotal();
            }
        }

        public int MiscMod1 {
            get {
                return miscMod1;
            }
            set {
                miscMod1 = value;
                resetTotal();
            }
        }

        public int MiscMod2 {
            get {
                return miscMod2;
            }
            set {
                miscMod2 = value;
                resetTotal();
            }
        }

        public bool ClassSkill {
            get {
                return classSkill;
            }
            set {
                classSkill = value;
                resetTotal();
            }
        }

        public bool Trained {
            get {
                return trained;
            }
            set {
                trained = value;
                resetTotal();
            }
        }

#endregion
    }
}
