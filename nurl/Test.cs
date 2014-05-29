/*
 * Created by SharpDevelop.
 * User: mike
 * Date: 28/05/2014
 * Time: 14:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace nurl {
	
	[TestFixture]
	public class Test {
		
		[Test]
		public void TestShow() {
			Command commande = new Command ();
			var url = "http://fake";
			var result = commande.show(url);
			Assert.AreEqual("<h1>hello</h1>", result, "not same");
		}
		
		[Test]
		public void TestSave() {
			Command commande = new Command ();
			var url = "http://fake";
			var filename = "fake.txt";
			commande.save(url, filename);
			Assert.True(true);
		}
	}
}
