using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheNumbersWithLuckyLastDigit {
    public int find(int n)
    {
        int i,j;
        int MAX = 99999;
        int len = 1000;
        if (ok(n)) return 1;
        int[] dp = new int[len];
        int[] minidp = new int[10];
        dp[0] = 0;
        for (i = 0; i < 10; i++) minidp[i] = MAX;
        for (i = 0; i < len; i++) dp[i] = MAX;
        for (i = 0; i < len; i++)
        {
            if (ok(i))
            {
                dp[i] = 1;
                for (j = 0; j + i < len; j++)
                {
                    dp[j + i] = Math.Min(dp[j + i], dp[j] + 1);
                }
            }
            if (i >= 4)
            {
                minidp[i % 10] = Math.Min(minidp[i % 10], dp[i]);
            }
        }

        if (n < len)
        {
            if (dp[n] == MAX) return -1;
            else return dp[n];
        }
        else return minidp[n % 10];

    }

    bool ok(int n)
    {
        if (n % 10 == 4 || n % 10 == 7) return true;
        return false;
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
	private void test_case_0() { int Arg0 = 99; int Arg1 = 4; verify_case(0, Arg1, find(Arg0)); }
	private void test_case_1() { int Arg0 = 11; int Arg1 = 2; verify_case(1, Arg1, find(Arg0)); }
	private void test_case_2() { int Arg0 = 13; int Arg1 = -1; verify_case(2, Arg1, find(Arg0)); }
	private void test_case_3() { int Arg0 = 1234567; int Arg1 = 1; verify_case(3, Arg1, find(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheNumbersWithLuckyLastDigit ___test = new TheNumbersWithLuckyLastDigit();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
