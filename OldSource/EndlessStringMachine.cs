using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class EndlessStringMachine {
public string getFragment(string input, string program, int s, int min, int max) {
    return "";
}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "a"; string Arg1 = "$meric$"; int Arg2 = 6; int Arg3 = 1; int Arg4 = 35; string Arg5 = "americamericamericamericamericameri"; verify_case(0, Arg5, getFragment(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { string Arg0 = "top"; string Arg1 = "$coder"; int Arg2 = 1; int Arg3 = 1; int Arg4 = 20; string Arg5 = "topcoder------------"; verify_case(1, Arg5, getFragment(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { string Arg0 = "abc"; string Arg1 = "$x$y$z$"; int Arg2 = 10; int Arg3 = 30; int Arg4 = 50; string Arg5 = "bcyabcxabcyabczabczab"; verify_case(2, Arg5, getFragment(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { string Arg0 = "xy"; string Arg1 = "$a$bb"; int Arg2 = 12; int Arg3 = 5000; int Arg4 = 5099; string Arg5 = "xybbbbaxyaxybbaxyaxybbbbbbbbaxyaxybbaxyaxybbbbaxyaxybbaxyaxybbbbbbaxyaxybbaxyaxybbbbaxyaxybbaxyaxybb"; verify_case(3, Arg5, getFragment(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
EndlessStringMachine ___test = new EndlessStringMachine();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
