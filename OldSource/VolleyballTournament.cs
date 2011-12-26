using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class VolleyballTournament {
    public string reconstructResults(int wonMatches, int lostMatches, int wonSets, int lostSets)
    {
        int winall = wonMatches * 3;
        int lostall = lostMatches * 3;
        int nokoriwin = wonSets - winall;
        int nokorilost = lostSets - lostall;
        if ((nokoriwin >= 1 && lostMatches > 1) && (lostMatches * 2 != nokoriwin)) return "AMBIGUITY";
        if (lostMatches != 0) nokoriwin /= lostMatches;
        if (nokorilost >= 1 && wonMatches > 1 && (wonMatches * 2 != nokorilost)) return "AMBIGUITY";
        if (wonMatches != 0) nokorilost /= wonMatches;
        string res = "";
        int i;
        for (i = 0; i < lostMatches; i++)
        {
            res += nokoriwin + "-" + 3 + ",";
        }
        for (i = 0; i < wonMatches; i++)
        {
            res += 3 + "-" + nokorilost + ",";
        }
        return res.Substring(0, res.Length - 1);
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
	private void test_case_0() { int Arg0 = 3; int Arg1 = 3; int Arg2 = 9; int Arg3 = 9; string Arg4 = "0-3,0-3,0-3,3-0,3-0,3-0"; verify_case(0, Arg4, reconstructResults(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 0; int Arg1 = 3; int Arg2 = 6; int Arg3 = 9; string Arg4 = "2-3,2-3,2-3"; verify_case(1, Arg4, reconstructResults(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 3; int Arg1 = 0; int Arg2 = 9; int Arg3 = 3; string Arg4 = "AMBIGUITY"; verify_case(2, Arg4, reconstructResults(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 4; int Arg3 = 4; string Arg4 = "1-3,3-1"; verify_case(3, Arg4, reconstructResults(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
VolleyballTournament ___test = new VolleyballTournament();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
