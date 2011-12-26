using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RowOfColors {
public int countWays(int w, int h, int k) {

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
	private void test_case_0() { int Arg0 = 4; int Arg1 = 1; int Arg2 = 2; int Arg3 = 6; verify_case(0, Arg3, countWays(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 4; int Arg1 = 3; int Arg2 = 2; int Arg3 = 12; verify_case(1, Arg3, countWays(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 4; int Arg1 = 4; int Arg2 = 10; int Arg3 = 0; verify_case(2, Arg3, countWays(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 14; int Arg1 = 28; int Arg2 = 14; int Arg3 = 178290591; verify_case(3, Arg3, countWays(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RowOfColors ___test = new RowOfColors();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
