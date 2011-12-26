using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RowGame {
public long score(int[] board, int k) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{2,-2,4,3,-10} ; int Arg1 = 3; long Arg2 = 21l; verify_case(0, Arg2, score(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{-6,5}; int Arg1 = 10; long Arg2 = 0l; verify_case(1, Arg2, score(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{5,-6}; int Arg1 = 10; long Arg2 = 50l; verify_case(2, Arg2, score(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{10,-100,80}; int Arg1 = 3; long Arg2 = 30l; verify_case(3, Arg2, score(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{10,-100,80}; int Arg1 = 4; long Arg2 = 90l; verify_case(4, Arg2, score(Arg0, Arg1)); }
	private void test_case_5() { int[] Arg0 = new int[]{-100,1,2,3,4,5,6,7,8,9,10,11,12,13,14}; int Arg1 = 400000000; long Arg2 = 41999999900l; verify_case(5, Arg2, score(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RowGame ___test = new RowGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
