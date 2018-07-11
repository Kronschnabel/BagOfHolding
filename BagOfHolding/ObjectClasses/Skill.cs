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
        public string getName() {
            return name;
        }

        public int getTotal() {
            return total;
        }

        public int getAbilityType() {
            return abilityType;
        }

        public int getAbilityMod() {
            return abilityMod;
        }

        public int getRanks() {
            return ranks;
        }

        public int getMiscMod1() {
            return miscMod1;
        }

        public int getMiscMod2() {
            return miscMod2;
        }

        public bool getClassSkill() {
            return classSkill;
        }

        public bool getTrained() {
            return trained;
        }

        public void setName(string n) {
            name = n;
        }

        public void setTotal(int t) {
            total = t;
        }

        public void setAbilityType(int t) {
            abilityType = t;
            resetTotal();
        }

        public void setAbilityMod(int m) {
            abilityMod = m;
            resetTotal();
        }

        public void setRanks(int r) {
            ranks = r;
            resetTotal();
        }

        public void setMiscMod1(int m) {
            miscMod1 = m;
            resetTotal();
        }

        public void setMiscMod2(int m) {
            miscMod2 = m;
            resetTotal();
        }

        public void setClassSkill(bool c) {
            classSkill = c;
            resetTotal();
        }

        public void setTrained(bool t) {
            trained = t;
            resetTotal();
        }
#endregion
    }
}
