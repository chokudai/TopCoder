using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NumberofFiboCalls {
    public int[] fiboCallsMade(int n)
    {
        int[,] dp = new int[Math.Max(2,n + 1), 2];
        dp[0, 0] = 1;
        dp[0, 1] = 0;
        dp[1, 0] = 0;
        dp[1, 1] = 1;
        int i;
        for (i = 2; i <= n; i++)
        {
            dp[i, 0] = dp[i - 1, 0] + dp[i - 2, 0];
            dp[i, 1] = dp[i - 1, 1] + dp[i - 2, 1];
        }
        return new int[2] { dp[n, 0], dp[n, 1] };
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int[] Expected, int[] Received) {
		Console.Write("Test Case #" + Case + "...");
		if (equal_arrays(Expected, Received)) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: " + print_array(Expected)); 
			Console.WriteLine("\tReceived: " + print_array(Received)); } }
	string print_array(int[] V) {
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append("{ ");
		foreach (int o in V) {
			builder.Append('\"');
			builder.Append(o.ToString());
			builder.Append("\",");
		}
		builder.Append(" }");
		return builder.ToString();
	}
	bool equal_arrays(int[] a, int[]b) {
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
		return true;
	}
	private void test_case_0() { int Arg0 = 0; int[] Arg1 = new int[]{1, 0 }; verify_case(0, Arg1, fiboCallsMade(Arg0)); }
	private void test_case_1() { int Arg0 = 3; int[] Arg1 = new int[]{1, 2 }; verify_case(1, Arg1, fiboCallsMade(Arg0)); }
	private void test_case_2() { int Arg0 = 6; int[] Arg1 = new int[]{5, 8 }; verify_case(2, Arg1, fiboCallsMade(Arg0)); }
	private void test_case_3() { int Arg0 = 22; int[] Arg1 = new int[]{10946, 17711 }; verify_case(3, Arg1, fiboCallsMade(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
NumberofFiboCalls ___test = new NumberofFiboCalls();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
