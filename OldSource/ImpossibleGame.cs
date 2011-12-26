using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ImpossibleGame {
public long getMinimum(int k, string[] before, string[] after) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 1; string[] Arg1 = new string[]{ "A" }
; string[] Arg2 = new string[]{ "B" }
; long Arg3 = 2l; verify_case(0, Arg3, getMinimum(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 2; string[] Arg1 = new string[]{ "A", "A", "D" }
; string[] Arg2 = new string[]{ "B", "C", "D" }
; long Arg3 = 5l; verify_case(1, Arg3, getMinimum(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 2; string[] Arg1 = new string[]{ "B", "C", "D" }
; string[] Arg2 = new string[]{ "C", "D", "B" }
; long Arg3 = 9l; verify_case(2, Arg3, getMinimum(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 6; string[] Arg1 = new string[]{ "AABBC", "AAAADA", "AAACA", "CABAA", "AAAAAA", "BAAAA" }
; string[] Arg2 = new string[]{ "AACCB", "DAAABC", "AAAAD", "ABCBA", "AABAAA", "AACAA" }
; long Arg3 = 499l; verify_case(3, Arg3, getMinimum(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ImpossibleGame ___test = new ImpossibleGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
