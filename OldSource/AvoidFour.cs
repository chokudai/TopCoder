using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AvoidFour {
public int count(long n) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { long Arg0 = 4l; int Arg1 = 9998; verify_case(0, Arg1, count(Arg0)); }
	private void test_case_1() { long Arg0 = 5l; int Arg1 = 99980; verify_case(1, Arg1, count(Arg0)); }
	private void test_case_2() { long Arg0 = 87l; int Arg1 = 576334228; verify_case(2, Arg1, count(Arg0)); }
	private void test_case_3() { long Arg0 = 88l; int Arg1 = 576334228; verify_case(3, Arg1, count(Arg0)); }
	private void test_case_4() { long Arg0 = 4128l; int Arg1 = 547731225; verify_case(4, Arg1, count(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
AvoidFour ___test = new AvoidFour();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
