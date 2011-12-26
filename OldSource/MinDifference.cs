using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MinDifference {
    public int closestElements(int A0, int X, int Y, int M, int n)
    {
        int i;
        long[] ar = new long[n];
        ar[0] = A0;
        for (i = 1; i < n; i++)
        {
            ar[i] = (ar[i - 1] * X + Y) % M;
        }
        Array.Sort(ar);
        long res = int.MaxValue;
        for (i = 1; i < n; i++) res = Math.Min(res, ar[i] - ar[i - 1]);
        return (int)res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 3; int Arg1 = 7; int Arg2 = 1; int Arg3 = 101; int Arg4 = 5; int Arg5 = 6; verify_case(0, Arg5, closestElements(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { int Arg0 = 3; int Arg1 = 9; int Arg2 = 8; int Arg3 = 32; int Arg4 = 8; int Arg5 = 0; verify_case(1, Arg5, closestElements(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { int Arg0 = 67; int Arg1 = 13; int Arg2 = 17; int Arg3 = 4003; int Arg4 = 23; int Arg5 = 14; verify_case(2, Arg5, closestElements(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { int Arg0 = 1; int Arg1 = 1221; int Arg2 = 3553; int Arg3 = 9889; int Arg4 = 11; int Arg5 = 275; verify_case(3, Arg5, closestElements(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_4() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 1; int Arg3 = 2; int Arg4 = 10000; int Arg5 = 0; verify_case(4, Arg5, closestElements(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_5() { int Arg0 = 1567; int Arg1 = 5003; int Arg2 = 9661; int Arg3 = 8929; int Arg4 = 43; int Arg5 = 14; verify_case(5, Arg5, closestElements(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MinDifference ___test = new MinDifference();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
