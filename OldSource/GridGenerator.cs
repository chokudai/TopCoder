using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GridGenerator {
public int generate(int[] row, int[] col) {
    int h = row.Length;
    int w = col.Length;
    int[,] dp = new int[h, w];
    int i, j;
    for (i = 0; i < h; i++) dp[i, 0] = row[i];
    for (i = 0; i < w; i++) dp[0, i] = col[i];
    for (i = 1; i < h; i++)
    {
        for (j = 1; j < w; j++)
        {
            dp[i, j] = dp[i - 1, j] + dp[i - 1, j - 1] + dp[i, j - 1];
        }
    }

    return dp[h - 1, w - 1];
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
	private void test_case_0() { int[] Arg0 = new int[]{1,0,3,4,1}; int[] Arg1 = new int[]{1,4,1,0,3}; int Arg2 = 579; verify_case(0, Arg2, generate(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{9,9,9,9,9,9,9,9,9,9}; int[] Arg1 = new int[]{9,9,9,9,9,9,9,9,9,9}; int Arg2 = 13163067; verify_case(1, Arg2, generate(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{0,0,0,0,0,0,0,0,0}; int[] Arg1 = new int[]{0,0,0,0,0,0,0,0,0}; int Arg2 = 0; verify_case(2, Arg2, generate(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
GridGenerator ___test = new GridGenerator();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
