using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class KiwiJuice {
    int[] dp;
    public int theProfit(int C, int[] bottles, int[] prices)
    {
        int len = bottles.Length;
        dp = new int[(1 << len)];
        int i, j;
        for (i = 0; i < (1 << len); i++)
        {
            int r = 0;
            int sum = 0;
            for (j = 0; j < 15; j++)
            {
                if (((i >> j) & 1) != 0)
                {
                    sum += bottles[j];
                    r++;
                }
            }
            int max = sum / C;
            if (sum % C == 0)
            {
                dp[i] = prices[C] * max + prices[0] * (r - max);
            }
            else
            {
                dp[i] = prices[C] * max + prices[0] * (r - max - 1) + prices[sum % C];
            }
        }

        for (i = 0; i < (1 << len); i++)
        {
            for (j = i; j > 0; j = ((j - 1) & i))
            {
                dp[i] = Math.Max(dp[i], dp[i - j] + dp[j]);
            }
        }
        return dp[(1 << len) - 1];
    }



    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 10; int[] Arg1 = new int[]{5, 8}; int[] Arg2 = new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10}; int Arg3 = 10; verify_case(0, Arg3, theProfit(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 10; int[] Arg1 = new int[]{5, 8}; int[] Arg2 = new int[]{0, 0, 0, 0, 0, 10, 10, 10, 10, 10, 10}; int Arg3 = 20; verify_case(1, Arg3, theProfit(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 10; int[] Arg1 = new int[]{4, 5, 3, 7}; int[] Arg2 = new int[]{14, 76, 12, 35, 6, 94, 26, 3, 93, 90, 420}; int Arg3 = 625; verify_case(2, Arg3, theProfit(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 1; int[] Arg1 = new int[]{0}; int[] Arg2 = new int[]{1000000, 1000000}; int Arg3 = 1000000; verify_case(3, Arg3, theProfit(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int Arg0 = 49; int[] Arg1 = new int[]{2, 47, 24, 14, 0, 32, 9, 12, 31, 46, 39, 12, 16, 22, 29}; int[] Arg2 = new int[]{428668, 995687, 128567, 37241, 496916, 238624, 304781, 997819, 85856, 417008,
398570, 951499, 750349, 333625, 927594, 188616, 942498, 259414, 654344, 354809,
25303, 226854, 98578, 207140, 305527, 358343, 393213, 256248, 282644, 103327,
667191, 103402, 609183, 619323, 189127, 518006, 778846, 400460, 128334, 795097,
605203, 669142, 121825, 934404, 837430, 554265, 610818, 546228, 80784, 949440}; int Arg3 = 12873962; verify_case(4, Arg3, theProfit(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
KiwiJuice ___test = new KiwiJuice();
___test.run_test(-1);

}
// END CUT HERE
}
