namespace BagOfHolding
{
    partial class InventoryWindow
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
            this.armor_butt = new System.Windows.Forms.Button();
            this.weapon_butt = new System.Windows.Forms.Button();
            this.item_butt = new System.Windows.Forms.Button();
            this.inventory_label = new System.Windows.Forms.Label();
            this.item_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCharacterAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItemListAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overwriteInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_panel.SuspendLayout();
            this.menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Black;
            this.main_panel.Controls.Add(this.armor_butt);
            this.main_panel.Controls.Add(this.weapon_butt);
            this.main_panel.Controls.Add(this.item_butt);
            this.main_panel.Controls.Add(this.inventory_label);
            this.main_panel.Controls.Add(this.item_panel);
            this.main_panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(701, 469);
            this.main_panel.TabIndex = 1;
            // 
            // armor_butt
            // 
            this.armor_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.armor_butt.BackColor = System.Drawing.Color.Gainsboro;
            this.armor_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.armor_butt.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armor_butt.Location = new System.Drawing.Point(619, 44);
            this.armor_butt.Name = "armor_butt";
            this.armor_butt.Size = new System.Drawing.Size(58, 28);
            this.armor_butt.TabIndex = 2;
            this.armor_butt.Text = "Armor";
            this.armor_butt.UseVisualStyleBackColor = false;
            this.armor_butt.Click += new System.EventHandler(this.armor_butt_Click);
            // 
            // weapon_butt
            // 
            this.weapon_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weapon_butt.BackColor = System.Drawing.Color.Gainsboro;
            this.weapon_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weapon_butt.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_butt.Location = new System.Drawing.Point(517, 44);
            this.weapon_butt.Name = "weapon_butt";
            this.weapon_butt.Size = new System.Drawing.Size(82, 28);
            this.weapon_butt.TabIndex = 2;
            this.weapon_butt.Text = "Weapons";
            this.weapon_butt.UseVisualStyleBackColor = false;
            this.weapon_butt.Click += new System.EventHandler(this.weapon_butt_Click);
            // 
            // item_butt
            // 
            this.item_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.item_butt.BackColor = System.Drawing.Color.Gainsboro;
            this.item_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_butt.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_butt.Location = new System.Drawing.Point(437, 44);
            this.item_butt.Name = "item_butt";
            this.item_butt.Size = new System.Drawing.Size(58, 28);
            this.item_butt.TabIndex = 2;
            this.item_butt.Text = "Items";
            this.item_butt.UseVisualStyleBackColor = false;
            this.item_butt.Click += new System.EventHandler(this.item_butt_Click);
            // 
            // inventory_label
            // 
            this.inventory_label.AutoSize = true;
            this.inventory_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.inventory_label.Location = new System.Drawing.Point(3, 44);
            this.inventory_label.Name = "inventory_label";
            this.inventory_label.Size = new System.Drawing.Size(101, 25);
            this.inventory_label.TabIndex = 1;
            this.inventory_label.Text = "Inventory";
            // 
            // item_panel
            // 
            this.item_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_panel.AutoScroll = true;
            this.item_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.item_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.item_panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.item_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.item_panel.Location = new System.Drawing.Point(0, 75);
            this.item_panel.Margin = new System.Windows.Forms.Padding(0);
            this.item_panel.Name = "item_panel";
            this.item_panel.Size = new System.Drawing.Size(701, 391);
            this.item_panel.TabIndex = 0;
            // 
            // menu_strip
            // 
            this.menu_strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Margin = new System.Windows.Forms.Padding(3);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(701, 24);
            this.menu_strip.TabIndex = 25;
            this.menu_strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newItemToolStripMenuItem.Text = "New Item...";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCharacterToolStripMenuItem,
            this.overwriteInventoryToolStripMenuItem,
            this.appendInventoryToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadCharacterToolStripMenuItem
            // 
            this.loadCharacterToolStripMenuItem.Name = "loadCharacterToolStripMenuItem";
            this.loadCharacterToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.loadCharacterToolStripMenuItem.Text = "Load Character...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCharacterAsToolStripMenuItem,
            this.saveItemListAsToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveCharacterAsToolStripMenuItem
            // 
            this.saveCharacterAsToolStripMenuItem.Name = "saveCharacterAsToolStripMenuItem";
            this.saveCharacterAsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveCharacterAsToolStripMenuItem.Text = "Save Character as...";
            // 
            // saveItemListAsToolStripMenuItem
            // 
            this.saveItemListAsToolStripMenuItem.Name = "saveItemListAsToolStripMenuItem";
            this.saveItemListAsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveItemListAsToolStripMenuItem.Text = "Save Inventory as...";
            this.saveItemListAsToolStripMenuItem.Click += new System.EventHandler(this.saveInventoryAsToolStripMenuItem_Click);
            // 
            // overwriteInventoryToolStripMenuItem
            // 
            this.overwriteInventoryToolStripMenuItem.Name = "overwriteInventoryToolStripMenuItem";
            this.overwriteInventoryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.overwriteInventoryToolStripMenuItem.Text = "Overwrite Inventory...";
            this.overwriteInventoryToolStripMenuItem.Click += new System.EventHandler(this.overwriteInventoryToolStripMenuItem_Click);
            // 
            // appendInventoryToolStripMenuItem
            // 
            this.appendInventoryToolStripMenuItem.Name = "appendInventoryToolStripMenuItem";
            this.appendInventoryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.appendInventoryToolStripMenuItem.Text = "Append Inventory...";
            // 
            // InventoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menu_strip);
            this.Controls.Add(this.main_panel);
            this.Name = "InventoryWindow";
            this.Size = new System.Drawing.Size(701, 469);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button armor_butt;
        private System.Windows.Forms.Button weapon_butt;
        private System.Windows.Forms.Button item_butt;
        private System.Windows.Forms.Label inventory_label;
        private System.Windows.Forms.FlowLayoutPanel item_panel;
        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveItemListAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overwriteInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendInventoryToolStripMenuItem;
    }
}
