using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class OneDigitDifference {
    public int getSmallest(int N)
    {
        if (N == 0) return 1;
        for (int i = 1; ; i *= 10)
        {
            if (N / i < 10) return N % i;
        }
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
	private void test_case_0() { int Arg0 = 9; int Arg1 = 0; verify_case(0, Arg1, getSmallest(Arg0)); }
	private void test_case_1() { int Arg0 = 0; int Arg1 = 1; verify_case(1, Arg1, getSmallest(Arg0)); }
	private void test_case_2() { int Arg0 = 900000123; int Arg1 = 123; verify_case(2, Arg1, getSmallest(Arg0)); }
	private void test_case_3() { int Arg0 = 30000; int Arg1 = 0; verify_case(3, Arg1, getSmallest(Arg0)); }
	private void test_case_4() { int Arg0 = 47; int Arg1 = 7; verify_case(4, Arg1, getSmallest(Arg0)); }
	private void test_case_5() { int Arg0 = 1907654321; int Arg1 = 907654321; verify_case(5, Arg1, getSmallest(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
OneDigitDifference ___test = new OneDigitDifference();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
