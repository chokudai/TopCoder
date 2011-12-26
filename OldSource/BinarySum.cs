using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BinarySum {
    public int rearrange(int a, int b, int c)
    {
        int x = 0;
        int i, j, k, l, m, n,myon;
        int bita, bitb, bitc;
        bita = bitb = bitc = 0;
        for (i = 0; ; i++)
        {
            if ((a >> i) + (b >> i) + (c >> i) == 0) break;
            if ((a >> i) % 2 == 1) bita++;
            if ((b >> i) % 2 == 1) bitb++;
            if ((c >> i) % 2 == 1) bitc++;
        }
        x = i;
        long ma = long.MaxValue >> 1;

        long[,,,] dp = new long[bita + 1, bitb + 1, bitc + 1, 2];//usea, useb, kuriagari 
        for (j = 0; j <= bita; j++)
        {
            for (k = 0; k <= bitb; k++)
            {
                for (l = 0; l < 2; l++)
                {
                    for (myon = 0; myon <= bitc; myon++)
                    {
                        dp[j, k, myon, l] = ma;
                    }
                }
            }
        }
        dp[0, 0, 0, 0] = 0;
        for (i = 0; i < x; i++)
        {
            long[,,,] nextdp = new long[bita + 1, bitb + 1,bitc + 1, 2];
            for (j = 0; j <= bita; j++)
            {
                for (k = 0; k <= bitb; k++)
                {
                    for (l = 0; l < 2; l++)
                    for (myon = 0; myon <= bitc; myon++)
                    {
                        nextdp[j, k, myon, l] = ma;
                    }
                }
            }
            for (j = 0; j <= bita; j++)
            {
                for (k = 0; k <= bitb; k++)
                {
                    for (l = 0; l < 2; l++)
                    {
                        for (myon = 0; myon <= bitc; myon++)
                        {
                            if (dp[j, k, myon, l] == ma) continue;
                            for (m = 0; m < 2; m++)
                            {
                                for (n = 0; n < 2; n++)
                                {
                                    int J, K;
                                    J = j + m;
                                    K = k + n;
                                    if (J > bita || K > bitb) continue;
                                    int kuri = (m + n + l) / 2;
                                    int aaa = (m + n + l) % 2;
                                    int Myon = myon + aaa;
                                    if (Myon > bitc) continue;
                                    nextdp[J, K, Myon, kuri] = Math.Min(dp[j, k, myon, l] + (m + n) * ((long)1 << i), nextdp[J, K, Myon, kuri]);
                                }
                            }
                        }
                    }
                }
            }
            dp = (long[, , ,])nextdp.Clone();
        }
        if (dp[bita, bitb, bitc, 0] == ma) return -1;
        if (dp[bita, bitb, bitc, 0] >= ((long)1 << x)) return -1;
        return (int)dp[bita, bitb, bitc, 0];
        
    }

    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 7; int Arg1 = 6; int Arg2 = 9; int Arg3 = 10; verify_case(0, Arg3, rearrange(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 2; int Arg3 = 2; verify_case(1, Arg3, rearrange(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 4; int Arg3 = 2; verify_case(2, Arg3, rearrange(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 3; int Arg1 = 3; int Arg2 = 9; int Arg3 = 6; verify_case(3, Arg3, rearrange(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 1; int Arg3 = -1; verify_case(4, Arg3, rearrange(Arg0, Arg1, Arg2)); }
	private void test_case_5() { int Arg0 = 32517565; int Arg1 = 204650420; int Arg2 = 4096; int Arg3 = -1; verify_case(5, Arg3, rearrange(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BinarySum ___test = new BinarySum();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
