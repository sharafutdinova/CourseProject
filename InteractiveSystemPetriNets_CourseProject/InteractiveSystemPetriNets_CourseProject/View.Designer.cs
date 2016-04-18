namespace InteractiveSystemPetriNets_CourseProject
{
    partial class View
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dbox = new System.Windows.Forms.GroupBox();
            this.saveDialogueMove = new System.Windows.Forms.Button();
            this.dlist = new System.Windows.Forms.ListBox();
            this.ebox = new System.Windows.Forms.GroupBox();
            this.elist = new System.Windows.Forms.ListBox();
            this.aBox1 = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.alist = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDialogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbox.SuspendLayout();
            this.ebox.SuspendLayout();
            this.aBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbox
            // 
            this.dbox.Controls.Add(this.saveDialogueMove);
            this.dbox.Controls.Add(this.dlist);
            this.dbox.Location = new System.Drawing.Point(12, 27);
            this.dbox.Name = "dbox";
            this.dbox.Size = new System.Drawing.Size(630, 174);
            this.dbox.TabIndex = 35;
            this.dbox.TabStop = false;
            this.dbox.Text = "Dialogue move";
            // 
            // saveDialogueMove
            // 
            this.saveDialogueMove.Location = new System.Drawing.Point(6, 139);
            this.saveDialogueMove.Name = "saveDialogueMove";
            this.saveDialogueMove.Size = new System.Drawing.Size(166, 21);
            this.saveDialogueMove.TabIndex = 20;
            this.saveDialogueMove.Text = "Save dialogue move";
            this.saveDialogueMove.UseVisualStyleBackColor = true;
            this.saveDialogueMove.Click += new System.EventHandler(this.OnSaveDialogueMoveButtonPressing);
            // 
            // dlist
            // 
            this.dlist.FormattingEnabled = true;
            this.dlist.Location = new System.Drawing.Point(6, 19);
            this.dlist.Name = "dlist";
            this.dlist.Size = new System.Drawing.Size(618, 108);
            this.dlist.TabIndex = 9;
            // 
            // ebox
            // 
            this.ebox.Controls.Add(this.elist);
            this.ebox.Location = new System.Drawing.Point(407, 207);
            this.ebox.Name = "ebox";
            this.ebox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ebox.Size = new System.Drawing.Size(235, 88);
            this.ebox.TabIndex = 36;
            this.ebox.TabStop = false;
            this.ebox.Text = "Error message";
            // 
            // elist
            // 
            this.elist.FormattingEnabled = true;
            this.elist.Location = new System.Drawing.Point(6, 22);
            this.elist.Name = "elist";
            this.elist.Size = new System.Drawing.Size(223, 56);
            this.elist.TabIndex = 6;
            // 
            // aBox1
            // 
            this.aBox1.Controls.Add(this.okButton);
            this.aBox1.Controls.Add(this.alist);
            this.aBox1.Location = new System.Drawing.Point(12, 199);
            this.aBox1.Name = "aBox1";
            this.aBox1.Size = new System.Drawing.Size(389, 173);
            this.aBox1.TabIndex = 37;
            this.aBox1.TabStop = false;
            this.aBox1.Text = "Select one of the possible answers";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(6, 146);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(160, 21);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OnOkButtonPressing);
            // 
            // alist
            // 
            this.alist.Location = new System.Drawing.Point(6, 21);
            this.alist.Name = "alist";
            this.alist.Size = new System.Drawing.Size(377, 121);
            this.alist.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDialogueToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openDialogueToolStripMenuItem
            // 
            this.openDialogueToolStripMenuItem.Name = "openDialogueToolStripMenuItem";
            this.openDialogueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openDialogueToolStripMenuItem.Text = "Open dialogue";
            this.openDialogueToolStripMenuItem.Click += new System.EventHandler(this.OnOpenDialogueMenuItemPressing);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.OnCloseMenuItemPressing);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 384);
            this.Controls.Add(this.dbox);
            this.Controls.Add(this.aBox1);
            this.Controls.Add(this.ebox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "View";
            this.Text = "Form1";
            this.dbox.ResumeLayout(false);
            this.ebox.ResumeLayout(false);
            this.aBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dbox;
        private System.Windows.Forms.Button saveDialogueMove;
        private System.Windows.Forms.ListBox dlist;
        private System.Windows.Forms.GroupBox ebox;
        private System.Windows.Forms.ListBox elist;
        private System.Windows.Forms.GroupBox aBox1;
        private System.Windows.Forms.ListBox alist;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDialogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;

        public System.Windows.Forms.ListBox Alist
        {
            get { return alist; }
            set { alist = value; }
        }

        public System.Windows.Forms.ListBox Elist
        {
            get { return elist; }
            set { elist = value; }
        }

        public System.Windows.Forms.ListBox Dlist
        {
            get { return dlist; }
            set { dlist = value; }
        }

    }
}

