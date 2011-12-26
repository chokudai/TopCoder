using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class EqualizeStrings {
    public string getEq(string s, string t)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            char c1, c2;
            if (s[i] > t[i])
            {
                c1 = s[i];
                c2 = t[i];
            }
            else
            {
                c1 = t[i];
                c2 = s[i];
            }
            if ((int)(c1 - c2) >= 13) res += "a";
            else res += c2;
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "cat"; string Arg1 = "dog"; string Arg2 = "caa"; verify_case(0, Arg2, getEq(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "abcdefghijklmnopqrstuvwxyz"; string Arg1 = "bcdefghijklmnopqrstuvwxyza"; string Arg2 = "abcdefghijklmnopqrstuvwxya"; verify_case(1, Arg2, getEq(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "programmingcompetitionsrule"; string Arg1 = "programmingcompetitionsrule"; string Arg2 = "programmingcompetitionsrule"; verify_case(2, Arg2, getEq(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "topcoderopen"; string Arg1 = "onlinerounds"; string Arg2 = "onlcndaoondn"; verify_case(3, Arg2, getEq(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
EqualizeStrings ___test = new EqualizeStrings();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
