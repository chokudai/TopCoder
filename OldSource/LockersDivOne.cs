using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LockersDivOne {
    public int lastOpened(int N)
    {
        int i, j;
        int best = -1;
        int max = 0;
        for (i = 1; i <= N; i++)
        {
            int nokori = i;
            for (j = 2; ; j++)
            {
                if (nokori % j == 1) break;
                nokori -= (nokori + j - 1) / j;
            }
            if (j >= max)
            {
                max = j;
                best = i;
            }
        }
        return best;
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
	private void test_case_0() { int Arg0 = 9; int Arg1 = 6; verify_case(0, Arg1, lastOpened(Arg0)); }
	private void test_case_1() { int Arg0 = 42; int Arg1 = 42; verify_case(1, Arg1, lastOpened(Arg0)); }
	private void test_case_2() { int Arg0 = 314; int Arg1 = 282; verify_case(2, Arg1, lastOpened(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
LockersDivOne ___test = new LockersDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
