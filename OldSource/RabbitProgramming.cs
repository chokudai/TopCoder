using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RabbitProgramming {
    long[,] C;
    public long getTeams(int[] points, string[] standings, int qualified, int selected)
    {
        C = new long[51, 51];
        int len = standings.Length;
        int[] maxpoint = new int[len];
        int[] minpoint = new int[len];
        int i, j, k;
        C[0, 0] = 1;
        for (i = 0; i < 50; i++)
        {
            
            for (j = 0; j <= i; j++)
            {
                //Console.Write(C[i, j] + " ");
                C[i + 1, j] += C[i, j];
                C[i + 1, j + 1] += C[i, j];
            }
            //Console.WriteLine();
        }

        for (i = 0; i < len; i++)
        {
            for (j = 0; j < standings[i].Length; j++)
            {
                if (standings[i][j] == 'Y')
                {
                    if (points[j] >= 0)
                    {
                        maxpoint[i] += points[j];
                        minpoint[i] += points[j];
                    }
                    else
                    {
                        maxpoint[i] -= points[j];
                    }
                }
            }
        }
        int[] memo = new int[len];
        for (i = 0; i < len; i++)
        {
            int num = 0;
            for (j = 0; j < len; j++)
            {
                if (maxpoint[i] < minpoint[j] || (maxpoint[i] == minpoint[j] && i > j))
                {
                    num++;
                }
            }
            memo[num]++;
        }
        for (i = 0; i < len; i++) Console.Write(memo[i] + " ");
        Console.WriteLine();
        long[] dp = new long[selected + 1];
        dp[0] = 1;
        for (i = qualified - 1; i >= 0; i--)
        {
            long[] nextdp = new long[selected + 1];
            for (j = 0; j <= selected; j++)
            {
                for (k = 0; k <= memo[i]; k++)
                {
                    if (j + k > selected) break;
                    if (j + k > qualified - i) break;
                    nextdp[j + k] += dp[j] * C[memo[i], k];
                }
            }
            dp = (long[])nextdp.Clone();
        }

        return dp[selected];
    }

    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{ 1, -10 }; string[] Arg1 = new string[]{ "NY", 
  "YN", 
  "YN",
  "YN" }; int Arg2 = 3; int Arg3 = 2; long Arg4 = 5l; verify_case(0, Arg4, getTeams(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int[] Arg0 = new int[]{ -250, -500, -1000 }; string[] Arg1 = new string[]{ "YYY", 
  "YNY", 
  "YYN", 
  "YYN", 
  "YNN" }; int Arg2 = 4; int Arg3 = 2; long Arg4 = 10l; verify_case(1, Arg4, getTeams(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int[] Arg0 = new int[]{ 5, -12, 5, -15, 10, -20, 3, -25, 7, -32, 21, -45 }; string[] Arg1 = new string[]{ "YYYYYYYYYNYY", 
  "YYYNYYYYYNNN", 
  "YYYNYNYYNNYN", 
  "YYYYYNYYYYNN", 
  "YYNNYNYNYYNN", 
  "YYYNNNYYNNNN", 
  "YYNNNNYYNNNN", 
  "NNYNYYYNYNNN", 
  "NNNNNNYYYNNN", 
  "YYYNNNYYYNNN" }
; int Arg2 = 4; int Arg3 = 3; long Arg4 = 99l; verify_case(2, Arg4, getTeams(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RabbitProgramming ___test = new RabbitProgramming();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
