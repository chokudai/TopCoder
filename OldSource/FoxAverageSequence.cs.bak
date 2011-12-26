using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FoxAverageSequence {
    public int theCount(int[] seq)
    {
        int i, j, k, l, m;
        long mod = 1000000007;
        long[, ,] dp = new long[3000, 41, 2];
        dp[0,0,0] = 1;
        for (i = 0; i < seq.Length; i++)
        {
            long[,,] nextdp = new long[3000, 41, 2];
            for (j = 0; j < 3000; j++)
            {
                for (l = 0; l <= 40; l++)
                {
                    for (m = 0; m < 2; m++)
                    {
                        if (dp[j, l, m] == 0) continue;
                        for (k = 0; k <= 40; k++)
                        {
                            if (seq[i] != -1 && seq[i] != k) continue;
                            if (k * i > j) continue;
                            if (k >= l)
                            {
                                nextdp[k + j, k, 0] += dp[j, l, m];
                                nextdp[k + j, k, 0] %= mod;
                            }
                            else if (m == 0)
                            {
                                nextdp[k + j, k, 1] += dp[j, l, m];
                                nextdp[k + j, k, 1] %= mod;
                            }
                        }
                    }
                }
            }
            dp = (long[,,])nextdp.Clone();
        }
        long res = 0;
        for (i = 0; i < 3000; i++)
        {
            for (j = 0; j <= 40; j++)
            {
                for (k = 0; k < 2; k++)
                {
                    res += dp[i, j, k];
                    res %= mod;
                }
            }
        }
        return (int)res;
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
	private void test_case_0() { int[] Arg0 = new int[]{3, -1}; int Arg1 = 4; verify_case(0, Arg1, theCount(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{5, 3, -1}; int Arg1 = 2; verify_case(1, Arg1, theCount(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{-1, 0, 40}; int Arg1 = 0; verify_case(2, Arg1, theCount(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{-1, 40, -1, -1, -1, 10, -1, -1, -1, 21, -1}; int Arg1 = 579347890; verify_case(3, Arg1, theCount(Arg0)); }
    //private void test_case_4() { int[] Arg0 = new int[] { -1, 12, 25, 0, 18, -1 }; int Arg1 = 58; verify_case(4, Arg1, theCount(Arg0)); }
    private void test_case_4() { int[] Arg0 = new int[] { -1}; int Arg1 = 41; verify_case(4, Arg1, theCount(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        FoxAverageSequence ___test = new FoxAverageSequence();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
