using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Stackol {
    public int countPrograms(string[] outputFragments, int k)
    {
        string s = "";
        foreach (string ss in outputFragments) s += ss;
        long mod = 1000000007;
        int len = s.Length;
        long[,] dp = new long[len + 1, k + 1];
        int i, j, l;
        int[] useA = new int[len + 1];
        int[] useB = new int[len + 1];
        for (i = 0; i < len; i++)
        {
            useA[i + 1] = useA[i];
            useB[i + 1] = useB[i];
            if (s[i] == 'A') useA[i + 1]++;
            else useB[i + 1]++;
        }

        dp[0, 0] = 1;

        for (i = 0; i <= len; i++)
        {
            for (j = i; j <= len; j++)
            {
                int make = 1;
                if (j - i >= 2)
                {
                    int a = useA[j] - useA[i];
                    int b = useB[j] - useB[i];
                    make = 0;
                    if (a != 0 && b != 0)
                    {
                        if (s[i + a] == 'A') make++;
                        if (s[i] == 'B') make++;
                    }
                    else
                    {
                        make = 1;
                    }
                }
                if (make != 0)
                {
                    for (l = 0; l < k; l++)
                    {
                        dp[j, l + 1] += dp[i, l] * make;
                        dp[j, l + 1] %= mod;
                    }
                }
            }
        }
        long res = 0;
        for (l = 0; l <= k; l++)
        {
            res += dp[len, l];
            res %= mod;
        }

        return (int)res;
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
	private void test_case_0() { string[] Arg0 = new string[]{"A"}; int Arg1 = 2; int Arg2 = 3; verify_case(0, Arg2, countPrograms(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"AAAA","BABA"}; int Arg1 = 1; int Arg2 = 0; verify_case(1, Arg2, countPrograms(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"AB"}; int Arg1 = 2; int Arg2 = 1; verify_case(2, Arg2, countPrograms(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"AAABABABAABA", "AA", "BBAB"}; int Arg1 = 3; int Arg2 = 94; verify_case(3, Arg2, countPrograms(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"AAAAAAAAAAAA","B"}; int Arg1 = 4; int Arg2 = 120; verify_case(4, Arg2, countPrograms(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        Stackol ___test = new Stackol();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
