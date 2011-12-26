using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SimpleGuess {
    public int getMaximum(int[] hints)
    {
        int i, j;
        int len = hints.Length;
        Array.Sort(hints);
        int res = -1;
        for (i = 0; i < len; i++)
        {
            for (j = i + 1; j < len; j++)
            {
                int XX = hints[i] + hints[j];
                if (XX % 2 != 0) continue;
                int X = XX / 2;
                int Y = hints[j] - X;
                if (Y < 0) continue;
                res = Math.Max(X * Y, res);
            }
        }
        return res;
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
	private void test_case_0() { int[] Arg0 = new int[]{ 1, 4, 5 }; int Arg1 = 6; verify_case(0, Arg1, getMaximum(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{ 1, 4, 5, 8 }; int Arg1 = 12; verify_case(1, Arg1, getMaximum(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{ 9, 8, 7, 6, 5, 4, 3, 2, 1 }; int Arg1 = 20; verify_case(2, Arg1, getMaximum(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{ 2, 100 }; int Arg1 = 2499; verify_case(3, Arg1, getMaximum(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{ 50, 58, 47, 57, 40 }; int Arg1 = 441; verify_case(4, Arg1, getMaximum(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SimpleGuess ___test = new SimpleGuess();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
