using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RequiredSubstrings {

    long mod = 1000000009;
    int len;
    public int solve(string[] words, int C, int L)
    {
        len = words.Length;
        int i, j, k, l;
        int[, ,] bm = new int[len, 52, 26];
        for (i = 0; i < len; i++)
        {
            for (k = 0; k < 26; k++)
            {
                if (encode(words[i][0]) == k) bm[i, 0, k] = 1;
                else bm[i, 0, k] = 0;
            }
            for (j = 1; j < words[i].Length; j++)
            {
                for (k = 0; k < 26; k++)
                {
                    string s = words[i].Substring(0, j) + decode(k);
                    bm[i, j, k] = 0;
                    for (l = 0; l < j + 1; l++)
                    {
                        if (s.IndexOf(words[i].Substring(0, j + 1 - l), l) == l)
                        {
                            bm[i, j, k] = (j + 1) - l; break;
                        }
                    }
                }
            }
            for (k = 0; k < 26; k++)
            {
                bm[i, words[i].Length, k] = words[i].Length;
            }
        }
        Dictionary<ulong, long> dic = new Dictionary<ulong, long>();
        dic[0] = 1;
        for (i = 0; i < L; i++)
        {
            Dictionary<ulong, long> ndic = new Dictionary<ulong, long>();
            foreach (KeyValuePair<ulong, long> kp in dic)
            {
                for (k = 0; k < 26; k++)
                {
                    int[] ar = arraydecode(kp.Key);
                    for (j = 0; j < len; j++)
                    {
                        ar[j] = bm[j, ar[j], k];
                    }
                    ulong key = arrayencode(ar);
                    if (!ndic.ContainsKey(key))
                    {
                        ndic[key] = 0;
                    }
                    ndic[key] = (ndic[key] + kp.Value) % mod;
                }
            }
            dic = ndic;
        }
        long ret = 0;
        foreach (KeyValuePair<ulong, long> kp in dic)
        {
            int[] ar = arraydecode(kp.Key);
            int now = 0;
            for (i = 0; i < len; i++)
            {
                if (ar[i] == words[i].Length)
                {
                    now++;
                }
            }
            if (now == C)
            {
                ret = (ret + kp.Value) % mod;
            }
        }
        return (int)ret;
    }

    ulong arrayencode(int[] ar)
    {
        ulong ret = 0;
        int i;
        for (i = 0; i < len; i++)
        {
            ret |= ((ulong)ar[i] << (i * 8));
        }
        return ret;
    }

    int[] arraydecode(ulong a)
    {
        int[] ret = new int[len];
        int i;
        for (i = 0; i < len; i++)
        {
            ret[i] = (int)(a >> (i * 8)) & 63;
        }
        return ret;
    }

    char decode(int a)
    {
        return (char)(a + 'a');
    }

    int encode(char C)
    {
        return C - 'a';
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
    private void test_case_0() { string[] Arg0 = new string[] { "ecddbadddfeecaebeeacedfffcbbeaabfdcdcbacdabcaadbfc", "cefcbedebacadabedffcfffedeacebbbcfbcabcabbbecdcbac", "eaecdeeafadecbedcbaccddcddeaafbdcaeeedecedcdcdaeff", "cdfceaeecaabccfaaecfeaaccdddecfeddddadcaaeaaccbcdb", "bebeedeaefdfbefdcfcdebcfeefbfaaceadfeeadedfdaafaba", "cbddaafedfebcfadcbffbbfaacddabdadeabdbefdecadabadc" }; int Arg1 = 2; int Arg2 = 3; int Arg3 = 50; verify_case(0, Arg3, solve(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string[] Arg0 = new string[]{"abcdefgh"}; int Arg1 = 0; int Arg2 = 7; int Arg3 = 31810104; verify_case(1, Arg3, solve(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string[] Arg0 = new string[]{"abcdefgh"}; int Arg1 = 1; int Arg2 = 7; int Arg3 = 0; verify_case(2, Arg3, solve(Arg0, Arg1, Arg2)); }
	private void test_case_3() { string[] Arg0 = new string[]{"a","b","c","d"}; int Arg1 = 3; int Arg2 = 3; int Arg3 = 24; verify_case(3, Arg3, solve(Arg0, Arg1, Arg2)); }
	private void test_case_4() { string[] Arg0 = new string[]{"ab","bc","xy","yz"}; int Arg1 = 2; int Arg2 = 3; int Arg3 = 2; verify_case(4, Arg3, solve(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        RequiredSubstrings ___test = new RequiredSubstrings();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
