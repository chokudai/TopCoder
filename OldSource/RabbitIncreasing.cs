using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RabbitIncreasing {
public int getNumber(int[] leaving, int k) {

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
	private void test_case_0() { int[] Arg0 = new int[]{ 3 }; int Arg1 = 3; int Arg2 = 1; verify_case(0, Arg2, getNumber(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{ 5, 9 }; int Arg1 = 10; int Arg2 = 6; verify_case(1, Arg2, getNumber(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{ 5, 10, 15 }; int Arg1 = 19; int Arg2 = 212; verify_case(2, Arg2, getNumber(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{ 2 }; int Arg1 = 10000000; int Arg2 = 0; verify_case(3, Arg2, getNumber(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{ 195, 211, 227, 230, 260, 
  297, 346, 350, 403, 411, 
  428, 485, 594, 606, 876 }
; int Arg1 = 1000; int Arg2 = 975206486; verify_case(4, Arg2, getNumber(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RabbitIncreasing ___test = new RabbitIncreasing();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
