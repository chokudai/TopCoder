using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NotTwo {
    public int maxStones(int width, int height)
    {
        int i, j;
        int[,] memo = new int[1005, 1005];
        for (i = 0; i < 1005; i++)
        {
            for (j = 0; j < 1005; j++)
            {
                memo[i, j] = 0;
            }
        }
        int res = 0;
        for (i = 2; i < width+2; i++)
        {
            for (j = 2; j < height+2; j++)
            {
                if (memo[i - 2,j] == 0 && memo[i,j - 2] == 0)
                {
                    res++;
                    memo[i, j] = 1;
                }
            }
        }
        return res;
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
	private void test_case_0() { int Arg0 = 3; int Arg1 = 2; int Arg2 = 4; verify_case(0, Arg2, maxStones(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 3; int Arg1 = 3; int Arg2 = 5; verify_case(1, Arg2, maxStones(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 8; int Arg1 = 5; int Arg2 = 20; verify_case(2, Arg2, maxStones(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
NotTwo ___test = new NotTwo();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
