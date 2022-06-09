namespace FASA_Character_Generator
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpCharacterStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDebugMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDebugMenu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radD100 = new System.Windows.Forms.RadioButton();
            this.txtRollResult = new System.Windows.Forms.TextBox();
            this.radD30 = new System.Windows.Forms.RadioButton();
            this.radD20 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radD12 = new System.Windows.Forms.RadioButton();
            this.radD10 = new System.Windows.Forms.RadioButton();
            this.radD8 = new System.Windows.Forms.RadioButton();
            this.radD6 = new System.Windows.Forms.RadioButton();
            this.radD4 = new System.Windows.Forms.RadioButton();
            this.radD3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDebugMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newCharacterToolStripMenuItem.Text = "New Character";
            this.newCharacterToolStripMenuItem.Click += new System.EventHandler(this.newCharacterToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumpCharacterStatsToolStripMenuItem,
            this.showDebugMenuToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // dumpCharacterStatsToolStripMenuItem
            // 
            this.dumpCharacterStatsToolStripMenuItem.Name = "dumpCharacterStatsToolStripMenuItem";
            this.dumpCharacterStatsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.dumpCharacterStatsToolStripMenuItem.Text = "Dump Character Stats";
            this.dumpCharacterStatsToolStripMenuItem.Click += new System.EventHandler(this.dumpCharacterStatsToolStripMenuItem_Click);
            // 
            // showDebugMenuToolStripMenuItem
            // 
            this.showDebugMenuToolStripMenuItem.Name = "showDebugMenuToolStripMenuItem";
            this.showDebugMenuToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.showDebugMenuToolStripMenuItem.Text = "Show Debug Menu";
            this.showDebugMenuToolStripMenuItem.Click += new System.EventHandler(this.showDebugMenuToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FASA_Character_Generator.Properties.Resources.backdrop;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.panelDebugMenu);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 448);
            this.panel1.TabIndex = 1;
            // 
            // panelDebugMenu
            // 
            this.panelDebugMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelDebugMenu.Controls.Add(this.groupBox1);
            this.panelDebugMenu.Controls.Add(this.label2);
            this.panelDebugMenu.Enabled = false;
            this.panelDebugMenu.Location = new System.Drawing.Point(3, 3);
            this.panelDebugMenu.Name = "panelDebugMenu";
            this.panelDebugMenu.Size = new System.Drawing.Size(882, 442);
            this.panelDebugMenu.TabIndex = 1;
            this.panelDebugMenu.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.radD100);
            this.groupBox1.Controls.Add(this.txtRollResult);
            this.groupBox1.Controls.Add(this.radD30);
            this.groupBox1.Controls.Add(this.radD20);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radD12);
            this.groupBox1.Controls.Add(this.radD10);
            this.groupBox1.Controls.Add(this.radD8);
            this.groupBox1.Controls.Add(this.radD6);
            this.groupBox1.Controls.Add(this.radD4);
            this.groupBox1.Controls.Add(this.radD3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice Roller";
            // 
            // radD100
            // 
            this.radD100.AutoSize = true;
            this.radD100.Location = new System.Drawing.Point(10, 222);
            this.radD100.Name = "radD100";
            this.radD100.Size = new System.Drawing.Size(55, 19);
            this.radD100.TabIndex = 9;
            this.radD100.Text = "D100";
            this.radD100.UseVisualStyleBackColor = true;
            // 
            // txtRollResult
            // 
            this.txtRollResult.Enabled = false;
            this.txtRollResult.Location = new System.Drawing.Point(91, 218);
            this.txtRollResult.Name = "txtRollResult";
            this.txtRollResult.Size = new System.Drawing.Size(100, 23);
            this.txtRollResult.TabIndex = 8;
            // 
            // radD30
            // 
            this.radD30.AutoSize = true;
            this.radD30.Location = new System.Drawing.Point(10, 197);
            this.radD30.Name = "radD30";
            this.radD30.Size = new System.Drawing.Size(48, 19);
            this.radD30.TabIndex = 7;
            this.radD30.Text = "D30";
            this.radD30.UseVisualStyleBackColor = true;
            // 
            // radD20
            // 
            this.radD20.AutoSize = true;
            this.radD20.Location = new System.Drawing.Point(10, 172);
            this.radD20.Name = "radD20";
            this.radD20.Size = new System.Drawing.Size(48, 19);
            this.radD20.TabIndex = 6;
            this.radD20.Text = "D20";
            this.radD20.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(91, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radD12
            // 
            this.radD12.AutoSize = true;
            this.radD12.Location = new System.Drawing.Point(10, 147);
            this.radD12.Name = "radD12";
            this.radD12.Size = new System.Drawing.Size(48, 19);
            this.radD12.TabIndex = 5;
            this.radD12.Text = "D12";
            this.radD12.UseVisualStyleBackColor = true;
            // 
            // radD10
            // 
            this.radD10.AutoSize = true;
            this.radD10.Location = new System.Drawing.Point(10, 122);
            this.radD10.Name = "radD10";
            this.radD10.Size = new System.Drawing.Size(48, 19);
            this.radD10.TabIndex = 4;
            this.radD10.Text = "D10";
            this.radD10.UseVisualStyleBackColor = true;
            // 
            // radD8
            // 
            this.radD8.AutoSize = true;
            this.radD8.Location = new System.Drawing.Point(10, 97);
            this.radD8.Name = "radD8";
            this.radD8.Size = new System.Drawing.Size(41, 19);
            this.radD8.TabIndex = 3;
            this.radD8.Text = "D8";
            this.radD8.UseVisualStyleBackColor = true;
            // 
            // radD6
            // 
            this.radD6.AutoSize = true;
            this.radD6.Location = new System.Drawing.Point(10, 72);
            this.radD6.Name = "radD6";
            this.radD6.Size = new System.Drawing.Size(41, 19);
            this.radD6.TabIndex = 2;
            this.radD6.Text = "D6";
            this.radD6.UseVisualStyleBackColor = true;
            // 
            // radD4
            // 
            this.radD4.AutoSize = true;
            this.radD4.Location = new System.Drawing.Point(10, 47);
            this.radD4.Name = "radD4";
            this.radD4.Size = new System.Drawing.Size(41, 19);
            this.radD4.TabIndex = 1;
            this.radD4.Text = "D4";
            this.radD4.UseVisualStyleBackColor = true;
            // 
            // radD3
            // 
            this.radD3.AutoSize = true;
            this.radD3.Location = new System.Drawing.Point(10, 22);
            this.radD3.Name = "radD3";
            this.radD3.Size = new System.Drawing.Size(41, 19);
            this.radD3.TabIndex = 0;
            this.radD3.Text = "D3";
            this.radD3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Debug Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(307, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "FASA Character Generator";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FASA Character Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelDebugMenu.ResumeLayout(false);
            this.panelDebugMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newCharacterToolStripMenuItem;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem dumpCharacterStatsToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private ToolStripMenuItem showDebugMenuToolStripMenuItem;
        private Panel panelDebugMenu;
        private GroupBox groupBox1;
        private Label label2;
        private RadioButton radD4;
        private RadioButton radD3;
        private RadioButton radD100;
        private TextBox txtRollResult;
        private RadioButton radD30;
        private RadioButton radD20;
        private RadioButton radD12;
        private RadioButton radD10;
        private RadioButton radD8;
        private RadioButton radD6;
    }
}