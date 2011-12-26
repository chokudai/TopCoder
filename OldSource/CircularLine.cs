using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CircularLine {
    public int longestTravel(int[] t)
    {
        int i, j;
        int sum = 0;
        for (i = 0; i < t.Length; i++)
        {
            sum += t[i];
        }
        int res = 0;
        for (i = 0; i < t.Length; i++)
        {
            int now = 0;
            for (j = i; j<t.Length ; j++)
            {
                now += t[j];
                res = Math.Max(res, Math.Min(now, sum - now));
            }
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
	private void test_case_0() { int[] Arg0 = new int[]{1,1,1,1}; int Arg1 = 2; verify_case(0, Arg1, longestTravel(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{1,4,4,1,5}; int Arg1 = 7; verify_case(1, Arg1, longestTravel(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{1,1,1000}; int Arg1 = 2; verify_case(2, Arg1, longestTravel(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{1,1000,1,1000}; int Arg1 = 1001; verify_case(3, Arg1, longestTravel(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{1,1,1,1,4}; int Arg1 = 4; verify_case(4, Arg1, longestTravel(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CircularLine ___test = new CircularLine();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
