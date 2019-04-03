using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOrganizer.Classes {
	/// <summary>
	/// This class is used to validate user input
	/// in order to prevent data problems and crashes.
	/// </summary>
	class Validator {
		/// <summary>
		/// This determines if the user has typed anything in
		/// a textbox or not.
		/// </summary>
		/// <param name="textBox"></param>
		/// <returns></returns>
		public static bool IsPresent(TextBox textBox) {
			if (textBox.Text == "") {
				return false;
			}
			return true;
		}

		/// <summary>
		/// Determines if the text in a textbox can be
		/// converted to a number.
		/// </summary>
		/// <param name="textBox"></param>
		/// <returns></returns>
		public static bool IsNumeric(TextBox textBox) {
			double value;
			if (Double.TryParse(textBox.Text, out value))
				return true;
			else
				return false;
		}
	}
}
