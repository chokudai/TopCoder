using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TableSeating {
public double getExpected(int numTables, int[] probs) {

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
	private void test_case_0() { int Arg0 = 4; int[] Arg1 = new int[]{100}; double Arg2 = 4.0; verify_case(0, Arg2, getExpected(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 4; int[] Arg1 = new int[]{0,100}; double Arg2 = 3.3333333333333335; verify_case(1, Arg2, getExpected(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 5; int[] Arg1 = new int[]{0,0,0,0,0,50,50}; double Arg2 = 0.0; verify_case(2, Arg2, getExpected(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 12; int[] Arg1 = new int[]{9,9,9,9,9,9,9,9,9,9,10}; double Arg2 = 7.871087929710551; verify_case(3, Arg2, getExpected(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TableSeating ___test = new TableSeating();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
