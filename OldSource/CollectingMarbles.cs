using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CollectingMarbles {
    public int mostMarbles(int[] marblesWeights, int bagCapacity, int numberOfBags)
    {
        int i, j;
        int len = marblesWeights.Length;
        int res = 0;
        int[] dp = new int[1<<len];
        dp[0] = 0;
        for (i = 1; i < (1 << len); i++)
        {
            int sum = 0;
            int marble = 0;
            for (j = 0; j < len; j++)
            {
                if ((i >> j) % 2 == 1)
                {
                    sum += marblesWeights[j];
                    marble++;
                }
            }
            dp[i] = 10000;
            if (sum <= bagCapacity) dp[i] = 1;
            else
            {
                for (j = i; j > 0; j--)
                {
                    j &= i;
                    if (j <= 0) break;
                    dp[i] = Math.Min(dp[i], dp[j] + dp[i - j]);
                }
            }
            if (dp[i] <= numberOfBags) res = Math.Max(res, marble);
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
	private void test_case_0() { int[] Arg0 = new int[]{ 2, 2, 2, 2, 2 }; int Arg1 = 5; int Arg2 = 2; int Arg3 = 4; verify_case(0, Arg3, mostMarbles(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{ 1, 3, 5, 2, 4 }; int Arg1 = 5; int Arg2 = 2; int Arg3 = 4; verify_case(1, Arg3, mostMarbles(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{ 7, 6, 6, 5 }; int Arg1 = 12; int Arg2 = 2; int Arg3 = 4; verify_case(2, Arg3, mostMarbles(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{ 2, 2, 2 }; int Arg1 = 1; int Arg2 = 10; int Arg3 = 0; verify_case(3, Arg3, mostMarbles(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CollectingMarbles ___test = new CollectingMarbles();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
