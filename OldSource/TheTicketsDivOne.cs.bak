using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheTicketsDivOne {

    double[,] c;
    int MAX = 1010;

    public double find(int n, int m)
    {
        c = new double[MAX, MAX];
        makec();
        double[] dp = new double[n + 1];
        int i, j;
        dp[1] = 1;
        for (i = 2; i <= n; i++)
        {
            dp[i] = 1.0 / 6;
            for (j = 1; j < i; j++)
            {
                dp[i] += c[i - 1, j] * dp[i - j] / 2.0;
            }
            dp[i] /= 1 - (c[i - 1, 0] / 2.0);
        }
        double res = 0;
        for (j = 0; j < m; j++)
        {
            res += c[m - 1, j] * dp[n - j];
        }
        return res;
    }

    void makec()
    {
        int i, j;
        c[0, 0] = 1;
        for (i = 1; i < MAX; i++)
        {
            c[i, 0] = c[i - 1, 0] / 2;
            for (j = 1; j <= i; j++)
            {
                c[i, j] = c[i - 1, j - 1] / 3 + c[i - 1, j] / 2;
            }
        }
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 2; int Arg1 = 1; double Arg2 = 0.4444444444444444; verify_case(0, Arg2, find(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 2; double Arg2 = 0.5555555555555556; verify_case(1, Arg2, find(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = 1; double Arg2 = 1.0; verify_case(2, Arg2, find(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 3; int Arg1 = 2; double Arg2 = 0.31746031746031744; verify_case(3, Arg2, find(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheTicketsDivOne ___test = new TheTicketsDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
