using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class InterestingParty {
    public int bestInvitation(string[] first, string[] second)
    {
        List<string> l = new List<string>();
        foreach (string s in first) l.Add(s);
        foreach (string s in second) l.Add(s);
        int res = 0;
        foreach (string s in l)
        {
            int count = 0;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == s || second[i] == s) count++;
            }
            res = Math.Max(res, count);
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
	private void test_case_0() { string[] Arg0 = new string[]{"fishing", "gardening", "swimming", "fishing"}; string[] Arg1 = new string[]{"hunting", "fishing", "fishing", "biting"}; int Arg2 = 4; verify_case(0, Arg2, bestInvitation(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"variety", "diversity", "loquacity", "courtesy"}; string[] Arg1 = new string[]{"talking", "speaking", "discussion", "meeting"}; int Arg2 = 1; verify_case(1, Arg2, bestInvitation(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"snakes", "programming", "cobra", "monty"}; string[] Arg1 = new string[]{"python", "python", "anaconda", "python"}; int Arg2 = 3; verify_case(2, Arg2, bestInvitation(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"t", "o", "p", "c", "o", "d", "e", "r", "s", "i", "n", "g", "l", "e", "r",
 "o", "u", "n", "d", "m", "a", "t", "c", "h", "f", "o", "u", "r", "n", "i"}; string[] Arg1 = new string[]{"n", "e", "f", "o", "u", "r", "j", "a", "n", "u", "a", "r", "y", "t", "w", 
 "e", "n", "t", "y", "t", "w", "o", "s", "a", "t", "u", "r", "d", "a", "y"}; int Arg2 = 6; verify_case(3, Arg2, bestInvitation(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
InterestingParty ___test = new InterestingParty();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
