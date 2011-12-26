using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheLuckyGameDivOne {
public int find(long a, long b, long jLen, long bLen) {

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
	private void test_case_0() { long Arg0 = 1l; long Arg1 = 10l; long Arg2 = 2l; long Arg3 = 1l; int Arg4 = 0; verify_case(0, Arg4, find(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { long Arg0 = 1l; long Arg1 = 100l; long Arg2 = 100l; long Arg3 = 100l; int Arg4 = 6; verify_case(1, Arg4, find(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { long Arg0 = 4l; long Arg1 = 8l; long Arg2 = 3l; long Arg3 = 2l; int Arg4 = 1; verify_case(2, Arg4, find(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { long Arg0 = 1l; long Arg1 = 100l; long Arg2 = 75l; long Arg3 = 50l; int Arg4 = 2; verify_case(3, Arg4, find(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheLuckyGameDivOne ___test = new TheLuckyGameDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
