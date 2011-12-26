using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LotteryPyaterochka {

    public double chanceToWin(int N)
    {
        return calc(5);
    }

    public double calc(int N)
    {
        double[,] dp = new double[N + 2, N + 2];
        int i, j, k;
        double res = 0;
        dp[0, 0] = 1;
        for (i = 0; i < 5; i++)
        {
            double[,] nextdp = new double[N + 2, N + 2];
            for (j = 0; j <= N; j++)
            {
                for (k = 0; j + k <= N; k++)
                {
                    if (j * 2 + k != i) continue;
                    if (j != 0) res += dp[j, k] * j / N;
                    if (k != 0) nextdp[j + 1, k - 1] += dp[j, k] * k / N;
                    nextdp[j, k + 1] += dp[j, k] * (N - k - j) / N;
                }
            }
            dp = (double[,])nextdp.Clone();
        }
        return res;
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
	private void test_case_0() { int Arg0 = 1; double Arg1 = 1.0; verify_case(0, Arg1, chanceToWin(Arg0)); }
	private void test_case_1() { int Arg0 = 2; double Arg1 = 1.0; verify_case(1, Arg1, chanceToWin(Arg0)); }
	private void test_case_2() { int Arg0 = 3; double Arg1 = 0.5004995004995004; verify_case(2, Arg1, chanceToWin(Arg0)); }
	private void test_case_3() { int Arg0 = 6; double Arg1 = 0.13161551092585574; verify_case(3, Arg1, chanceToWin(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
LotteryPyaterochka ___test = new LotteryPyaterochka();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
