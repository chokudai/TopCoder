using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MaximizeSquares {
    public int squareCount(int N)
    {
        int i,j;
        int res = 0;
        for (i = 1; i <= N; i++)
        {
            int h = i;
            int w = N / i;
            int amari = N - h * w;
            int now = 0;
            for (j = 2; j <= Math.Min(h, w); j++)
            {
                now += (h - j + 1) * (w - j + 1);
            }
            for (j = 2; j <= Math.Min(amari, w + 1); j++)
            {
                now += amari - j + 1;
            }
            res = Math.Max(now, res);
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
	private void test_case_0() { int Arg0 = 4; int Arg1 = 1; verify_case(0, Arg1, squareCount(Arg0)); }
	private void test_case_1() { int Arg0 = 5; int Arg1 = 1; verify_case(1, Arg1, squareCount(Arg0)); }
	private void test_case_2() { int Arg0 = 6; int Arg1 = 2; verify_case(2, Arg1, squareCount(Arg0)); }
	private void test_case_3() { int Arg0 = 16; int Arg1 = 14; verify_case(3, Arg1, squareCount(Arg0)); }
	private void test_case_4() { int Arg0 = 115; int Arg1 = 340; verify_case(4, Arg1, squareCount(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MaximizeSquares ___test = new MaximizeSquares();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
