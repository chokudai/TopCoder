using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheLockDivOne {
public string password(int n, long k) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 2; long Arg1 = 4l; string Arg2 = "11"; verify_case(0, Arg2, password(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 3; long Arg1 = 8l; string Arg2 = "111"; verify_case(1, Arg2, password(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 4; long Arg1 = 6l; string Arg2 = "0110"; verify_case(2, Arg2, password(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 10; long Arg1 = 1l; string Arg2 = "0000000000"; verify_case(3, Arg2, password(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 7; long Arg1 = 100l; string Arg2 = "1111110"; verify_case(4, Arg2, password(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheLockDivOne ___test = new TheLockDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
