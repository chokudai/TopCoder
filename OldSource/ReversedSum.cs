using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ReversedSum {
    public int getReversedSum(int x, int y)
    {
        return rev(rev(x) + rev(y));
    }

    int rev(int x)
    {
        int ret = 0;
        while (x != 0)
        {
            ret *= 10;
            ret += x % 10;
            x /= 10;
        }
        return ret;
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
	private void test_case_0() { int Arg0 = 123; int Arg1 = 100; int Arg2 = 223; verify_case(0, Arg2, getReversedSum(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 111; int Arg1 = 111; int Arg2 = 222; verify_case(1, Arg2, getReversedSum(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 5; int Arg1 = 5; int Arg2 = 1; verify_case(2, Arg2, getReversedSum(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 1000; int Arg1 = 1; int Arg2 = 2; verify_case(3, Arg2, getReversedSum(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 456; int Arg1 = 789; int Arg2 = 1461; verify_case(4, Arg2, getReversedSum(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ReversedSum ___test = new ReversedSum();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
