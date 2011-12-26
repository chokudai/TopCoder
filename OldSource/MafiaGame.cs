using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MafiaGame {
public double probabilityToLose(int N, int[] decisions) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 3; int[] Arg1 = new int[]{1, 1, 1}; double Arg2 = 1.0; verify_case(0, Arg2, probabilityToLose(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 5; int[] Arg1 = new int[]{1, 2, 3}; double Arg2 = 0.0; verify_case(1, Arg2, probabilityToLose(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 20; int[] Arg1 = new int[]{1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 6, 7, 18, 19, 0}; double Arg2 = 0.0; verify_case(2, Arg2, probabilityToLose(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 23; int[] Arg1 = new int[]{17, 10, 3, 14, 22, 5, 11, 10, 22, 3, 14, 5, 11, 17}; double Arg2 = 0.14285714285714285; verify_case(3, Arg2, probabilityToLose(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MafiaGame ___test = new MafiaGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
