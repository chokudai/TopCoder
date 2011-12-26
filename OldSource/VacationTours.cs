using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class VacationTours {
public int getIncome(string[] c, string[] d, int fee) {

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
	private void test_case_0() { string[] Arg0 = new string[]{"AAA",
 "AAA",
 "AAA"}; string[] Arg1 = new string[]{"ABJ",
 "JAB",
 "BJA"}; int Arg2 = 15; int Arg3 = 12; verify_case(0, Arg3, getIncome(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string[] Arg0 = new string[]{"AAAA",
 "AAAA",
 "AAAA",
 "AAAA"}; string[] Arg1 = new string[]{"AAAA",
 "AAAA",
 "AAAA",
 "AAAA"}; int Arg2 = 100; int Arg3 = 300; verify_case(1, Arg3, getIncome(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string[] Arg0 = new string[]{"A//",
 "/A/",
 "//A"}; string[] Arg1 = new string[]{"A//",
 "/A/",
 "//A"}; int Arg2 = 1000; int Arg3 = 0; verify_case(2, Arg3, getIncome(Arg0, Arg1, Arg2)); }
	private void test_case_3() { string[] Arg0 = new string[]{"AAA////",
 "/AA/A//",
 "//AA/A/",
 "A//AA//",
 "///AAA/",
 "///A/AA",
 "AA////A"}; string[] Arg1 = new string[]{"AKo////",
 "/AU/X//",
 "//AZ/o/",
 "j//AK//",
 "///XAo/",
 "///y/AK",
 "KP////A"}; int Arg2 = 1000; int Arg3 = 1809; verify_case(3, Arg3, getIncome(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
VacationTours ___test = new VacationTours();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
