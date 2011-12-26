using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MagicalSource {
    public long calculate(long x)
    {
        for (long waru = 111111111111111; ; waru /= 10)
        {
            if (x % waru == 0) return x / waru;
        }
        return x;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { long Arg0 = 1371110974l; long Arg1 = 1234l; verify_case(0, Arg1, calculate(Arg0)); }
	private void test_case_1() { long Arg0 = 111111l; long Arg1 = 1l; verify_case(1, Arg1, calculate(Arg0)); }
	private void test_case_2() { long Arg0 = 10989l; long Arg1 = 99l; verify_case(2, Arg1, calculate(Arg0)); }
	private void test_case_3() { long Arg0 = 120l; long Arg1 = 120l; verify_case(3, Arg1, calculate(Arg0)); }
	private void test_case_4() { long Arg0 = 109999999989l; long Arg1 = 99l; verify_case(4, Arg1, calculate(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MagicalSource ___test = new MagicalSource();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
