namespace BagOfHolding
{
    partial class PartyWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.main_panel = new System.Windows.Forms.Panel();
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.savePartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearWithoutSavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.party_label = new System.Windows.Forms.Label();
            this.party_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_panel.SuspendLayout();
            this.menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.main_panel.Controls.Add(this.menu_strip);
            this.main_panel.Controls.Add(this.party_label);
            this.main_panel.Controls.Add(this.party_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Margin = new System.Windows.Forms.Padding(0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(853, 507);
            this.main_panel.TabIndex = 1;
            // 
            // menu_strip
            // 
            this.menu_strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Margin = new System.Windows.Forms.Padding(3);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(853, 24);
            this.menu_strip.TabIndex = 25;
            this.menu_strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newCharacterToolStripMenuItem.Text = "New Character...";
            this.newCharacterToolStripMenuItem.Click += new System.EventHandler(this.newCharacterToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCharacterToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadCharacterToolStripMenuItem
            // 
            this.loadCharacterToolStripMenuItem.Name = "loadCharacterToolStripMenuItem";
            this.loadCharacterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadCharacterToolStripMenuItem.Text = "Load Characters...";
            this.loadCharacterToolStripMenuItem.Click += new System.EventHandler(this.loadCharacterToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePartyToolStripMenuItem});
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // savePartyToolStripMenuItem
            // 
            this.savePartyToolStripMenuItem.Name = "savePartyToolStripMenuItem";
            this.savePartyToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.savePartyToolStripMenuItem.Text = "Save Party...";
            this.savePartyToolStripMenuItem.Click += new System.EventHandler(this.savePartyToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.clearPartyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearPartyToolStripMenuItem
            // 
            this.clearPartyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearWithoutSavingToolStripMenuItem,
            this.clearAndSaveToolStripMenuItem});
            this.clearPartyToolStripMenuItem.Name = "clearPartyToolStripMenuItem";
            this.clearPartyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearPartyToolStripMenuItem.Text = "Clear Party";
            // 
            // clearWithoutSavingToolStripMenuItem
            // 
            this.clearWithoutSavingToolStripMenuItem.Name = "clearWithoutSavingToolStripMenuItem";
            this.clearWithoutSavingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.clearWithoutSavingToolStripMenuItem.Text = "Clear without saving...";
            this.clearWithoutSavingToolStripMenuItem.Click += new System.EventHandler(this.clearWithoutSavingToolStripMenuItem_Click);
            // 
            // clearAndSaveToolStripMenuItem
            // 
            this.clearAndSaveToolStripMenuItem.Name = "clearAndSaveToolStripMenuItem";
            this.clearAndSaveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.clearAndSaveToolStripMenuItem.Text = "Clear and save...";
            this.clearAndSaveToolStripMenuItem.Click += new System.EventHandler(this.clearAndSaveToolStripMenuItem_Click);
            // 
            // party_label
            // 
            this.party_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.party_label.AutoSize = true;
            this.party_label.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.party_label.Location = new System.Drawing.Point(3, 38);
            this.party_label.Name = "party_label";
            this.party_label.Size = new System.Drawing.Size(55, 23);
            this.party_label.TabIndex = 2;
            this.party_label.Text = "Party";
            // 
            // party_panel
            // 
            this.party_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.party_panel.AutoScroll = true;
            this.party_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.party_panel.Location = new System.Drawing.Point(0, 64);
            this.party_panel.Name = "party_panel";
            this.party_panel.Size = new System.Drawing.Size(853, 443);
            this.party_panel.TabIndex = 0;
            this.party_panel.WrapContents = false;
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // PartyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_panel);
            this.Name = "PartyWindow";
            this.Size = new System.Drawing.Size(853, 507);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyWindow_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartyWindow_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PartyWindow_KeyUp);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label party_label;
        private System.Windows.Forms.FlowLayoutPanel party_panel;
        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem savePartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearWithoutSavingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAndSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
