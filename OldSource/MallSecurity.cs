using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MallSecurity {
public int maxGuards(int N, string[] escDescription) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 10; string[] Arg1 = new string[]{"1 1 1,1 1 2,1 1 3,1 1 4,1 1 5,1 1 6,1 1 7,1 1 8,1 ", 
 "1 9,1 1 10"}; int Arg2 = 5; verify_case(0, Arg2, maxGuards(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 11; string[] Arg1 = new string[]{"1 1 1,1 1 2,1 1 3,1 1 4,1 1 5,1 1 6,1 1 7,1 1 8,1 ", 
 "1 9,1 1 10"}; int Arg2 = 6; verify_case(1, Arg2, maxGuards(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 10; string[] Arg1 = new string[]{"1 1 7,1 2 9,2 1", 
 " 8,1 2 6,1 1 8,1 2 3,1 2 2,2 ", 
 "2 4,1 1 1,2 1 2,3 2 3,1 1 5,2 1 1,4 ", 
 "1 7,1 1 10,3 2 5,1 2 5,3 3 1,", 
 "3 2 8,3 1 2,1 1 3,4 4 2,2", 
 " 4 6,4 2 5,2 3 3,6 4 1,5 2 8,1 3 6,1 3 7,", 
 "4 3 8,1 3 8,5 2 3,4 2 8,2 6 7,1 3 9,", 
 "1 1 4,6 1 1,2 3 1,5 1 5,6 1 8,5 ", 
 "2 2,3 2 10,3 3 9,1 5 2,4 1 1,1 5 10"}; int Arg2 = 25; verify_case(2, Arg2, maxGuards(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MallSecurity ___test = new MallSecurity();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
