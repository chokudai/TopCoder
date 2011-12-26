using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MuddyRoad {
public double getExpectedValue(int[] road) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{0, 60, 60, 0}; double Arg1 = 0.36; verify_case(0, Arg1, getExpectedValue(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{0, 50, 50, 50, 50, 0}; double Arg1 = 0.5625; verify_case(1, Arg1, getExpectedValue(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{0, 0, 100, 100, 100, 100, 100, 100, 0, 0, 100, 0}; double Arg1 = 3.0; verify_case(2, Arg1, getExpectedValue(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{0, 12, 34, 56, 78, 91, 23, 45, 67, 89, 0}; double Arg1 = 1.7352539420031923; verify_case(3, Arg1, getExpectedValue(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{0, 50, 50, 100, 50, 100, 50, 50, 100, 66, 0}; double Arg1 = 2.288125; verify_case(4, Arg1, getExpectedValue(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MuddyRoad ___test = new MuddyRoad();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
