namespace GameOrganizer {
	partial class AddGameForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
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
		private void InitializeComponent() {
			this.gameInformationTab = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.addGameGrpBox = new System.Windows.Forms.GroupBox();
			this.gameInfoPicBox = new System.Windows.Forms.PictureBox();
			this.platformTxtBox = new System.Windows.Forms.TextBox();
			this.publisherTxtBox = new System.Windows.Forms.TextBox();
			this.titleTxtBox = new System.Windows.Forms.TextBox();
			this.titleLbl = new System.Windows.Forms.Label();
			this.platformLbl = new System.Windows.Forms.Label();
			this.publisherLbl = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.addArtBtn = new System.Windows.Forms.Button();
			this.gameArtWorkPicBox = new System.Windows.Forms.PictureBox();
			this.OkBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.gameInformationTab.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.addGameGrpBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gameInfoPicBox)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gameArtWorkPicBox)).BeginInit();
			this.SuspendLayout();
			// 
			// gameInformationTab
			// 
			this.gameInformationTab.Controls.Add(this.tabPage1);
			this.gameInformationTab.Controls.Add(this.tabPage2);
			this.gameInformationTab.Location = new System.Drawing.Point(4, 5);
			this.gameInformationTab.Name = "gameInformationTab";
			this.gameInformationTab.SelectedIndex = 0;
			this.gameInformationTab.Size = new System.Drawing.Size(320, 269);
			this.gameInformationTab.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.addGameGrpBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(312, 243);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Information";
			// 
			// addGameGrpBox
			// 
			this.addGameGrpBox.Controls.Add(this.gameInfoPicBox);
			this.addGameGrpBox.Controls.Add(this.platformTxtBox);
			this.addGameGrpBox.Controls.Add(this.publisherTxtBox);
			this.addGameGrpBox.Controls.Add(this.titleTxtBox);
			this.addGameGrpBox.Controls.Add(this.titleLbl);
			this.addGameGrpBox.Controls.Add(this.platformLbl);
			this.addGameGrpBox.Controls.Add(this.publisherLbl);
			this.addGameGrpBox.Location = new System.Drawing.Point(6, 6);
			this.addGameGrpBox.Name = "addGameGrpBox";
			this.addGameGrpBox.Size = new System.Drawing.Size(279, 225);
			this.addGameGrpBox.TabIndex = 1;
			this.addGameGrpBox.TabStop = false;
			// 
			// gameInfoPicBox
			// 
			this.gameInfoPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gameInfoPicBox.Location = new System.Drawing.Point(156, 116);
			this.gameInfoPicBox.Name = "gameInfoPicBox";
			this.gameInfoPicBox.Size = new System.Drawing.Size(115, 103);
			this.gameInfoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.gameInfoPicBox.TabIndex = 2;
			this.gameInfoPicBox.TabStop = false;
			// 
			// platformTxtBox
			// 
			this.platformTxtBox.Location = new System.Drawing.Point(88, 39);
			this.platformTxtBox.Name = "platformTxtBox";
			this.platformTxtBox.Size = new System.Drawing.Size(183, 20);
			this.platformTxtBox.TabIndex = 6;
			// 
			// publisherTxtBox
			// 
			this.publisherTxtBox.Location = new System.Drawing.Point(88, 13);
			this.publisherTxtBox.Name = "publisherTxtBox";
			this.publisherTxtBox.Size = new System.Drawing.Size(183, 20);
			this.publisherTxtBox.TabIndex = 5;
			// 
			// titleTxtBox
			// 
			this.titleTxtBox.Location = new System.Drawing.Point(88, 65);
			this.titleTxtBox.Name = "titleTxtBox";
			this.titleTxtBox.Size = new System.Drawing.Size(183, 20);
			this.titleTxtBox.TabIndex = 4;
			// 
			// titleLbl
			// 
			this.titleLbl.AutoSize = true;
			this.titleLbl.Location = new System.Drawing.Point(11, 68);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(27, 13);
			this.titleLbl.TabIndex = 2;
			this.titleLbl.Text = "Title";
			// 
			// platformLbl
			// 
			this.platformLbl.AutoSize = true;
			this.platformLbl.Location = new System.Drawing.Point(11, 42);
			this.platformLbl.Name = "platformLbl";
			this.platformLbl.Size = new System.Drawing.Size(49, 13);
			this.platformLbl.TabIndex = 1;
			this.platformLbl.Text = "Platform*";
			// 
			// publisherLbl
			// 
			this.publisherLbl.AutoSize = true;
			this.publisherLbl.Location = new System.Drawing.Point(11, 16);
			this.publisherLbl.Name = "publisherLbl";
			this.publisherLbl.Size = new System.Drawing.Size(54, 13);
			this.publisherLbl.TabIndex = 0;
			this.publisherLbl.Text = "Publisher*";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
			this.tabPage2.Controls.Add(this.addArtBtn);
			this.tabPage2.Controls.Add(this.gameArtWorkPicBox);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(312, 243);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Artwork";
			// 
			// addArtBtn
			// 
			this.addArtBtn.Location = new System.Drawing.Point(12, 214);
			this.addArtBtn.Name = "addArtBtn";
			this.addArtBtn.Size = new System.Drawing.Size(75, 23);
			this.addArtBtn.TabIndex = 1;
			this.addArtBtn.Text = "Add Artwork";
			this.addArtBtn.UseVisualStyleBackColor = true;
			this.addArtBtn.Click += new System.EventHandler(this.addArtBtn_Click);
			// 
			// gameArtWorkPicBox
			// 
			this.gameArtWorkPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gameArtWorkPicBox.Location = new System.Drawing.Point(6, 6);
			this.gameArtWorkPicBox.Name = "gameArtWorkPicBox";
			this.gameArtWorkPicBox.Size = new System.Drawing.Size(297, 181);
			this.gameArtWorkPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.gameArtWorkPicBox.TabIndex = 0;
			this.gameArtWorkPicBox.TabStop = false;
			// 
			// OkBtn
			// 
			this.OkBtn.Location = new System.Drawing.Point(155, 294);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(75, 23);
			this.OkBtn.TabIndex = 3;
			this.OkBtn.Text = "OK";
			this.OkBtn.UseVisualStyleBackColor = true;
			this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(236, 294);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 8;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// AddGameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 329);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.gameInformationTab);
			this.Controls.Add(this.OkBtn);
			this.Name = "AddGameForm";
			this.Text = "Add New Game";
			this.gameInformationTab.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.addGameGrpBox.ResumeLayout(false);
			this.addGameGrpBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gameInfoPicBox)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gameArtWorkPicBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl gameInformationTab;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox addGameGrpBox;
		private System.Windows.Forms.PictureBox gameInfoPicBox;
		private System.Windows.Forms.TextBox platformTxtBox;
		private System.Windows.Forms.TextBox publisherTxtBox;
		private System.Windows.Forms.TextBox titleTxtBox;
		private System.Windows.Forms.Label titleLbl;
		private System.Windows.Forms.Label platformLbl;
		private System.Windows.Forms.Label publisherLbl;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button addArtBtn;
		private System.Windows.Forms.PictureBox gameArtWorkPicBox;
		private System.Windows.Forms.Button OkBtn;
		private System.Windows.Forms.Button cancelBtn;
	}
}