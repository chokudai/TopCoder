using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class IntervalSubsets {
    public int numberOfSubsets(int[] x, int[] y)
    {
        int i, j, k;
        int len = x.Length;
        int[] dp = new int[len + 1];
        dp[0] = 1;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len - 1; j++)
            {
                if (x[j] > x[j + 1])
                {
                    int temp = x[j];
                    x[j] = x[j + 1];
                    x[j + 1] = temp;
                    temp = y[j];
                    y[j] = y[j + 1];
                    y[j + 1] = temp;
                }
            }
        }
        for (i = 0; i < len; i++)
        {
            int endminvalue = int.MaxValue;
            for (j = i; j < len; j++)
            {
                if (x[j] > endminvalue) break;
                endminvalue = Math.Min(endminvalue, y[j]);
                for (k = j; k < len; k++)
                {
                    if (x[k] <= y[j]) continue;
                    else break;
                }
                dp[k] += dp[i];
            }
        }
        return dp[len];
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
	private void test_case_0() { int[] Arg0 = new int[]{68,25}; int[] Arg1 = new int[]{75,64}; int Arg2 = 1; verify_case(0, Arg2, numberOfSubsets(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{4,2,3}; int[] Arg1 = new int[]{4,5,3}; int Arg2 = 2; verify_case(1, Arg2, numberOfSubsets(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{3,4,3,2,1}; int[] Arg1 = new int[]{4,5,4,5,5}; int Arg2 = 5; verify_case(2, Arg2, numberOfSubsets(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{2,3,4,4,4,4,2,2,1}; int[] Arg1 = new int[]{3,5,4,5,4,5,3,2,4}; int Arg2 = 14; verify_case(3, Arg2, numberOfSubsets(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{1, 1, 3, 3}; int[] Arg1 = new int[]{2, 2, 4, 4}; int Arg2 = 4; verify_case(4, Arg2, numberOfSubsets(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
IntervalSubsets ___test = new IntervalSubsets();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
