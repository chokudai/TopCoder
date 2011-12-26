using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FencingGarden {
public long computeWidth(int[] segment) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{1,1,1,1,10}; long Arg1 = 8l; verify_case(0, Arg1, computeWidth(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{50,25,25}; long Arg1 = 50l; verify_case(1, Arg1, computeWidth(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{5,7,9,13,21,581,1848,1058,57172,58281,612,528}; long Arg1 = 60078l; verify_case(2, Arg1, computeWidth(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FencingGarden ___test = new FencingGarden();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
