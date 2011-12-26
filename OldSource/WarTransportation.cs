using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class WarTransportation {
public int messenger(int n, string[] highways) {

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
	private void test_case_0() { int Arg0 = 3; string[] Arg1 = new string[]{"1 2 1,1 3 2,3 2 3"}; int Arg2 = 5; verify_case(0, Arg2, messenger(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 8; string[] Arg1 = new string[]{"1 3 1,1 4 1,3 5 1,4 5 1,5 6 1,6 7 1,6 8 1,7 2 1,",
 "8 2 1"}; int Arg2 = -1; verify_case(1, Arg2, messenger(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 4; string[] Arg1 = new string[]{"1 3 1,1 3 2,3 2 1,1 4 1,4 2 1"}; int Arg2 = -1; verify_case(2, Arg2, messenger(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 4; string[] Arg1 = new string[]{"1 3 1,3 2 1,1 4 1,4 2 1,3 4 1"}; int Arg2 = 3; verify_case(3, Arg2, messenger(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 20; string[] Arg1 = new string[]{"1 13 3,13 4 7,4 3 4,3 10 8,10 18 9,18 12 6,12 2 3,",
 "1 17 6,17 13 6,13 9 4,9 10 8,10 7 2,7 5 5,5 19 9,1",
 "9 14 6,14 16 9,16 18 7,18 15 5,15 20 3,20 12 9,12 ",
 "8 4,8 11 3,11 4 1,4 3 7,3 2 3,20 10 2,1 18 2,16 19",
 " 9,4 15 9,13 15 6"}; int Arg2 = 23; verify_case(4, Arg2, messenger(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
WarTransportation ___test = new WarTransportation();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
