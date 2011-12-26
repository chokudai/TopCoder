using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BadVocabulary {
    public int count(string badPrefix, string badSuffix, string badSubstring, string[] vocabulary)
    {
        int res = 0;
        int i, j, k;
        for (i = 0; i < vocabulary.Length; i++)
        {
            bool flag = false;
            for (j = 0; j < badPrefix.Length && j < vocabulary[i].Length; j++)
            {
                if (badPrefix[j] != vocabulary[i][j]) break;
            }
            if (j == badPrefix.Length) flag = true;
            for (k = 1; k < vocabulary[i].Length; k++)
            {
                for (j = 0; j < badSubstring.Length && j + k < vocabulary[i].Length; j++)
                {
                    if (badSubstring[j] != vocabulary[i][j + k]) break;
                }
                if (j == badSubstring.Length && j + k != vocabulary[i].Length) flag = true;
            }
            for (j = 0; j < badSuffix.Length && j < vocabulary[i].Length; j++)
            {
                if (badSuffix[badSuffix.Length - 1 - j] != vocabulary[i][vocabulary[i].Length - 1 - j]) break;
            }
            if (j == badSuffix.Length) flag = true;
            if (flag) res++;
        }
        return res;
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
	private void test_case_0() { string Arg0 = "bug"; string Arg1 = "bug"; string Arg2 = "bug"; string[] Arg3 = new string[]{"buggy", "debugger", "debug"}; int Arg4 = 3; verify_case(0, Arg4, count(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { string Arg0 = "a"; string Arg1 = "b"; string Arg2 = "c"; string[] Arg3 = new string[]{"a", "b", "tco"}; int Arg4 = 3; verify_case(1, Arg4, count(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { string Arg0 = "cut"; string Arg1 = "sore"; string Arg2 = "scar"; string[] Arg3 = new string[]{"scary", "oscar"}; int Arg4 = 0; verify_case(2, Arg4, count(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { string Arg0 = "bar"; string Arg1 = "else"; string Arg2 = "foo"; string[] Arg3 = new string[]{"foofoofoo", "foobar", "elsewhere"}; int Arg4 = 1; verify_case(3, Arg4, count(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { string Arg0 = "pre"; string Arg1 = "s"; string Arg2 = "all"; string[] Arg3 = new string[]{"all", "coders", "be", "prepared", "for", "the", "challenge", "phase"}; int Arg4 = 3; verify_case(4, Arg4, count(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BadVocabulary ___test = new BadVocabulary();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
