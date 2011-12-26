using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PeopleYouMayKnow {
public int maximalScore(string[] friends, int person1, int person2) {

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
	private void test_case_0() { string[] Arg0 = new string[]{"NN"
,"NN"}; int Arg1 = 0; int Arg2 = 1; int Arg3 = 0; verify_case(0, Arg3, maximalScore(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string[] Arg0 = new string[]{"NYNN"
,"YNYN"
,"NYNY"
,"NNYN"}; int Arg1 = 0; int Arg2 = 3; int Arg3 = 1; verify_case(1, Arg3, maximalScore(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string[] Arg0 = new string[]{"NYNYYYN"
,"YNYNNYY"
,"NYNNNNY"
,"YNNNNNN"
,"YNNNNYN"
,"YYNNYNY"
,"NYYNNYN"}; int Arg1 = 2; int Arg2 = 3; int Arg3 = 1; verify_case(2, Arg3, maximalScore(Arg0, Arg1, Arg2)); }
	private void test_case_3() { string[] Arg0 = new string[]{"NYYYYNNNN"
,"YNNNNYYYN"
,"YNNNNNNYN"
,"YNNNNNNYN"
,"YNNNNNNNY"
,"NYNNNNNNY"
,"NYNNNNNNY"
,"NYYYNNNNY"
,"NNNNYYYYN"}; int Arg1 = 8; int Arg2 = 0; int Arg3 = 3; verify_case(3, Arg3, maximalScore(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PeopleYouMayKnow ___test = new PeopleYouMayKnow();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
