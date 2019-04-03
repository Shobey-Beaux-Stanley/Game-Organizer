using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace GameOrganizer {
	/// <summary>
	/// This is the main form for the user. It allows viewing and selecting
	/// games and their data. This form can also open up new forms for adding games
	/// and editing games.
	/// </summary>
	public partial class MainForm : Form {
		private List<Classes.Game> gameList;//List that will contain the collection of games.

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MainForm () {
			InitializeComponent();
		}

		/// <summary>
		/// When exit is pressed, the program will prompt the user and will either 
		/// return to the running program or close the program based on input
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitToolStripMenuItem_Click (object sender, EventArgs e) {
			DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirm Quit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
			if (result == DialogResult.Yes) {
				Application.Exit();
			}
			else {
				return;
			}
		}

		/// <summary>
		/// This will load all saved items from the user into the program when 
		/// the program is first opened.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load (object sender, EventArgs e) {//Use a static class and yield instead of this implementation
			gameList = new List<Classes.Game>();
			foreach (Classes.Game game in Classes.XmlHandler.LoadAllGames()) {
				gameLstBox.Items.Add(game.Title);
				gameList.Add(game);
			}
			if (gameLstBox.Items.Count > 0) {//Prevents index out of bounds in case of no games in collection.
				this.gameLstBox.SelectedIndex = 0;
			}
		}

		/// <summary>
		/// The event handler for selecting an item in the list.
		/// This will update the data in the view in real time so the user
		/// can see and edit it.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gameLstBox_SelectedIndexChanged(object sender, EventArgs e) {
			if (gameLstBox.SelectedIndex >= 0) {
				if (gameLstBox.Items.Count > 0) {
					this.titleLbl.Text = gameList[gameLstBox.SelectedIndex].Title;
					this.platformLbl.Text = gameList[gameLstBox.SelectedIndex].Platform;
					this.publisherLbl.Text = gameList[gameLstBox.SelectedIndex].Publisher;
					if (gameList[gameLstBox.SelectedIndex].Artwork != null) {
						this.boxArtPicBox.Image = gameList[gameLstBox.SelectedIndex].Artwork;
					}
				}
			}
		}

		/// <summary>
		/// Opens up an Add Game Form which allows the user
		/// to add a new game to the collection.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addGameMenuItem_Click(object sender, EventArgs e) {
			AddGameForm gameForm = new AddGameForm(this);
			gameForm.Show();
		}

		/// <summary>
		/// Adds a new game to the list of games.
		/// </summary>
		/// <param name="newGame"></param>
		public void AddGameToList(Classes.Game newGame) {
			this.gameList.Add(newGame);
			this.gameLstBox.Items.Add(newGame.Title);
			Classes.XmlHandler.SaveAllGames(this.gameList);
		}

		/// <summary>
		/// Opens up the Edit Game Form to edit and
		/// update game information.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void editGameToolStripMenuItem_Click(object sender, EventArgs e) {
			Classes.Game editGame = gameList[gameLstBox.SelectedIndex];
			EditGameForm editForm = new EditGameForm(this, editGame);
			editForm.Show();
			Classes.XmlHandler.SaveAllGames(this.gameList);
		}

		/// <summary>
		/// Removes the selected game from the collection, sets the
		/// current selected index to -1 (unselected), and saves the list
		/// of games to the xml file.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
			DialogResult result = MessageBox.Show("Do you want to remove this item?", 
				"Delete Confirm", 
				MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes) {
				int index = gameLstBox.SelectedIndex;
				Console.WriteLine("index is " + index);
				gameList.RemoveAt(index);
				gameLstBox.SelectedIndex = -1;
				gameLstBox.Items.RemoveAt(index);
				Classes.XmlHandler.SaveAllGames(gameList);
			}
		}
	}
}
