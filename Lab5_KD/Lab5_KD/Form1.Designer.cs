namespace Lab5_KD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textButton = new System.Windows.Forms.RadioButton();
            this.ellipseButton = new System.Windows.Forms.RadioButton();
            this.recButton = new System.Windows.Forms.RadioButton();
            this.lineButton = new System.Windows.Forms.RadioButton();
            this.penWidthList = new System.Windows.Forms.ListBox();
            this.fillColorList = new System.Windows.Forms.ListBox();
            this.penColorList = new System.Windows.Forms.ListBox();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.fillBox = new System.Windows.Forms.CheckBox();
            this.outlineBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.outlineBox);
            this.panel1.Controls.Add(this.fillBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.penWidthList);
            this.panel1.Controls.Add(this.fillColorList);
            this.panel1.Controls.Add(this.penColorList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 345);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pen Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fill Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pen Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textButton);
            this.groupBox1.Controls.Add(this.ellipseButton);
            this.groupBox1.Controls.Add(this.recButton);
            this.groupBox1.Controls.Add(this.lineButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 237);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(310, 90);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textButton
            // 
            this.textButton.AutoSize = true;
            this.textButton.Location = new System.Drawing.Point(24, 114);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(56, 21);
            this.textButton.TabIndex = 3;
            this.textButton.TabStop = true;
            this.textButton.Text = "Text";
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // ellipseButton
            // 
            this.ellipseButton.AutoSize = true;
            this.ellipseButton.Location = new System.Drawing.Point(24, 87);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(70, 21);
            this.ellipseButton.TabIndex = 2;
            this.ellipseButton.TabStop = true;
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // recButton
            // 
            this.recButton.AutoSize = true;
            this.recButton.Location = new System.Drawing.Point(24, 60);
            this.recButton.Name = "recButton";
            this.recButton.Size = new System.Drawing.Size(93, 21);
            this.recButton.TabIndex = 1;
            this.recButton.TabStop = true;
            this.recButton.Text = "Rectangle";
            this.recButton.UseVisualStyleBackColor = true;
            this.recButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // lineButton
            // 
            this.lineButton.AutoSize = true;
            this.lineButton.Location = new System.Drawing.Point(24, 33);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(56, 21);
            this.lineButton.TabIndex = 0;
            this.lineButton.TabStop = true;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // penWidthList
            // 
            this.penWidthList.FormattingEnabled = true;
            this.penWidthList.ItemHeight = 16;
            this.penWidthList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.penWidthList.Location = new System.Drawing.Point(697, 60);
            this.penWidthList.Name = "penWidthList";
            this.penWidthList.Size = new System.Drawing.Size(138, 164);
            this.penWidthList.TabIndex = 2;
            this.penWidthList.SelectedIndexChanged += new System.EventHandler(this.penWidthList_SelectedIndexChanged);
            // 
            // fillColorList
            // 
            this.fillColorList.FormattingEnabled = true;
            this.fillColorList.ItemHeight = 16;
            this.fillColorList.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.fillColorList.Location = new System.Drawing.Point(545, 60);
            this.fillColorList.Name = "fillColorList";
            this.fillColorList.Size = new System.Drawing.Size(120, 100);
            this.fillColorList.TabIndex = 1;
            this.fillColorList.SelectedIndexChanged += new System.EventHandler(this.fillColorList_SelectedIndexChanged);
            // 
            // penColorList
            // 
            this.penColorList.FormattingEnabled = true;
            this.penColorList.ItemHeight = 16;
            this.penColorList.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.penColorList.Location = new System.Drawing.Point(389, 60);
            this.penColorList.Name = "penColorList";
            this.penColorList.Size = new System.Drawing.Size(120, 100);
            this.penColorList.TabIndex = 0;
            this.penColorList.SelectedIndexChanged += new System.EventHandler(this.penColorList_SelectedIndexChanged);
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.Window;
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(0, 373);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(943, 110);
            this.drawPanel.TabIndex = 2;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseClick);
            // 
            // fillBox
            // 
            this.fillBox.AutoSize = true;
            this.fillBox.Location = new System.Drawing.Point(411, 222);
            this.fillBox.Name = "fillBox";
            this.fillBox.Size = new System.Drawing.Size(47, 21);
            this.fillBox.TabIndex = 7;
            this.fillBox.Text = "Fill";
            this.fillBox.UseVisualStyleBackColor = true;
            this.fillBox.CheckedChanged += new System.EventHandler(this.fillBox_CheckedChanged);
            // 
            // outlineBox
            // 
            this.outlineBox.AutoSize = true;
            this.outlineBox.Location = new System.Drawing.Point(411, 260);
            this.outlineBox.Name = "outlineBox";
            this.outlineBox.Size = new System.Drawing.Size(75, 21);
            this.outlineBox.TabIndex = 8;
            this.outlineBox.Text = "Outline";
            this.outlineBox.UseVisualStyleBackColor = true;
            this.outlineBox.CheckedChanged += new System.EventHandler(this.outlineBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 483);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab 5 - Kanav Dhir";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.ListBox penWidthList;
        private System.Windows.Forms.ListBox fillColorList;
        private System.Windows.Forms.ListBox penColorList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton textButton;
        private System.Windows.Forms.RadioButton ellipseButton;
        private System.Windows.Forms.RadioButton recButton;
        private System.Windows.Forms.RadioButton lineButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox outlineBox;
        private System.Windows.Forms.CheckBox fillBox;
    }
}

