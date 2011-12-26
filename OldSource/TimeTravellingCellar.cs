using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TimeTravellingCellar {
    public int determineProfit(int[] profit, int[] decay)
    {
        int i, j;
        int max = -99999;
        for (i = 0; i < profit.Length; i++)
        {
            for (j = 0; j < decay.Length; j++)
            {
                if (i == j) continue;
                max = Math.Max(max, profit[i] - decay[j]);
            }
        }
        return max;
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
	private void test_case_0() { int[] Arg0 = new int[]{1,2,3}; int[] Arg1 = new int[]{3,1,2}; int Arg2 = 2; verify_case(0, Arg2, determineProfit(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{3,2}; int[] Arg1 = new int[]{1,2}; int Arg2 = 1; verify_case(1, Arg2, determineProfit(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{3,3,3}; int[] Arg1 = new int[]{1,1,1}; int Arg2 = 2; verify_case(2, Arg2, determineProfit(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{1000,500,250,125}; int[] Arg1 = new int[]{64,32,16,8}; int Arg2 = 992; verify_case(3, Arg2, determineProfit(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TimeTravellingCellar ___test = new TimeTravellingCellar();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
