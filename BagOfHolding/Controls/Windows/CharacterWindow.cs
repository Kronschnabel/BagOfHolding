//CharacterWindow.cs
//
//A CharaterWindow is just a Forms control. It gets added to a Window object's main_panel. 
//This class is responsible for getting and setting the data associated with a single character, 
//and opening the Inventory and Spellbook windows. The class's methods are broken up into the following regions.
//
//Open Window(s) methods: Handles the initialization of the Character Window and the creation of its subwindows.
//          open()
//          startup()
//          createWindows()
//          openInvWindow()
//          openSpellbookWindow()
//
//UI update\skills methods: Pulls data from the character object and updates the control's data. The skill UI gets updated seperately.
//          updateUIData()
//          updateSkillUI()
//          updateCharSkills()
//
//Event Handlers: The first chunk of methods here respond to the button presses and double clicks, then there's a subregion.
//
//          TextChanged Event Handlers: These handlers update the character objects data to match the changes to the UI. There are a bunch.
//                      
//Get & Set methods: 
//          getChar()
//          setChar()
//
//////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BagOfHolding
{
    public partial class CharacterWindow : UserControl
    {
        bool initialized;
        Character character;

        Window inv_win;
        InventoryWindow inv_control;
        Window spellbook_win;
        SpellbookWindow spellbook_control;

        Color hpForeColor = Color.LimeGreen;
        Color hpBackColor = Color.Brown;
        Color expForeColor = Color.DarkOrchid;
        Color expBackColor = Color.Gray;
     
        public CharacterWindow() {
            character = new Character();
        }

        #region Startup methods

        private void startup() {
            initialized = true;
            InitializeComponent();
            Properties.Settings.Default.PropertyChanged += new PropertyChangedEventHandler(settingsChanged);
            Dock = DockStyle.Fill;
            createWindows();
            health_bar.setColors(hpForeColor, hpBackColor);
            exp_bar.setColors(expForeColor, expBackColor);
            exp_bar.setBaseWidth(100);
            exp_bar.updateBar();
        }

        private void createWindows() {
            inv_win = new Window("inv");
            inv_control = new InventoryWindow();
            inv_win.addControl(inv_control);
            Parent.Parent.Parent.Parent.Controls.Add(inv_win);

            spellbook_win = new Window("spellbook");
            spellbook_control = new SpellbookWindow();
            spellbook_win.addControl(spellbook_control);
            Parent.Parent.Parent.Parent.Controls.Add(spellbook_win);
        }

        #endregion

        #region Open methods

        public void open() {
            if(!initialized)
                startup();

            setColors();
            updateUIData();
            updateSkillUI();
            Show();
            Visible = true;
            BringToFront();
            IsAccessible = true;
        }

        private void openInvWindow() {
            inv_control.setChar(ref character);
            inv_win.open();
            inv_control.open();
        }

        private void openSpellbookWindow() {
            spellbook_control.setChar(ref character);
            spellbook_win.open();
            spellbook_control.open();
        }

        #endregion

        #region UI update\skills methods

        private void updateUIData() {
            max_hp_box.Text = character.MaxHP.ToString();
            hp_box.Text = character.HP.ToString();
            exp_box.Text = character.Exp.ToString();
            max_exp_box.Text = character.ExpToAdvance.ToString();
            char_notes_box.Lines = character.Notes.ToArray();
            speed_box.Text = character.Speed.ToString();
            fort_save_box.Text = character.Fortitude.ToString();
            will_save_box.Text = character.Will.ToString();
            ref_save_box.Text = character.Reflex.ToString();
            str_box.Text = character.Strength.Total.ToString();
            dex_box.Text = character.Dexterity.Total.ToString();
            con_box.Text = character.Constitution.Total.ToString();
            int_box.Text = character.Intelligence.Total.ToString();
            wis_box.Text = character.Wisdom.Total.ToString();
            cha_box.Text = character.Charisma.Total.ToString();
            if(character.Strength.Mod >= 0)
                str_mod_label.Text = "+" + character.Strength.Mod.ToString();
            else
                str_mod_label.Text = character.Strength.Mod.ToString();
            if(character.Dexterity.Mod >= 0)
                dex_mod_label.Text = "+" + character.Dexterity.Mod.ToString();
            else
                dex_mod_label.Text = character.Dexterity.Mod.ToString();
            if(character.Constitution.Mod >= 0)
                con_mod_label.Text = "+" + character.Constitution.Mod.ToString();
            else
                con_mod_label.Text = character.Constitution.Mod.ToString();
            if(character.Intelligence.Mod >= 0)
                int_mod_label.Text = "+" + character.Intelligence.Mod.ToString();
            else
                int_mod_label.Text = character.Intelligence.Mod.ToString();
            if(character.Wisdom.Mod >= 0)
                wis_mod_label.Text = "+" + character.Wisdom.Mod.ToString();
            else
                wis_mod_label.Text = character.Wisdom.Mod.ToString();
            if(character.Charisma.Mod >= 0)
                cha_mod_label.Text = "+" + character.Charisma.Mod.ToString();
            else
                cha_mod_label.Text = character.Charisma.Mod.ToString();
            ff_ac_box.Text = character.FF.ToString();
            touch_ac_box.Text = character.Touch.ToString();
            if(character.Init >= 0)
                init_box.Text = "+" + character.Init.ToString();
            else
                init_box.Text = character.Init.ToString();
            ac_box.Text = character.AC.ToString();
            if(character.BAB >= 0)
                bab_box.Text = "+" + character.BAB.ToString();
            else
                bab_box.Text = character.BAB.ToString();
            if(character.Melee >= 0)
                melee_box.Text = "+" + character.Melee.ToString();
            else
                melee_box.Text = character.Melee.ToString();
            if(character.Ranged >= 0)
                ranged_box.Text = "+" + character.Ranged.ToString();
            else
                ranged_box.Text = character.Ranged.ToString();
            subtitle_box.Text = character.Subtitle;
            char_name_box.Text = character.Name;
            gender_box.Text = character.Gender;
            size_box.Text = character.Size;
            race_box.Text = character.Race;
            alignment_box.Text = character.Alignment;
            char_level_box.Text = character.Level.ToString();
            avatar_panel.BackColor = character.CharColor;
            char_image.Image = character.CharImage;
            char_image.BackColor = character.IBC;

            health_bar.setCurrent(character.HP);
            health_bar.setMax(character.MaxHP);
            exp_bar.setCurrent(character.Exp);
            exp_bar.setMax(character.ExpToAdvance);
            health_bar.updateBar();
            exp_bar.updateBar();

            if(character.HPHidden) {
                hp_box.Visible = false;
                hp_slash_label.Visible = false;
                max_hp_box.Visible = false;
            }
            else {
                hp_box.Visible = true;
                hp_slash_label.Visible = true;
                max_hp_box.Visible = true;
            }

            f_class_1.Checked = character.Classes[0].Favored;
            class_level_box_1.Text = character.Classes[0].Level.ToString();
            class_hd_box_1.Text = character.Classes[0].HitDie;
            class_name_box_1.Text = character.Classes[0].Name;
            class_skill_box_1.Text = character.Classes[0].SkillRanks.ToString();
            f_class_2.Checked = character.Classes[1].Favored;
            class_level_box_2.Text = character.Classes[1].Level.ToString();
            class_hd_box_2.Text = character.Classes[1].HitDie;
            class_name_box_2.Text = character.Classes[1].Name;
            class_skill_box_2.Text = character.Classes[1].SkillRanks.ToString();
            f_class_3.Checked = character.Classes[2].Favored;
            class_level_box_3.Text = character.Classes[2].Level.ToString();
            class_hd_box_3.Text = character.Classes[2].HitDie;
            class_name_box_3.Text = character.Classes[2].Name;
            class_skill_box_3.Text = character.Classes[2].SkillRanks.ToString();
            f_class_4.Checked = character.Classes[3].Favored;
            class_level_box_4.Text = character.Classes[3].Level.ToString();
            class_hd_box_4.Text = character.Classes[3].HitDie;
            class_name_box_4.Text = character.Classes[3].Name;
            class_skill_box_4.Text = character.Classes[3].SkillRanks.ToString();
            f_class_5.Checked = character.Classes[4].Favored;
            class_level_box_5.Text = character.Classes[4].Level.ToString();
            class_hd_box_5.Text = character.Classes[4].HitDie;
            class_name_box_5.Text = character.Classes[4].Name;
            class_skill_box_5.Text = character.Classes[4].SkillRanks.ToString();
        }

        private void updateSkillUI() {
            skill_panel.Controls.Clear();
            character.setSkillMods();

            foreach(Skill s in character.Skills) {
                skill_panel.Controls.Add(new SkillBox(s));
            }
        }

        private void updateCharSkills() {
            character.Skills.Clear();

            foreach(SkillBox s in skill_panel.Controls) {
                character.Skills.Add(s.getSkill());
            }
        }

        #endregion

        #region Utility methods

        private bool checkHover(Point p) {
            Rectangle hoverArea = RectangleToScreen(skill_panel_back.Bounds);
            hoverArea.Inflate(-3, -3);

            return hoverArea.Contains(p);
        }

        private void setColors() {
            menu_strip.BackColor = Properties.Settings.Default.windowToolColor;
        }

        private void tryDeleteImage(string path) {
            try {
                File.Delete(path);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        private void toggleHPHidden() {
            if(character.HPHidden)
                character.HPHidden = false;
            else
                character.HPHidden = true;

            updateUIData();
        }

        #endregion

        #region Event Handlers

        private void settingsChanged(object sender, PropertyChangedEventArgs e) {
            setColors();
        }

        private void avatar_panel_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                character.CharColor = colorPicker.Color;
                updateUIData();
            }
        }

        private void char_image_Click(object sender, EventArgs e) {
            OpenFileDialog imageSelect = new OpenFileDialog();
            imageSelect.Filter = "Image Files ('*.jpg') | *.jpg";

            if(imageSelect.ShowDialog() == DialogResult.OK) {
                char_image.Image.Dispose();
                tryDeleteImage(character.Name + ".jpg");
                character.CharImage = Image.FromFile(imageSelect.FileName);
                updateUIData();
            }
        }

        private void saveCharacterAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "Character Files ('*.char') | *.char";
            saveWindow.DefaultExt = "char";

            if(saveWindow.ShowDialog() == DialogResult.OK) {
                character.saveChar(saveWindow.FileName);
            }
        }

        private void loadCharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog loadWindow = new OpenFileDialog();
            loadWindow.Filter = "Character Files ('*.char') | *.char";
            loadWindow.DefaultExt = "char";

            if(loadWindow.ShowDialog() == DialogResult.OK) {
                character.loadChar(loadWindow.FileName);
                updateUIData();
                updateSkillUI();
            }
        }

        private void inv_butt_Click(object sender, EventArgs e) {
            openInvWindow();
        }

        private void spell_butt_Click(object sender, EventArgs e) {
            openSpellbookWindow();
        }

        private void newSkillToolStripMenuItem_Click(object sender, EventArgs e) {
            updateCharSkills();
            character.Skills.Add(new Skill());
            updateSkillUI();
        }

        private void addPathfinderSkillsToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach(string s in File.ReadAllLines("basePFSkills.txt")) {
                Skill skill = new Skill();
                string[] sLine = s.Split('>');
                skill.fromString(sLine[1]);
                character.Skills.Add(skill);
            }

            updateSkillUI();
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            character.saveChar();
            character = new Character();
            updateUIData();
            updateSkillUI();
        }

        private void saveCharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            updateCharSkills();
            character.saveChar();
        }

        private void ability_table_Leave(object sender, EventArgs e) {
            updateUIData();
            updateSkillUI();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            updateCharSkills();
            updateUIData();
            updateSkillUI();
        }

        private void skill_panel_back_MouseMove(object sender, MouseEventArgs e) {
            if(checkHover(MousePosition))
                skill_clear_butt.Visible = true;
            else
                skill_clear_butt.Visible = false;
        }

        private void skill_clear_butt_Click(object sender, EventArgs e) {
            skill_panel.Controls.Clear();
        }

        private void max_hp_box_DoubleClick(object sender, EventArgs e) {
            toggleHPHidden();
        }

        private void hp_slash_label_DoubleClick(object sender, EventArgs e) {
            toggleHPHidden();
        }

        private void hp_box_DoubleClick(object sender, EventArgs e) {
            toggleHPHidden();
        }

        private void hp_text_panel_DoubleClick(object sender, EventArgs e) {
            toggleHPHidden();
        }

        #region TextChanged Event Handlers
        //These methods are purely responsible for updating character's data to match the UI's

        private void char_name_box_TextChanged(object sender, EventArgs e) {
            character.Name = char_name_box.Text;
        }

        private void subtitle_box_TextChanged(object sender, EventArgs e) {
            character.Subtitle = subtitle_box.Text;
        }

        private void race_box_TextChanged(object sender, EventArgs e) {
            character.Race = race_box.Text;
        }

        private void size_box_TextChanged(object sender, EventArgs e) {
            character.Size = size_box.Text;
        }

        private void gender_box_TextChanged(object sender, EventArgs e) {
            character.Gender = gender_box.Text;
        }

        private void char_level_box_TextChanged(object sender, EventArgs e) {
            int lvl;
            if(int.TryParse(char_level_box.Text, out lvl))
                character.Level = lvl;
            else
                character.Level = 0;
        }

        private void alignment_box_TextChanged(object sender, EventArgs e) {
            character.Alignment = alignment_box.Text;
        }

        private void hp_box_TextChanged(object sender, EventArgs e) {
            int hp;
            if(int.TryParse(hp_box.Text, out hp))
                character.HP = hp;
            else
                character.HP = 0;

            health_bar.setCurrent(character.HP);
            health_bar.updateBar();
        }

        private void max_hp_box_TextChanged(object sender, EventArgs e) {
            int mhp;
            if(int.TryParse(max_hp_box.Text, out mhp))
                character.MaxHP = mhp;
            else
                character.MaxHP = 0;

            health_bar.setMax(character.MaxHP);
            health_bar.updateBar();
        }

        private void str_box_TextChanged(object sender, EventArgs e) {
            int strT;
            if(int.TryParse(str_box.Text, out strT))
                character.Strength.Total = strT;
            else
                character.Strength.Total = 0;
        }

        private void dex_box_TextChanged(object sender, EventArgs e) {
            int dexT;
            if(int.TryParse(dex_box.Text, out dexT))
                character.Dexterity.Total = dexT;
            else
                character.Dexterity.Total = 0;
        }

        private void con_box_TextChanged(object sender, EventArgs e) {
            int conT;
            if(int.TryParse(con_box.Text, out conT))
                character.Constitution.Total = conT;
            else
                character.Constitution.Total = 0;
        }

        private void int_box_TextChanged(object sender, EventArgs e) {
            int intT;
            if(int.TryParse(int_box.Text, out intT))
                character.Intelligence.Total = intT;
            else
                character.Intelligence.Total = 0;
        }

        private void wis_box_TextChanged(object sender, EventArgs e) {
            int wisT;
            if(int.TryParse(wis_box.Text, out wisT))
                character.Wisdom.Total = wisT;
            else
                character.Wisdom.Total = 0;
        }

        private void cha_box_TextChanged(object sender, EventArgs e) {
            int chaT;
            if(int.TryParse(cha_box.Text, out chaT))
                character.Charisma.Total = chaT;
            else
                character.Charisma.Total = 0;
        }

        private void exp_box_TextChanged(object sender, EventArgs e) {
            int exp;
            if(int.TryParse(exp_box.Text, out exp))
                character.Exp = exp;
            else
                character.Exp = 0;

            exp_bar.setCurrent(character.Exp);
            exp_bar.updateBar();
        }

        private void max_exp_box_TextChanged(object sender, EventArgs e) {
            int mexp;
            if(int.TryParse(max_exp_box.Text, out mexp))
                character.ExpToAdvance = mexp;
            else
                character.ExpToAdvance = 0;

            exp_bar.setMax(character.ExpToAdvance);
            exp_bar.updateBar();
        }

        private void init_box_TextChanged(object sender, EventArgs e) {
            int init;
            if(int.TryParse(init_box.Text, out init))
                character.Init = init;
            else
                character.Init = 0;
        }

        private void ac_box_TextChanged(object sender, EventArgs e) {
            int ac;
            if(int.TryParse(ac_box.Text, out ac))
                character.AC = ac;
            else
                character.AC = 0;
        }

        private void ff_ac_box_TextChanged(object sender, EventArgs e) {
            int ff;
            if(int.TryParse(ff_ac_box.Text, out ff))
                character.FF = ff;
            else
                character.FF = 0;
        }

        private void touch_ac_box_TextChanged(object sender, EventArgs e) {
            int touch;
            if(int.TryParse(touch_ac_box.Text, out touch))
                character.Touch = touch;
            else
                character.Touch = 0;
        }

        private void speed_box_TextChanged(object sender, EventArgs e) {
            int spd;
            if(int.TryParse(speed_box.Text, out spd))
                character.Speed = spd;
            else
                character.Speed = 0;
        }

        private void fort_save_box_TextChanged(object sender, EventArgs e) {
            int fort;
            if(int.TryParse(fort_save_box.Text, out fort))
                character.Fortitude = fort;
            else
                character.Fortitude = 0;
        }

        private void will_save_box_TextChanged(object sender, EventArgs e) {
            int will;
            if(int.TryParse(will_save_box.Text, out will))
                character.Will = will;
            else
                character.Will = 0;
        }

        private void ref_save_box_TextChanged(object sender, EventArgs e) {
            int reflex;
            if(int.TryParse(ref_save_box.Text, out reflex))
                character.Reflex = reflex;
            else
                character.Reflex = 0;
        }

        private void bab_box_TextChanged(object sender, EventArgs e) {
            int bab;
            if(int.TryParse(bab_box.Text, out bab))
                character.BAB = bab;
            else
                character.BAB = 0;
        }

        private void melee_box_TextChanged(object sender, EventArgs e) {
            int mel;
            if(int.TryParse(melee_box.Text, out mel))
                character.Melee = mel;
            else
                character.Melee = 0;
        }

        private void ranged_box_TextChanged(object sender, EventArgs e) {
            int ran;
            if(int.TryParse(ranged_box.Text, out ran))
                character.Ranged = ran;
            else
                character.Ranged = 0;
        }

        private void char_notes_box_TextChanged(object sender, EventArgs e) {
            character.Notes = char_notes_box.Lines.ToList();
        }


        private void f_class_1_CheckedChanged(object sender, EventArgs e) {
            character.Classes[0].Favored = f_class_1.Checked;
        }

        private void class_name_box_1_TextChanged(object sender, EventArgs e) {
            character.Classes[0].Name = class_name_box_1.Text;
        }

        private void class_level_box_1_TextChanged(object sender, EventArgs e) {
            int lvl;
            if(int.TryParse(class_level_box_1.Text, out lvl))
                character.Classes[0].Level = lvl;
            else
                character.Classes[0].Level = 0;
        }

        private void class_hd_box_1_TextChanged(object sender, EventArgs e) {
            character.Classes[0].HitDie = class_hd_box_1.Text;
        }

        private void class_skill_box_1_TextChanged(object sender, EventArgs e) {
            int skill;
            if(int.TryParse(class_skill_box_1.Text, out skill))
                character.Classes[0].SkillRanks = skill;
            else
                character.Classes[0].SkillRanks = 0;
        }

        private void f_class_2_CheckedChanged(object sender, EventArgs e) {
            character.Classes[1].Favored = f_class_2.Checked;
        }

        private void class_name_box_2_TextChanged(object sender, EventArgs e) {
            character.Classes[1].Name = class_name_box_2.Text;
        }

        private void class_level_box_2_TextChanged(object sender, EventArgs e) {
            int lvl;
            if(int.TryParse(class_level_box_2.Text, out lvl))
                character.Classes[1].Level = lvl;
            else
                character.Classes[1].Level = 0;
        }

        private void class_hd_box_2_TextChanged(object sender, EventArgs e) {
            character.Classes[1].HitDie = class_hd_box_2.Text;
        }

        private void class_skill_box_2_TextChanged(object sender, EventArgs e) {
            int skill;
            if(int.TryParse(class_skill_box_2.Text, out skill))
                character.Classes[1].SkillRanks = skill;
            else
                character.Classes[1].SkillRanks = 0;
        }

        private void f_class_3_CheckedChanged(object sender, EventArgs e) {
            character.Classes[2].Favored = f_class_3.Checked;
        }

        private void class_name_box_3_TextChanged(object sender, EventArgs e) {
            character.Classes[2].Name = class_name_box_3.Text;
        }

        private void class_level_box_3_TextChanged(object sender, EventArgs e) {
            int lvl;
            if(int.TryParse(class_level_box_3.Text, out lvl))
                character.Classes[2].Level = lvl;
            else
                character.Classes[2].Level = 0;
        }

        private void class_hd_box_3_TextChanged(object sender, EventArgs e) {
            character.Classes[2].HitDie = class_hd_box_3.Text;
        }

        private void class_skill_box_3_TextChanged(object sender, EventArgs e) {
            int skill;
            if(int.TryParse(class_skill_box_3.Text, out skill))
                character.Classes[2].SkillRanks = skill;
            else
                character.Classes[2].SkillRanks = 0;
        }

        private void f_class_4_CheckedChanged(object sender, EventArgs e) {
            character.Classes[3].Favored = f_class_4.Checked;
        }

        private void class_name_box_4_TextChanged(object sender, EventArgs e) {
            character.Classes[3].Name = class_name_box_4.Text;
        }

        private void class_level_box_4_TextChanged(object sender, EventArgs e) {
            int lvl;
            if(int.TryParse(class_level_box_4.Text, out lvl))
                character.Classes[3].Level = lvl;
            else
                character.Classes[3].Level = 0;
        }

        private void class_hd_box_4_TextChanged(object sender, EventArgs e) {
            character.Classes[3].HitDie = class_hd_box_4.Text;
        }

        private void class_skill_box_4_TextChanged(object sender, EventArgs e) {
            int skill;
            if(int.TryParse(class_skill_box_4.Text, out skill))
                character.Classes[3].SkillRanks = skill;
            else
                character.Classes[3].SkillRanks = 0;
        }

        private void f_class_5_CheckedChanged(object sender, EventArgs e) {
            character.Classes[4].Favored = f_class_5.Checked;
        }

        private void class_name_box_5_TextChanged(object sender, EventArgs e) {
            character.Classes[4].Name = class_name_box_5.Text;
        }

        private void class_level_box_5_TextChanged(object sender, EventArgs e) {
            int lvl;
            if(int.TryParse(class_level_box_5.Text, out lvl))
                character.Classes[4].Level = lvl;
            else
                character.Classes[4].Level = 0;
        }

        private void class_hd_box_5_TextChanged(object sender, EventArgs e) {
            character.Classes[4].HitDie = class_hd_box_5.Text;
        }

        private void class_skill_box_5_TextChanged(object sender, EventArgs e) {
            int skill;
            if(int.TryParse(class_skill_box_5.Text, out skill))
                character.Classes[4].SkillRanks = skill;
            else
                character.Classes[4].SkillRanks = 0;
        }

        #endregion

        #endregion

        #region Get & Set methods
        public Character getChar() {
            return character;
        }

        public void setChar(ref Character c) {
            character = c;
        }
        #endregion
    }
}
