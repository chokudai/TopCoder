using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class JingleRingle {
    public int profit(int[] buyOffers, int[] sellOffers, int tax)
    {
        int res = 0;
        int i, j;
        int len = buyOffers.Length;
        int len2 = sellOffers.Length;
        Array.Sort(buyOffers);
        Array.Sort(sellOffers);
        for (i = 0; i <= Math.Min(len2, len); i++)
        {
            int now = 0;
            for (j = 0; j < i; j++)
            {
                now += buyOffers[len - 1 - j];
                now -= sellOffers[j];
                now -= buyOffers[len - 1 - j] * tax / 100;
            }
            res = Math.Max(res, now);
        }
        return res;
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
	private void test_case_0() { int[] Arg0 = new int[]{1000, 1024}; int[] Arg1 = new int[]{990, 1011}; int Arg2 = 0; int Arg3 = 34; verify_case(0, Arg3, profit(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{1000, 1001, 1002}; int[] Arg1 = new int[]{980, 981, 982}; int Arg2 = 2; int Arg3 = 2; verify_case(1, Arg3, profit(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{100, 120, 140}; int[] Arg1 = new int[]{150, 170, 200}; int Arg2 = 15; int Arg3 = 0; verify_case(2, Arg3, profit(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{}; int[] Arg1 = new int[]{}; int Arg2 = 20; int Arg3 = 0; verify_case(3, Arg3, profit(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int[] Arg0 = new int[]{1692, 3281, 862}; int[] Arg1 = new int[]{2701, 2819, 2582, 1918, 638, 601, 1128, 2760, 1949, 3074,
  615, 2221, 1691, 3226, 1351, 1329, 556, 1060, 898, 1080,
 2494, 2379, 3148, 737, 1412, 3290, 1594, 1314, 959, 3192,
 1326, 932, 1103, 937, 1670, 2017, 1403, 1282, 2949, 2940,
 2557, 940, 2561, 1248, 2385, 541, 2382, 1309, 831}; int Arg2 = 4; int Arg3 = 3905; verify_case(4, Arg3, profit(Arg0, Arg1, Arg2)); }
	private void test_case_5() { int[] Arg0 = new int[]{5016, 7212, 7613, 1590, 2942, 5155, 5898, 8113, 2001, 2348,
  671, 5167, 7524, 2467, 4294, 3628, 4480, 5872, 5230, 3732,
 4637, 6419, 1431, 6335, 1652, 3005, 2125, 2193, 2183, 5856,
 1795, 5441, 2079, 7114, 2290, 4025, 5943, 1695}; int[] Arg1 = new int[]{2407, 5602, 1350}; int Arg2 = 3; int Arg3 = 13195; verify_case(5, Arg3, profit(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
JingleRingle ___test = new JingleRingle();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
