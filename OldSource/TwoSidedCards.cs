using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TwoSidedCards {
public int theCount(int[] taro, int[] hanako) {

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
	private void test_case_0() { int[] Arg0 = new int[]{1, 2, 3}; int[] Arg1 = new int[]{1, 3, 2}; int Arg2 = 12; verify_case(0, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{1, 2, 3}; int[] Arg1 = new int[]{1, 2, 3}; int Arg2 = 6; verify_case(1, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{1, 2}; int[] Arg1 = new int[]{2, 1}; int Arg2 = 4; verify_case(2, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{5, 8, 1, 2, 3, 4, 6, 7}; int[] Arg1 = new int[]{1, 2, 3, 4, 5, 6, 7, 8}; int Arg2 = 2177280; verify_case(3, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{41, 22, 17, 36, 26, 15, 10, 23, 33, 48, 49, 9, 34, 6, 21, 2, 46, 16, 25, 3, 24, 13, 40, 37, 35,
50, 44, 42, 31, 12, 29, 7, 43, 18, 30, 19, 45, 32, 39, 14, 8, 27, 1, 5, 38, 11, 4, 20, 47, 28}; int[] Arg1 = new int[]{19, 6, 23, 35, 17, 7, 50, 2, 33, 36, 12, 31, 46, 21, 30, 13, 47, 22, 44, 4, 25, 24, 3, 15, 20,
48, 10, 28, 26, 18, 5, 45, 49, 16, 40, 42, 43, 14, 1, 37, 29, 8, 41, 38, 9, 11, 34, 32, 39, 27}; int Arg2 = 529165844; verify_case(4, Arg2, theCount(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TwoSidedCards ___test = new TwoSidedCards();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
