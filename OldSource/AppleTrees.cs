using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AppleTrees {
public int theCount(int D, int[] r) {

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
	private void test_case_0() { int Arg0 = 10; int[] Arg1 = new int[]{40}; int Arg2 = 10; verify_case(0, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 4; int[] Arg1 = new int[]{1, 1, 1, 1}; int Arg2 = 24; verify_case(1, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 4; int[] Arg1 = new int[]{1, 1, 2}; int Arg2 = 4; verify_case(2, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 58; int[] Arg1 = new int[]{5, 8}; int Arg2 = 2550; verify_case(3, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 47; int[] Arg1 = new int[]{4, 8, 9}; int Arg2 = 28830; verify_case(4, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_5() { int Arg0 = 100000; int[] Arg1 = new int[]{21, 37, 23, 13, 32, 22, 9, 39}; int Arg2 = 923016564; verify_case(5, Arg2, theCount(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
AppleTrees ___test = new AppleTrees();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
