using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class QuickT9 {

    Dictionary<char, char> cdic;
    Dictionary<string, string> resdic;
    Dictionary<string, int> numdic;
    Dictionary<string, int> exnumdic;

    string getnum(string s)
    {
        string res = "";
        foreach (char c in s) res += cdic[c];
        return res;
    }

    public int minimumPressings(string[] t9, string word)
    {

        cdic = new Dictionary<char, char>();
        resdic = new Dictionary<string, string>();
        numdic = new Dictionary<string, int>();
        exnumdic = new Dictionary<string, int>();

        string sss = "abcdefghijklmnopqrstuvwxyz";
        string ttt = "22233344455566677778889999";
        int i, j, k;
        for (i = 0; i < 26; i++) cdic[sss[i]] = ttt[i];
        for (i = 0; i < t9.Length; i++)
        {
            string[] ss = t9[i].Split(' ');
            for (k = 0; k < ss.Length; k++)
            {
                for (j = 1; j <= ss[k].Length; j++)
                {
                    string s = ss[k].Substring(0, j);
                    string nums = getnum(s);
                    if (!resdic.ContainsKey(nums)) resdic[nums] = s;
                    else resdic[nums] = resdic[nums] + " " + s;
                }
            }
        }
        foreach (KeyValuePair<string, string> p in resdic)
        {
            string s = p.Value;
            string nums = p.Key;
            string[] ss = s.Split(' ');
            Array.Sort(ss);
            int count = 0;
            for (i = 0; i < ss.Length; i++)
            {
                if (i != 0 && ss[i] == ss[i - 1]) continue;
                int temp = ss[i].Length + count;
                if (numdic.ContainsKey(ss[i]))
                {
                    numdic[ss[i]] = Math.Min(numdic[ss[i]], temp);
                }
                else
                {
                    numdic[ss[i]] = temp;
                }
                count++;
            }
        }
        foreach (KeyValuePair<string, int> p in numdic)
        {
            string s = p.Key;
            int a = p.Value;
            for (i = 0; i < s.Length; i++)
            {
                string ss = s.Substring(0, s.Length - i);
                if (!exnumdic.ContainsKey(ss) || exnumdic[ss] > a + Math.Max(0, i - 1))
                {
                    exnumdic[ss] = a + Math.Max(0, i - 1);
                }
            }
        }
        int[] dp = new int[word.Length + 1];
        int MAX = 9999999;
        for (i = 0; i <= word.Length; i++) dp[i] = MAX;
        dp[0] = 0;
        for (i = 1; i <= word.Length; i++)
        {
            for (j = 0; j < i; j++)
            {
                string s = word.Substring(j, i - j);
                if (!exnumdic.ContainsKey(s)) continue;
                dp[i] = Math.Min(dp[i], dp[j] + exnumdic[s] + 1);

            }
        }
        if (dp[word.Length] >= MAX) return -1;
        return dp[word.Length];
        

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
	private void test_case_0() { string[] Arg0 = new string[]{"aae", "bab", "abad", "bdbd", "beta"}; string Arg1 = "babe"; int Arg2 = 9; verify_case(0, Arg2, minimumPressings(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"ann","ie"}; string Arg1 = "annie"; int Arg2 = 7; verify_case(1, Arg2, minimumPressings(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"ann","amm"}; string Arg1 = "annie"; int Arg2 = -1; verify_case(2, Arg2, minimumPressings(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"aaa aab","aac aba abb ccca"}; string Arg1 = "aba"; int Arg2 = 6; verify_case(3, Arg2, minimumPressings(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"acac aba aaab","aab aa baa","bba bacade abb","baba"}; string Arg1 = "abbaca"; int Arg2 = 10; verify_case(4, Arg2, minimumPressings(Arg0, Arg1)); }
	private void test_case_5() { string[] Arg0 = new string[]{"aaa aab aac","aba abb","ccca"}; string Arg1 = "ccc"; int Arg2 = 5; verify_case(5, Arg2, minimumPressings(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
QuickT9 ___test = new QuickT9();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
