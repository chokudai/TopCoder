using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Loopy {
public int minLoop(string[] code) {

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
	private void test_case_0() { string[] Arg0 = new string[]{"RETURN", "IF 0 ELSE 1"}; int Arg1 = 0; verify_case(0, Arg1, minLoop(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"IF 1 ELSE 2","IF 1 ELSE 2","RETURN"}; int Arg1 = 1; verify_case(1, Arg1, minLoop(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"IF 1 ELSE 2","RETURN", "IF 3 ELSE 2", "IF 2 ELSE 3"}; int Arg1 = 0; verify_case(2, Arg1, minLoop(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"IF 1 ELSE 2","IF 3 ELSE 3","IF 4 ELSE 1",
 "IF 4 ELSE 5","RETURN","IF 0 ELSE 6",
 "IF 6 ELSE 6","IF 7 ELSE 2"}; int Arg1 = 5; verify_case(3, Arg1, minLoop(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Loopy ___test = new Loopy();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
