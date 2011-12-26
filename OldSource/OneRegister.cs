using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class OneRegister {
public string getProgram(int s, int t) {

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
	private void test_case_0() { int Arg0 = 7; int Arg1 = 392; string Arg2 = "+*+"; verify_case(0, Arg2, getProgram(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 7; int Arg1 = 256; string Arg2 = "/+***"; verify_case(1, Arg2, getProgram(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 4; int Arg1 = 256; string Arg2 = "**"; verify_case(2, Arg2, getProgram(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 7; int Arg1 = 7; string Arg2 = ""; verify_case(3, Arg2, getProgram(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 7; int Arg1 = 9; string Arg2 = ":-("; verify_case(4, Arg2, getProgram(Arg0, Arg1)); }
	private void test_case_5() { int Arg0 = 10; int Arg1 = 1; string Arg2 = "/"; verify_case(5, Arg2, getProgram(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
OneRegister ___test = new OneRegister();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
