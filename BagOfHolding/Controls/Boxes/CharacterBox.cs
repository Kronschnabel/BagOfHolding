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
    public partial class CharacterBox : UserControl {
        Character character;

        Window char_win;
        CharacterWindow char_control;
        Window inv_win;
        InventoryWindow inv_control;
        Window spellbook_win;
        SpellbookWindow spellbook_control;

        Color hpForeColor = Color.LimeGreen;
        Color hpBackColor = Color.Brown;
        Color expForeColor = Color.DarkOrchid;
        Color expBackColor = Color.Gray;

        public CharacterBox() {
            character = new Character();
            InitializeComponent();
            initializeBars();
            updateUIData();
        }

        public CharacterBox(Character c) {
            character = c;
            InitializeComponent();
            initializeBars();
            updateUIData();
        }

        public void createWindows() {
            char_win = new Window("char");
            char_control = new CharacterWindow();
            char_win.addControl(char_control);
            Parent.Parent.Parent.Parent.Parent.Parent.Parent.Controls.Add(char_win);

            inv_win = new Window("inv");
            inv_control = new InventoryWindow();
            inv_win.addControl(inv_control);
            Parent.Parent.Parent.Parent.Parent.Parent.Parent.Controls.Add(inv_win);

            spellbook_win = new Window("spellbook");
            spellbook_control = new SpellbookWindow();
            spellbook_win.addControl(spellbook_control);
            Parent.Parent.Parent.Parent.Parent.Parent.Parent.Controls.Add(spellbook_win);
        }

        public void initializeBars() {
            health_bar.setColors(hpForeColor, hpBackColor);
            exp_bar.setColors(expForeColor, expBackColor);
            exp_bar.setBaseWidth(100);
            exp_bar.updateBar();
        }

        private void openCharWindow() {
            char_control.setChar(ref character);
            char_win.open();
            char_control.open();
        }

        private void openInvWindow() {
            inv_control.setChar(ref character);
            inv_win.open();
            inv_control.open();
        }

        private void openSpellBookWindow() {
            spellbook_control.setChar(ref character);
            spellbook_win.open();
            spellbook_control.open();
        }

        private void updateUIData() {
            max_hp_box.Text = character.getMaxHP().ToString();
            hp_box.Text = character.getHP().ToString();
            exp_box.Text = character.getExp().ToString();
            max_exp_box.Text = character.getExpToAdvance().ToString();
            char_notes_box.Lines = character.getNotes().ToArray();
            speed_box.Text = character.getSpeed().ToString();
            fort_save_box.Text = character.getFortitude().ToString();
            will_save_box.Text = character.getWill().ToString();
            ref_save_box.Text = character.getReflex().ToString();
            str_box.Text = character.getStr().getTotal().ToString();
            dex_box.Text = character.getDex().getTotal().ToString();
            con_box.Text = character.getCon().getTotal().ToString();
            int_box.Text = character.getInt().getTotal().ToString();
            wis_box.Text = character.getWis().getTotal().ToString();
            cha_box.Text = character.getCha().getTotal().ToString();
            if(character.getStr().getMod() >= 0)
                str_mod_label.Text = "+" + character.getStr().getMod().ToString();
            else
                str_mod_label.Text = character.getStr().getMod().ToString();
            if(character.getDex().getMod() >= 0)
                dex_mod_label.Text = "+" + character.getDex().getMod().ToString();
            else 
                dex_mod_label.Text = character.getDex().getMod().ToString();
            if(character.getCon().getMod() >= 0)
                con_mod_label.Text = "+" + character.getCon().getMod().ToString();
            else
                con_mod_label.Text = character.getCon().getMod().ToString();
            if(character.getInt().getMod() >= 0)
                int_mod_label.Text = "+" + character.getInt().getMod().ToString();
            else 
                int_mod_label.Text = character.getInt().getMod().ToString();
            if(character.getWis().getMod() >= 0)
                wis_mod_label.Text = "+" + character.getWis().getMod().ToString();
            else
                wis_mod_label.Text = character.getWis().getMod().ToString();
            if(character.getCha().getMod() >= 0)
                cha_mod_label.Text = "+" + character.getCha().getMod().ToString();
            else
                cha_mod_label.Text = character.getCha().getMod().ToString();
            ff_ac_box.Text = character.getFF().ToString();
            touch_ac_box.Text = character.getTouch().ToString();
            if(character.getInit() >= 0)
                init_box.Text = "+" + character.getInit().ToString();
            else
                init_box.Text = character.getInit().ToString();
            ac_box.Text = character.getAC().ToString();
            if(character.getBab() >= 0)
                bab_box.Text = "+" + character.getBab().ToString();
            else
                bab_box.Text = character.getBab().ToString();
            if(character.getMelee() >= 0)
                melee_box.Text = "+" + character.getMelee().ToString();
            else
                melee_box.Text = character.getMelee().ToString();
            if(character.getRanged() >= 0)
                ranged_box.Text = "+" + character.getRanged().ToString();
            else
                ranged_box.Text = character.getRanged().ToString();
            subtitle_box.Text = character.getSubtitle();
            char_name_box.Text = character.getName();
            gender_box.Text = character.getGender();
            size_box.Text = character.getSize();
            race_box.Text = character.getRace();
            alignment_box.Text = character.getAlignment();
            char_level_box.Text = character.getLevel().ToString();
            avatar_panel.BackColor = character.getColor();
            char_image.Image = character.getImage();
            char_image.BackColor = character.getIBC();
        }

        private void tryDeleteImage(string path) {
            try {
                File.Delete(path);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("No overwrite required");
            }
        }

        private bool checkHover(Point p) {
            Rectangle hoverArea = RectangleToScreen(char_panel.Bounds);
            hoverArea.Inflate(-4, -4);

            return hoverArea.Contains(p);
        }

        #region Event Handlers
        private void avatar_panel_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK) {
                character.setColor(colorPicker.Color);
                updateUIData();
            }
        }

        private void char_image_Click(object sender, EventArgs e) {
            OpenFileDialog imageSelect = new OpenFileDialog();
            imageSelect.Filter = "Image Files ('*.jpg') | *.jpg";

            if(imageSelect.ShowDialog() == DialogResult.OK) {
                char_image.Image.Dispose();
                tryDeleteImage(character.getName() + ".jpg");
                character.setImage(Image.FromFile(imageSelect.FileName));
                updateUIData();
            }
        }

        private void char_name_box_TextChanged(object sender, EventArgs e) {
            character.setName(char_name_box.Text);
        }

        private void subtitle_box_TextChanged(object sender, EventArgs e) {
            character.setSubtitle(subtitle_box.Text);
        }

        private void race_box_TextChanged(object sender, EventArgs e) {
            character.setRace(race_box.Text);
        }

        private void size_box_TextChanged(object sender, EventArgs e) {
            character.setSize(size_box.Text);
        }

        private void gender_box_TextChanged(object sender, EventArgs e) {
            character.setGender(gender_box.Text);
        }

        private void char_level_box_TextChanged(object sender, EventArgs e) {
            int lvl;
            if(int.TryParse(char_level_box.Text, out lvl))
                character.setLevel(lvl);
            else
                character.setLevel(0);
        }

        private void alignment_box_TextChanged(object sender, EventArgs e) {
            character.setAlignment(alignment_box.Text);
        }

        private void hp_box_TextChanged(object sender, EventArgs e) {
            int hp;
            if(int.TryParse(hp_box.Text, out hp))
                character.setHP(hp);
            else
                character.setHP(0);

            health_bar.setCurrent(character.getHP());
            health_bar.updateBar();
        }

        private void max_hp_box_TextChanged(object sender, EventArgs e) {
            int mhp;
            if(int.TryParse(max_hp_box.Text, out mhp))
                character.setMaxHP(mhp);
            else
                character.setMaxHP(0);

            health_bar.setMax(character.getMaxHP());
            health_bar.updateBar();
        }

        private void str_box_TextChanged(object sender, EventArgs e) {
            int strT;
            if(int.TryParse(str_box.Text, out strT))
                character.getStr().setTotal(strT);
            else
                character.getStr().setTotal(0);
        }

        private void dex_box_TextChanged(object sender, EventArgs e) {
            int dexT;
            if(int.TryParse(dex_box.Text, out dexT))
                character.getDex().setTotal(dexT);
            else
                character.getDex().setTotal(0);
        }

        private void con_box_TextChanged(object sender, EventArgs e) {
            int conT;
            if(int.TryParse(con_box.Text, out conT))
                character.getCon().setTotal(conT);
            else
                character.getCon().setTotal(0);
        }

        private void int_box_TextChanged(object sender, EventArgs e) {
            int intT;
            if(int.TryParse(int_box.Text, out intT))
                character.getInt().setTotal(intT);
            else
                character.getInt().setTotal(0);
        }

        private void wis_box_TextChanged(object sender, EventArgs e) {
            int wisT;
            if(int.TryParse(wis_box.Text, out wisT))
                character.getWis().setTotal(wisT);
            else
                character.getWis().setTotal(0);
        }

        private void cha_box_TextChanged(object sender, EventArgs e) {
            int chaT;
            if(int.TryParse(cha_box.Text, out chaT))
                character.getCha().setTotal(chaT);
            else
                character.getCha().setTotal(0);
        }

        private void exp_box_TextChanged(object sender, EventArgs e) {
            int exp;
            if(int.TryParse(exp_box.Text, out exp))
                character.setExp(exp);
            else
                character.setExp(0);

            exp_bar.setCurrent(character.getExp());
            exp_bar.updateBar();
        }

        private void max_exp_box_TextChanged(object sender, EventArgs e) {
            int mexp;
            if(int.TryParse(max_exp_box.Text, out mexp))
                character.setExpToAdvance(mexp);
            else
                character.setExpToAdvance(0);

            exp_bar.setMax(character.getExpToAdvance());
            exp_bar.updateBar();
        }

        private void init_box_TextChanged(object sender, EventArgs e) {
            int init;
            if(int.TryParse(init_box.Text, out init))
                character.setInit(init);
            else
                character.setInit(0);
        }

        private void ac_box_TextChanged(object sender, EventArgs e) {
            int ac;
            if(int.TryParse(ac_box.Text, out ac))
                character.setAC(ac);
            else
                character.setAC(0);
        }

        private void ff_ac_box_TextChanged(object sender, EventArgs e) {
            int ff;
            if(int.TryParse(ff_ac_box.Text, out ff))
                character.setFF(ff);
            else
                character.setFF(0);
        }

        private void touch_ac_box_TextChanged(object sender, EventArgs e) {
            int touch;
            if(int.TryParse(touch_ac_box.Text, out touch))
                character.setTouch(touch);
            else
                character.setTouch(0);
        }

        private void speed_box_TextChanged(object sender, EventArgs e) {
            int spd;
            if(int.TryParse(speed_box.Text, out spd))
                character.setSpeed(spd);
            else
                character.setSpeed(0);
        }

        private void fort_save_box_TextChanged(object sender, EventArgs e) {
            int fort;
            if(int.TryParse(fort_save_box.Text, out fort))
                character.setFortitude(fort);
            else
                character.setFortitude(0);
        }

        private void will_save_box_TextChanged(object sender, EventArgs e) {
            int will;
            if(int.TryParse(will_save_box.Text, out will))
                character.setWill(will);
            else
                character.setWill(0);
        }

        private void ref_save_box_TextChanged(object sender, EventArgs e) {
            int reflex;
            if(int.TryParse(ref_save_box.Text, out reflex))
                character.setReflex(reflex);
            else
                character.setReflex(0);
        }

        private void bab_box_TextChanged(object sender, EventArgs e) {
            int bab;
            if(int.TryParse(bab_box.Text, out bab))
                character.setBab(bab);
            else
                character.setBab(0);
        }

        private void melee_box_TextChanged(object sender, EventArgs e) {
            int mel;
            if(int.TryParse(melee_box.Text, out mel))
                character.setMelee(mel);
            else
                character.setMelee(0);
        }

        private void ranged_box_TextChanged(object sender, EventArgs e) {
            int ran;
            if(int.TryParse(ranged_box.Text, out ran))
                character.setRanged(ran);
            else
                character.setRanged(0);
        }

        private void char_notes_box_TextChanged(object sender, EventArgs e) {
            character.setNotes(char_notes_box.Lines.ToList());
        }


        private void inv_butt_Click(object sender, EventArgs e) {
            openInvWindow();
        }

        private void spell_butt_Click(object sender, EventArgs e) {
            openSpellBookWindow();
        }


        private void char_name_box_DoubleClick(object sender, EventArgs e) {
            openCharWindow();
        }

        private void char_panel_MouseMove(object sender, MouseEventArgs e) {
            if(checkHover(MousePosition))
                del_butt.Visible = true;
            else
                del_butt.Visible = false;
        }

        private void del_butt_Click(object sender, EventArgs e) {
            Dispose();
        }
        #endregion

        #region Get & Set methods
        public Character getChar() {
            return character;
        }

        public void setChar(Character c) {
            character = c;
            updateUIData();
        }
        #endregion
    }
}
