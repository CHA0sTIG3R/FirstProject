namespace FirstProject
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreGroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWindowsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.teamToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.testToolStripMenuItem,
            this.testToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.changeColorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreGroundToolStripMenuItem,
            this.backGroundToolStripMenuItem});
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changeColorToolStripMenuItem.Text = "Change Color";
            // 
            // foreGroundToolStripMenuItem
            // 
            this.foreGroundToolStripMenuItem.Name = "foreGroundToolStripMenuItem";
            this.foreGroundToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.foreGroundToolStripMenuItem.Text = "ForeGround";
            this.foreGroundToolStripMenuItem.Click += new System.EventHandler(this.foreGroundToolStripMenuItem_Click);
            // 
            // backGroundToolStripMenuItem
            // 
            this.backGroundToolStripMenuItem.Name = "backGroundToolStripMenuItem";
            this.backGroundToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.backGroundToolStripMenuItem.Text = "BackGround";
            this.backGroundToolStripMenuItem.Click += new System.EventHandler(this.backGroundToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeToolStripMenuItem,
            this.designerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.designerToolStripMenuItem.Text = "Designer";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWindowsFormToolStripMenuItem,
            this.addUserControlToolStripMenuItem,
            this.addComponentToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // addWindowsFormToolStripMenuItem
            // 
            this.addWindowsFormToolStripMenuItem.Name = "addWindowsFormToolStripMenuItem";
            this.addWindowsFormToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addWindowsFormToolStripMenuItem.Text = "Add Windows Form";
            // 
            // addUserControlToolStripMenuItem
            // 
            this.addUserControlToolStripMenuItem.Name = "addUserControlToolStripMenuItem";
            this.addUserControlToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addUserControlToolStripMenuItem.Text = "Add User Control";
            // 
            // addComponentToolStripMenuItem
            // 
            this.addComponentToolStripMenuItem.Name = "addComponentToolStripMenuItem";
            this.addComponentToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addComponentToolStripMenuItem.Text = "Add Component";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildSolutionToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // buildSolutionToolStripMenuItem
            // 
            this.buildSolutionToolStripMenuItem.Name = "buildSolutionToolStripMenuItem";
            this.buildSolutionToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.buildSolutionToolStripMenuItem.Text = "Build Solution";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.testToolStripMenuItem.Text = "Tools";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem1.Text = "Test";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(71, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 153);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem1,
            this.changeFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // changeColorToolStripMenuItem1
            // 
            this.changeColorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foregroundToolStripMenuItem1,
            this.backGroundToolStripMenuItem1});
            this.changeColorToolStripMenuItem1.Name = "changeColorToolStripMenuItem1";
            this.changeColorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.changeColorToolStripMenuItem1.Text = "Change Color";
            // 
            // foregroundToolStripMenuItem1
            // 
            this.foregroundToolStripMenuItem1.Name = "foregroundToolStripMenuItem1";
            this.foregroundToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.foregroundToolStripMenuItem1.Text = "ForeGround";
            this.foregroundToolStripMenuItem1.Click += new System.EventHandler(this.foregroundToolStripMenuItem1_Click);
            // 
            // backGroundToolStripMenuItem1
            // 
            this.backGroundToolStripMenuItem1.Name = "backGroundToolStripMenuItem1";
            this.backGroundToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.backGroundToolStripMenuItem1.Text = "BackGround";
            this.backGroundToolStripMenuItem1.Click += new System.EventHandler(this.backGroundToolStripMenuItem1_Click);
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeFontToolStripMenuItem.Text = "Change Font";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Location = new System.Drawing.Point(71, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ContextMenuStrip = this.contextMenuStrip1;
            this.button3.Location = new System.Drawing.Point(71, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addWindowsFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addComponentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildSolutionToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreGroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backGroundToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem foregroundToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backGroundToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}