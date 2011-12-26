using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ParallelProgramming {

    int[] t;
    string[] p;
    int[] dp;
    int len;
    int MAX = 9999999;

    public int minTime(int[] time, string[] prec)
    {
        len = time.Length;
        t = time; p = prec;
        dp = new int[len];
        int ret = 0;
        int i;
        for (i = 0; i < len; i++) ret = Math.Max(gettime(i), ret);
        if (ret >= MAX) return -1;
        return ret;
    }

    int gettime(int a)
    {
        if (dp[a] != 0) return dp[a];
        dp[a] = MAX;
        int i;
        int ret = 0;
        for (i = 0; i < len; i++) if (p[a][i] == 'Y') ret = Math.Max(ret, gettime(i));
        return dp[a] = ret + t[a];
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
	private void test_case_0() { int[] Arg0 = new int[]{150,200,250}; string[] Arg1 = new string[]{"NNN",
 "NNN",
 "NNN"}; int Arg2 = 250; verify_case(0, Arg2, minTime(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{150,200,250}; string[] Arg1 = new string[]{"NNN",
 "YNN",
 "NNN"}; int Arg2 = 350; verify_case(1, Arg2, minTime(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{150,200,250}; string[] Arg1 = new string[]{"NYN",
 "NNY",
 "NNN"}; int Arg2 = 600; verify_case(2, Arg2, minTime(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{150,200,250}; string[] Arg1 = new string[]{"NYN",
 "NNY",
 "YNN"}; int Arg2 = -1; verify_case(3, Arg2, minTime(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{345,335,325,350,321,620}; string[] Arg1 = new string[]{"NNNNNN",
 "NNYYYY",
 "YNNNNN",
 "NNYNYN",
 "NNNNNN",
 "NNNNNN"}; int Arg2 = 1355; verify_case(4, Arg2, minTime(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ParallelProgramming ___test = new ParallelProgramming();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
