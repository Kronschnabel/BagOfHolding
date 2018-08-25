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
                        case "maxHP": {
                                if(!int.TryParse(sLine[1], out maxHP))
                                    maxHP = 0;
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
                        case "hp": {
                                if(!int.TryParse(sLine[1], out hp))
                                    hp = 0;
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
                        preEdit = strength.getTotal();
                        if(op == '=')
                            strength.setTotal(0);

                        strength.addToTotal(total);
                        postEdit = strength.getTotal();
                        break;
                    }
                case "dext": {
                        preEdit = dexterity.getTotal();
                        if(op == '=')
                            dexterity.setTotal(0);

                        dexterity.addToTotal(total);
                        postEdit = dexterity.getTotal();
                        break;
                    }
                case "cont": {
                        preEdit = constitution.getTotal();
                        if(op == '=')
                            constitution.setTotal(0);

                        constitution.addToTotal(total);
                        postEdit = constitution.getTotal();
                        break;
                    }
                case "intt": {
                        preEdit = intelligence.getTotal();
                        if(op == '=')
                            intelligence.setTotal(0);

                        intelligence.addToTotal(total);
                        postEdit = intelligence.getTotal();
                        break;
                    }
                case "wist": {
                        preEdit = wisdom.getTotal();
                        if(op == '=')
                            wisdom.setTotal(0);

                        wisdom.addToTotal(total);
                        postEdit = wisdom.getTotal();
                        break;
                    }
                case "chat": {
                        preEdit = charisma.getTotal();
                        if(op == '=')
                            charisma.setTotal(0);

                        charisma.addToTotal(total);
                        postEdit = charisma.getTotal();
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
                switch(s.getAbilityType()) {
                    case 0:
                        s.setAbilityMod(strength.getMod());
                        break;
                    case 1:
                        s.setAbilityMod(dexterity.getMod());
                        break;
                    case 2:
                        s.setAbilityMod(constitution.getMod());
                        break;
                    case 3:
                        s.setAbilityMod(intelligence.getMod());
                        break;
                    case 4:
                        s.setAbilityMod(wisdom.getMod());
                        break;
                    case 5:
                        s.setAbilityMod(charisma.getMod());
                        break;
                    default:
                        s.setAbilityMod(0);
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

        public string getPath() {
            return path;
        }

        public string getCharID() {
            return charID;
        }

        public string getName() {
            return name;
        }

        public string getSubtitle() {
            return subtitle;
        }

        public List<string> getNotes() {
            return notes;
        }

        public string getRace() {
            return race;
        }

        public string getSize() {
            return size;
        }

        public string getGender() {
            return gender;
        }

        public string getAlignment() {
            return alignment;
        }

        public Color getColor() {
            return charColor;
        }

        public Image getImage() {
            return charImage;
        }

        public Color getIBC() {
            return imageBackColor;
        }

        public AbilityScore getStr() {
            return strength;
        }

        public AbilityScore getDex() {
            return dexterity;
        }

        public AbilityScore getCon() {
            return constitution;
        }

        public AbilityScore getInt() {
            return intelligence;
        }

        public AbilityScore getWis() {
            return wisdom;
        }

        public AbilityScore getCha() {
            return charisma;
        }

        public List<Klass> getClasses() {
            return classes;
        }

        public int getLevel() {
            return level;
        }

        public int getExp() {
            return exp;
        }

        public int getExpToAdvance() {
            return expToAdvance;
        }

        public int getHP() {
            return hp;
        }

        public int getMaxHP() {
            return maxHP;
        }

        public int getFortitude() {
            return fortitude;
        }

        public int getReflex() {
            return reflex;
        }

        public int getWill() {
            return will;
        }

        public int getBab() {
            return bab;
        }

        public int getMelee() {
            return melee;
        }

        public int getRanged() {
            return ranged;
        }

        public int getAC() {
            return ac;
        }

        public int getFF() {
            return flatFooted;
        }

        public int getTouch() {
            return touch;
        }

        public int getInit() {
            return initiative;
        }

        public int getSpeed() {
            return speed;
        }

        public List<Skill> getSkills() {
            return skills;
        }

        public List<Item> getInv() {
            return inv;
        }

        public List<Weapon> getWeapons() {
            return weapons;
        }

        public List<Armor> getArmor() {
            return armor;
        }

        public List<Spell> getSpellbook() {
            return spellbook;
        }

        public int[] getSpellsLeft() {
            return spellsLeft;
        }

        public void setPath(string p) {
            path = p;
        }

        public void setCharID(string c) {
            charID = c;
        }

        public void setName(string n) {
            name = n;
        }

        public void setSubtitle(string s) {
            subtitle = s;
        }

        public void setNotes(List<string> n) {
            notes = n;
        }

        public void setRace(string r) {
            race = r;
        }

        public void setSize(string s) {
            size = s;
        }

        public void setGender(string g) {
            gender = g;
        }

        public void setAlignment(string a) {
            alignment = a;
        }

        public void setColor(Color c) {
            charColor = c;
        }

        public void setImage(Image i) {
            charImage = i;
        }
        
        public void setIBC(Color c) {
            imageBackColor = c;
        }

        public void setStr(AbilityScore str) {
            strength = str;
        }

        public void setDex(AbilityScore dex) {
            dexterity = dex;
        }

        public void setCon(AbilityScore con) {
            constitution = con;
        }

        public void setInt(AbilityScore intel) {
            intelligence = intel;
        }

        public void setWis(AbilityScore wis) {
            wisdom = wis;
        }

        public void setCha(AbilityScore cha) {
            charisma = cha;
        }

        public void setClasses(List<Klass> c) {
            classes = c;
        }

        public void setLevel(int l) {
            level = l;
        }

        public void setExp(int e) {
            exp = e;
        }

        public void setExpToAdvance(int e) {
            expToAdvance = e;
        }

        public void setHP(int h) {
            hp = h;
        }

        public void setMaxHP(int h) {
            maxHP = h;
        }

        public void setFortitude(int f) {
            fortitude = f;
        }

        public void setReflex(int r) {
            reflex = r;
        }

        public void setWill(int w) {
            will = w;
        }

        public void setBab(int b) {
            bab = b;
        }

        public void setMelee(int m) {
            melee = m;
        }

        public void setRanged(int r) {
            ranged = r;
        }

        public void setAC(int a) {
            ac = a;
        }

        public void setFF(int f) {
            flatFooted = f;
        }

        public void setTouch(int t) {
            touch = t;
        }

        public void setInit(int i) {
            initiative = i;
        }

        public void setSpeed(int s) {
            speed = s;
        }

        public void setSkills(List<Skill> s) {
            skills = s;
        }

        public void setInv(List<Item> i) {
            inv = i;
        }

        public void setWeapons(List<Weapon> w) {
            weapons = w;
        }

        public void setArmor(List<Armor> a) {
            armor = a;
        }

        public void setSpellbook(List<Spell> s) {
            spellbook = s;
        }

        public void setSpellsLeft(int[] s) {
            spellsLeft = s;
        }

        #endregion
    }
}
