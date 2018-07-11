using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfHolding
{
    class Die
    {
        Random rand;
        int seed;
        int sIncrement;

        public Die() {
            new Die((int) DateTime.Now.Ticks);
        }

        public Die(int s) {
            seed = s;
        }

        public int roll(int sides) {
            updateIncrement();
            rand = new Random((int) DateTime.Now.Ticks + seed + sIncrement);
            return rand.Next(1, sides + 1);
        }

        private void updateIncrement() {
            sIncrement += 3;

            if(sIncrement >= 1000)
                sIncrement = 0;
        }

        #region Get & Set methods
        public int getSeed() {
            return seed;
        }

        public int getIncrement() {
            return sIncrement;
        }

        public void setSeed(int s) {
            seed = s;
        }

        public void setIncrement(int i) {
            sIncrement = i;
        }
#endregion
    }
}
