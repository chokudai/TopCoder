using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class KnightsOut {
public int count(int N, int M) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 2; int Arg1 = 3; int Arg2 = 4; verify_case(0, Arg2, count(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 3; int Arg1 = 3; int Arg2 = 1; verify_case(1, Arg2, count(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 7; int Arg1 = 5; int Arg2 = 16; verify_case(2, Arg2, count(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 1; verify_case(3, Arg2, count(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 69; int Arg1 = 142; int Arg2 = 77502052; verify_case(4, Arg2, count(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
KnightsOut ___test = new KnightsOut();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
