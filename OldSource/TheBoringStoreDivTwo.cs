using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheBoringStoreDivTwo {
public string find(string J, string B) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "StoreOfJohn"; string Arg1 = "StoreOfBrus"; string Arg2 = "or"; verify_case(0, Arg2, find(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "JohnAndJohn"; string Arg1 = "John"; string Arg2 = ""; verify_case(1, Arg2, find(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "JohnPlaysGames"; string Arg1 = "BrusAlsoPlays"; string Arg2 = "ays"; verify_case(2, Arg2, find(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "abacaba"; string Arg1 = "abacabadabacaba"; string Arg2 = "abaabacaba"; verify_case(3, Arg2, find(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheBoringStoreDivTwo ___test = new TheBoringStoreDivTwo();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
