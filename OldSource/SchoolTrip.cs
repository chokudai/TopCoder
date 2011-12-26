using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SchoolTrip {
    public double duration(int[] probability)
    {
        int len = probability.Length;
        double[,] dp = new double[1 << len, len];
        int i, j, k, l;
        for (i = 1; i < (1 << len); i++)
        {
            for (j = 0; j < len; j++)
            {
                dp[i, j] = 60;
            }
        }
        for (j = 0; j < len; j++) dp[0, j] = 0;
        for (j = 0; j < len; j++) dp[1 << j, j] = 0;
        for (i = 1; i < (1 << len); i++)
        {
            if ((i & (i - 1)) == 0) continue;
            for (l = 0; l < 20000; l++)
            {
                for (j = 0; j < len; j++)
                {
                    int next = -1;
                    int nextnext = -1;
                    for (k = (j + 1) % len; nextnext == -1; k = (k + 1) % len)
                    {
                        if ((i >> k) % 2 == 1)
                        {
                            if (next == -1) next = k;
                            else
                            {
                                nextnext = k;
                            }
                        }
                    }
                    double hazure = dp[i, next];
                    double atari = 60;
                    for (k = 0; k < len; k++)
                    {
                        if ((i >> k) % 2 == 1 && k != j)
                        {
                            int nn = next;
                            if (k == next) nn = nextnext;
                            atari = Math.Min(atari, dp[i - (1 << k), nn]);
                        }
                    }
                    dp[i, j] = hazure * (100 - probability[j]) / 100.0 + atari * probability[j] / 100.0 + 1;
                }
            }
        }
        return dp[(1 << len) - 1, 0];
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
	private void test_case_0() { int[] Arg0 = new int[]{100,23}; double Arg1 = 1.0; verify_case(0, Arg1, duration(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{50,50}; double Arg1 = 2.0; verify_case(1, Arg1, duration(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{25,50,75}; double Arg1 = 3.892383478590375; verify_case(2, Arg1, duration(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{100,100,100,42,11}; double Arg1 = 4.0; verify_case(3, Arg1, duration(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SchoolTrip ___test = new SchoolTrip();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
