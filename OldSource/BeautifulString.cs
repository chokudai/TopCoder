using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BeautifulString {
    public int maximumLength(int countA, int countB, int maxA, int maxB)
    {
        if (maxA == 0) return Math.Min(countB, maxB);
        if (maxB == 0) return Math.Min(countA, maxA);
        long putA = Math.Min(countA, (long)(countB + 1) * maxA);
        long putB = Math.Min(countB, (long)(countA + 1) * maxB);
        return (int)(putA + putB);
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
	private void test_case_0() { int Arg0 = 0; int Arg1 = 0; int Arg2 = 10; int Arg3 = 10; int Arg4 = 0; verify_case(0, Arg4, maximumLength(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 10; int Arg1 = 10; int Arg2 = 0; int Arg3 = 0; int Arg4 = 0; verify_case(1, Arg4, maximumLength(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 3; int Arg1 = 5; int Arg2 = 1; int Arg3 = 1; int Arg4 = 7; verify_case(2, Arg4, maximumLength(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 677578; int Arg1 = 502524; int Arg2 = 989951; int Arg3 = 504698; int Arg4 = 1180102; verify_case(3, Arg4, maximumLength(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BeautifulString ___test = new BeautifulString();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
