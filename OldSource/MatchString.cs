using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MatchString {
    public int placeWords(string matchString, string[] matchWords)
    {
        int max = int.MaxValue >> 2;
        int i, j, k;
        int[,] dist = new int[50, 50];
        for (i = 0; i < 50; i++) for (j = 0; j < 50; j++) dist[i, j] = max;
        for (i = 0; i < matchString.Length; i++)
        {
            for (j = 0; j < matchWords[i].Length; j++)
            {
                if (matchString[i] == matchWords[i][j])
                {
                    dist[i,j] = 0;
                }
            }
        }
        for (i = 0; i <matchString.Length; i++)
        {
            bool flag = true;
            for (j = 0; j < matchWords[i].Length; j++)
            {
                if (dist[i, j] == 0)
                {
                    flag = false;
                    for (k = j; k < 50; k++)
                    {
                        dist[i, k] = Math.Min(dist[i, k], Math.Abs(j - k));
                    }
                }
            }
            if (flag) return -1;
        }
        int res = max;
        for (j = 0; j < 50; j++)
        {
            int now = 0;
            for (i = 0; i < matchString.Length; i++) now += dist[i, j];
            res = Math.Min(now, res);
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
	private void test_case_0() { string Arg0 = "TOP"; string[] Arg1 = new string[]{"TIK", 
 "PPPO", 
 "OP"}; int Arg2 = 5; verify_case(0, Arg2, placeWords(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "EEA"; string[] Arg1 = new string[]{"GEGA", 
 "TOPCODER", 
 "TEST"}; int Arg2 = -1; verify_case(1, Arg2, placeWords(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "AB"; string[] Arg1 = new string[]{"ABA", 
 "ABAB"}; int Arg2 = 1; verify_case(2, Arg2, placeWords(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "FIND"; string[] Arg1 = new string[]{"VERYFAST", 
 "OPINION", 
 "SPENDING", 
 "ODD"}; int Arg2 = 3; verify_case(3, Arg2, placeWords(Arg0, Arg1)); }
	private void test_case_4() { string Arg0 = "TOP"; string[] Arg1 = new string[]{"OUTTHERE", 
 "FROM", 
 "NOPQRSTU"}; int Arg2 = 0; verify_case(4, Arg2, placeWords(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
    MatchString ___test = new MatchString();
    ___test.run_test(-1);
try {


} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
