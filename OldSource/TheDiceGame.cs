using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheDiceGame {
    public double expectedThrows(int candies)
    {
        double[] dp = new double[candies + 20];
        double[] reach = new double[candies + 20];
        dp[0] = 0;
        reach[0] = 1;
        int i, j;
        for (i = 0; i < candies; i++)
        {
            for (j = 1; j <= 6; j++)
            {
                dp[i + j] += (dp[i] + reach[i]) / 6;
                reach[i + j] += reach[i] / 6;
            }
        }
        double res = 0;
        double res2 = 0;
        for (j = 1; j <= 6; j++) res += dp[candies - 1 + j];
        for (j = 1; j <= 6; j++) res2 += reach[candies - 1 + j];
        Console.WriteLine(res2);
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
	private void test_case_0() { int Arg0 = 1; double Arg1 = 1.0; verify_case(0, Arg1, expectedThrows(Arg0)); }
	private void test_case_1() { int Arg0 = 2; double Arg1 = 1.1666666666666667; verify_case(1, Arg1, expectedThrows(Arg0)); }
	private void test_case_2() { int Arg0 = 7; double Arg1 = 2.5216263717421126; verify_case(2, Arg1, expectedThrows(Arg0)); }
	private void test_case_3() { int Arg0 = 47; double Arg1 = 13.90476189046144; verify_case(3, Arg1, expectedThrows(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheDiceGame ___test = new TheDiceGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
