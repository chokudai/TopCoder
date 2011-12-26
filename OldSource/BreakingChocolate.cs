using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BreakingChocolate {
public int minSteps(int W, int H, int[] sx, int[] sy) {

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
	private void test_case_0() { int Arg0 = 3; int Arg1 = 3; int[] Arg2 = new int[]{2}; int[] Arg3 = new int[]{2}; int Arg4 = 4; verify_case(0, Arg4, minSteps(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 2; int[] Arg2 = new int[]{1,2}; int[] Arg3 = new int[]{2,1}; int Arg4 = 3; verify_case(1, Arg4, minSteps(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 10; int Arg1 = 10; int[] Arg2 = new int[]{1}; int[] Arg3 = new int[]{1}; int Arg4 = 2; verify_case(2, Arg4, minSteps(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 10; int Arg1 = 10; int[] Arg2 = new int[]{3,5,6}; int[] Arg3 = new int[]{5,5,5}; int Arg4 = 6; verify_case(3, Arg4, minSteps(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int Arg0 = 3; int Arg1 = 3; int[] Arg2 = new int[]{1,1,1,2,2,3,3,3}; int[] Arg3 = new int[]{1,2,3,1,3,1,2,3}; int Arg4 = 4; verify_case(4, Arg4, minSteps(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BreakingChocolate ___test = new BreakingChocolate();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
