using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class OlympicCandles {
    public int numberOfNights(int[] candles)
    {
        int i, j;
        for (i = 1; i <= candles.Length; i++)
        {
            Array.Sort(candles);
            Array.Reverse(candles);
            for (j = 0; j < i; j++)
            {
                if (candles[j] == 0) return i - 1;
                candles[j]--;
            }
        }
        return i - 1;
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
	private void test_case_0() { int[] Arg0 = new int[]{2, 2, 2}; int Arg1 = 3; verify_case(0, Arg1, numberOfNights(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{2, 2, 2, 4}; int Arg1 = 4; verify_case(1, Arg1, numberOfNights(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{5, 2, 2, 1}; int Arg1 = 3; verify_case(2, Arg1, numberOfNights(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{1, 2, 3, 4, 5, 6}; int Arg1 = 6; verify_case(3, Arg1, numberOfNights(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}; int Arg1 = 4; verify_case(4, Arg1, numberOfNights(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
OlympicCandles ___test = new OlympicCandles();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
