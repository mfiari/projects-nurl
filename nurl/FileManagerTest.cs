/*
 * Created by SharpDevelop.
 * User: mike
 * Date: 29/05/2014
 * Time: 11:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace nurl {
	
	[TestFixture]
	public class FileManagerTest {
		
		[Test]
		public void TestCreate() {
			FileManager fileManager = new FileManager("test.txt");
			Assert.True(FileManager.fileExiste("test.txt"));
		}
		
		[Test]
		public void TestFileExist() {
			Assert.True(FileManager.fileExiste("test.txt"));
		}
		
		[Test]
		public void TestFileNotExist() {
			Assert.False(FileManager.fileExiste("toto.txt"));
		}
		
		[Test]
		public void TestWrite() {
			FileManager fileManager = new FileManager("myFile.txt");
			fileManager.write("mon texte");
			var result = fileManager.getContent();
			Assert.AreEqual("mon texte", result, "not same");
		}
	}
}
