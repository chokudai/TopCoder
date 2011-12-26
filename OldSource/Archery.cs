using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Archery {
    public double expectedPoints(int N, int[] ringPoints)
    {
        double res = 0; N++;
        for (int i = 0; i < ringPoints.Length; i++)
        {
            res += ringPoints[i] * (i * 2 + 1);
        }
        return res / N / N;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 1; int[] Arg1 = new int[]{10, 0}; double Arg2 = 2.5; verify_case(0, Arg2, expectedPoints(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 3; int[] Arg1 = new int[]{1, 1, 1, 1}; double Arg2 = 1.0; verify_case(1, Arg2, expectedPoints(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 4; int[] Arg1 = new int[]{100, 0, 100, 0, 100}; double Arg2 = 60.0; verify_case(2, Arg2, expectedPoints(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 9; int[] Arg1 = new int[]{69, 50, 79, 16, 52, 71, 17, 96, 56, 32}; double Arg2 = 51.96; verify_case(3, Arg2, expectedPoints(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Archery ___test = new Archery();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
