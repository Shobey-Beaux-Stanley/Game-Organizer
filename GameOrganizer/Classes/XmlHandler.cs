using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace GameOrganizer.Classes {

	/// <summary>
	/// This class will handle all xml related functions such as
	/// loading, saving, etc...
	/// </summary>
	class XmlHandler {

		/// <summary>
		/// Takes the list of games and saves their data to the 
		/// xml file.
		/// </summary>
		/// <param name="gamesList"></param>
		public static void SaveAllGames(List<Classes.Game> gamesList) {
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.IndentChars = "  ";
		
			string path = @"SavedList\listOfGames.xml";
			XmlWriter writer = XmlWriter.Create(path, settings);
			

			writer.WriteStartDocument();
			writer.WriteStartElement("games");

			foreach (Game game in gamesList) {
				writer.WriteStartElement("game");
				writer.WriteElementString("publisher", game.Publisher);
				writer.WriteElementString("platform", game.Platform);
				writer.WriteElementString("title", game.Title);
				writer.WriteEndElement();
			}

			writer.WriteEndElement();
			writer.WriteEndDocument();
			writer.Close();
			
		}

		/// <summary>
		/// This generator function creates games from the saved xml file and
		/// returns them.
		/// </summary>
		/// <returns></returns>
		public static System.Collections.Generic.IEnumerable<Classes.Game> LoadAllGames() {
			Classes.Game game;
			string company = "";
			string platform = "";
			string name = "";
			string path = @"SavedList\listOfGames.xml";

			XmlReaderSettings settings = new XmlReaderSettings();
			settings.IgnoreWhitespace = true;
			XmlReader reader = XmlReader.Create(path, settings);
			reader.Read();
			while (reader.Read()) {
				if (reader.IsStartElement()) {
					switch (reader.Name) {
						case "platform":
							if (reader.Read()) {
								platform = reader.Value;
							}
							break;
						case "publisher":
							if (reader.Read()) {
								company = reader.Value;
							}
							break;
						case "title":
							if (reader.Read()) {
								name = reader.Value;
								game = new Classes.Game(platform, company, name);
								game.LoadImage();
								yield return game;
							}
							break;
					}
				}
			}
			reader.Close();
		}
	}
}
