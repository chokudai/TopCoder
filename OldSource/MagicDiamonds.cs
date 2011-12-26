using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MagicDiamonds {
    public long minimalTransfer(long n)
    {
        if (n == 3) return 3;
        else if (isPrime(n)) return 2;
        return 1;
    }

    bool isPrime(long a)
    {
        long i;
        if (a <= 1) return false;
        for (i = 2; i * i <= a; i++) if (a % i == 0) return false;
        return true;
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { long Arg0 = 2l; long Arg1 = 2l; verify_case(0, Arg1, minimalTransfer(Arg0)); }
	private void test_case_1() { long Arg0 = 4294967297l; long Arg1 = 1l; verify_case(1, Arg1, minimalTransfer(Arg0)); }
	private void test_case_2() { long Arg0 = 2147483647l; long Arg1 = 2l; verify_case(2, Arg1, minimalTransfer(Arg0)); }
	private void test_case_3() { long Arg0 = 1l; long Arg1 = 1l; verify_case(3, Arg1, minimalTransfer(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MagicDiamonds ___test = new MagicDiamonds();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
