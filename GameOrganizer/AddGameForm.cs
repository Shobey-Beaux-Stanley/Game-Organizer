using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GameOrganizer {
	/// <summary>
	/// This class creates a form used for adding new game
	/// information into the program.
	/// </summary>
	public partial class AddGameForm : Form {
		private MainForm parentForm;//Used for passing over the new game information to the main form.

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AddGameForm() {
			InitializeComponent();
		}

		/// <summary>
		/// Overloaded constructor with a refernece to the main form.
		/// </summary>
		/// <param name="parentForm"></param>
		public AddGameForm(MainForm parentForm) {
			this.parentForm = parentForm;
			InitializeComponent();
		}

		//Properties
		public TextBox PublisherTextBox {get { return this.publisherTxtBox; } set { this.publisherTxtBox = value; } }
		public TextBox PlatformTextBox { get { return this.platformTxtBox; } set { this.platformTxtBox = value; } }
		public TextBox TitleTextBox { get { return this.titleTxtBox; } set { this.titleTxtBox = value; } }
		public PictureBox GameInfoPictureBox { get { return this.gameInfoPicBox; } set { this.gameInfoPicBox = value; } }
		public PictureBox GameArtworkPictureBox { get { return this.gameArtWorkPicBox; } set { this.gameArtWorkPicBox = value; } }

		/// <summary>
		/// This method will close the Add Game Form and 
		/// return to the primary form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cancelBtn_Click (object sender, EventArgs e) {
			this.Close();
		}

		/// <summary>
		/// This function takes user input from the Add Game Form and creates
		/// a new game to be stored in the program.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void OkBtn_Click (object sender, EventArgs e) {
			Classes.Game newGame;
			string title = "-";
			string platform = "-";
			string company = "-";
			if (!Classes.Validator.IsPresent(this.titleTxtBox)) {
				MessageBox.Show("Game must have a title");
				this.titleTxtBox.Focus();
				return;
			}
			else 
				title = this.titleTxtBox.Text.Trim();

			if (Classes.Validator.IsPresent(this.platformTxtBox)) 
				platform = this.platformTxtBox.Text.Trim();

			if (Classes.Validator.IsPresent(this.publisherTxtBox)) 
				company = this.publisherTxtBox.Text.Trim();

			newGame = new Classes.Game(title: title, platform: platform, company: company);

			if (this.gameInfoPicBox.Image != null) {
				newGame.Artwork = this.gameInfoPicBox.Image;
			}
				
			this.parentForm.AddGameToList(newGame);
			this.Close();
		}

		/// <summary>
		/// When adding a new game, in the second tab of the add game form called
		/// Artwork, there is an option to add an image file. Once the add button 
		/// is clicked, a file chooser is opened and the selected file is set as 
		/// the artwork for the picture box in both tabs of the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addArtBtn_Click(object sender, EventArgs e) {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.InitialDirectory = "c:\\";
			dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
			DialogResult result = dialog.ShowDialog();
			if (result == DialogResult.OK) {
				System.IO.FileInfo info = new System.IO.FileInfo(dialog.FileName);
				System.Drawing.Image newArt = System.Drawing.Image.FromFile(info.FullName);
				this.gameArtWorkPicBox.Image = newArt;
				this.gameInfoPicBox.Image = newArt;
				string fileName = this.titleTxtBox.Text.Replace(' ', '_');
				fileName = fileName.Replace(':', '_');
				string path = @"Artwork\" + fileName + "_Art.jpg";
				System.IO.File.Copy(info.FullName, path, true);
			}
		}
	}
}
