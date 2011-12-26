using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Hotel {
    public int marketCost(int minCustomers, int[] customers, int[] cost)
    {
        int[] dp = new int[3000];
        int i,j;
        for (i = 0; i < 3000; i++) dp[i] = 99999999;
        dp[0] = 0;
        for (i = 0; i < customers.Length; i++)
        {
            for (j = 0; j < minCustomers; j++)
            {
                dp[j + customers[i]] = Math.Min(dp[j + customers[i]], dp[j] + cost[i]);
            }
        }
        int res = 999999999;
        for (i = minCustomers; i < 3000; i++) res = Math.Min(res, dp[i]);
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
	private void test_case_0() { int Arg0 = 10; int[] Arg1 = new int[]{1,2,3}; int[] Arg2 = new int[]{3,2,1}; int Arg3 = 4; verify_case(0, Arg3, marketCost(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 10; int[] Arg1 = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; int[] Arg2 = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; int Arg3 = 10; verify_case(1, Arg3, marketCost(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 12; int[] Arg1 = new int[]{5, 1}; int[] Arg2 = new int[]{3, 1}; int Arg3 = 8; verify_case(2, Arg3, marketCost(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 100; int[] Arg1 = new int[]{9, 11, 4, 7, 2, 8}; int[] Arg2 = new int[]{4, 9, 3, 8, 1, 9}; int Arg3 = 45; verify_case(3, Arg3, marketCost(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Hotel ___test = new Hotel();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
