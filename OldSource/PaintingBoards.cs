using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PaintingBoards {
    DateTime dt;
    public double minimalTime(int[] boardLength, int[] painterSpeed)
    {
        dt = DateTime.Now;
        int i, j, k, l;
        double max = 99999999;
        int blen = boardLength.Length;
        int plen = painterSpeed.Length;
        double[,] dp = new double[blen+1, 1 << plen];
        Array.Sort(painterSpeed);
        Array.Reverse(painterSpeed);
        double[, ,] waru = new double[blen + 1, blen, plen];
        for (i = 0; i <= blen; i++)
        {
            for (j = 0; j < (1 << plen); j++)
            {
                dp[i, j] = max;
            }
        }
        int[] sum = new int[blen + 1];
        for (i = 0; i < blen; i++)
        {
            sum[i + 1] = sum[i] + boardLength[i];
        }
        for (l = 0; l <= blen; l++)
        {
            for (i = 0; i < blen; i++)
            {
                for (k = 0; k < plen; k++)
                {
                    waru[l, i, k] = (sum[l] - sum[i]) / (double)painterSpeed[k];
                }
            }
        }

        dp[0, 0] = 0;
        double nowmax = (double)sum[blen] / painterSpeed[0];
        for (j = 0; j < (1 << plen); j++)
        {
            if ((DateTime.Now - dt).TotalMilliseconds >= 1950) break;
            for (i = 0; i < blen; i++)
            {
                if (dp[i, j] >= nowmax) continue;
                if (dp[i, j] >= dp[i + 1, j]) continue;
                for (k = 0; k < plen; k++)
                {
                    if ((j >> k) % 2 == 1)
                    {
                        if (dp[i, j - (1 << k)] <= dp[i, j])
                        {
                            dp[i, j] = dp[i, j - (1 << k)];
                            break;
                        }
                    }
                }
                if (k != plen) continue;
                for (k = 0; k < plen; k++)
                {
                    if ((j >> k) % 2 == 1) continue;
                    for (l = i + 1 ; l <= blen; l++)
                    {
                        if (waru[l, i, k] >= nowmax) break;
                        dp[l, j + (1 << k)] = Math.Min(dp[l, j + (1 << k)],
                            Math.Max(dp[i, j], waru[l, i, k]));
                        if (l == blen) nowmax = Math.Min(nowmax, dp[l, j + (1 << k)]);
                    }
                }
            }
        }
        double res = nowmax;
        for (j = 0; j < (1 << plen); j++) res = Math.Min(res, dp[blen, j]);
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
    private void test_case_0() { int[] Arg0 = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 10000 }; int[] Arg1 = new int[] { 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000 }; double Arg2 = 1.0; verify_case(0, Arg2, minimalTime(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{1,2,1,4,2,1,1}; int[] Arg1 = new int[]{1,2,3}; double Arg2 = 2.0; verify_case(1, Arg2, minimalTime(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{40, 46, 82, 89, 33, 46, 3, 50, 95, 
81, 69, 40, 94, 93, 90, 98, 17, 34, 
45, 18, 93, 28, 43, 38, 35}; int[] Arg1 = new int[]{49, 51, 35, 27, 48, 36, 54, 10}; double Arg2 = 4.686274509803922; verify_case(2, Arg2, minimalTime(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{3,3,20}; int[] Arg1 = new int[]{9,1}; double Arg2 = 2.888888888888889; verify_case(3, Arg2, minimalTime(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PaintingBoards ___test = new PaintingBoards();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
