using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheSequencesLevelThree {
    long mod = 1234567891;
    public int find(int[] sequence, int K)
    {
        Array.Sort(sequence);
        int len = sequence.Length;
        if (len <= 2) return 0;
        int i, j, k;
        long[,] dp = new long[len + 1, len + 1];
        for (i = 0; i <= len; i++)
        {
            for (j = 0; j <= len; j++) dp[i, j] = 0;
        }
        dp[0, 0] = 1;
        for (k = 0; k < len; k++)
        {
            long[,] nextdp = new long[len + 1, len + 1];
            for (i = 0; i < len; i++)
            {
                for (j = 0; j < len; j++)
                {
                    if (dp[i, j] == 0) continue;
                    if (k == len - 1 && (i == 0 || j == 0)) continue;
                    if (i == 0 || Math.Abs(sequence[k] - sequence[i - 1]) <= K) { nextdp[k + 1, j] += dp[i, j]; nextdp[k + 1, j] %= mod; }
                    if (j == 0 || Math.Abs(sequence[k] - sequence[j - 1]) <= K) { nextdp[i, k + 1] += dp[i, j]; nextdp[i, k + 1] %= mod; }
                }
            }
            dp = (long[,])nextdp.Clone();
        }
        long res = 0;
        for (i = 1; i < len; i++)
        {
            if (Math.Abs(sequence[len - 1] - sequence[i - 1]) <= K)
            {
                res += dp[i, len];
            }
            res %= mod;
        }
        return (int)res;
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{1, 5, 10, 4}; int Arg1 = 10; int Arg2 = 6; verify_case(0, Arg2, find(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{1, 5, 10, 4}; int Arg1 = 6; int Arg2 = 4; verify_case(1, Arg2, find(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{4, 44, 7, 77}; int Arg1 = 1; int Arg2 = 0; verify_case(2, Arg2, find(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{96, 29, 21, 90, 46, 77, 31, 63, 79}; int Arg1 = 44; int Arg2 = 126; verify_case(3, Arg2, find(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheSequencesLevelThree ___test = new TheSequencesLevelThree();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
