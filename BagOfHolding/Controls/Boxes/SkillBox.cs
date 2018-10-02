using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagOfHolding
{
    public partial class SkillBox : UserControl
    {
        Skill skill;

        public SkillBox() {
            skill = new Skill();
            InitializeComponent();
            updateUIData();
        }

        public SkillBox(Skill s) {
            skill = s;
            InitializeComponent();
            updateUIData();
        }

        private void updateUIData() {
            skill_name_box.Text = skill.Name;
            ability_box.Text = getAbilityString();
            total_box.Text = skill.Total.ToString();
            ranks_box.Value = skill.Ranks;
            ability_mod_box.Text = skill.AbilityMod.ToString();
            if(skill.Trained)
                trained_box.Text = "3";
            else
                trained_box.Text = "0";
            miscMod1_box.Text = skill.MiscMod1.ToString();
            miscMod2_box.Text = skill.MiscMod2.ToString();
            class_skill_box.Checked = skill.ClassSkill;
        }

        #region Utility methods

        private string getAbilityString() {
            switch(skill.AbilityType) {
                case 0:
                    return "STR";
                case 1:
                    return "DEX";
                case 2:
                    return "CON";
                case 3:
                    return "INT";
                case 4:
                    return "WIS";
                case 5:
                    return "CHA";
                default:
                    return "STR";
            }
        }

        private bool checkHover(Point p) {
            Rectangle hoverArea = RectangleToScreen(DisplayRectangle);
            hoverArea.Inflate(-3, -3);

            return hoverArea.Contains(p);
        }

        #endregion

        #region Get & Set methods

        public Skill getSkill() {
            return skill;
        }

        public void setSkill(Skill s) {
            skill = s;
        }

        private void setForeColor(Color f) {
            skill_table.ForeColor = f;
            skill_name_box.ForeColor = f;
            class_skill_box.ForeColor = f;
            ability_box.ForeColor = f;
            total_box.ForeColor = f;
            ranks_box.ForeColor = f;
            ability_mod_box.ForeColor = f;
            trained_box.ForeColor = f;
            miscMod1_box.ForeColor = f;
            miscMod2_box.ForeColor = f;
        }

        private void setBackColor(Color b) {
            skill_table.BackColor = b;
            skill_name_box.BackColor = b;
            class_skill_box.BackColor = b;
            ability_box.BackColor = b;
            total_box.BackColor = b;
            ranks_box.BackColor = b;
            ability_mod_box.BackColor = b;
            trained_box.BackColor = b;
            miscMod1_box.BackColor = b;
            miscMod2_box.BackColor = b;
        }

        #endregion

        #region Event Handlers

        private void skill_table_MouseMove(object sender, MouseEventArgs e) {
            if(checkHover(MousePosition))
                del_butt.Visible = true;
            else
                del_butt.Visible = false;
        }

        private void del_butt_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void ability_box_Leave(object sender, EventArgs e) {
            switch(ability_box.Text.ToUpper()) {
                case "STR":
                    skill.AbilityType = 0;
                    break;
                case "DEX":
                    skill.AbilityType = 1;
                    break;
                case "CON":
                    skill.AbilityType = 2;
                    break;
                case "INT":
                    skill.AbilityType = 3;
                    break;
                case "WIS":
                    skill.AbilityType = 4;
                    break;
                case "CHA":
                    skill.AbilityType = 5;
                    break;
                default: {
                        ability_box.Text = "STR";
                        skill.AbilityType = 0;
                        break;
                    }
            }
        }

        #region ValueChanged events

        private void skill_name_box_TextChanged(object sender, EventArgs e) {
            skill.Name = skill_name_box.Text;
        }

        private void ranks_box_ValueChanged(object sender, EventArgs e) {
            skill.Ranks = (int) ranks_box.Value;
            updateUIData();
        }

        private void miscMod1_box_TextChanged(object sender, EventArgs e) {
            int m;
            if(int.TryParse(miscMod1_box.Text, out m))
                skill.MiscMod1 = m;
            else
                skill.MiscMod1 = 0;

            updateUIData();
        }

        private void miscMod2_box_TextChanged(object sender, EventArgs e) {
            int m;
            if(int.TryParse(miscMod2_box.Text, out m))
                skill.MiscMod2 = m;
            else
                skill.MiscMod2 = 0;

            updateUIData();
        }

        private void class_skill_box_CheckedChanged(object sender, EventArgs e) {
            skill.ClassSkill = class_skill_box.Checked;
            updateUIData();
        }

        #endregion

        #endregion
    }
}
