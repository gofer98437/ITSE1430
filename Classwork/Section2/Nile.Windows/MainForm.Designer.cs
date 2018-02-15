namespace Nile.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this._MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mIFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mIProductAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._mIProductEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._mIProductRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mIHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _MainMenu
            // 
            this._MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._MainMenu.Location = new System.Drawing.Point(0, 0);
            this._MainMenu.Name = "_MainMenu";
            this._MainMenu.Size = new System.Drawing.Size(709, 24);
            this._MainMenu.TabIndex = 0;
            this._MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mIFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // _mIFileExit
            // 
            this._mIFileExit.Name = "_mIFileExit";
            this._mIFileExit.Size = new System.Drawing.Size(152, 22);
            this._mIFileExit.Text = "E&xit";
            this._mIFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mIProductAdd,
            this._mIProductEdit,
            this.toolStripSeparator1,
            this._mIProductRemove});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "&Product";
            // 
            // _mIProductAdd
            // 
            this._mIProductAdd.Name = "_mIProductAdd";
            this._mIProductAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this._mIProductAdd.Size = new System.Drawing.Size(152, 22);
            this._mIProductAdd.Text = "&Add";
            this._mIProductAdd.Click += new System.EventHandler(this.OnProductAdd);
            // 
            // _mIProductEdit
            // 
            this._mIProductEdit.Name = "_mIProductEdit";
            this._mIProductEdit.Size = new System.Drawing.Size(152, 22);
            this._mIProductEdit.Text = "&Edit";
            this._mIProductEdit.Click += new System.EventHandler(this.OnProductEdit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // _mIProductRemove
            // 
            this._mIProductRemove.Name = "_mIProductRemove";
            this._mIProductRemove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._mIProductRemove.Size = new System.Drawing.Size(152, 22);
            this._mIProductRemove.Text = "&Remove";
            this._mIProductRemove.Click += new System.EventHandler(this.OnProductRemove);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mIHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // _mIHelpAbout
            // 
            this._mIHelpAbout.Name = "_mIHelpAbout";
            this._mIHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._mIHelpAbout.Size = new System.Drawing.Size(152, 22);
            this._mIHelpAbout.Text = "About";
            this._mIHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 422);
            this.Controls.Add(this._MainMenu);
            this.MainMenuStrip = this._MainMenu;
            this.Name = "MainForm";
            this.Text = "nile";
            this._MainMenu.ResumeLayout(false);
            this._MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _mIFileExit;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _mIProductAdd;
        private System.Windows.Forms.ToolStripMenuItem _mIProductEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _mIProductRemove;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _mIHelpAbout;
    }
}

