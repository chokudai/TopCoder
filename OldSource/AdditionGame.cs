using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AdditionGame {
    public int getMaximumPoints(int A, int B, int C, int N)
    {
        int[] ar = new int[3] { A, B, C };
        int i;
        int point = 0;
        for (i = 0; i < N; i++)
        {
            Array.Sort(ar);
            point += ar[2];
            if (ar[2] >= 1) ar[2]--;
        }
        return point;
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
	private void test_case_0() { int Arg0 = 3; int Arg1 = 4; int Arg2 = 5; int Arg3 = 3; int Arg4 = 13; verify_case(0, Arg4, getMaximumPoints(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 1; int Arg3 = 8; int Arg4 = 3; verify_case(1, Arg4, getMaximumPoints(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 3; int Arg1 = 5; int Arg2 = 48; int Arg3 = 40; int Arg4 = 1140; verify_case(2, Arg4, getMaximumPoints(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 36; int Arg1 = 36; int Arg2 = 36; int Arg3 = 13; int Arg4 = 446; verify_case(3, Arg4, getMaximumPoints(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int Arg0 = 8; int Arg1 = 2; int Arg2 = 6; int Arg3 = 13; int Arg4 = 57; verify_case(4, Arg4, getMaximumPoints(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
AdditionGame ___test = new AdditionGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
