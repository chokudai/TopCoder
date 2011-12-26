using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ConvexHexagons {
    long mod = 1000000007;
    public int find(int a)
    {
        long N = a;
        int i, j,k;
        long res = 0;
        for (i = 1; i < N; i++)
        {
            for (j = 1; j < N; j++)
            {
                res += (N - i) * Math.Max(i, 0) * Math.Max(N - i - j, 0);
            }
        }
        return (int)res;
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
	private void test_case_0() { int Arg0 = 4; int Arg1 = 7; verify_case(0, Arg1, find(Arg0)); }
	private void test_case_1() { int Arg0 = 7; int Arg1 = 232; verify_case(1, Arg1, find(Arg0)); }
	private void test_case_2() { int Arg0 = 104; int Arg1 = 635471838; verify_case(2, Arg1, find(Arg0)); }
	private void test_case_3() { int Arg0 = 1; int Arg1 = 0; verify_case(3, Arg1, find(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ConvexHexagons ___test = new ConvexHexagons();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
