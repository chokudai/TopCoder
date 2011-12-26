using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CubeStickers {
public string isPossible(string[] sticker) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"cyan","magenta","yellow","purple","black","white","purple"}; string Arg1 = "YES"; verify_case(0, Arg1, isPossible(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"blue","blue","blue","blue","blue","blue","blue","blue","blue","blue"}; string Arg1 = "NO"; verify_case(1, Arg1, isPossible(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"red","yellow","blue","red","yellow","blue","red","yellow","blue"}; string Arg1 = "YES"; verify_case(2, Arg1, isPossible(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"purple","orange","orange","purple","black","orange","purple"}; string Arg1 = "NO"; verify_case(3, Arg1, isPossible(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"white","gray","green","blue","yellow","red","target","admin"}; string Arg1 = "YES"; verify_case(4, Arg1, isPossible(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CubeStickers ___test = new CubeStickers();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
