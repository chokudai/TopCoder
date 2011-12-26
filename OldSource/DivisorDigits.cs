using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DivisorDigits {
    public int howMany(int number)
    {
        int now = number;
        int count = 0;
        while (now != 0)
        {
            int next = now % 10;
            if (next != 0 && number % next == 0)
            {
                count++;
            }
            now /= 10;
        }
        return count;
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
	private void test_case_0() { int Arg0 = 12345; int Arg1 = 3; verify_case(0, Arg1, howMany(Arg0)); }
	private void test_case_1() { int Arg0 = 661232; int Arg1 = 3; verify_case(1, Arg1, howMany(Arg0)); }
	private void test_case_2() { int Arg0 = 52527; int Arg1 = 0; verify_case(2, Arg1, howMany(Arg0)); }
	private void test_case_3() { int Arg0 = 730000000; int Arg1 = 0; verify_case(3, Arg1, howMany(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
DivisorDigits ___test = new DivisorDigits();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
