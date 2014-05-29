/*
 * Created by SharpDevelop.
 * User: mike
 * Date: 28/05/2014
 * Time: 21:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;

namespace nurl {
	
	/// <summary>
	/// Description of FileManager.
	/// </summary>
	public class FileManager {
		
		private Stream fileStream;
		
		public FileManager() {
			
		}
		
		public FileManager (string path) {
			if (!fileExiste(path)) {
				this.fileStream = File.Create(path);
			} else {
				this.fileStream = File.Open(path, FileMode.Open);
			}
		}
		
		public static Boolean fileExiste(string url) {
			return File.Exists(url);
		}
		
		public void write (string texte) {
			if (this.fileStream != null) {
				StreamWriter writer = new StreamWriter(this.fileStream, Encoding.UTF8);
				writer.Write(texte);
				writer.Flush();
			}
		}
		
		public string getContent () {
			if (this.fileStream != null) {
				this.fileStream.Position = 0;
				StreamReader reader = new StreamReader(this.fileStream, Encoding.UTF8);
				string fileContent = reader.ReadToEnd();
				reader.Dispose();
				return fileContent;
			}
			return null;
		}
		
		public void close () {
			this.fileStream.Dispose();
		}
	}
}
