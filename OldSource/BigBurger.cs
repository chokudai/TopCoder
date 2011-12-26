using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BigBurger {
public int maxWait(int[] arrival, int[] service) {

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
	private void test_case_0() { int[] Arg0 = new int[]{3,3,9}; int[] Arg1 = new int[]{2,15,14}; int Arg2 = 11; verify_case(0, Arg2, maxWait(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{182}; int[] Arg1 = new int[]{11}; int Arg2 = 0; verify_case(1, Arg2, maxWait(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{2,10,11}; int[] Arg1 = new int[]{3,4,3}; int Arg2 = 3; verify_case(2, Arg2, maxWait(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{2,10,12}; int[] Arg1 = new int[]{15,1,15}; int Arg2 = 7; verify_case(3, Arg2, maxWait(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BigBurger ___test = new BigBurger();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
