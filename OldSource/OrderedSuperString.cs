using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class OrderedSuperString {
    public int getLength(string[] words)
    {
        string s = "";
        int res = 0;
        int i, j;
        for (i = 0; i < words.Length; i++)
        {
            for (j = 0; j <= s.Length; j++)
            {
                int kaburi = s.Length - j;
                string s1 = s.Substring(0, j) + words[i];
                string s2 = s;
                if (kaburi <= words[i].Length) s2 += words[i].Substring(kaburi, words[i].Length - kaburi);
                if (s1 == s2.Substring(0, s1.Length))
                {
                    res += j;
                    s = s2.Substring(j, s2.Length - j);
                    break;
                }
            }
        }
        return res + s.Length;
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
	private void test_case_0() { string[] Arg0 = new string[]{"abc","ca"}; int Arg1 = 4; verify_case(0, Arg1, getLength(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"a","a","b","a"}; int Arg1 = 3; verify_case(1, Arg1, getLength(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"abcdef", "ab","bc", "de","ef"}; int Arg1 = 6; verify_case(2, Arg1, getLength(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"ab","bc", "de","ef","abcdef"}; int Arg1 = 12; verify_case(3, Arg1, getLength(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        OrderedSuperString ___test = new OrderedSuperString();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
