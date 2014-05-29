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

namespace nurl {
	
	/// <summary>
	/// Description of FileManager.
	/// </summary>
	public class FileManager {
		
		private Stream fileStream;
		
		public FileManager() {
			
		}
		
		public FileManager (string path) {
			this.fileStream = File.Create(path);
		}
		
		public static Boolean fileExiste(string url) {
			return File.Exists(url);
		}
	}
}
