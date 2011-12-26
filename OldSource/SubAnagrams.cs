using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SubAnagrams {
    
    
    public int maximumParts(string[] suppliedWord)
    {
        string st = "";
        foreach (string s in suppliedWord) st += s;
        int len = st.Length;
        int[,] wordstep = new int[len + 1001, 26];
        int[] wordnum = new int[26];
        int[,] wordmemo = new int[len + 1, 26];
        int i, j, k, res = 0;
        for (i = 1; i < len + 1001; i++) for (j = 0; j < 26; j++) wordstep[i, j] = len + 10;
        for (i = 0; i < len; i++)
        {
            int num = (int)(st[i] - 'A');
            wordstep[++wordnum[num], num] = i + 1;
            for (j = 0; j < 26; j++) wordmemo[i + 1, j] = wordmemo[i, j];
            wordmemo[i + 1, num]++;
        }
        int[,] dp = new int[len + 1, len + 1];
        for (j = 0; j <= len; j++) dp[0, j] = 1;
        for (i = 0; i < len; i++)
            for (j = i + 1; j < len; j++)
            {
                if (dp[i, j] <= 0) continue;
                int next = j + 1;
                int[] nokori = new int[26];
                for (k = 0; k < 26; k++) next = Math.Max(next, wordstep[2 * wordmemo[j, k] - wordmemo[i, k], k]);
                for (k = next; k <= len; k++) dp[j, k] = Math.Max(dp[j, k], dp[i, j] + 1);
            }
        for (i = 0; i < len; i++) res = Math.Max(res, dp[i, len]);
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
	private void test_case_0() { string[] Arg0 = new string[]{"ABABAB"}; int Arg1 = 3; verify_case(0, Arg1, maximumParts(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"AAXAAAABX"}; int Arg1 = 4; verify_case(1, Arg1, maximumParts(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"ABCDEFGHIJKL"}; int Arg1 = 1; verify_case(2, Arg1, maximumParts(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"ABBAB","B","BBX","Z"}; int Arg1 = 2; verify_case(3, Arg1, maximumParts(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SubAnagrams ___test = new SubAnagrams();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
