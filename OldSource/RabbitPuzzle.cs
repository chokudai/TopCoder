using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RabbitPuzzle {
    public int theCount(long[] rabbits, long[] nests, int K)
    {

    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); if ((Case == -1) || (Case == 7)) test_case_7(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { long[] Arg0 = new long[]{0, 5, 8}; long[] Arg1 = new long[]{0, 8, 11}; int Arg2 = 1; int Arg3 = 1; verify_case(0, Arg3, theCount(Arg0, Arg1, Arg2)); }
	private void test_case_1() { long[] Arg0 = new long[]{0, 5, 8}; long[] Arg1 = new long[]{0, 8, 11}; int Arg2 = 3; int Arg3 = 5; verify_case(1, Arg3, theCount(Arg0, Arg1, Arg2)); }
	private void test_case_2() { long[] Arg0 = new long[]{0, 5, 8}; long[] Arg1 = new long[]{0, 8, 11}; int Arg2 = 2; int Arg3 = 0; verify_case(2, Arg3, theCount(Arg0, Arg1, Arg2)); }
	private void test_case_3() { long[] Arg0 = new long[]{5, 8, 58}; long[] Arg1 = new long[]{13, 22, 64}; int Arg2 = 58; int Arg3 = 0; verify_case(3, Arg3, theCount(Arg0, Arg1, Arg2)); }
	private void test_case_4() { long[] Arg0 = new long[]{0, 1, 2}; long[] Arg1 = new long[]{1, 2, 3}; int Arg2 = 100; int Arg3 = 0; verify_case(4, Arg3, theCount(Arg0, Arg1, Arg2)); }
	private void test_case_5() { long[] Arg0 = new long[]{5, 8, 58}; long[] Arg1 = new long[]{20, 26, 61}; int Arg2 = 58; int Arg3 = 537851168; verify_case(5, Arg3, theCount(Arg0, Arg1, Arg2)); }
	private void test_case_6() { long[] Arg0 = new long[]{67, 281, 2348}; long[] Arg1 = new long[]{235, 1394, 3293}; int Arg2 = 83; int Arg3 = 167142023; verify_case(6, Arg3, theCount(Arg0, Arg1, Arg2)); }
	private void test_case_7() { long[] Arg0 = new long[]{-1000000000000000000, 999999999999999998, 999999999999999999}; long[] Arg1 = new long[]{-1000000000000000000, 999999999999999999, 1000000000000000000}; int Arg2 = 5; int Arg3 = 29; verify_case(7, Arg3, theCount(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RabbitPuzzle ___test = new RabbitPuzzle();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
