using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Reflections {
public long minimumMoves(int[] mirrorX, int[] mirrorY, int[] mirrorZ, int[] finalPosition) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{2}; int[] Arg1 = new int[]{}; int[] Arg2 = new int[]{}; int[] Arg3 = new int[]{3, 0, 1}; long Arg4 = 3l; verify_case(0, Arg4, minimumMoves(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int[] Arg0 = new int[]{-5, 1, 4, 2, 3, 6, -6}; int[] Arg1 = new int[]{}; int[] Arg2 = new int[]{}; int[] Arg3 = new int[]{9, 0, 0}; long Arg4 = 2l; verify_case(1, Arg4, minimumMoves(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int[] Arg0 = new int[]{5, 8}; int[] Arg1 = new int[]{}; int[] Arg2 = new int[]{}; int[] Arg3 = new int[]{4, 0, 0}; long Arg4 = 4l; verify_case(2, Arg4, minimumMoves(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int[] Arg0 = new int[]{5}; int[] Arg1 = new int[]{5}; int[] Arg2 = new int[]{1, 2, 3}; int[] Arg3 = new int[]{10, 12, -1}; long Arg4 = 5l; verify_case(3, Arg4, minimumMoves(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int[] Arg0 = new int[]{8, -3, 21}; int[] Arg1 = new int[]{4, 5}; int[] Arg2 = new int[]{-7, -2, -1, 7, 14}; int[] Arg3 = new int[]{40, -4, 31}; long Arg4 = 10l; verify_case(4, Arg4, minimumMoves(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Reflections ___test = new Reflections();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
