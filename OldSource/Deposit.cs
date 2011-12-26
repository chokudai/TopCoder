using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Deposit {
public double successProbability(int[] siteX, int[] siteY, int[] depositX, int[] depositY) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{0,4,4,0}; int[] Arg1 = new int[]{0,0,4,4}; int[] Arg2 = new int[]{1,2,2,1}; int[] Arg3 = new int[]{1,1,2,2}; double Arg4 = 0.6666666666666666; verify_case(0, Arg4, successProbability(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int[] Arg0 = new int[]{0,4,4,0}; int[] Arg1 = new int[]{0,0,4,4}; int[] Arg2 = new int[]{1,3,3,1}; int[] Arg3 = new int[]{1,1,3,3}; double Arg4 = 1.0; verify_case(1, Arg4, successProbability(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int[] Arg0 = new int[]{5,2,-1,0,4}; int[] Arg1 = new int[]{3,4,2,0,0}; int[] Arg2 = new int[]{3,3,4}; int[] Arg3 = new int[]{3,2,1}; double Arg4 = 0.6112700209855423; verify_case(2, Arg4, successProbability(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int[] Arg0 = new int[]{200,-99,-405,-601,-708,-494,-300,-88}; int[] Arg1 = new int[]{520,516,407,321,104,-97,-221,-101}; int[] Arg2 = new int[]{-101,-201,-296,-400,-402}; int[] Arg3 = new int[]{318,396,402,305,200}; double Arg4 = 0.49892756207100747; verify_case(3, Arg4, successProbability(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int[] Arg0 = new int[]{-3,6,10,10,-2}; int[] Arg1 = new int[]{-1,-10,-9,7,3}; int[] Arg2 = new int[]{3,5,6,4}; int[] Arg3 = new int[]{-5,-7,-6,-4}; double Arg4 = 0.16641662251521538; verify_case(4, Arg4, successProbability(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_5() { int[] Arg0 = new int[]{-2,4,-2}
; int[] Arg1 = new int[]{-2,-2,8}
; int[] Arg2 = new int[]{-1,0,0}
; int[] Arg3 = new int[]{0,-1,0}
; double Arg4 = 0.04518850219072291; verify_case(5, Arg4, successProbability(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Deposit ___test = new Deposit();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
