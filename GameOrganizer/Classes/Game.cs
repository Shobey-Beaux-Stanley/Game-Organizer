using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOrganizer.Classes {
	/// <summary>
	/// This class will represent a game and contain metadata describing it.
	/// </summary>
	public class Game : IComparable<Game> {
		private string publisher;
		private string platform;
		private string title;
		private System.Drawing.Image artwork;
		/// <summary>
		/// Default constructor
		/// </summary>
		public Game() {

		}

		/// <summary>
		/// Overloaded constructor with all string field members.
		/// </summary>
		/// <param name="company"></param>
		/// <param name="platform"></param>
		/// <param name="title"></param>
		public Game(string company, string platform, string title) {
			this.publisher = company;
			this.platform = platform;
			this.title = title;
			// The following lines of code are for using the default artwork.
			string path = @"Artwork\";
			string fileName = "Null.jpg";
			string fullPath = path + fileName;
			this.artwork = System.Drawing.Image.FromFile(fullPath);
		}

		//Class Properties
		public string Publisher { get { return this.publisher; } set { this.publisher = value; } }
		public string Platform { get { return this.platform; } set { this.platform = value; } }
		public string Title { get { return this.title; } set { this.title = value; } }
		public System.Drawing.Image Artwork { get { return this.artwork; } set { this.artwork = value; } }

		/// <summary>
		/// Loads the image used for cover art for the game object
		/// and stores it in the artwork field.
		/// </summary>
		public void LoadImage() { 
			string path = @"Artwork\";
			string fileName = this.Title.Replace(' ', '_');
			fileName = fileName.Replace(":", "_") + "_Art.jpg";
			Console.WriteLine(fileName);
			string fullPath = path + fileName;
			if (System.IO.File.Exists(fullPath))
				this.artwork = System.Drawing.Image.FromFile(fullPath);

		}
		/// <summary>
		/// ToString method to print out all object member fields
		/// </summary>
		/// <returns></returns>
		public override string ToString() {
			return publisher + " " + platform + " " + Title;
		}

		public int CompareTo(Game otherGame) {
			return string.Compare(this.Title, otherGame.Title);
		}
	}
}
