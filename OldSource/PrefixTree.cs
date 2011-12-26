using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PrefixTree {
    public int getNumNodes(string[] words)
    {
        int len = words.Length;
        int max = 1 << len;
        int i, j, k;
        int[] same = new int[max];
        int[,] num = new int[len, 26];
        int[] dp = new int[max];
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < words[i].Length; j++)
            {
                num[i, words[i][j] - 'a']++;
            }
        }
        for (i = 1; i < max; i++)
        {
            same[i] = 0;
            for (j = 0; j < 26; j++)
            {
                int minnum = 100;
                for (k = 0; k < words.Length; k++)
                {
                    if ((i >> k) % 2 == 0) continue;
                    minnum = Math.Min(minnum, num[k, j]);
                }
                same[i] += minnum;
            }
        }
        for (i = 0; i < max; i++)
        {
            dp[i] = 9999999;
        }
        for (i = 0; i < len; i++) dp[1 << i] = words[i].Length;

        for (i = 0; i < max; i++)
        {
            for (j = i - 1; ; j--)
            {
                j &= i;
                if (j <= 0) break;
                dp[i] = Math.Min(dp[i], dp[j] + dp[i-j] - same[i]);

            }
        }
        return dp[max-1] + 1;
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
	private void test_case_0() { string[] Arg0 = new string[]{"topcoder"}; int Arg1 = 9; verify_case(0, Arg1, getNumNodes(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"topcoder","topcoder"}; int Arg1 = 9; verify_case(1, Arg1, getNumNodes(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"aab","ca"}; int Arg1 = 5; verify_case(2, Arg1, getNumNodes(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"aab","ca","ba"}; int Arg1 = 5; verify_case(3, Arg1, getNumNodes(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"ab","cd","ef"}; int Arg1 = 7; verify_case(4, Arg1, getNumNodes(Arg0)); }
	private void test_case_5() { string[] Arg0 = new string[]{"a","aa","aaa"}; int Arg1 = 4; verify_case(5, Arg1, getNumNodes(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
    PrefixTree ___test = new PrefixTree();
    ___test.run_test(-1);
try {

} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
