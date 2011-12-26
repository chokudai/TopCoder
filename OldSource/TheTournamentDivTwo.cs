using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheTournamentDivTwo {
public int find(int[] points) {

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
	private void test_case_0() { int[] Arg0 = new int[]{10, 1, 1}; int Arg1 = 6; verify_case(0, Arg1, find(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{1, 1, 1}; int Arg1 = -1; verify_case(1, Arg1, find(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{0, 0, 0, 0, 0, 0, 0}; int Arg1 = 0; verify_case(2, Arg1, find(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{13, 8, 7}; int Arg1 = 14; verify_case(3, Arg1, find(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheTournamentDivTwo ___test = new TheTournamentDivTwo();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
