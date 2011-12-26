using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheFansAndMeetingsDivOne {
    public double find(int[] minJ, int[] maxJ, int[] minB, int[] maxB, int k)
    {
        int i, j, l, m;
        int len = minJ.Length;
        double[,] dp = new double[k + 2, (k + 3) * 50];
        double[,] dp2 = new double[k + 2, (k + 3) * 50];
        dp[0, 0] = dp2[0, 0] = 1;

        for (i = 0; i < len; i++)
        {
            for (j = k; j >= 0; j--)
            {
                for (l = (k + 1) * 50-1 ; l >= 0; l--)
                {
                    if (dp[j, l] == 0) continue;
                    for (m = maxJ[i]; m >= minJ[i]; m--)
                    {
                        dp[j + 1, l + m] += dp[j, l] / (maxJ[i] - minJ[i] + 1);
                    }
                }
            }
        }
        for (i = 0; i < len; i++)
        {
            for (j = k; j >= 0; j--)
            {
                for (l = (k + 1) * 50 - 1; l >= 0; l--)
                {
                    if (dp2[j, l] == 0) continue;
                    for (m = maxB[i]; m >= minB[i]; m--)
                    {
                        dp2[j + 1, l + m] += dp2[j, l] / (maxB[i] - minB[i] + 1);
                    }
                }
            }
        }
        double res = 0;
        for (i = 0; i < (k + 3) * 50; i++)
        {
            res += dp[k, i] * dp2[k, i];
        }
        return res / calc(len, k) / calc(len, k);
    }

    double calc(int a, int b)
    {
        double res = 1;
        for (int i = 0; i < b; i++)
        {
            res *= a-i;
            res /= (i+1);
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
	private void test_case_0() { int[] Arg0 = new int[]{1}; int[] Arg1 = new int[]{9}; int[] Arg2 = new int[]{5}; int[] Arg3 = new int[]{5}; int Arg4 = 1; double Arg5 = 0.1111111111111111; verify_case(0, Arg5, find(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { int[] Arg0 = new int[]{5, 2, 5, 1, 1, 2, 4, 1}; int[] Arg1 = new int[]{7, 6, 7, 3, 4, 3, 5, 1}; int[] Arg2 = new int[]{8, 9, 7, 11, 12, 7, 8, 40}; int[] Arg3 = new int[]{9, 10, 9, 33, 14, 7, 11, 40}; int Arg4 = 2; double Arg5 = 4.724111866969009E-5; verify_case(1, Arg5, find(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { int[] Arg0 = new int[]{4, 7, 4}; int[] Arg1 = new int[]{7, 7, 7}; int[] Arg2 = new int[]{40, 40, 40}; int[] Arg3 = new int[]{40, 40, 40}; int Arg4 = 1; double Arg5 = 0.0; verify_case(2, Arg5, find(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { int[] Arg0 = new int[]{3, 6, 2, 1, 1, 10, 3}; int[] Arg1 = new int[]{6, 9, 5, 6, 5, 10, 9}; int[] Arg2 = new int[]{1, 1, 1, 1, 8, 3, 1}; int[] Arg3 = new int[]{3, 9, 7, 3, 10, 6, 5}; int Arg4 = 4; double Arg5 = 0.047082056525158976; verify_case(3, Arg5, find(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheFansAndMeetingsDivOne ___test = new TheFansAndMeetingsDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
