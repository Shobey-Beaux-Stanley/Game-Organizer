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
	/// This form is used for editing game data and saving
	/// the changes.
	/// </summary>
	public partial class EditGameForm : AddGameForm {
		private Classes.Game game;//The game to be edited.

		/// <summary>
		/// Default constructor.
		/// </summary>
		public EditGameForm() : base() {
			game = null;
			InitializeComponent();
		}

		/// <summary>
		/// Overloaded constructor with a reference to the main form,
		/// and the game to be edited.
		/// </summary>
		/// <param name="form"></param>
		/// <param name="game"></param>
		public EditGameForm(MainForm form, Classes.Game game) : base(form){
			this.game = game;
			base.PublisherTextBox.Text = game.Publisher;
			base.PlatformTextBox.Text = game.Platform;
			base.TitleTextBox.Text = game.Title;
			base.GameInfoPictureBox.Image = game.Artwork;
			base.GameArtworkPictureBox.Image = game.Artwork;
			InitializeComponent();
		}

		/// <summary>
		/// Overrides the parent class of OkButton Click so that it
		/// edits the selected game instead of adding a new game 
		/// to the collection.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void OkBtn_Click(object sender, EventArgs e) {
			if (!Classes.Validator.IsPresent(base.TitleTextBox)) {
				MessageBox.Show("Game must have a title");
				base.TitleTextBox.Focus();
				return;
			}
			else
				this.game.Title = base.TitleTextBox.Text.Trim();

			if (Classes.Validator.IsPresent(base.PlatformTextBox))
				this.game.Platform = base.PlatformTextBox.Text.Trim();

			if (Classes.Validator.IsPresent(base.PublisherTextBox))
				this.game.Publisher = base.PublisherTextBox.Text.Trim();


			if (base.GameInfoPictureBox.Image != null) {
				this.game.Artwork = base.GameInfoPictureBox.Image;
			}
			this.Close();
		}

	}
}
