using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheMoviesLevelThreeDivOne {
    public long find(int[] timeJ, int[] timeB)
    {
        return 0;
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
	private void test_case_0() { int[] Arg0 = new int[]{4, 4}; int[] Arg1 = new int[]{4, 4}; long Arg2 = 2l; verify_case(0, Arg2, find(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{1, 4}; int[] Arg1 = new int[]{4, 2}; long Arg2 = 1l; verify_case(1, Arg2, find(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{10, 10, 10, 10}; int[] Arg1 = new int[]{1, 1, 1, 10}; long Arg2 = 3l; verify_case(2, Arg2, find(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{1, 2, 3, 4, 5, 6, 7}; int[] Arg1 = new int[]{7, 6, 5, 4, 3, 2, 1}; long Arg2 = 98l; verify_case(3, Arg2, find(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheMoviesLevelThreeDivOne ___test = new TheMoviesLevelThreeDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
