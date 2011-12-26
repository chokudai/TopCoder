using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ToastXRaspberry {
    public int apply(int upper_limit, int layer_count)
    {
        return (upper_limit + layer_count - 1) / upper_limit;
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
	private void test_case_0() { int Arg0 = 4; int Arg1 = 13; int Arg2 = 4; verify_case(0, Arg2, apply(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 8; int Arg1 = 5; int Arg2 = 1; verify_case(1, Arg2, apply(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 73; int Arg1 = 265; int Arg2 = 4; verify_case(2, Arg2, apply(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ToastXRaspberry ___test = new ToastXRaspberry();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
