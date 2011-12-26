using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CircuitDesign {
public int countPerms(int n, int[] top, int[] bottom) {

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
	private void test_case_0() { int Arg0 = 4; int[] Arg1 = new int[]{1,1,2,4,4}; int[] Arg2 = new int[]{1,2,2,2,3}; int Arg3 = 32; verify_case(0, Arg3, countPerms(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 2; int[] Arg1 = new int[]{1,2}; int[] Arg2 = new int[]{2,1}; int Arg3 = 2; verify_case(1, Arg3, countPerms(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 3; int[] Arg1 = new int[]{1,1,1,2,2,2,3,3,3}; int[] Arg2 = new int[]{1,2,3,1,2,3,1,2,3}; int Arg3 = 0; verify_case(2, Arg3, countPerms(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 30; int[] Arg1 = new int[]{5,5,5,5,5,5,5,5,5, 5,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30}; int[] Arg2 = new int[]{1,2,3,4,5,6,7,8,9,10,15,15,15,15,15,15,15,15,15,15,25,25,25,25,25,25,25,25,25,25}; int Arg3 = 628573100; verify_case(3, Arg3, countPerms(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int Arg0 = 5; int[] Arg1 = new int[]{1,2,3,4,5,1,2,3,4}; int[] Arg2 = new int[]{1,2,3,4,5,5,1,4,2}; int Arg3 = 2; verify_case(4, Arg3, countPerms(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CircuitDesign ___test = new CircuitDesign();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
