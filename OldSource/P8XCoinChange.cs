using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class P8XCoinChange {

    long mod = 1000003;
    int len;
    public int solve(long coins_sum, long[] values)
    {
        int i,j;
        Array.Sort(values);
        len = values.Length;
        Array.Reverse(values);
        long[] num = new long[len];
        for (i = 0; i < len; i++)
        {
            if (i == 0) num[i] = coins_sum / values[i];
            else
            {
                num[i] = (coins_sum % values[i - 1]) / values[i];
            }
        }
        Array.Reverse(values);

        long[,] dp = new long[len, 1];
        dp[len - 1, 0] = 1;

        long[,] pow = new long[len, len];

        for (i = 0; i < len; i++)
        {
            for (j = 0; j <= i; j++)
            {
                pow[len - i - 1, len - j - 1] = 1;
            }
            long[,] nextdp = matmul(matpow(pow, num[len - i - 1]),dp);
            dp = (long[,])nextdp.Clone();
            
            if (i != len - 1)
            {
                long[,] nextpow = matpow(pow, (values[i + 1]) / values[i]);
                pow = (long[,])nextpow.Clone();
            }
             
        }
        long ret = 0;
        for (i = 0; i < len; i++) ret = (ret + dp[i, 0]) % mod;
        return (int)ret;
    }

    long[,] matpow(long[,] m, long a)
    {
        if (a == 0)
        {
            long[,] res = new long[len, len];
            int i;
            for (i = 0; i < len; i++) res[i, i] = 1;
            return res;
        }
        else if (a % 2 == 0)
        {
            long[,] res = matpow(m, a / 2);
            return matmul(res, res);
        }
        else
        {
            return matmul(m, matpow(m, a - 1));
        }
    }

    long[,] matmul(long[,] ma, long[,] mb)
    {
        int i, j, k;
        int len1 = ma.GetLength(0);
        int len2 = mb.GetLength(1);
        int len3 = ma.GetLength(1);
        long[,] res = new long[len1, len2];
        for (i = 0; i < len1; i++)
        {
            for (j = 0; j < len2; j++)
            {
                for (k = 0; k < len3; k++)
                {
                    res[i, j] += ma[i, k] * mb[k, j] % mod;
                }
                res[i, j] %= mod;
            }
        }
        return res;
    }


// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { long Arg0 = 4l; long[] Arg1 = new long[]{1, 3}; int Arg2 = 2; verify_case(0, Arg2, solve(Arg0, Arg1)); }
	private void test_case_1() { long Arg0 = 4l; long[] Arg1 = new long[]{1, 2, 4}; int Arg2 = 4; verify_case(1, Arg2, solve(Arg0, Arg1)); }
	private void test_case_2() { long Arg0 = 3l; long[] Arg1 = new long[]{1, 5}; int Arg2 = 1; verify_case(2, Arg2, solve(Arg0, Arg1)); }
	private void test_case_3() { long Arg0 = 11l; long[] Arg1 = new long[]{1, 2, 6}; int Arg2 = 9; verify_case(3, Arg2, solve(Arg0, Arg1)); }
	private void test_case_4() { long Arg0 = 1000000000000000000l; long[] Arg1 = new long[]{1, 1000000000, 1000000000000000000}; int Arg2 = 997005; verify_case(4, Arg2, solve(Arg0, Arg1)); }
	private void test_case_5() { long Arg0 = 961320341778342848l; long[] Arg1 = new long[]{1,2,10,30,150,300,1200,2400,4800,14400,
28800,57600,288000,576000,2304000,9216000,
18432000,73728000,221184000,663552000,
1327104000,5308416000,31850496000,
95551488000,191102976000,764411904000,
1528823808000,6115295232000,18345885696000,
36691771392000,73383542784000,220150628352000,
440301256704000,1320903770112000,3962711310336000,
15850845241344000,31701690482688000,95105071448064000,
475525357240320000,951050714480640000}; int Arg2 = 245264; verify_case(5, Arg2, solve(Arg0, Arg1)); }
	private void test_case_6() { long Arg0 = 1000000000000000000l; long[] Arg1 = new long[]{1, 2}; int Arg2 = 499989; verify_case(6, Arg2, solve(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        P8XCoinChange ___test = new P8XCoinChange();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
