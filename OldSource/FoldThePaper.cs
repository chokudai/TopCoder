using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FoldThePaper {
public int getValue(string[] paper) {

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
	private void test_case_0() { string[] Arg0 = new string[]{
"1 1 1",
"1 1 1"
}; int Arg1 = 6; verify_case(0, Arg1, getValue(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{
"1 -1",
"1 -1"
}; int Arg1 = 2; verify_case(1, Arg1, getValue(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{
"1 -1 -1 1",
"-1 -1 -1 -1",
"-1 -1 -1 -1",
"1 -1 -1 1"
}; int Arg1 = 4; verify_case(2, Arg1, getValue(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{
"20 13 -2 100",
"-12 0 4 -3",
"4 1 -36 21"
}; int Arg1 = 131; verify_case(3, Arg1, getValue(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{
"0"
}; int Arg1 = 0; verify_case(4, Arg1, getValue(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FoldThePaper ___test = new FoldThePaper();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
