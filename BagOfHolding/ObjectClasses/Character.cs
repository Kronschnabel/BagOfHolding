using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace BagOfHolding
{
    public class Character {
        string path;
        string charID;
        string name;
        string subtitle;
        List<string> notes;
        string race;
        string size;
        string gender;
        string alignment;

        Color charColor;
        Image charImage;
        Color imageBackColor;

        AbilityScore strength;
        AbilityScore dexterity;
        AbilityScore constitution;
        AbilityScore intelligence;
        AbilityScore wisdom;
        AbilityScore charisma;

        List<Klass> classes;

        int level;
        int exp;
        int expToAdvance;
        int hp;
        int maxHP;
        bool hpHidden;

        int fortitude;
        int reflex;
        int will;

        int bab;
        int melee;
        int ranged;

        int ac;
        int flatFooted;
        int touch;
        int initiative;
        int speed;

        List<Skill> skills;

        List<Item> inv;
        List<Weapon> weapons;
        List<Armor> armor;

        List<Spell> spellbook;
        int[] spellsLeft;

        public Character() {
            createLists();
            setBlankChar();
        }

        #region Save\Load Character Data

        public void saveChar() {
            List<string> file = new List<string>();
            trySaveImage(name + ".jpg");

            file.Add("image>" + name + ".jpg");
            file.Add("imageBC>" + imageBackColor.ToArgb());
            file.Add("name>" + name);
            file.Add("subtitle>" + subtitle);
            foreach(string n in notes)
                file.Add("notes>" + n);
            file.Add("race>" + race);
            file.Add("size>" + size);
            file.Add("gender>" + gender);
            file.Add("alignment>" + alignment);
            file.Add("color>" + charColor.ToArgb());
            file.Add("strength>" + strength.toString());
            file.Add("dexterity>" + dexterity.toString());
            file.Add("constitution>" + constitution.toString());
            file.Add("intelligence>" + intelligence.toString());
            file.Add("wisdom>" + wisdom.toString());
            file.Add("charisma>" + charisma.toString());
            foreach(Klass c in classes)
                file.Add("class>" + c.toString());
            file.Add("level>" + level);
            file.Add("exp>" + exp);
            file.Add("expToAdvance>" + expToAdvance);
            file.Add("hp>" + hp);
            file.Add("maxHP>" + maxHP);
            file.Add("hpHidden>" + hpHidden);
            file.Add("fortitude>" + fortitude);
            file.Add("reflex>" + reflex);
            file.Add("will>" + will);
            file.Add("bab>" + bab);
            file.Add("melee>" + melee);
            file.Add("ranged>" + ranged);
            file.Add("ac>" + ac);
            file.Add("ff>" + flatFooted);
            file.Add("touch>" + touch);
            file.Add("initiative>" + initiative);
            file.Add("speed>" + speed);
            foreach(Skill s in skills)
                file.Add("skill>" + s.toString());
            foreach(Item i in inv)
                file.Add("item>" + i.toString());
            foreach(Weapon w in weapons)
                file.Add("weapon>" + w.toString());
            foreach(Armor a in armor)
                file.Add("armor>" + a.toString());
            foreach(Spell s in spellbook)
                file.Add("spell>" + s.toString());
            file.Add("spellsLeft>" + spellsLeftString());

            if(path.Equals(""))
                path = name + ".char";
            File.WriteAllLines(path, file);
        }

        public void saveChar(string path) {
            this.path = path;
            saveChar();
        }

        public void saveInv(string path) {
            List<string> file = new List<string>();

            foreach(Item i in inv)
                file.Add("item>" + i.toString());
            foreach(Weapon w in weapons)
                file.Add("weapon>" + w.toString());
            foreach(Armor a in armor)
                file.Add("armor>" + a.toString());

            File.WriteAllLines(path, file);
        }

        public void saveSpellbook(string path) {
            List<string> file = new List<string>();

            foreach(Spell s in spellbook)
                file.Add("spell>" + s.toString());

            File.WriteAllLines(path, file);
        }

        private void trySaveImage(string path) {
            try {
                charImage.Save(path);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Image save failed!");
            }
        }

        private void tryLoadImage(string path) {
            try {
                charImage = Image.FromFile(path);
            }
            catch(Exception ex) {
                charImage = getRandomDCI();
            }

        }

        public void loadChar(string path) {
            setBlankChar();
            classes.Clear();
            this.path = path;
            int bC;

            foreach(string line in File.ReadAllLines(path)) {
                string[] sLine = line.Split('>');

                if(sLine.Length == 2) {
                    switch(sLine[0]) {

                        case "image":
                            tryLoadImage(sLine[1]);
                            break;
                        case "imageBC":
                            if(int.TryParse(sLine[1], out bC))
                                imageBackColor = Color.FromArgb(bC);
                            else
                                setRandBackColor();
                            break;
                        case "name":
                            name = sLine[1];
                            break;
                        case "subtitle":
                            subtitle = sLine[1];
                            break;
                        case "notes":
                            notes.Add(sLine[1]);
                            break;
                        case "race":
                            race = sLine[1];
                            break;
                        case "size":
                            size = sLine[1];
                            break;
                        case "gender":
                            gender = sLine[1];
                            break;
                        case "alignment":
                            alignment = sLine[1];
                            break;
                        case "color": {
                                if(int.TryParse(sLine[1], out bC))
                                    charColor = Color.FromArgb(bC);
                                else
                                    charColor = Color.ForestGreen;
                                break;
                            }
                        case "strength": {
                                strength.fromString(sLine[1]);
                                break;
                            }
                        case "dexterity": {
                                dexterity.fromString(sLine[1]);
                                break;
                            }
                        case "constitution": {
                                constitution.fromString(sLine[1]);
                                break;
                            }
                        case "intelligence": {
                                intelligence.fromString(sLine[1]);
                                break;
                            }
                        case "wisdom": {
                                wisdom.fromString(sLine[1]);
                                break;
                            }
                        case "charisma": {
                                charisma.fromString(sLine[1]);
                                break;
                            }
                        case "class": {
                                Klass k = new Klass();
                                k.fromString(sLine[1]);
                                classes.Add(k);
                                break;
                            }
                        case "skill": {
                                Skill s = new Skill();
                                s.fromString(sLine[1]);
                                skills.Add(s);
                                break;
                            }
                        case "level": {
                                if(!int.TryParse(sLine[1], out level))
                                    level = 0;
                                break;
                            }
                        case "exp": {
                                if(!int.TryParse(sLine[1], out exp))
                                    exp = 0;
                                break;
                            }
                        case "expToAdvance": {
                                if(!int.TryParse(sLine[1], out expToAdvance))
                                    expToAdvance = 0;
                                break;
                            }
                        case "hp": {
                                if(!int.TryParse(sLine[1], out hp))
                                    hp = 0;
                                break;
                            }
                        case "maxHP": {
                                if(!int.TryParse(sLine[1], out maxHP))
                                    maxHP = 0;
                                break;
                            }
                        case "hpHidden": {
                                if(!bool.TryParse(sLine[1], out hpHidden))
                                    hpHidden = false;
                                break;
                            }
                        case "fortitude": {
                                if(!int.TryParse(sLine[1], out fortitude))
                                    fortitude = 0;
                                break;
                            }
                        case "reflex": {
                                if(!int.TryParse(sLine[1], out reflex))
                                    reflex = 0;
                                break;
                            }
                        case "will": {
                                if(!int.TryParse(sLine[1], out will))
                                    will = 0;
                                break;
                            }
                        case "bab": {
                                if(!int.TryParse(sLine[1], out bab))
                                    bab = 0;
                                break;
                            }
                        case "melee": {
                                if(!int.TryParse(sLine[1], out melee))
                                    melee = 0;
                                break;
                            }
                        case "ranged": {
                                if(!int.TryParse(sLine[1], out ranged))
                                    ranged = 0;
                                break;
                            }
                        case "ac": {
                                if(!int.TryParse(sLine[1], out ac))
                                    ac = 0;
                                break;
                            }
                        case "ff": {
                                if(!int.TryParse(sLine[1], out flatFooted))
                                    flatFooted = 0;
                                break;
                            }
                        case "touch": {
                                if(!int.TryParse(sLine[1], out touch))
                                    touch = 0;
                                break;
                            }
                        case "initiative": {
                                if(!int.TryParse(sLine[1], out initiative))
                                    initiative = 0;
                                break;
                            }
                        case "speed": {
                                if(!int.TryParse(sLine[1], out speed))
                                    speed = 0;
                                break;
                            }
                        case "item": {
                                Item i = new Item();
                                i.fromString(sLine[1]);
                                inv.Add(i);
                                break;
                            }
                        case "weapon": {
                                Weapon w = new Weapon();
                                w.fromString(sLine[1]);
                                weapons.Add(w);
                                break;
                            }
                        case "armor": {
                                Armor a = new Armor();
                                a.fromString(sLine[1]);
                                armor.Add(a);
                                break;
                            }
                        case "spell": {
                                Spell s = new Spell();
                                s.fromString(sLine[1]);
                                spellbook.Add(s);
                                break;
                            }
                        case "spellsLeft":
                            setSpellsLeft(sLine[1]);
                            break;
                    }
                }
            }

            setSkillMods();
        }

        public void loadInv(string path, bool overwrite) {
            if(overwrite) {
                inv.Clear();
                weapons.Clear();
                armor.Clear();
            }

            foreach(string line in File.ReadAllLines(path)) {
                string[] sLine = line.Split('>');

                if(sLine.Length == 2) {
                    switch(sLine[0]) {
                        case "item": {
                                Item i = new Item();
                                i.fromString(sLine[1]);
                                inv.Add(i);
                                break;
                            }
                        case "weapon": {
                                Weapon w = new Weapon();
                                w.fromString(sLine[1]);
                                weapons.Add(w);
                                break;
                            }
                        case "armor": {
                                Armor a = new Armor();
                                a.fromString(sLine[1]);
                                armor.Add(a);
                                break;
                            }
                    }
                }
            }
        }

        public void loadSpellbook(string path, bool overwrite) {
            if(overwrite)
                spellbook.Clear();

            foreach(string line in File.ReadAllLines(path)) {
                string[] sLine = line.Split('>');

                if(sLine.Length == 2) {
                    switch(sLine[0]) {
                        case "spell": {
                                Spell s = new Spell();
                                s.fromString(sLine[1]);
                                spellbook.Add(s);
                                break;
                            }
                    }
                }
            }
        }

        #endregion

        #region Character Utility methods

        private void setBlankChar() {
            path = "";
            charID = "";
            name = "New Character";
            subtitle = "";
            race = "race";
            size = "size";
            gender = "gender";
            alignment = "";

            charColor = Color.ForestGreen;
            charImage = getRandomDCI();
            setRandBackColor();

            strength = new AbilityScore();
            dexterity = new AbilityScore();
            constitution = new AbilityScore();
            intelligence = new AbilityScore();
            wisdom = new AbilityScore();
            charisma = new AbilityScore();

            classes.Clear();
            classes.Add(new Klass());
            classes.Add(new Klass());
            classes.Add(new Klass());
            classes.Add(new Klass());
            classes.Add(new Klass());

            skills.Clear();

            level = 0;
            exp = 0;
            expToAdvance = 0;
            hp = 0;
            //24,75,87
            maxHP = 0;
            hpHidden = false;

            fortitude = 0;
            reflex = 0;
            will = 0;

            bab = 0;
            melee = 0;
            ranged = 0;

            ac = 0;
            flatFooted = 0;
            touch = 0;
            initiative = 0;
            speed = 0;

            notes.Clear();
            inv.Clear();
            weapons.Clear();
            armor.Clear();
            spellbook.Clear();
        }

        public void statEditFromCommand(string var, char op, int total, ref int preEdit, ref int postEdit) {
            if(op == '-')
                total *= -1;

            switch(var) {
                case "exp": {
                        preEdit = exp;
                        if(op == '=')
                            exp = 0;

                        exp += total;
                        postEdit = exp;
                        break;
                    }
                case "expt": {
                        preEdit = expToAdvance;
                        if(op == '=')
                            expToAdvance = 0;

                        expToAdvance += total;
                        postEdit = expToAdvance;
                        break;
                    }
                case "level": {
                        preEdit = level;
                        if(op == '=')
                            level = 0;

                        level += total;
                        postEdit = level;
                        break;
                    }
                case "strt": {
                        preEdit = strength.Total;
                        if(op == '=')
                            strength.Total = 0;

                        strength.addToTotal(total);
                        postEdit = strength.Total;
                        break;
                    }
                case "dext": {
                        preEdit = dexterity.Total;
                        if(op == '=')
                            dexterity.Total = 0;

                        dexterity.addToTotal(total);
                        postEdit = dexterity.Total;
                        break;
                    }
                case "cont": {
                        preEdit = constitution.Total;
                        if(op == '=')
                            constitution.Total = 0;

                        constitution.addToTotal(total);
                        postEdit = constitution.Total;
                        break;
                    }
                case "intt": {
                        preEdit = intelligence.Total;
                        if(op == '=')
                            intelligence.Total = 0;

                        intelligence.addToTotal(total);
                        postEdit = intelligence.Total;
                        break;
                    }
                case "wist": {
                        preEdit = wisdom.Total;
                        if(op == '=')
                            wisdom.Total = 0;

                        wisdom.addToTotal(total);
                        postEdit = wisdom.Total;
                        break;
                    }
                case "chat": {
                        preEdit = charisma.Total;
                        if(op == '=')
                            charisma.Total = 0;

                        charisma.addToTotal(total);
                        postEdit = charisma.Total;
                        break;
                    }
                case "will": {
                        preEdit = will;
                        if(op == '=')
                            will = 0;

                        will += total;
                        postEdit = will;
                        break;
                    }
                case "ref": {
                        preEdit = reflex;
                        if(op == '=')
                            reflex = 0;

                        reflex += total;
                        postEdit = reflex;
                        break;
                    }
                case "fort": {
                        preEdit = fortitude;
                        if(op == '=')
                            fortitude = 0;

                        will += fortitude;
                        postEdit = fortitude;
                        break;
                    }
                case "bab": {
                        preEdit = bab;
                        if(op == '=')
                            bab = 0;

                        bab += total;
                        postEdit = bab;
                        break;
                    }
                case "mel": {
                        preEdit = melee;
                        if(op == '=')
                            melee = 0;

                        melee += total;
                        postEdit = melee;
                        break;
                    }
                case "ran": {
                        preEdit = ranged;
                        if(op == '=')
                            ranged = 0;

                        ranged += total;
                        postEdit = ranged;
                        break;
                    }
                case "ac": {
                        preEdit = ac;
                        if(op == '=')
                            ac = 0;

                        ac += total;
                        postEdit = ac;
                        break;
                    }
                case "ff": {
                        preEdit = flatFooted;
                        if(op == '=')
                            flatFooted = 0;

                        flatFooted += total;
                        postEdit = flatFooted;
                        break;
                    }
                case "touch": {
                        preEdit = touch;
                        if(op == '=')
                            touch = 0;

                        touch += total;
                        postEdit = touch;
                        break;
                    }
                case "init": {
                        preEdit = initiative;
                        if(op == '=')
                            initiative = 0;

                        initiative += total;
                        postEdit = initiative;
                        break;
                    }
                case "spd": {
                        preEdit = speed;
                        if(op == '=')
                            speed = 0;

                        speed += total;
                        postEdit = speed;
                        break;
                    }
                case "hp": {
                        preEdit = hp;
                        if(op == '=')
                            hp = 0;

                        hp += total;
                        postEdit = hp;
                        break;
                    }
                case "hpt": {
                        preEdit = maxHP;
                        if(op == '=')
                            maxHP = 0;

                        maxHP += total;
                        postEdit = maxHP;
                        break;
                    }
                default: {

                        break;
                    }
            }
        }

        private void createLists() {
            notes = new List<string>();
            classes = new List<Klass>();
            skills = new List<Skill>();
            inv = new List<Item>();
            weapons = new List<Weapon>();
            armor = new List<Armor>();
            spellbook = new List<Spell>();
            spellsLeft = new int[10];
        }

        private Bitmap getRandomDCI() {
            Die DCI = new Die();

            switch(DCI.roll(7)) {
                case 1:
                    return Properties.Resources.DCI_guy;
                case 2:
                    return Properties.Resources.DCI_derpguy;
                case 3:
                    return Properties.Resources.DCI_beardguy;
                case 4:
                    return Properties.Resources.DCI_younglady;
                case 5:
                    return Properties.Resources.DCI_hoodguy;
                case 6:
                    return Properties.Resources.DCI_orcguy;
                case 7:
                    return Properties.Resources.DCI_madguy;
                default:
                    return Properties.Resources.DCI_guy;
            }
        }

        private void setRandBackColor() {
            Die randColor = new Die();

            switch(randColor.roll(10)) {
                case 1:
                    imageBackColor = Color.FromArgb(165, 55, 55);
                    break;
                case 2:
                    imageBackColor = Color.FromArgb(55, 165, 55);
                    break;
                case 3:
                    imageBackColor = Color.FromArgb(55, 55, 165);
                    break;
                case 4:
                    imageBackColor = Color.FromArgb(165, 165, 55);
                    break;
                case 5:
                    imageBackColor = Color.FromArgb(165, 55, 165);
                    break;
                case 6:
                    imageBackColor = Color.FromArgb(55, 165, 165);
                    break;
                case 7:
                    imageBackColor = Color.FromArgb(165, 55, 130);
                    break;
                case 8:
                    imageBackColor = Color.FromArgb(165, 130, 55);
                    break;
                case 9:
                    imageBackColor = Color.FromArgb(130, 165, 55);
                    break;
                case 10:
                    imageBackColor = Color.FromArgb(55, 165, 130);
                    break;
            }
        }

        public void setSkillMods() {
            foreach(Skill s in skills) {
                switch(s.AbilityType) {
                    case 0:
                        s.AbilityMod = strength.Mod;
                        break;
                    case 1:
                        s.AbilityMod = dexterity.Mod;
                        break;
                    case 2:
                        s.AbilityMod = constitution.Mod;
                        break;
                    case 3:
                        s.AbilityMod = intelligence.Mod;
                        break;
                    case 4:
                        s.AbilityMod = wisdom.Mod;
                        break;
                    case 5:
                        s.AbilityMod = charisma.Mod;
                        break;
                    default:
                        s.AbilityMod = 0;
                        break;
                }
            }
        }

        #endregion

        #region Spells-Left methods

        private void setSpellsLeft(string l) {
            string[] sLine = l.Split('|');

            if(!int.TryParse(sLine[0], out spellsLeft[0]))
                spellsLeft[0] = 0;
            if(!int.TryParse(sLine[1], out spellsLeft[1]))
                spellsLeft[1] = 0;
            if(!int.TryParse(sLine[2], out spellsLeft[2]))
                spellsLeft[2] = 2;
            if(!int.TryParse(sLine[3], out spellsLeft[3]))
                spellsLeft[3] = 0;
            if(!int.TryParse(sLine[4], out spellsLeft[4]))
                spellsLeft[4] = 0;
            if(!int.TryParse(sLine[5], out spellsLeft[5]))
                spellsLeft[5] = 0;
            if(!int.TryParse(sLine[6], out spellsLeft[6]))
                spellsLeft[6] = 0;
            if(!int.TryParse(sLine[7], out spellsLeft[7]))
                spellsLeft[7] = 0;
            if(!int.TryParse(sLine[8], out spellsLeft[8]))
                spellsLeft[8] = 0;
            if(!int.TryParse(sLine[9], out spellsLeft[9]))
                spellsLeft[9] = 0;

        }

        private string spellsLeftString() {
            return spellsLeft[0] + "|" + spellsLeft[1] + "|" + spellsLeft[2] + "|" + spellsLeft[3] + "|" + spellsLeft[4] + "|" + spellsLeft[5] + "|" + spellsLeft[6] + "|" + spellsLeft[7] + "|" + spellsLeft[8] + "|" + spellsLeft[9];
        }

        #endregion

        #region Get & Set methods

        public string Path {
                get {
                    return path;
                }
                set {
                    path = value;
                }
            }

        public string CharID {
            get {
                return charID;
            }
            set {
                charID = value;
            }
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public string Subtitle {
            get {
                return subtitle;
            }
            set {
                subtitle = value;
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

        public string Race {
            get {
                return race;
            }
            set {
                race = value;
            }
        }

        public string Size {
            get {
                return size;
            }
            set {
                size = value;
            }
        }

        public string Gender {
            get {
                return gender;
            }
            set {
                gender = value;
            }
        }

        public string Alignment {
            get {
                return alignment;
            }
            set {
                alignment = value;
            }
        }

        public Color CharColor {
            get {
                return charColor;
            }
            set {
                charColor = value;
            }
        }

        public Image CharImage {
            get {
                return charImage;
            }
            set {
                charImage = value;
            }
        }

        public Color IBC {
            get {
                return imageBackColor;
            }
            set {
                imageBackColor = value;
            }
        }

        public AbilityScore Strength {
            get {
                return strength;
            }
            set {
                strength = value;
            }
        }

        public AbilityScore Dexterity {
            get {
                return dexterity;
            }
            set {
                dexterity = value;
            }
        }

        public AbilityScore Constitution {
            get {
                return constitution;
            }
            set {
                constitution = value;
            }
        }

        public AbilityScore Intelligence {
            get {
                return intelligence;
            }
            set {
                intelligence = value;
            }
        }

        public AbilityScore Wisdom {
            get {
                return wisdom;
            }
            set {
                wisdom = value;
            }
        }

        public AbilityScore Charisma {
            get {
                return charisma;
            }
            set {
                charisma = value;
            }
        }

        public List<Klass> Classes {
            get {
                return classes;
            }
            set {
                classes = value;
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

        public int Exp {
            get {
                return exp;
            }
            set {
                exp = value;
            }
        }

        public int ExpToAdvance {
            get {
                return expToAdvance;
            }
            set {
                expToAdvance = value;
            }
        }

        public int HP {
            get {
                return hp;
            }
            set {
                hp = value;
            }
        }

        public int MaxHP {
            get {
                return maxHP;
            }
            set {
                maxHP = value;
            }
        }

        public bool HPHidden {
            get {
                return hpHidden;
            }
            set {
                hpHidden = value;
            }
        }

        public int Fortitude {
            get {
                return fortitude;
            }
            set {
                fortitude = value;
            }
        }

        public int Reflex {
            get {
                return reflex;
            }
            set {
                reflex = value;
            }
        }

        public int Will {
            get {
                return will;
            }
            set {
                will = value;
            }
        }

        public int BAB {
            get {
                return bab;
            }
            set {
                bab = value;
            }
        }

        public int Melee {
            get {
                return melee;
            }
            set {
                melee = value;
            }
        }

        public int Ranged {
            get {
                return ranged;
            }
            set {
                ranged = value;
            }
        }

        public int AC {
            get {
                return ac;
            }
            set {
                ac = value;
            }
        }

        public int FF {
            get {
                return flatFooted;
            }
            set {
                flatFooted = value;
            }
        }

        public int Touch {
            get {
                return touch;
            }
            set {
                touch = value;
            }
        }

        public int Init {
            get {
                return initiative;
            }
            set {
                initiative = value;
            }
        }

        public int Speed {
            get {
                return speed;
            }
            set {
                speed = value;
            }
        }

        public List<Skill> Skills {
            get {
                return skills;
            }
            set {
                skills = value;
            }
        }

        public List<Item> Inv {
            get {
                return inv;
            }
            set {
                inv = value;
            }
        }

        public List<Weapon> Weapons {
            get {
                return weapons;
            }
            set {
                weapons = value;
            }
        }

        public List<Armor> Armor {
            get {
                return armor;
            }
            set {
                armor = value;
            }
        }

        public List<Spell> Spellbook {
            get {
                return spellbook;
            }
            set {
                spellbook = value;
            }
        }

        public int[] SpellsLeft {
            get {
                return spellsLeft;
            }
            set {
                spellsLeft = value;
            }
        }

        #endregion
    }
}
