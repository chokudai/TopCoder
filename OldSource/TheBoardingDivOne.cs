using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheBoardingDivOne {
public long find(int[] pattern, int boardingTime) {

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
	private void test_case_0() { int[] Arg0 = new int[]{-1, -1}; int Arg1 = 100; long Arg2 = 1l; verify_case(0, Arg2, find(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{-1, 2, -1}; int Arg1 = 222; long Arg2 = 1l; verify_case(1, Arg2, find(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{2, 1, 3, 5, 4, 6}; int Arg1 = 155; long Arg2 = 1l; verify_case(2, Arg2, find(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{-1, -1, -1, -1, -1, -1, -1}; int Arg1 = 198; long Arg2 = 233l; verify_case(3, Arg2, find(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheBoardingDivOne ___test = new TheBoardingDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
