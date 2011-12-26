using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Roundabout {
public int clearUpTime(string north, string east, string south, string west) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); if ((Case == -1) || (Case == 7)) test_case_7(); if ((Case == -1) || (Case == 8)) test_case_8(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "--"; string Arg1 = "--"; string Arg2 = "WE"; string Arg3 = "-S"; int Arg4 = 6; verify_case(0, Arg4, clearUpTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { string Arg0 = "WWW"; string Arg1 = "NNN"; string Arg2 = "---"; string Arg3 = "---"; int Arg4 = 9; verify_case(1, Arg4, clearUpTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { string Arg0 = "SSS"; string Arg1 = "WW-"; string Arg2 = "N"; string Arg3 = "S------"; int Arg4 = 13; verify_case(2, Arg4, clearUpTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { string Arg0 = "SSS-"; string Arg1 = "--W---W"; string Arg2 = "WE"; string Arg3 = "-S"; int Arg4 = 14; verify_case(3, Arg4, clearUpTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { string Arg0 = "E"; string Arg1 = "-N"; string Arg2 = "W"; string Arg3 = "-S"; int Arg4 = 5; verify_case(4, Arg4, clearUpTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_5() { string Arg0 = ""; string Arg1 = ""; string Arg2 = ""; string Arg3 = ""; int Arg4 = 0; verify_case(5, Arg4, clearUpTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_6() { string Arg0 = "W"; string Arg1 = ""; string Arg2 = "--E"; string Arg3 = ""; int Arg4 = 6; verify_case(6, Arg4, clearUpTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_7() { string Arg0 = "ES"; string Arg1 = "N"; string Arg2 = "E"; string Arg3 = ""; int Arg4 = 9; verify_case(7, Arg4, clearUpTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_8() { string Arg0 = "E"; string Arg1 = "SN"; string Arg2 = "-N"; string Arg3 = "S-E"; int Arg4 = 12; verify_case(8, Arg4, clearUpTime(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Roundabout ___test = new Roundabout();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
