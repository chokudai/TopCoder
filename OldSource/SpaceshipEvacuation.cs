using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SpaceshipEvacuation {
public int additionalCabins(int N, string[] tunnelNetwork, int crewSize) {

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
	private void test_case_0() { int Arg0 = 3; string[] Arg1 = new string[]{"0 1 5 3",
 "2 1 0 0"}; int Arg2 = 5; int Arg3 = 7; verify_case(0, Arg3, additionalCabins(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 3; string[] Arg1 = new string[]{"0 1 0 2",
 "0 2 0 4"}; int Arg2 = 5; int Arg3 = 4; verify_case(1, Arg3, additionalCabins(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 4; string[] Arg1 = new string[]{"0 1 0 6",
 "3 2 3 1",
 "2 1 0 1",
 "3 1 2 2"}; int Arg2 = 6; int Arg3 = 6; verify_case(2, Arg3, additionalCabins(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 10; string[] Arg1 = new string[]{"0 1 11 101",
 "1 2 0 100",
 "2 3 20 100",
 "3 4 0 107",
 "4 1 66 0",
 "3 5 104 2",
 "4 6 82 0",
 "5 7 25 25",
 "7 8 14 42",
 "8 9 0 94",
 "9 5 17 92"}; int Arg2 = 110; int Arg3 = 376; verify_case(3, Arg3, additionalCabins(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int Arg0 = 3; string[] Arg1 = new string[]{"0 1 0 0"}; int Arg2 = 1; int Arg3 = -1; verify_case(4, Arg3, additionalCabins(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SpaceshipEvacuation ___test = new SpaceshipEvacuation();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
