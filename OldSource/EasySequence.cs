using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class EasySequence {
public int find(int[] A, int[] B) {

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
	private void test_case_0() { int[] Arg0 = new int[]{1,2,3}; int[] Arg1 = new int[]{0,7,8,5}; int Arg2 = 5; verify_case(0, Arg2, find(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{1,2,8}; int[] Arg1 = new int[]{7,4,2,3}; int Arg2 = -1; verify_case(1, Arg2, find(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{1,2,3,4,5}; int[] Arg1 = new int[]{4,5}; int Arg2 = 3; verify_case(2, Arg2, find(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{1}; int[] Arg1 = new int[]{1,1,1}; int Arg2 = 0; verify_case(3, Arg2, find(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
EasySequence ___test = new EasySequence();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
