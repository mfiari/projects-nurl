/*
 * Created by SharpDevelop.
 * User: mike
 * Date: 28/05/2014
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;

namespace nurl
{
	/// <summary>
	/// Description of Command.
	/// </summary>
	public class Command {
		
		public Command() {
			
		}
		
		public string show (string url) {
			return "<h1>hello</h1>";
		}
		
		public void save (string url, string filename) {
			Stream fileStream = File.Create(filename);
			if (fileStream != null) {
				StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8);
				writer.Write("<h1>hello</h1>");
				writer.Dispose();
			}
		}
 		
	}
}
