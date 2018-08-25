using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfHolding
{
    public class Command
    {
        string[] sLine;
        string var;
        List<string> modVar;

        bool die;
        bool sum;
        bool modded;
        bool party;
        bool varEdit;
        bool multiRoll;
        bool multiMod;

        int mod;
        int sides;
        int rollCount;

        public Command(string line) {
            sLine = line.Split(' ');
            modVar = new List<string>();

            foreach(string command in sLine) {
                if(command != "") {
                    char preOp = command[0];
                    char postOp = command[command.Length - 1];

                    if(postOp == '+' || postOp == '-' || postOp == '=') {
                        varEdit = true;
                        sum = true;
                        var = command;
                    }
                    else if(command == "s" || command == "sum") {
                        sum = true;
                    }
                    else if(command == "p" || command == "party") {
                        party = true;
                    }
                    else if(preOp == 'd' || preOp == 'D') {
                        string[] diceString = command.Split('*');
                        diceString[0] = diceString[0].Remove(0, 1);

                        if(int.TryParse(diceString[0], out sides)) {
                            die = true;
                        }


                        if(diceString.Length == 2)
                            rollCount = int.Parse(diceString[1]);

                        if(rollCount <= 1)
                            rollCount = 1;
                        else
                            multiRoll = true;
                    }
                    else if(preOp == '+' || preOp == '-') {
                        modded = true;
                        string var = command;

                        if(postOp == '*') {
                            multiMod = true;
                            var = var.Remove(var.Length - 1);
                        }

                        modVar.Add(var);
                    }
                }
            }
        }

        public void calcMod() {
            mod = 0;

            foreach(string command in modVar) {
                char op = command[0];
                string var = command.Remove(0, 1).ToLower();
                int neg = 1;
                int constantMod;

                if(op == '-')
                    neg = -1;

                if(int.TryParse(var, out constantMod))
                    mod += (neg * constantMod);
            }
        }

        public void calcMod(Character c) {
            mod = 0;

            foreach(string command in modVar) {
                char op = command[0];
                string var = command.Remove(0, 1).ToLower();
                int neg = 1;

                if(op == '-')
                    neg = -1;

                switch(var) {
                    case "str": {
                            mod += (neg * c.getStr().getMod());
                            break;
                        }
                    case "dex": {
                            mod += (neg * c.getDex().getMod());
                            break;
                        }
                    case "con": {
                            mod += (neg * c.getCon().getMod());
                            break;
                        }
                    case "int": {
                            mod += (neg * c.getInt().getMod());
                            break;
                        }
                    case "wis": {
                            mod += (neg * c.getWis().getMod());
                            break;
                        }
                    case "cha": {
                            mod += (neg * c.getCha().getMod());
                            break;
                        }
                    case "strt": {
                            mod += (neg * c.getStr().getTotal());
                            break;
                        }
                    case "dext": {
                            mod += (neg * c.getDex().getTotal());
                            break;
                        }
                    case "cont": {
                            mod = (neg * c.getCon().getTotal());
                            break;
                        }
                    case "intt": {
                            mod += (neg * c.getInt().getTotal());
                            break;
                        }
                    case "wist": {
                            mod += (neg * c.getWis().getTotal());
                            break;
                        }
                    case "chat": {
                            mod += (neg * c.getCha().getTotal());
                            break;
                        }
                    case "will": {
                            mod += (neg * c.getWill());
                            break;
                        }
                    case "ref": {
                            mod += (neg * c.getReflex());
                            break;
                        }
                    case "fort": {
                            mod += (neg * c.getFortitude());
                            break;
                        }
                    case "bab": {
                            mod += (neg * c.getBab());
                            break;
                        }
                    case "mel": {
                            mod += (neg * c.getMelee());
                            break;
                        }
                    case "ran": {
                            mod += (neg * c.getRanged());
                            break;
                        }
                    case "ac": {
                            mod += (neg * c.getAC());
                            break;
                        }
                    case "ff": {
                            mod += (neg * c.getFF());
                            break;
                        }
                    case "touch": {
                            mod += (neg * c.getTouch());
                            break;
                        }
                    case "init": {
                            mod += (neg * c.getInit());
                            break;
                        }
                    case "spd": {
                            mod += (neg * c.getSpeed());
                            break;
                        }
                    case "hp": {
                            mod += (neg * c.getHP());
                            break;
                        }
                    case "hpt": {
                            mod += (neg * c.getMaxHP());
                            break;
                        }
                    default: {
                            int constantMod;
                            if(int.TryParse(var, out constantMod))
                                mod += (neg * constantMod);

                            break;
                        }

                }
            }
        }

        #region Get & Set methods

        public string[] getSLine() {
            return sLine;
        }

        public string getVar() {
            return var;
        }

        public List<string> getModVar() {
            return modVar;
        }

        public bool getDie() {
            return die;
        }

        public bool getSum() {
            return sum;
        }

        public bool getModded() {
            return modded;
        }

        public bool getParty() {
            return party;
        }

        public bool getVarEdit() {
            return varEdit;
        }

        public bool getMultiRoll() {
            return multiRoll;
        }

        public bool getMultiMod() {
            return multiMod;
        }

        public int getMod() {
            return mod;
        }

        public int getSides() {
            return sides;
        }

        public int getRollCount() {
            return rollCount;
        }

        public void setSLine(string[] c) {
            sLine = c;
        }

        public void setSLine(string c) {
            sLine = c.Split(' ');
        }

        public void setVar(string v) {
            var = v;
        }

        public void setModVar(List<string> m) {
            modVar = m;
        }

        public void setDie(bool d) {
            die = d;
        }

        public void setSum(bool s) {
            sum = s;
        }

        public void setModded(bool m) {
            modded = m;
        }

        public void setParty(bool p) {
            party = p;
        }

        public void setVarEdit(bool v) {
            varEdit = v;
        }

        public void setMultiRoll(bool m) {
            multiRoll = m;
        }

        public void setMultiMod(bool m) {
            multiMod = m;
        }

        public void setMod(int m) {
            mod = m;
        }

        public void setSides(int s) {
            sides = s;
        }

        public void setRollCount(int r) {
            rollCount = r;
        }

#endregion
    }
}
