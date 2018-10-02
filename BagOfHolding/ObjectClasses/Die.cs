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
            sIncrement += (sIncrement % 5) + 3;

            sIncrement %= 132040292;
        }

        #region Get & Set methods

        public int Seed {
            get {
                return seed;
            }
            set {
                seed = value;
            }
        }

        public int Increment {
            get {
                return sIncrement;
            }
            set {
                sIncrement = value;
            }
        }

#endregion
    }
}
