using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FibonacciPositioning {
    public double getFPosition(int n)
    {
        if (n == 1) return 2.0;
        int i;
        int[] ar = new int[100000];
        ar[0] = 1;
        ar[1] = 1;
        for (i = 2; i < 100000; i++)
        {
            ar[i] = ar[i - 1] + ar[i - 2];
        }
        for (i = 1; i < 100000; i++)
        {
            if (ar[i] >= n)
            {
                return i + 1 - (double)(ar[i] - n) / (ar[i] - ar[i - 1]);
            }
        }
        return 0;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 1; double Arg1 = 2.0; verify_case(0, Arg1, getFPosition(Arg0)); }
	private void test_case_1() { int Arg0 = 5; double Arg1 = 5.0; verify_case(1, Arg1, getFPosition(Arg0)); }
	private void test_case_2() { int Arg0 = 4; double Arg1 = 4.5; verify_case(2, Arg1, getFPosition(Arg0)); }
	private void test_case_3() { int Arg0 = 100; double Arg1 = 11.2; verify_case(3, Arg1, getFPosition(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FibonacciPositioning ___test = new FibonacciPositioning();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
