using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class IsomorphicWords {
    public int countPairs(string[] words)
    {
        int i, j, k;
        int len = words.Length;
        int res = 0;
        for (i = 0; i < len; i++)
        {
            for (j = i + 1; j < len; j++)
            {
                if (words[i].Length != words[j].Length) continue;
                Dictionary<char, int> dica = new Dictionary<char, int>();
                Dictionary<char, int> dicb = new Dictionary<char, int>();
                int count = 1;
                for (k = 0; k < words[i].Length; k++)
                {
                    if (dica.ContainsKey(words[i][k]))
                    {
                        if (!dicb.ContainsKey(words[j][k])) break;
                        if (dica[words[i][k]] != dicb[words[j][k]]) break;
                    }
                    else
                    {
                        if (dicb.ContainsKey(words[j][k])) break;
                        dica[words[i][k]] = dicb[words[j][k]] = count++;
                    }
                }
                if (k == words[i].Length)
                {
                    res++;
                }
            }
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"abca", "zbxz", "opqr"}; int Arg1 = 1; verify_case(0, Arg1, countPairs(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"aa", "ab", "bb", "cc", "cd"}; int Arg1 = 4; verify_case(1, Arg1, countPairs(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{ "cacccdaabc", "cdcccaddbc", "dcdddbccad", "bdbbbaddcb",
  "bdbcadbbdc", "abaadcbbda", "babcdabbac", "cacdbaccad",
  "dcddabccad", "cacccbaadb", "bbcdcbcbdd", "bcbadcbbca" }; int Arg1 = 13; verify_case(2, Arg1, countPairs(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
IsomorphicWords ___test = new IsomorphicWords();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
