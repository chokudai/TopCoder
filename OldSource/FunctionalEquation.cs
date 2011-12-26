using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FunctionalEquation {
    long[] x, y;
    public long minAbsSum(int C, int N, int xzero, int xprod, int xadd, int xmod, int yzero, int yprod, int yadd, int ymod)
    {
        x = new long[N];
        y = new long[N];
        int i;
        x[0] = xzero;
        y[0] = yzero;
        for (i = 1; i < N; i++)
        {
            x[i] = ((long)x[i - 1] * xprod + xadd) % xmod;
            y[i] = ((long)y[i - 1] * yprod + yadd) % ymod;
        }

    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 3; int Arg1 = 10; int Arg2 = 0; int Arg3 = 1; int Arg4 = 1; int Arg5 = 456; int Arg6 = 1; int Arg7 = 1; int Arg8 = 1; int Arg9 = 456; long Arg10 = 0l; verify_case(0, Arg10, minAbsSum(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9)); }
	private void test_case_1() { int Arg0 = 4; int Arg1 = 10; int Arg2 = 0; int Arg3 = 1; int Arg4 = 1; int Arg5 = 456; int Arg6 = 1; int Arg7 = 1; int Arg8 = 1; int Arg9 = 456; long Arg10 = 5l; verify_case(1, Arg10, minAbsSum(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9)); }
	private void test_case_2() { int Arg0 = 16; int Arg1 = 10000; int Arg2 = 654816386; int Arg3 = 163457813; int Arg4 = 165911619; int Arg5 = 987654321; int Arg6 = 817645381; int Arg7 = 871564816; int Arg8 = 614735118; int Arg9 = 876543210; long Arg10 = 3150803357206l; verify_case(2, Arg10, minAbsSum(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FunctionalEquation ___test = new FunctionalEquation();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
