using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TakeSubstringGame {
    public int winningMove(int n)
    {
        int[] num = new int[8];
        num[0] = 1;
        int i, j, k;
        for (i = 0; i < 7; i++) num[i + 1] = num[i] * 10;
        int[] dp = new int[1000001];
        int MAX = 9999999;
        for (i = 1; i < dp.Length; i++) dp[i] = MAX;
        dp[0] = 0;
        for (i = 1; i <= n; i++)
        {
            for (j = 0; j < 8; j++)
            {
                int now = i / num[j];
                for (k = 0; k < 8; k++)
                {
                    int next = now % num[k];
                    if (next == 0) continue;
                    if (dp[i - next] == MAX)
                    {
                        dp[i] = Math.Min(dp[i], next);
                    }
                }
            }
        }
        if (dp[n] == MAX) return -1;
        else return dp[n];
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
	private void test_case_0() { int Arg0 = 5; int Arg1 = -1; verify_case(0, Arg1, winningMove(Arg0)); }
	private void test_case_1() { int Arg0 = 10; int Arg1 = 1; verify_case(1, Arg1, winningMove(Arg0)); }
	private void test_case_2() { int Arg0 = 17; int Arg1 = -1; verify_case(2, Arg1, winningMove(Arg0)); }
	private void test_case_3() { int Arg0 = 239; int Arg1 = 9; verify_case(3, Arg1, winningMove(Arg0)); }
	private void test_case_4() { int Arg0 = 566; int Arg1 = 66; verify_case(4, Arg1, winningMove(Arg0)); }
	private void test_case_5() { int Arg0 = 23900; int Arg1 = -1; verify_case(5, Arg1, winningMove(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {

    TakeSubstringGame ___test = new TakeSubstringGame();
    ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
