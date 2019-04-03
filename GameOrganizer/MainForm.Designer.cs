namespace GameOrganizer {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gameLstBox = new System.Windows.Forms.ListBox();
			this.boxArtPicBox = new System.Windows.Forms.PictureBox();
			this.titleLbl = new System.Windows.Forms.Label();
			this.platformLbl = new System.Windows.Forms.Label();
			this.publisherLbl = new System.Windows.Forms.Label();
			this.infoGrpBox = new System.Windows.Forms.GroupBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.boxArtPicBox)).BeginInit();
			this.infoGrpBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(741, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGameMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// addGameMenuItem
			// 
			this.addGameMenuItem.Name = "addGameMenuItem";
			this.addGameMenuItem.Size = new System.Drawing.Size(157, 22);
			this.addGameMenuItem.Text = "Add New Game";
			this.addGameMenuItem.Click += new System.EventHandler(this.addGameMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editMenuItem
			// 
			this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGameToolStripMenuItem});
			this.editMenuItem.Name = "editMenuItem";
			this.editMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editMenuItem.Text = "Edit";
			// 
			// editGameToolStripMenuItem
			// 
			this.editGameToolStripMenuItem.Name = "editGameToolStripMenuItem";
			this.editGameToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.editGameToolStripMenuItem.Text = "Edit Game";
			this.editGameToolStripMenuItem.Click += new System.EventHandler(this.editGameToolStripMenuItem_Click);
			// 
			// gameLstBox
			// 
			this.gameLstBox.BackColor = System.Drawing.SystemColors.Menu;
			this.gameLstBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gameLstBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.gameLstBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gameLstBox.FormattingEnabled = true;
			this.gameLstBox.IntegralHeight = false;
			this.gameLstBox.ItemHeight = 23;
			this.gameLstBox.Location = new System.Drawing.Point(0, 24);
			this.gameLstBox.Name = "gameLstBox";
			this.gameLstBox.ScrollAlwaysVisible = true;
			this.gameLstBox.Size = new System.Drawing.Size(314, 384);
			this.gameLstBox.TabIndex = 1;
			this.gameLstBox.SelectedIndexChanged += new System.EventHandler(this.gameLstBox_SelectedIndexChanged);
			// 
			// boxArtPicBox
			// 
			this.boxArtPicBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.boxArtPicBox.Location = new System.Drawing.Point(6, 17);
			this.boxArtPicBox.Name = "boxArtPicBox";
			this.boxArtPicBox.Size = new System.Drawing.Size(201, 361);
			this.boxArtPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.boxArtPicBox.TabIndex = 0;
			this.boxArtPicBox.TabStop = false;
			// 
			// titleLbl
			// 
			this.titleLbl.AutoSize = true;
			this.titleLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLbl.Location = new System.Drawing.Point(221, 16);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(37, 23);
			this.titleLbl.TabIndex = 1;
			this.titleLbl.Text = "Title";
			// 
			// platformLbl
			// 
			this.platformLbl.AutoSize = true;
			this.platformLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.platformLbl.Location = new System.Drawing.Point(221, 63);
			this.platformLbl.Name = "platformLbl";
			this.platformLbl.Size = new System.Drawing.Size(65, 23);
			this.platformLbl.TabIndex = 2;
			this.platformLbl.Text = "Platform";
			// 
			// publisherLbl
			// 
			this.publisherLbl.AutoSize = true;
			this.publisherLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.publisherLbl.Location = new System.Drawing.Point(221, 86);
			this.publisherLbl.Name = "publisherLbl";
			this.publisherLbl.Size = new System.Drawing.Size(75, 23);
			this.publisherLbl.TabIndex = 3;
			this.publisherLbl.Text = "Publisher";
			// 
			// infoGrpBox
			// 
			this.infoGrpBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.infoGrpBox.AutoSize = true;
			this.infoGrpBox.BackColor = System.Drawing.SystemColors.Menu;
			this.infoGrpBox.Controls.Add(this.publisherLbl);
			this.infoGrpBox.Controls.Add(this.platformLbl);
			this.infoGrpBox.Controls.Add(this.titleLbl);
			this.infoGrpBox.Controls.Add(this.boxArtPicBox);
			this.infoGrpBox.Location = new System.Drawing.Point(310, 24);
			this.infoGrpBox.Name = "infoGrpBox";
			this.infoGrpBox.Size = new System.Drawing.Size(431, 395);
			this.infoGrpBox.TabIndex = 2;
			this.infoGrpBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(741, 408);
			this.Controls.Add(this.infoGrpBox);
			this.Controls.Add(this.gameLstBox);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Game Organizer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.boxArtPicBox)).EndInit();
			this.infoGrpBox.ResumeLayout(false);
			this.infoGrpBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ListBox gameLstBox;
		private System.Windows.Forms.ToolStripMenuItem addGameMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMenuItem;
		private System.Windows.Forms.PictureBox boxArtPicBox;
		private System.Windows.Forms.Label titleLbl;
		private System.Windows.Forms.Label platformLbl;
		private System.Windows.Forms.Label publisherLbl;
		private System.Windows.Forms.GroupBox infoGrpBox;
		private System.Windows.Forms.ToolStripMenuItem editGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
	}
}

