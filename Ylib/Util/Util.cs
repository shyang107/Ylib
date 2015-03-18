using System;
using System.Text;

namespace Ylib.Util
{
	public static class Util
	{
		/// <summary>
		/// Pause and show the specified msg.
		/// </summary>
		/// <param name = "messages">Show the messages on the screen when the function is on.</param>
		public static void Pause (params string[] messages)
		{
			var msg = new StringBuilder ();

			if (messages.Length < 1)
				msg.AppendLine ("Press any to continue...");
			else {
				foreach (var str in messages) {
					msg.AppendLine (str);
				}
			}
					
			Console.WriteLine ("------------------------------------------------------------");
			Console.Write (msg.ToString ());
			Console.WriteLine ("------------------------------------------------------------");
			Console.ReadKey ();
		}

		public static string Spaces (int numOfSpaces)
		{
			StringBuilder str = new StringBuilder ();
			var n = (numOfSpaces <= 0) ? 1 : numOfSpaces;
			for (int i = 0; i < n; i++) {
				str.Append (" ");
			}
			return str.ToString ();
		}
	}
}

