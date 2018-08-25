using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfHolding
{
    public class AbilityScore
    {
        int total;
        int mod;

        public AbilityScore() {
            setTotal(0);
        }

        private void resetMod() {
            if(total % 2 != 0)
                mod = total - 1;
            else
                mod = total;

            mod = (mod / 2) - 5;
        }

        public void addToTotal(int t) {
            total += t;
        }

        #region To\From string 

        public string toString() {
            return total + "|" + mod;
        }

        public void fromString(string l) {
            string[] sLine = l.Split('|');

            if(!int.TryParse(sLine[0], out total))
                total = 0;
            if(!int.TryParse(sLine[1], out mod))
                mod = 0;
        }

#endregion

        #region Get & Set methods

        public int getTotal() {
            return total;
        }

        public int getMod() {
            return mod;
        }

        public void setTotal(int t) {
            total = t;
            resetMod();
        }

        public void setMod(int m) {
            mod = m;
        }

        #endregion

    }
}
