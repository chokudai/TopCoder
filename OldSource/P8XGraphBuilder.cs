using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class P8XGraphBuilder {
    public int solve(int[] scores)
    {
        int N = scores.Length + 1;
        int[] dp = new int[1000];
        int start = scores[0] * N;
        int i, j;
        for (i = 1; i < 1000; i++) dp[i] = -99999999;
        for (i = 0; i < N; i++)
        {
            for (j = 1; j < N - 1; j++)
            {
                dp[i + j] = Math.Max(dp[i + j], dp[i] + scores[j] - scores[0]);
            }
        }
        return start + dp[N - 2];
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
	private void test_case_0() { int[] Arg0 = new int[]{1, 3, 0}; int Arg1 = 8; verify_case(0, Arg1, solve(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{0, 0, 0, 10}; int Arg1 = 10; verify_case(1, Arg1, solve(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{1, 2, 3, 4, 5, 6}; int Arg1 = 12; verify_case(2, Arg1, solve(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{5, 0, 0}; int Arg1 = 15; verify_case(3, Arg1, solve(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{1, 3, 2, 5, 3, 7, 5}; int Arg1 = 20; verify_case(4, Arg1, solve(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
P8XGraphBuilder ___test = new P8XGraphBuilder();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
