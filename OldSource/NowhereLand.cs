using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NowhereLand {
public int placeGuards(string[] cities, int k, string[] guards, string[] agencies) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{ "0111",
  "1000",
  "1000",
  "1000" }; int Arg1 = 1; string[] Arg2 = new string[]{ "0", "", "", "" }; string[] Arg3 = new string[]{ "0", "0", "", "0" }; int Arg4 = 1; verify_case(0, Arg4, placeGuards(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { string[] Arg0 = new string[]{ "011",
  "101",
  "110"  }; int Arg1 = 1; string[] Arg2 = new string[]{ "0", "", "" }; string[] Arg3 = new string[]{ "0", "", "" }; int Arg4 = 2; verify_case(1, Arg4, placeGuards(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { string[] Arg0 = new string[]{ "011",
  "101",
  "110"  }; int Arg1 = 1; string[] Arg2 = new string[]{ "", "", "" }	; string[] Arg3 = new string[]{ "0", "0", "0" }; int Arg4 = 0; verify_case(2, Arg4, placeGuards(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { string[] Arg0 = new string[]{ "010100",
  "101100",
  "010011",
  "110010",
  "001100",
  "001000" }; int Arg1 = 3; string[] Arg2 = new string[]{ "1 2", "", "1", "", "0", "0" }; string[] Arg3 = new string[]{ "0 1 2", "0 1", "0 1 2", "1 2", "0", "0" }; int Arg4 = 7; verify_case(3, Arg4, placeGuards(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
NowhereLand ___test = new NowhereLand();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
