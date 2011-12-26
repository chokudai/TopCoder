using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheBeauty {
    public int find(int n)
    {
        bool[] check = new bool[10];
        int i;
        while (n != 0)
        {
            check[n % 10] = true;
            n /= 10;
        }
        int res = 0;
        for (i = 0; i < 10; i++) if (check[i]) res++;
        return res;
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
	private void test_case_0() { int Arg0 = 7; int Arg1 = 1; verify_case(0, Arg1, find(Arg0)); }
	private void test_case_1() { int Arg0 = 100; int Arg1 = 2; verify_case(1, Arg1, find(Arg0)); }
	private void test_case_2() { int Arg0 = 123456789; int Arg1 = 9; verify_case(2, Arg1, find(Arg0)); }
	private void test_case_3() { int Arg0 = 1000000000; int Arg1 = 2; verify_case(3, Arg1, find(Arg0)); }
	private void test_case_4() { int Arg0 = 932400154; int Arg1 = 7; verify_case(4, Arg1, find(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheBeauty ___test = new TheBeauty();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
