using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MagicStonesStore {
    public string ableToDivide(int n)
    {
        int i;
        for (i = 1; i <= n; i++)
        {
            if (isPrime(i) && isPrime(n + n - i)) return "YES";
        }
        return "NO";
    }

    bool isPrime(int a)
    {
        if (a < 2) return false;
        int i;
        for (i = 2; i * i <= a; i++)
        {
            if (a % i == 0) return false;
        }
        return true;
    }


// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 1; string Arg1 = "NO"; verify_case(0, Arg1, ableToDivide(Arg0)); }
	private void test_case_1() { int Arg0 = 2; string Arg1 = "YES"; verify_case(1, Arg1, ableToDivide(Arg0)); }
	private void test_case_2() { int Arg0 = 3; string Arg1 = "YES"; verify_case(2, Arg1, ableToDivide(Arg0)); }
	private void test_case_3() { int Arg0 = 5; string Arg1 = "YES"; verify_case(3, Arg1, ableToDivide(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MagicStonesStore ___test = new MagicStonesStore();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
