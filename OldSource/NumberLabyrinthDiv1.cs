using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NumberLabyrinthDiv1 {
    public int getNumberOfPaths(int[] X, int[] Y, int[] val, int xFinish, int yFinish, int K)
    {
        if (K < 2) return 0;

    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{}; int[] Arg1 = new int[]{}; int[] Arg2 = new int[]{}; int Arg3 = 3; int Arg4 = 3; int Arg5 = 2; int Arg6 = 2; verify_case(0, Arg6, getNumberOfPaths(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_1() { int[] Arg0 = new int[]{}; int[] Arg1 = new int[]{}; int[] Arg2 = new int[]{}; int Arg3 = 3; int Arg4 = 3; int Arg5 = 3; int Arg6 = 14; verify_case(1, Arg6, getNumberOfPaths(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_2() { int[] Arg0 = new int[]{2}; int[] Arg1 = new int[]{2}; int[] Arg2 = new int[]{1}; int Arg3 = 3; int Arg4 = 3; int Arg5 = 3; int Arg6 = 18; verify_case(2, Arg6, getNumberOfPaths(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_3() { int[] Arg0 = new int[]{1, 3, 6}; int[] Arg1 = new int[]{1, 3, 6}; int[] Arg2 = new int[]{2, 2, 2}; int Arg3 = 5; int Arg4 = 5; int Arg5 = 4; int Arg6 = 210; verify_case(3, Arg6, getNumberOfPaths(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_4() { int[] Arg0 = new int[]{1, 19, 20, 21, 21, 21, 20, 19, 19}; int[] Arg1 = new int[]{1, 11, 11, 11, 10, 9, 9, 9, 10}; int[] Arg2 = new int[]{1, 2, 2, 2, 2, 2, 2, 2, 2}; int Arg3 = 20; int Arg4 = 10; int Arg5 = 4; int Arg6 = 1778; verify_case(4, Arg6, getNumberOfPaths(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_5() { int[] Arg0 = new int[]{13, 224, 77, 509, 1451, 43, 379, 142, 477}; int[] Arg1 = new int[]{1974, 375, 38, 783, 3, 1974, 1790, 1008, 2710}; int[] Arg2 = new int[]{30, 1845, 360, 11, 837, 84, 210, 4, 6704}; int Arg3 = 509; int Arg4 = 2011; int Arg5 = 10; int Arg6 = 196052726; verify_case(5, Arg6, getNumberOfPaths(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
NumberLabyrinthDiv1 ___test = new NumberLabyrinthDiv1();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
