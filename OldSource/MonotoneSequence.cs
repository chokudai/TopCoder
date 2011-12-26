using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MonotoneSequence {
    public int longestMonotoneSequence(int[] seq)
    {
        int len = seq.Length;
        int[] dp = new int[len];
        int res = 0;
        int i, j;
        for (i = 0; i < len; i++) dp[i] = 1;
        for (i = 0; i < len; i++)
        {
            for (j = Math.Max(i - 1, 0); j < i; j++)
            {
                if (seq[i] > seq[j])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }
        for (i = 0; i < len; i++)
        {
            res = Math.Max(res, dp[i]);
            //Console.WriteLine(dp[i]);
        }
        for (i = 0; i < len; i++) dp[i] = 1;
        for (i = 0; i < len; i++)
        {
            for (j = Math.Max(i - 1, 0); j < i; j++)
            {
                if (seq[i] < seq[j])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }
        for (i = 0; i < len; i++)
        {
            res = Math.Max(res, dp[i]);
            //Console.WriteLine(dp[i]);
        }
        return res;
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
	private void test_case_0() { int[] Arg0 = new int[]{1, 7, 7, 8, 3, 6, 7, 2}; int Arg1 = 3; verify_case(0, Arg1, longestMonotoneSequence(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{1, 1, 1, 1, 1}; int Arg1 = 1; verify_case(1, Arg1, longestMonotoneSequence(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{10, 20, 30, 25, 20, 19, 20, 18, 23}; int Arg1 = 4; verify_case(2, Arg1, longestMonotoneSequence(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{3, 2, 1, 4}; int Arg1 = 3; verify_case(3, Arg1, longestMonotoneSequence(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MonotoneSequence ___test = new MonotoneSequence();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
