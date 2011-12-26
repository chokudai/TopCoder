using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class VerySmoothDecompositions {
public int solve(string[] digits) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"47"}; int Arg1 = 0; verify_case(0, Arg1, solve(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"2"}; int Arg1 = 1; verify_case(1, Arg1, solve(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"10"}; int Arg1 = 2; verify_case(2, Arg1, solve(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"36"}; int Arg1 = 7; verify_case(3, Arg1, solve(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"1","21"}; int Arg1 = 1; verify_case(4, Arg1, solve(Arg0)); }
	private void test_case_5() { string[] Arg0 = new string[]{"1024"}; int Arg1 = 23; verify_case(5, Arg1, solve(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
VerySmoothDecompositions ___test = new VerySmoothDecompositions();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
