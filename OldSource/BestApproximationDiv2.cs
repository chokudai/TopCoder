using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BestApproximationDiv2 {
public string findFraction(int maxDen, string number) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 42; string Arg1 = "0.141592658"; string Arg2 = "1/7 has 3 exact digits"; verify_case(0, Arg2, findFraction(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 3; string Arg1 = "0.1337"; string Arg2 = "0/1 has 1 exact digits"; verify_case(1, Arg2, findFraction(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 80000; string Arg1 = "0.1234567891011121314151617181920"; string Arg2 = "10/81 has 8 exact digits"; verify_case(2, Arg2, findFraction(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 1000; string Arg1 = "0.42"; string Arg2 = "3/7 has 3 exact digits"; verify_case(3, Arg2, findFraction(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 100; string Arg1 = "0.420"; string Arg2 = "21/50 has 4 exact digits"; verify_case(4, Arg2, findFraction(Arg0, Arg1)); }
	private void test_case_5() { int Arg0 = 115; string Arg1 = "0.141592658"; string Arg2 = "16/113 has 7 exact digits"; verify_case(5, Arg2, findFraction(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BestApproximationDiv2 ___test = new BestApproximationDiv2();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
