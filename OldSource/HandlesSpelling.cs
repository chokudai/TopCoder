using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class HandlesSpelling {
    public int spellIt(string[] parts, string[] badges)
    {
        int i, j, k, l;
        string st = "";
        for (i = 0; i < parts.Length; i++) st += parts[i];
        int len = st.Length;
        int ma = 99999999;
        int[,] dp = new int[len + 1, len + 1];
        for (i = 0; i <= len; i++)
        {
            for (j = 0; j <= len; j++)
            {
                dp[i, j] = ma;
            }
        }
        dp[0, 0] = 0;

        for (l = 0; l < len; l++)
        {
            int[,] nextdp = new int[len + 1, len + 1];
            for (i = 0; i <= len; i++)
            {
                for (j = 0; j <= len; j++)
                {
                    if (dp[i, j] == ma) continue;
                    for (k = 0; k < badges.Length; k++)
                    {
                        if (i + badges[k].Length > len) continue;
                        if (j + badges[k].Length > len) continue;
                        if (l + badges[k].Length > len) continue;
                        string s = st.Substring(l, badges[k].Length);
                        Console.WriteLine(badges[k] + " " + s);
                        if (badges[k] == s)
                        {
                            nextdp[Math.Max(i, j + badges[k].Length), j + badges[k].Length] = Math.Min(nextdp[Math.Max(i, j + badges[k].Length), j + badges[k].Length], dp[i, j]);
                        }
                    }
                    if (i != len) nextdp[i + 1, 0] = Math.Min(nextdp[i, 0], dp[i, j] + 1);
                }
            }
            for (i = 0; i <= len; i++)
            {
                for (j = 0; j <= len; j++)
                {
                    dp[i, j] = nextdp[i, j];
                }
            }
            for (i = 0; i <= len; i++)
            {
                for (j = 0; j <= len; j++)
                {
                    nextdp[i, j] = ma;
                }
            }
        }

        int res = -99999999;
        for (i = 0; i <= len; i++)
        {
            for (j = 0; j <= len; j++)
            {
                res = Math.Max(res, i * i - dp[i, j]);
            }
        }
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
	private void test_case_0() { string[] Arg0 = new string[]{"HELLO"}; string[] Arg1 = new string[]{"E","HE","L"}; int Arg2 = 15; verify_case(0, Arg2, spellIt(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"ALGORITHM","QUALIFICATION","ROUND","TWO"}; string[] Arg1 = new string[]{"AL", "CAT", "GOR", "IFI", "ION", "ROUND", "T"}; int Arg2 = 282; verify_case(1, Arg2, spellIt(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"GOOD","LUCK"}; string[] Arg1 = new string[]{"GOODLUCKBJ","G","L"}; int Arg2 = -5; verify_case(2, Arg2, spellIt(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"ANDDOHAVEFUN"}; string[] Arg1 = new string[]{"HAV"}; int Arg2 = 0; verify_case(3, Arg2, spellIt(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
HandlesSpelling ___test = new HandlesSpelling();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
