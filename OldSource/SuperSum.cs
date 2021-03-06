using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SuperSum {

    long mod = 1000000007;

    public int calculate(int k, int n)
    {
        return (int)(c(k + n, n - 1) % mod);
    }

    long c(int n, int k)
    {
        if (n / 2 < k) return c(n, n - k);
        int i;
        long res = 1;
        for (i = 0; i < k; i++)
        {
            res *= (n - i);
            res %= mod;
            // res /= (i + 1);
            res *= powmod(i + 1, mod - 2, mod);
            res %= mod;
        }
        return res % mod;
    }

    long powmod(long a, long n, long mod)
    {
        if (n == 0) return 1;
        if (n % 2 == 1) return a * powmod(a, n - 1, mod) % mod;
        long c = powmod(a, n / 2, mod);
        return c * c % mod;
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
	private void test_case_0() { int Arg0 = 1; int Arg1 = 3; int Arg2 = 6; verify_case(0, Arg2, calculate(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 3; int Arg2 = 10; verify_case(1, Arg2, calculate(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 4; int Arg1 = 10; int Arg2 = 2002; verify_case(2, Arg2, calculate(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 10; int Arg1 = 35; int Arg2 = 150595840; verify_case(3, Arg2, calculate(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SuperSum ___test = new SuperSum();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
