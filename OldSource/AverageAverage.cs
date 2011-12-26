using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AverageAverage {
    public double average(int[] numList)
    {
        int i;
        int res = 0;
        for (i = 0; i < numList.Length; i++) res += numList[i];
        return (double)(res / numList.Length);
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{1,2,3}; double Arg1 = 2.0; verify_case(0, Arg1, average(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{42}; double Arg1 = 42.0; verify_case(1, Arg1, average(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{3,1,4,15,9}; double Arg1 = 6.4; verify_case(2, Arg1, average(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
AverageAverage ___test = new AverageAverage();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
